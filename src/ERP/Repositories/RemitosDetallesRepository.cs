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
    }
}
