using ERP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    class EArticulosRepository
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
                                          Stock = a.Stock,
                                          StockMinimo = a.StockMinimo,
                                          IVA = a.IVA,
                                          Estado = a.Estado
                                      });
                return query.OrderBy(a => a.Descripcion).ToList();
            }
        }

        public static EArticulosImport[] ObtenerArticulosParaExportar()
        {
            using (var db = new VentasConexión())
            {
                var prds = db.EArticulos.ToList();
                //foreach (var item in prds)
                //{
                //    if (item.PrecioL1 == null) item.PrecioL1 = 0;
                //    if (item.PrecioL2 == null) item.PrecioL2 = 0;
                //    if (item.PrecioL3 == null) item.PrecioL3 = 0;
                //    if (item.Stock == null) item.Stock = 0;
                //    if (item.IVA == null) item.IVA = 0;
                //}
                var prd = from p in prds
                          select new EArticulosImport
                          {
                              Id = p.Id,
                              IdEmpresa = p.IdEmpresa,
                              CodBarra = p.CodBarra,
                              Descripcion = p.Descripcion,
                              Marca = p.EMarcas.Marca,
                              Rubro = p.ERubros.Rubro,
                              Proveedor = p.Proveedores.RazonSocial,
                              Unidad = p.Unidades.Unidad,
                              Costo = p.Costo,
                              PrecioL1 = p.PrecioL1 == null ? 0 : Convert.ToDecimal(p.PrecioL1),
                              PrecioL2 = p.PrecioL2 == null ? 0 : Convert.ToDecimal(p.PrecioL2),
                              PrecioL3 = p.PrecioL3 == null ? 0 : Convert.ToDecimal(p.PrecioL3),
                              Stock = p.Stock == null ? 0 : Convert.ToDecimal(p.Stock),
                              StockMinimo = p.StockMinimo,
                              IvaVentas = p.IVA == null ? 0 : Convert.ToDecimal(p.IVA),
                              Observaciones = p.Observaciones == null ? "" : p.Observaciones
                          };
                return prd.ToArray();
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

        public static EArticulos Insertar(string codbarra, string descripcion, int idmarca, int idrubro,
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
                        DescuentoPorc2 = descporc2,
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

        internal static EArticulos ObtenerArticulosPorDescripcion(string descripcion)
        {
            using (var db = new VentasConexión())
            {
                return (from a in db.EArticulos where a.Descripcion.ToLower() == descripcion.ToLower() select a).FirstOrDefault();
            }
        }

        public static void Actualizar(decimal id, int IdEmpresa, string codbarra, string descripcion, int? idmarca, int? idrubro,
                                           int? idproveedor, int? idunidad, decimal costoinicial, decimal desc1, decimal? descporc1,
                                           decimal desc2, decimal? descporc2, decimal desc3, decimal? descporc3, decimal costo,
                                           decimal? stock, decimal stockminimo, decimal? lista1, decimal? listaporc1, decimal? lista2,
                                           decimal? listaporc2, decimal? lista3, decimal? listaporc3, decimal? iva, string observaciones,
                                           int? estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    if (!db.EArticulos.Any(t => t.Id == id))
                    {
                        throw new Exception(String.Format("No existe el Artículo {0} - {1}, {2}", id, descripcion));
                    }
                    var a = db.EArticulos.Find(id);
                    a.IdEmpresa = IdEmpresa;
                    a.CodBarra = codbarra;
                    a.Descripcion = descripcion;
                    a.IdMarca = idmarca;
                    a.IdRubro = idrubro;
                    a.IdProveedor = idproveedor;
                    a.IdUnidad = idunidad;
                    a.CostoInicial = costoinicial;
                    a.Descuento1 = desc1;
                    a.DescuentoPorc1 = descporc1;
                    a.Descuento2 = desc2;
                    a.DescuentoPorc2 = descporc2;
                    a.Descuento3 = desc3;
                    a.DescuentoPorc3 = descporc3;
                    a.Costo = costo;
                    a.Stock = stock;
                    a.StockMinimo = stockminimo;
                    a.PrecioL1 = lista1;
                    a.PrecioPorcL1 = listaporc1;
                    a.PrecioL2 = lista2;
                    a.PrecioPorcL2 = listaporc2;
                    a.PrecioL3 = lista3;
                    a.PrecioPorcL3 = listaporc3;
                    a.IVA = iva;
                    a.Observaciones = observaciones;
                    a.Estado = estado;
                    if (a.Estado != estado)
                    {
                        a.Estado = estado;
                    }
                    db.SaveChanges();
                    trx.Commit();
                }
                catch (Exception)
                {
                    trx.Rollback();
                    throw;
                }
            }
        }

        public static bool IncrementarStockArticulo(decimal id, decimal cantidad)
        {
            try
            {
                using (var db = new VentasConexión())
                {
                    var a = db.EArticulos.Find(id);
                    a.Stock = a.Stock + cantidad;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DescontarStockArticulo(decimal id, decimal cantidad)
        {
            try
            {
                using (var db = new VentasConexión())
                {
                    var a = db.EArticulos.Find(id);
                    a.Stock = a.Stock - cantidad;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void Actualizadr(decimal id, int IdEmpresa, string razonSocial, int idTipoDocumento, decimal nroDocumento,
            DateTime fechaNacimiento, string email, string dirección, string teléfono, Domicilios domicilio, byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    if (!db.Clientes.Any(t => t.Id == id))
                    {
                        throw new Exception(String.Format("No existe el Cliente {0} - {1}, {2}", id, razonSocial));
                    }
                    var c = db.Clientes.Find(id);
                    c.IdEmpresa = IdEmpresa;
                    c.RazonSocial = razonSocial;
                    c.IdTipoDocumento = idTipoDocumento;
                    c.NroDocumento = nroDocumento;
                    c.FechaNacimiento = fechaNacimiento;
                    c.EMail = email;
                    c.Direccion = dirección;
                    c.Telefono = teléfono;
                    c.IdDomicilio = DomiciliosRepository.ObtenerIdDomicilio(db, domicilio);
                    c.Estado = estado;
                    if (c.Estado != estado)
                    {
                        c.Estado = estado;
                    }
                    db.SaveChanges();
                    trx.Commit();
                }
                catch (Exception)
                {
                    trx.Rollback();
                    throw;
                }
            }
        }

        /*
                public static List<EArticulos> CargarArtículos(string archivo)
                {

                    List<EArticulos> result = new List<EArticulos>();
                    var líneas = File.ReadAllLines(archivo).Skip(1);
                    int i = 1;
                    foreach (var línea in líneas)
                    {
                        var campos = línea.Split('\t');
                        var rend = new RendicionBSE();
                        rend.Id = i++;
                        rend.CodigoSucursal = Int32.Parse(campos[0]);
                        rend.NombreSucursal = campos[1];
                        rend.Moneda = campos[2];
                        rend.Comprobante = campos[3];
                        rend.TipoMovimiento = campos[4];
                        rend.Importe = campos[5];
                        rend.FechaProceso = campos[6];
                        rend.CuilUsuario = campos[7];
                        rend.NombreUsuario = campos[8];
                        rend.Hora = campos[9];
                        rend.CodigoBarra = campos[10];
                        rend.GrupoTerminal = campos[11];
                        rend.NroRendicion = campos[12];
                        rend.FechaMovimiento = campos[13];
                        result.Add(rend);
                    }
                    return result;

                }
                */
    }
}
