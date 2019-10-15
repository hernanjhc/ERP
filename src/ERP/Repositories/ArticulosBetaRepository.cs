using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using ERP.Models;

namespace ERP.Repositories
{
    public class ArticulosBetaRepository
    {
        //public static List<articulosBeta> LeerExcel(string archivo)
        //{
        //    //var book = new ExcelQueryFactory(archivo);
        //    //var resultado = (from row in book.Worksheet("Hoja1")
        //    //                 let item = new articulosBeta
        //    //                 {
        //    //                     //codigo	codbarra	cantidad	costo	precioL1
        //    //                     codigo = row["codigo"].Cast(),
        //    //                     codbarra = row["codbarra"].Cast(),
        //    //                     cantidad = row["cantidad"].Cast(),
        //    //                     costo = row["costo"].Cast(),
        //    //                     precioL1 = row["precioL1"].Cast()
        //    //                 }
        //    //                 select item).ToList();
        //    //book.Dispose();
        //    return resultado;
        //}
    }
}
