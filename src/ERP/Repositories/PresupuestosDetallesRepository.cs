using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    class PresupuestosDetallesRepository
    {
        public static IList<EPresupuestosDetalles> ObtenerDetallesDelPresupuesto(int idpresupuesto)
        {
            using (var db = new VentasConexión())
            {
                var query = (
                             from ep in db.EPresupuestosDetalles
                             select ep)
                             .Where(d => d.IdPresupuesto == idpresupuesto)
                             .ToList()
                                .Select(
                                    p => new EPresupuestosDetalles
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdPresupuesto = p.IdPresupuesto,
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
