using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    class ProveedoresRepository
    {
        public static IList<Proveedores> ObtenerProveedores()
        {
            using (var db = new VentasConexión())
            {
                var query = (from p in db.Proveedores
                             join td in db.TiposDocumento on p.IdTipoDocumento equals td.Id
                             select p)
                             .ToList()
                                .Select(
                                    p => new Proveedores
                                    {
                                        Id = p.Id,
                                        IdEmpresa = p.IdEmpresa,
                                        RazonSocial = p.RazonSocial,
                                        IdTipoDocumento = p.IdTipoDocumento,
                                        // Preparar un modelo
                                        TiposDocumento = p.TiposDocumento,
                                        NroDocumento = p.NroDocumento,
                                        FechaNacimiento = p.FechaNacimiento,
                                        EMail = p.EMail,
                                        Direccion = p.Direccion,
                                        Telefono = p.Telefono,
                                        IdDomicilio = p.IdDomicilio,
                                        //Domicilio = c.Domicilio,
                                        Estado = p.Estado
                                    });
                return query.OrderBy(p => p.RazonSocial).ToList();
            }
        }

        public static IList<Proveedores> BuscarProveedoresPorDocumento(string nroDocumento)
        {
            var query = ObtenerProveedores().Where(a => a.NroDocumento.ToString().Contains(nroDocumento))
                        .Select(
                            a => new Proveedores
                            {
                                Id = a.Id,
                                NroDocumento = a.NroDocumento,
                                RazonSocial = a.RazonSocial
                            });
            return query.ToList();
        }

        public static IList<Proveedores> BuscarProveedoresPorNombre(string nombre)
        {
            var query = ObtenerProveedores().Where(a => (a.RazonSocial).Contains(nombre))
                        .Select(
                            a => new Proveedores
                            {
                                Id = a.Id,
                                NroDocumento = a.NroDocumento,
                                RazonSocial = a.RazonSocial
                            });
            return query.ToList();
        }

        internal static Proveedores BuscarProveedorPorNroDocumento(decimal nroDocumento)
        {
            using (var db = new VentasConexión())
            {
                return db.Proveedores.FirstOrDefault(a => a.NroDocumento == nroDocumento);
            }
        }

        internal static string ObtenerProveedorStringPorID(int? idProveedor)
        {
            using (var db = new VentasConexión())
            {
                return db.Proveedores.Find(idProveedor).RazonSocial;
            }
        }

        internal static Proveedores ObtenerProveedorPorId(decimal id)
        {
            using (var db = new VentasConexión())
            {
                var a = db.Proveedores.Find(id);
                if (a != null)
                {
                    db.Entry(a).Reference(t => t.TiposDocumento).Load();
                    db.Entry(a).Reference(d => d.Domicilios).Load();
                    if (a.Domicilios != null)
                    {
                        db.Entry(a.Domicilios).Reference(p => p.Provincias).Load();
                        db.Entry(a.Domicilios).Reference(d => d.Departamentos).Load();
                        db.Entry(a.Domicilios).Reference(l => l.Localidades).Load();
                        db.Entry(a.Domicilios).Reference(b => b.Barrios).Load();
                    }
                }
                return a;
            }
        }

        internal static int ObtenerIdProveedor(string proveedor)
        {
            using (var db = new VentasConexión())
            {
                int idProveedor = 0;
                if (!db.Proveedores.Any(p => p.RazonSocial.ToLower().Trim() == proveedor.ToLower().Trim()))
                {
                    Insertar(proveedor, 1, 100, DateTime.Now,
                        "email", "direccion", null, null, 1);
                }
                idProveedor = db.Proveedores.FirstOrDefault(p => p.RazonSocial.ToLower().Trim() == proveedor.ToLower().Trim()).Id;

                return idProveedor;
            }
        }

        internal static Domicilios ObtenerDomicilio(Int32? id)
        {
            using (var db = new VentasConexión())
            {
                return db.Domicilios.Find(id);
            }
        }

        public static void Actualizar(decimal id, int IdEmpresa, string razonSocial, int idTipoDocumento, decimal nroDocumento,
            DateTime fechaNacimiento, string email, string dirección, string teléfono, Domicilios domicilio, byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    if (!db.Proveedores.Any(t => t.Id == id))
                    {
                        throw new Exception(String.Format("No existe el Proveedor {0} - {1}, {2}", id, razonSocial));
                    }
                    var p = db.Proveedores.Find(id);
                    p.IdEmpresa = IdEmpresa;
                    p.RazonSocial = razonSocial;
                    p.IdTipoDocumento = idTipoDocumento;
                    p.NroDocumento = nroDocumento;
                    p.FechaNacimiento = fechaNacimiento;
                    p.EMail = email;
                    p.Direccion = dirección;
                    p.Telefono = teléfono;
                    p.IdDomicilio = DomiciliosRepository.ObtenerIdDomicilio(db, domicilio);
                    p.Estado = estado;
                    if (p.Estado != estado)
                    {
                        p.Estado = estado;
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

        public static void Eliminar(decimal id)
        {
            using (var db = new VentasConexión())
            {
                if (!db.Proveedores.Any(t => t.Id == id))
                {
                    throw new Exception("No existe el Proveedor con Id " + id);
                }
                var Proveedor = db.Proveedores.Find(id);
                db.Proveedores.Remove(Proveedor);
                db.SaveChanges();
            }
        }

        public static Proveedores Insertar(string razonSocial, int idTipoDocumento, decimal nroDocumento,
            DateTime fechaNacimiento, string email, string dirección, Domicilios domicilio, string teléfono, byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.Proveedores.Any() ? db.Proveedores.Max(a1 => a1.Id) + 1 : 1;
                    var p = new Proveedores
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        RazonSocial = razonSocial,
                        IdTipoDocumento = idTipoDocumento,
                        NroDocumento = nroDocumento,
                        FechaNacimiento = fechaNacimiento,
                        EMail = email,
                        Direccion = dirección,
                        IdDomicilio = domicilio!= null? DomiciliosRepository.ObtenerIdDomicilio(db, domicilio) : null,
                        Telefono = teléfono,
                        Estado = estado
                    };
                    db.Proveedores.Add(p);
                    db.SaveChanges();
                    trx.Commit();
                    return p;
                }
                catch (Exception)
                {
                    trx.Rollback();
                    throw;
                }
            }
        }
    }
}
