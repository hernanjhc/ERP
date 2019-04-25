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
            using (var db = new Models.ERPEntities())
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
    }
}
