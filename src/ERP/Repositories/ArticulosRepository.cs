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

        public static void Eliminar(decimal id)
        {
            using (var db = new VentasConexión())
            {
                if (!db.EArticulos.Any(t => t.Id == id))
                {
                    throw new Exception("No existe Artículos con Id " + id);
                }
                var Artículo = db.EArticulos.Find(id);
                db.EArticulos.Remove(Artículo);
                db.SaveChanges();
            }
        }

        public static EArticulos Insertar(string codigo, string codbarra, string descripcion, int idmarca, int idrubro,
                                            int idproveedor, int idunidad, decimal costoinicial, decimal desc1, decimal descporc1,
                                            decimal desc2, decimal descporc2, decimal desc3, decimal descporc3, decimal costo,
                                            decimal stock, decimal stockminimo, decimal lista1, decimal listaporc1, decimal lista2, 
                                            decimal listaporc2, decimal lista3, decimal listaporc3, decimal iva, string observaciones,
                                            byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.EArticulos.Any() ? db.EArticulos.Max(a1 => a1.Id) + 1 : 1;
                    var a = new EArticulos
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        Codigo = codigo,
                        CodBarra = codbarra,
                        Descripcion = descripcion,
                        IdMarca = idmarca,
                        IdRubro = idrubro,
                        IdProveedor = idproveedor,
                        IdUnidad = idunidad,
                        CostoInicial = costoinicial,
                        Descuento1 = desc1,
                        DescuentoPorc1 = descporc1,
                        Descuento2 = desc2,
                        DescuentoPorc2= descporc2,
                        Descuento3 = desc3,
                        DescuentoPorc3 = descporc3,
                        Costo = costo,
                        Stock = stock,
                        StockMinimo = stockminimo,
                        PrecioL1 = lista1,
                        PrecioPorcL1 = listaporc1,
                        PrecioL2 = lista2,
                        PrecioPorcL2 = listaporc2,
                        PrecioL3 = lista3,
                        PrecioPorcL3 = listaporc3,
                        IVA = iva,
                        Observaciones = observaciones,
                        Estado = estado
                    };
                    db.EArticulos.Add(a);
                    db.SaveChanges();
                    trx.Commit();
                    return a;
                }
                catch (Exception)
                {
                    trx.Rollback();
                    throw;
                }
            }
        }

        internal static EArticulos ObtenerArticulosPorId(decimal id)
        {
            using (var db = new VentasConexión())
            {
                return db.EArticulos.Find(id);
            }
        }

    }
}
