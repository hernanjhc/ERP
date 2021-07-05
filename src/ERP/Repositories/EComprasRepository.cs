using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    public class EComprasRepository
    {

        public static ECompras Insertar(int idProveedor, DateTime fecha, decimal importe, int retirado, int pagado, int idUsuario)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.ECompras.Any() ? db.ECompras.Max(a1 => a1.Id) + 1 : 1;
                    var a = new ECompras
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdProveedor = idProveedor,
                        Fecha = fecha,
                        Importe = importe,
                        Retirado = retirado,
                        Pagado = pagado,
                        IdUsuario = idUsuario
                    };
                    db.ECompras.Add(a);
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
        public static IList<ECompras> ObtenerCompras()
        {
            using (var db = new VentasConexión())
            {
                var query = (from ep in db.ECompras
                             select ep)
                             .ToList()
                                .Select(
                                    p => new ECompras
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdProveedor = p.IdProveedor,
                                        Fecha = p.Fecha,
                                        Importe = p.Importe,
                                        Retirado = p.Retirado,
                                        Pagado = p.Pagado,
                                        IdUsuario = p.IdUsuario
                                    });
                return query.OrderBy(p => p.Id).ToList();
            }
        }

        internal static ECompras ObtenerCompraPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.ECompras.Find(id);
            }
        }
    }
}
