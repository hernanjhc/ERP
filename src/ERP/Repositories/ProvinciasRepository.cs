using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    static class ProvinciasRepository
    {
        public static IEnumerable<Provincias> ObtenerProvincias()
        {
            using (var db = new Models.VentasConexión())
            {
                var query = db.Provincias.ToList()
                                .Select(
                                    c => new Provincias {
                                        Id = c.Id,
                                        Nombre = c.Nombre
                                    }
                                 );
                return query.OrderBy(c => c.Nombre).ToList();
            }
        }
    }
}
