using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    static class TiposDocumentoRepository
    {
        public static IEnumerable<TiposDocumento> ObtenerTiposDocumento()
        {
            using (var db = new Models.VentasConexión())
            {
                var deptos = db.TiposDocumento.ToList()
                             .Select(
                                td => new TiposDocumento {
                                  Id = td.Id,
                                  Descripcion = td.Descripcion
                                }
                             );
                return deptos.OrderBy(b => b.Descripcion).ToList();
            }
        }

        public static TiposDocumento TiposDocumentoPorId(int idTipoDocumento)
        {
            using (var db = new VentasConexión())
            {
                return db.TiposDocumento.Find(idTipoDocumento);
            }
        }

    }
}
