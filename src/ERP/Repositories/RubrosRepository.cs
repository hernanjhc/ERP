using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    public class RubrosRepository
    {
        public static IEnumerable<ERubros> ObtenerRubros()
        {
            using (var db = new VentasConexión())
            {
                return (from r in db.ERubros orderby r.Rubro select r).ToList();
            }
        }

        internal static ERubros Insertar(string rubro, string observaciones, byte estado)
        {
            using (var db = new VentasConexión())
            {
                if (db.ERubros.Any(c => c.Rubro.ToLower().Trim() == rubro.ToLower().Trim()))
                {
                    throw new Exception("Ya existe rubro con este nombre.");
                }
                var id = db.ERubros.Any() ? db.ERubros.Max(a1 => a1.Id) + 1 : 1;
                var r = new ERubros
                {
                    Id = id,
                    IdEmpresa = Lib.Configuration.IdEmpresa,
                    Rubro = rubro,
                    Observaciones = observaciones,
                    Estado = estado
                };
                db.ERubros.Add(r);
                db.SaveChanges();
                return r;
            }
        }

        internal static void Actualizar(int id, string rubro, string observaciones, byte estado)
        {
            using (var db = new VentasConexión())
            {
                if (!db.ERubros.Any(t => t.Id == id))
                {
                    throw new Exception("No existe rubro con Id " + id);
                }
                var r = db.ERubros.Find(id);
                r.Rubro = rubro.Trim();
                r.Observaciones = observaciones.Trim();
                r.Estado = estado;
                db.SaveChanges();
            }
        }

        internal static string ObtenerRubroStringPorId(int? idRubro)
        {
            using (var db = new VentasConexión())
            {
                return db.ERubros.Find(idRubro).Rubro;
            }
        }

        internal static ERubros ObtenerRubroPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.ERubros.Find(id);
            }
        }

        public static void Eliminar(int id)
        {
            using (var db = new VentasConexión())
            {
                if (!db.ERubros.Any(t => t.Id == id))
                {
                    throw new Exception("No existe Rubro con Id " + id);
                }
                var rubro = db.ERubros.Find(id);
                db.ERubros.Remove(rubro);
                db.SaveChanges();
            }
        }

        internal static int ObtenerIdRubro(string rubro)
        {
            using (var db = new VentasConexión())
            {
                int idRubro = 0;
                if (!db.ERubros.Any(r => r.Rubro.ToLower().Trim() == rubro.ToLower().Trim()))
                {
                    Insertar(rubro, "",1);
                }
                idRubro = db.ERubros.FirstOrDefault(r => r.Rubro.ToLower().Trim() == rubro.ToLower().Trim()).Id;

                return idRubro;
            }
        }
    }
}
