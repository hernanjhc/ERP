using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    public class EComprasDetallesRepository
    {
        internal static IEnumerable<EComprasDetalles> ObtenerDetallesDeCompra(int idCompra)
        {
            using (var db = new VentasConexión())
            {
                var query = (
                             from ep in db.EComprasDetalles
                             select ep)
                             .Where(d => d.IdCompra == idCompra)
                             .ToList()
                                .Select(
                                    p => new EComprasDetalles
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdCompra = p.IdCompra,
                                        IdArticulo = p.IdArticulo,
                                        Importe = p.Importe,
                                        Cantidad = p.Cantidad,
                                        Precio = p.Precio
                                    });
                return query.OrderBy(p => p.Id).ToList();
            }
        }

        public static EComprasDetalles Insertar(int idCompra, int idArticulo, int cantidad, decimal precio, decimal importe)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.EComprasDetalles.Any() ? db.EComprasDetalles.Max(a1 => a1.Id) + 1 : 1;
                    var a = new EComprasDetalles
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdCompra = idCompra,
                        IdArticulo = idArticulo,
                        Importe = importe,
                        Cantidad = cantidad,
                        Precio = precio
                    };
                    db.EComprasDetalles.Add(a);
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
    }
}
