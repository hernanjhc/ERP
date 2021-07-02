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
    class PresupuestosDetallesRepository
    {
        public static IList<EPresupuestosDetalles> ObtenerDetallesDelPresupuesto(int idpresupuesto)
        {
            using (var db = new VentasConexión())
            {
                var query = (
                             from ep in db.EPresupuestosDetalles
                             select ep)
                             .Where(d => d.IdPresupuesto == idpresupuesto)
                             .ToList()
                                .Select(
                                    p => new EPresupuestosDetalles
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        IdPresupuesto = p.IdPresupuesto,
                                        IdArticulo = p.IdArticulo,
                                        Importe = p.Importe,
                                        Cantidad = p.Cantidad,
                                        Precio = p.Precio
                                    });
                return query.OrderBy(p => p.Id).ToList();
            }
        }

        public static EPresupuestosDetalles Insertar(int idPresupuesto, int idArticulo, int cantidad, decimal precio, decimal importe)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.EPresupuestosDetalles.Any() ? db.EPresupuestosDetalles.Max(a1 => a1.Id) + 1 : 1;
                    var a = new EPresupuestosDetalles
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdPresupuesto = idPresupuesto,
                        IdArticulo = idArticulo,
                        Importe = importe,
                        Cantidad = cantidad,
                        Precio = precio
                    };
                    db.EPresupuestosDetalles.Add(a);
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

        public static DataTable CargarDetalles(int idPresupuesto)
        {
            var tabla = new dsImpresiones.DetallesDataTable();

            var detalles = ObtenerDetalles(idPresupuesto);
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

        internal static EPresupuestosDetalles ObtenerDetallesPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.EPresupuestosDetalles.Find(id);
            }
        }

        public static IList<EPresupuestosDetalles> ObtenerDetalles(int idPresupuesto)
        {
            using (var db = new VentasConexión())
            {
                var query = (from a in db.EPresupuestosDetalles
                             select a).Where(x => x.IdPresupuesto == idPresupuesto)
                               .ToList();
                return query.ToList();
            }
        }

    }
}
