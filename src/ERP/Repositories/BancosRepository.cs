using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    class BancosRepository
    {
        public static IEnumerable<Bancos> ObtenerBancos()
        {
            using (var db = new Models.VentasConexión())
            {
                var bn = db.Bancos.ToList()
                             .Select(
                                td => new Bancos
                                {
                                    Id = td.Id,
                                    Nombre = td.Nombre
                                }
                             );
                return bn.OrderBy(b => b.Nombre).ToList();
            }
        }
    }
}
