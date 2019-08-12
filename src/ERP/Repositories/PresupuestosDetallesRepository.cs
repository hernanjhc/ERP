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

        public static EPresupuestosDetalles Insertar(int idPresupuesto, int idArticulo, decimal importe, int cantidad, decimal precio)
        //id int, idEmpresa int, idPresupuesto int, idArticulo int,
        //importe decimal, cantidad int, precio decimal
        
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.EPresupuestosDetalles.Any() ? db.EPresupuestosDetalles.Max(a1 => a1.Id) + 1 : 1;
                    var a = new EPresupuestosDetalles
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdPresupuesto = idPresupuesto,
                        IdArticulo = idArticulo,
                        Importe = importe,
                        Cantidad = cantidad,
                        Precio = precio
                    };
                    db.EPresupuestosDetalles.Add(a);
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
