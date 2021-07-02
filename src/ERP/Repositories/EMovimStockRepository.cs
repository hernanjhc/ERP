using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    public class EMovimStockRepository
    {
        //public static bool InsertarVenta(EVentas venta)
        //{
        //    using (var db = new VentasConexión())
        //    {
        //        try
        //        {
        //            var id = db.EMovimStock.Any() ? db.EMovimStock.Max(d => d.Id) + 1 : 1;
        //            var movimiento = new EMovimStock
        //            {
        //                Id = id,
        //                IdEmpresa = venta.IdEmpresa,
        //                Fecha = DateTime.Now,
        //                idVenta = venta.Id,
        //                Credito = venta.ImporteTotal
        //            };
        //            db.EMovimStock.Add(movimiento);
        //            db.SaveChanges();
        //            return true;
        //        }
        //        catch (Exception)
        //        {
        //            return false;
        //        }

        //    }
        //}
    }
}
