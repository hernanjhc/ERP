using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    public class UnidadesRepository
    {
        public static IEnumerable<Unidades> ObtenerUnidades()
        {
            using (var db = new VentasConexión())
            {
                return (from u in db.Unidades orderby u.Unidad select u).ToList();
            }
        }

        internal static Unidades Insertar(string unidad, string observaciones, byte estado)
        {
            using (var db = new VentasConexión())
            {
                if (db.Unidades.Any(c => c.Unidad.ToLower().Trim() == unidad.ToLower().Trim()))
                {
                    throw new Exception("Ya existe unidad con este nombre.");
                }
                var id = db.Unidades.Any() ? db.Unidades.Max(a1 => a1.Id) + 1 : 1;
                var u = new Unidades
                {
                    Id = id,
                    Unidad = unidad,
                    Observaciones = observaciones,
                    Estado = estado
                };
                db.Unidades.Add(u);
                db.SaveChanges();
                return u;
            }
        }

        internal static void Actualizar(int id, string unidad, string observaciones, byte estado)
        {
            using (var db = new VentasConexión())
            {
                if (!db.Unidades.Any(t => t.Id == id))
                {
                    throw new Exception("No existe unidad con Id " + id);
                }
                var u = db.Unidades.Find(id);
                u.Unidad = unidad.Trim();
                u.Observaciones = observaciones.Trim();
                u.Estado = estado;
                db.SaveChanges();
            }
        }

        internal static string ObtenerUnidadStringPorId(int? idUnidad)
        {
            using (var db = new VentasConexión())
            {
                return db.Unidades.Find(idUnidad).Unidad;
            }
        }

        internal static Unidades ObtenerUnidadPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.Unidades.Find(id);
            }
        }

        public static void Eliminar(int id)
        {
            using (var db = new VentasConexión())
            {
                if (!db.Unidades.Any(t => t.Id == id))
                {
                    throw new Exception("No existe Unidad con Id " + id);
                }
                var unidad = db.Unidades.Find(id);
                db.Unidades.Remove(unidad);
                db.SaveChanges();
            }
        }

        internal static int ObtenerIdUnidad(string unidad)
        {
            using (var db = new VentasConexión())
            {
                int idUnidad = 0;
                if (!db.Unidades.Any(u => u.Unidad.ToLower().Trim() == unidad.ToLower().Trim()))
                {
                    Insertar(unidad,"",1);
                }
                idUnidad = db.Unidades.FirstOrDefault(u => u.Unidad.ToLower().Trim() == unidad.ToLower().Trim()).Id;

                return idUnidad;
            }
        }
    }
}
