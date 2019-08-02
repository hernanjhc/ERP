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

        public static Bancos Insertar(string nombre)
        {
            using (var db = new VentasConexión())
            {
                if (db.Bancos.Any(d => d.Nombre.ToLower() == nombre.ToLower() ))
                {
                    throw new Exception("Ya existe un Banco con este nombre");
                }

                var id = db.Bancos.Any() ? db.Bancos.Max(d => d.Id) + 1 : 1;
                var ban = new Bancos
                {
                    Id = id,
                    Nombre = nombre
                };
                db.Bancos.Add(ban);
                db.SaveChanges();
                return ban;
            }
        }
    }
}
