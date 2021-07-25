using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;
using System.Data;
using ERP.Reports.DataSet;

namespace ERP.Repositories
{
    class VentasDetallesRepository
    {
        public static IList<EVentasDetalles> ObtenerDetallesDeVenta(int idVenta)
        {
            using (var db = new VentasConexión())
            {
                var query = (
                             from ep in db.EVentasDetalles
                             select ep)
                             .Where(d => d.IdVenta == idVenta)
                             .ToList()
                                .Select(
                                    p => new EVentasDetalles
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdVenta = p.IdVenta,
                                        IdArticulo = p.IdArticulo,
                                        Importe = p.Importe,
                                        Cantidad = p.Cantidad,
                                        Precio = p.Precio
                                    });
                return query.OrderBy(p => p.Id).ToList();
            }
        }

        public static EVentasDetalles Insertar(int idVenta, int idArticulo, int cantidad, decimal precio, decimal importe)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.EVentasDetalles.Any() ? db.EVentasDetalles.Max(a1 => a1.Id) + 1 : 1;
                    var a = new EVentasDetalles
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdVenta = idVenta,
                        IdArticulo = idArticulo,
                        Importe = importe,
                        Cantidad = cantidad,
                        Precio = precio
                    };
                    db.EVentasDetalles.Add(a);
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

        public static bool Insertar(EVentasDetalles detalles)
        {
            bool proceso = true;
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.EVentasDetalles.Any() ? db.EVentasDetalles.Max(a1 => a1.Id) + 1 : 1;
                    detalles.IdEmpresa = Lib.Configuration.IdEmpresa;
                    detalles.Id = id;
                    db.EVentasDetalles.Add(detalles);
                    db.SaveChanges();
                    trx.Commit();
                }
                catch (Exception)
                {
                    trx.Rollback();
                    proceso = false;
                }
            }
            return proceso;
        }

        public static DataTable CargarDetalles(int idVenta)
        {
            var tabla = new dsImpresiones.DetallesDataTable();

            var detalles = ObtenerDetalles(idVenta);
            foreach (var d in detalles)
            {
                string id = d.IdArticulo.ToString();
                string codBarra = EArticulosRepository.ObtenerArticulosPorId(Convert.ToInt32(d.IdArticulo)).CodBarra;
                string descripcion = EArticulosRepository.ObtenerArticulosPorId(Convert.ToInt32(d.IdArticulo)).Descripcion;
                string cantidad = d.Cantidad.ToString();
                string precio = d.Precio.ToString();
                string importe = d.Importe.ToString();

                tabla.AddDetallesRow(id, codBarra, descripcion, cantidad, precio, importe);
            }
            return tabla;
        }

        internal static EVentasDetalles ObtenerDetallesPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.EVentasDetalles.Find(id);
            }
        }

        public static IList<EVentasDetalles> ObtenerDetalles(int idVenta)
        {
            using (var db = new VentasConexión())
            {
                var query = (from a in db.EVentasDetalles
                             select a).Where(x => x.IdVenta == idVenta)
                               .ToList();
                return query.ToList();
            }
        }

        internal static void EliminarDetallesVentaRegistradosIncorrectamente(int idVentaRegistrada)
        {
            using (var db = new VentasConexión())
            {
                var detalles = db.EVentasDetalles.Where(d => d.IdVenta == idVentaRegistrada);
                foreach (var item in detalles)
                {
                    var eliminar = db.EVentasDetalles.Find(item);
                    db.EVentasDetalles.Remove(eliminar);
                    db.SaveChanges();
                }
            }
        }
    }
}
