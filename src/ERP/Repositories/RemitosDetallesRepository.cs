using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

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
    }
}
