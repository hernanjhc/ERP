using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    class RemitosRepository
    {

        public static IList<ERemitos> ObtenerRemitos()
        {
            using (var db = new VentasConexión())
            {
                var query = (//from c in db.Clientes
                             from ep in db.ERemitos
                                 //join c in db.Clientes on ep.IdCliente equals c.Id
                                 //join td in db.TiposDocumento on c.IdTipoDocumento equals td.Id
                             select ep)
                             .ToList()
                                .Select(
                                    p => new ERemitos
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdCliente = p.IdCliente,
                                        //Cliente = p.Clientes.RazonSocial,
                                        Fecha = p.Fecha,
                                        IdVenta = p.IdVenta,
                                        EntregaNombre = p.EntregaNombre,
                                        RecibeNombre = p.RecibeNombre,
                                        RecibeTipoDocumento = p.RecibeTipoDocumento,
                                        RecibeNroDocumento = p.RecibeNroDocumento,
                                        IdUsuario = p.IdUsuario,
                                        Estado = p.Estado
                                    });
                return query.OrderBy(p => p.Id).ToList();
            }
        }

        internal static ERemitos ObtenerRemitoPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.ERemitos.Find(id);
            }
        }

        public static ERemitos Insertar(int idCliente, DateTime fecha, int idVenta, string entregaNombre, string recibeNombre, int recibeTipoDoc,
                                            decimal recibeNroDoc, int idUsuario, byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.ERemitos.Any() ? db.ERemitos.Max(a1 => a1.Id) + 1 : 1;
                    var a = new ERemitos
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdCliente = idCliente,
                        Fecha = fecha,
                        IdVenta = idVenta,
                        EntregaNombre = entregaNombre,
                        RecibeNombre = recibeNombre,
                        RecibeTipoDocumento = recibeTipoDoc, //revisar
                        RecibeNroDocumento = recibeNroDoc,
                        IdUsuario = idUsuario,
                        Estado = estado
                    };
                    db.ERemitos.Add(a);
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

        public static void Anular(int id)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    if (!db.ERemitos.Any(t => t.Id == id))
                    {
                        throw new Exception(String.Format("No existe el Remito {0}", id));
                    }
                    var p = db.ERemitos.Find(id);
                    p.Estado = 2;   // anulado
                    db.SaveChanges();
                    trx.Commit();
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
