using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;
using System.Linq;

namespace ERP.Repositories
{
    class UnidadesRepository
    {
        public static IEnumerable<Unidades> ObtenerUsuarios()
        {
            using (var db = new VentasConexión())
            {
                return (from u in db.Unidades orderby u.Unidad select u).ToList();
            }
        }
    }
}
