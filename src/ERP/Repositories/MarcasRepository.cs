using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    public class MarcasRepository
    {
        public static IEnumerable<EMarcas> ObtenerMarcas()
        {
            using (var db = new VentasConexión())
            {
                return (from m in db.EMarcas orderby m.Marca select m).ToList();
            }
        }

        internal static EMarcas Insertar(string marca, string observaciones)
        {
            using (var db = new VentasConexión())
            {
                if (db.EMarcas.Any(c => c.Marca.ToLower().Trim() == marca.ToLower().Trim()))
                {
                    throw new Exception("Ya existe marca con este nombre.");
                }
                var id = db.EMarcas.Any() ? db.EMarcas.Max(a1 => a1.Id) + 1 : 1;
                var m = new EMarcas
                {
                    Id = id,
                    IdEmpresa = Lib.Configuration.IdEmpresa,
                    Marca = marca,
                    Observaciones = observaciones
                };
                db.EMarcas.Add(m);
                db.SaveChanges();
                return m;
            }
        }

        internal static void Actualizar(int id, string marca, string observaciones)
        {
            using (var db = new VentasConexión())
            {
                if (!db.EMarcas.Any(t => t.Id == id))
                {
                    throw new Exception("No existe marca con Id " + id);
                }
                var m = db.EMarcas.Find(id);
                m.Marca = marca.Trim();
                m.Observaciones = observaciones.Trim();
                db.SaveChanges();
            }
        }

        internal static EMarcas ObtenerMarcaPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.EMarcas.Find(id);
            }
        }

        public static void Eliminar(int id)
        {
            using (var db = new VentasConexión())
            {
                if (!db.EMarcas.Any(t => t.Id == id))
                {
                    throw new Exception("No existe marca con Id " + id);
                }
                var marca = db.EMarcas.Find(id);
                db.EMarcas.Remove(marca);
                db.SaveChanges();
            }
        }

    }
}
