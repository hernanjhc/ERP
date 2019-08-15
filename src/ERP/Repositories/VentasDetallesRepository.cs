using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    class VentasDetallesRepository
    {
        public static IList<EVentasDetalles> ObtenerDetallesDeVenta(int idVenta)
        {
            using (var db = new VentasConexión())
            {
                var query = (
                             from ep in db.EVentasDetalles
                             select ep)
                             .Where(d => d.IdVenta == idVenta)
                             .ToList()
                                .Select(
                                    p => new EVentasDetalles
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdVenta = p.IdVenta,
                                        IdArticulo = p.IdArticulo,
                                        Importe = p.Importe,
                                        Cantidad = p.Cantidad,
                                        Precio = p.Precio
                                    });
                return query.OrderBy(p => p.Id).ToList();
            }
        }

        public static EVentasDetalles Insertar(int idVenta, int idArticulo, int cantidad, decimal precio, decimal importe)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.EVentasDetalles.Any() ? db.EVentasDetalles.Max(a1 => a1.Id) + 1 : 1;
                    var a = new EVentasDetalles
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdVenta = idVenta,
                        IdArticulo = idArticulo,
                        Importe = importe,
                        Cantidad = cantidad,
                        Precio = precio
                    };
                    db.EVentasDetalles.Add(a);
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
