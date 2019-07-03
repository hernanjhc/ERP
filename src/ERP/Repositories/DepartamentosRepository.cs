using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    static class DepartamentosRepository
    {
        public static IEnumerable<Departamentos> ObtenerDepartamentosPorProvincia(int idProvincia)
        {
            using (var db = new Models.VentasConexión())
            {
                var deptos = db.Departamentos.Where(d => d.IdProvincia == idProvincia).ToList()
                                .Select(
                                    d => new Departamentos{
                                        Id = d.Id,
                                        Nombre = d.Nombre
                                    }
                                 ).ToList();
                return deptos.OrderBy(b => b.Nombre).ToList();
            }
        }

        public static Departamentos Insertar(int idProvincia, string nombre)
        {
            using (var db = new VentasConexión())
            {
                if (db.Departamentos.Any(d => d.Nombre.ToLower() == nombre.ToLower() && 
                        d.IdProvincia == idProvincia))
                {
                    throw new Exception("Ya existe un departamento con este nombre en esta provincia.");
                }

                var id = db.Departamentos.Any() ? db.Departamentos.Max(d => d.Id) + 1 : 1;
                var depto = new Departamentos
                {
                    Id = id,
                    IdProvincia = idProvincia,
                    Nombre = nombre
                };
                db.Departamentos.Add(depto);
                db.SaveChanges();
                return depto;
            }
        }

        internal static Departamentos ObtenerDepartamentosPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.Departamentos.FirstOrDefault(d => d.Id == id);
            }
        }

        internal static void Actualizar(int id, string nombre)
        {
            using (var db = new VentasConexión())
            {
                if (!db.Departamentos.Any(t => t.Id == id))
                {
                    throw new Exception("No existe el Departamentoscon Id " + id);
                }
                var depto = db.Departamentos.Find(id);
                if (db.Departamentos.Any(d => d.Nombre.ToLower() == nombre.ToLower() &&
                        d.IdProvincia == depto.IdProvincia))
                {
                    throw new Exception("Ya existe un departamento con este nombre en esta provincia.");
                }
                depto.Nombre = nombre;
                db.SaveChanges();
            }
        }

        internal static void Eliminar(int id)
        {
            using (var db = new VentasConexión())
            {
                if (!db.Departamentos.Any(t => t.Id == id))
                {
                    throw new Exception("No existe el departamento con Id " + id);
                }
                var d = db.Departamentos.Find(id);
                if (d.Localidades.Any())
                {
                    throw new Exception(String.Format("No se puede eliminar el departamento " + 
                        "porque tiene {0} localidades relacionadas.", d.Localidades.Count));
                }
                if (d.Domicilios.Any())
                {
                    throw new Exception("No se puede eliminar el departamento porque está relacionado a alumnos.");
                }
                db.Departamentos.Remove(d);
                db.SaveChanges();
            }
        }
    }
}
