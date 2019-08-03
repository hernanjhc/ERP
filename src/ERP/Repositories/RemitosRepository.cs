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
    }
}
