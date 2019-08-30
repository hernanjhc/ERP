using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    class VentasRepository
    {
        public static IList<EVentas> ObtenerVentas()
        {
            using (var db = new VentasConexión())
            {
                var query = (//from c in db.Clientes
                             from ep in db.EVentas
                                 //join c in db.Clientes on ep.IdCliente equals c.Id
                                 //join td in db.TiposDocumento on c.IdTipoDocumento equals td.Id
                             select ep)
                             .ToList()
                                .Select(
                                    p => new EVentas
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdCliente = p.IdCliente,
                                        //Cliente = p.Clientes.RazonSocial,
                                        Fecha = p.Fecha,                                        
                                        Descuento = p.Descuento,
                                        DescuentoPorc = p.DescuentoPorc,
                                        Importe = p.Importe,
                                        PrecioLista = p.PrecioLista,
                                        IdUsuario = p.IdUsuario,
                                        Estado = p.Estado
                                    });
                return query.OrderBy(p => p.Id).ToList();
            }
        }

        internal static EVentas ObtenerVentaPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.EVentas.Find(id);
            }
        }

        public static EVentas Insertar(int idCliente, DateTime fecha, decimal importe, decimal descuento, decimal descPorc,
                                            decimal importeTotal, int PrecioLista, int idUsuario, byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.EVentas.Any() ? db.EVentas.Max(a1 => a1.Id) + 1 : 1;
                    var a = new EVentas
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdCliente = idCliente,
                        Fecha = fecha,                        
                        Importe = importe,
                        Descuento = descuento,
                        DescuentoPorc = descPorc,
                        ImporteTotal = importeTotal,
                        PrecioLista = PrecioLista,
                        IdUsuario = idUsuario,
                        Estado = estado
                    };
                    db.EVentas.Add(a);
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
                    if (!db.EVentas.Any(t => t.Id == id))
                    {
                        throw new Exception(String.Format("No existe la venta {0}", id));
                    }
                    var p = db.EVentas.Find(id);
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
