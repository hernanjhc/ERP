using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    public class MovimientosRepository
    {
        public static bool InsertarVenta(EVentas venta)
        {
            using (var db = new VentasConexión())
            {
                try
                {
                    var id = db.EMovimientos.Any() ? db.EMovimientos.Max(d => d.Id) + 1 : 1;
                    var movimiento = new EMovimientos
                    {
                        Id = id,
                        IdEmpresa = venta.IdEmpresa,
                        Fecha = DateTime.Now,
                        idVenta = venta.Id,
                        Credito = venta.ImporteTotal
                    };
                    db.EMovimientos.Add(movimiento);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                
            }
        }
    }
}
