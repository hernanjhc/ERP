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
    }
}
