using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    class ArticulosRepository
    {
        public static IList<EArticulos> ObtenerArticulos()
        {
            using (var db = new VentasConexión())
            {
                var query = (from a in db.EArticulos
                             select a)
                               .ToList()
                                  .Select(
                                      a => new EArticulos
                                      {
                                          Id = a.Id,
                                          IdEmpresa = a.IdEmpresa,
                                          Codigo = a.Codigo,
                                          CodBarra = a.CodBarra,
                                          Descripcion = a.Descripcion,
                                          IdMarca = a.IdMarca,
                                          IdRubro = a.IdRubro,
                                          IdProveedor = a.IdProveedor,
                                          IdUnidad = a.IdUnidad,
                                          CostoInicial = a.CostoInicial,
                                          Descuento1 = a.Descuento1,
                                          DescuentoPorc1 = a.DescuentoPorc1,
                                          Descuento2 = a.Descuento2,
                                          DescuentoPorc2 = a.DescuentoPorc2,
                                          Descuento3 = a.Descuento3,
                                          DescuentoPorc3 = a.DescuentoPorc3,
                                          Costo = a.Costo,
                                          PrecioL1 = a.PrecioL1,
                                          PrecioPorcL1 = a.PrecioPorcL1,
                                          PrecioL2 = a.PrecioL2,
                                          PrecioPorcL2 = a.PrecioPorcL2,
                                          PrecioL3 = a.PrecioL3,
                                          PrecioPorcL3 = a.PrecioPorcL3,
                                          IVA = a.IVA,
                                          Estado = a.Estado
                                      });
                return query.OrderBy(a => a.Descripcion).ToList();
            }
        }
    }
}
