using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;
using System.Data;
using ERP.Reports.DataSet;

namespace ERP.Repositories
{
    class RemitosDetallesRepository
    {
        public static IList<ERemitosDetalles> ObtenerDetallesDelRemito(int idRemito)
        {
            using (var db = new VentasConexión())
            {
                var query = (
                             from ep in db.ERemitosDetalles
                             select ep)
                             .Where(d => d.IdRemito == idRemito)
                             .ToList()
                                .Select(
                                    p => new ERemitosDetalles
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdRemito = p.IdRemito,
                                        IdArticulo = p.IdArticulo,                                        
                                        Cantidad = p.Cantidad                                        
                                    });
                return query.OrderBy(p => p.Id).ToList();
            }
        }

        public static ERemitosDetalles Insertar(int idRemito, int idArticulo, int cantidad)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.ERemitosDetalles.Any() ? db.ERemitosDetalles.Max(a1 => a1.Id) + 1 : 1;
                    var a = new ERemitosDetalles
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdRemito = idRemito,
                        IdArticulo = idArticulo,                        
                        Cantidad = cantidad
                    };
                    db.ERemitosDetalles.Add(a);
                    db.SaveChanges();
                    trx.Commit();
                    return a;
                }
                catch (Exception)
                {
                    trx.Rollback();
                    throw;
                }
            }
        }

        public static DataTable CargarDetalles(int idRemito)
        {
            var tabla = new dsImpresiones.DetallesDataTable();

            var detalles = ObtenerDetalles(idRemito);
            foreach (var d in detalles)
            {
                string id = d.IdArticulo.ToString();
                string codBarra = ArticulosRepository.ObtenerArticulosPorId(Convert.ToInt32(d.IdArticulo)).CodBarra;
                string descripcion = ArticulosRepository.ObtenerArticulosPorId(Convert.ToInt32(d.IdArticulo)).Descripcion;
                string cantidad = d.Cantidad.ToString();
                //string precio = d.Precio.ToString();
                //string importe = d.Importe.ToString();

                //tabla.AddDetallesRow(id, codBarra, descripcion, cantidad, precio, importe);
                tabla.AddDetallesRow(id, codBarra, descripcion, cantidad, "", "");
            }
            return tabla;
        }

        internal static ERemitosDetalles ObtenerDetallesPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.ERemitosDetalles.Find(id);
            }
        }

        public static IList<ERemitosDetalles> ObtenerDetalles(int idRemito)
        {
            using (var db = new VentasConexión())
            {
                var query = (from a in db.ERemitosDetalles
                             select a).Where(x => x.IdRemito == idRemito)
                               .ToList();
                return query.ToList();
            }
        }
    }
}
