using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    class PresupuestosRepository
    {
        public static IList<EPresupuestos> ObtenerPresupuestos()
        {
            using (var db = new VentasConexión())
            {
                var query = (//from c in db.Clientes
                             from ep in db.EPresupuestos
                                 //join c in db.Clientes on ep.IdCliente equals c.Id
                                 //join td in db.TiposDocumento on c.IdTipoDocumento equals td.Id
                             select ep)
                             .ToList()
                                .Select(
                                    p => new EPresupuestos
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdCliente = p.IdCliente,
                                        //Cliente = p.Clientes.RazonSocial,
                                        Fecha = p.Fecha,
                                        DiasValidez = p.DiasValidez,
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

        internal static EPresupuestos ObtenerPresupuestoPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.EPresupuestos.Find(id);
            }
        }

        public static EPresupuestos Insertar(int idCliente, DateTime fecha, int diasValidez, decimal importe, decimal descuento, decimal descPorc,
                                            decimal importeTotal, int PrecioLista, int idUsuario, byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.EPresupuestos.Any() ? db.EPresupuestos.Max(a1 => a1.Id) + 1 : 1;
                    var a = new EPresupuestos
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdCliente = idCliente,
                        Fecha = fecha,
                        DiasValidez = diasValidez,
                        Importe = importe,
                        Descuento = descuento,
                        DescuentoPorc = descPorc,
                        ImporteTotal = importeTotal,
                        PrecioLista = PrecioLista,
                        IdUsuario = idUsuario,                        
                        Estado = estado
                    };
                    db.EPresupuestos.Add(a);
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
                    if (!db.EPresupuestos.Any(t => t.Id == id))
                    {
                        throw new Exception(String.Format("No existe el Presupuesto {0}", id));
                    }
                    var p = db.EPresupuestos.Find(id);
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
