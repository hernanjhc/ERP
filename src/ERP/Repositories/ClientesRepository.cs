using ERP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    class ClientesRepository
    {
        public static IList<Clientes> ObtenerClientes()
        {
            using (var db = new VentasConexión())
            {
                var query = (from c in db.Clientes
                             join td in db.TiposDocumento on c.IdTipoDocumento equals td.Id
                             select c)
                             .ToList()
                                .Select(
                                    c => new Clientes
                                    {
                                        Id = c.Id,
                                        IdEmpresa = c.IdEmpresa,
                                        RazonSocial = c.RazonSocial,
                                        IdTipoDocumento = c.IdTipoDocumento,
                                        // Preparar un modelo
                                        TiposDocumento = c.TiposDocumento,
                                        NroDocumento = c.NroDocumento,
                                        FechaNacimiento = c.FechaNacimiento,
                                        EMail = c.EMail,
                                        Direccion = c.Direccion,
                                        Telefono = c.Telefono,
                                        IdDomicilio = c.IdDomicilio,
                                        //Domicilio = c.Domicilio,
                                        Estado = c.Estado
                                    });
                return query.OrderBy(c => c.RazonSocial).ToList();
            }
        }

        public static IList<Clientes> BuscarClientesPorDocumento(string nroDocumento)
        {
            var query = ObtenerClientes().Where(a => a.NroDocumento.ToString().Contains(nroDocumento))
                        .Select(
                            a => new Clientes
                            {
                                Id = a.Id,
                                NroDocumento = a.NroDocumento,
                                RazonSocial = a.RazonSocial
                            });
            return query.ToList();
        }

        public static IList<Clientes> BuscarClientesPorNombre(string nombre)
        {
            var query = ObtenerClientes().Where(a => (a.RazonSocial).Contains(nombre))
                        .Select(
                            a => new Clientes
                            {
                                Id = a.Id,
                                NroDocumento = a.NroDocumento,
                                RazonSocial = a.RazonSocial
                            });
            return query.ToList();
        }

        internal static Clientes BuscarClientePorNroDocumento(decimal nroDocumento)
        {
            using (var db = new VentasConexión())
            {
                return db.Clientes.FirstOrDefault(a => a.NroDocumento == nroDocumento);
            }
        }

        internal static Clientes ObtenerClientePorId(decimal id)
        {
            using (var db = new VentasConexión())
            {
                var a = db.Clientes.Find(id);
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

        public static void Eliminar(decimal id)
        {
            using (var db = new VentasConexión())
            {
                if (!db.Clientes.Any(t => t.Id == id))
                {
                    throw new Exception("No existe el Cliente con Id " + id);
                }
                var Cliente = db.Clientes.Find(id);
                db.Clientes.Remove(Cliente);
                db.SaveChanges();
            }
        }

        public static Clientes Insertar(string razonSocial, int idTipoDocumento, decimal nroDocumento,
            DateTime fechaNacimiento, string email, string dirección, Domicilios domicilio, string teléfono, byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.Clientes.Any() ? db.Clientes.Max(a1 => a1.Id) + 1 : 1;
                    var c = new Clientes
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        RazonSocial = razonSocial,
                        IdTipoDocumento = idTipoDocumento,
                        NroDocumento = nroDocumento,
                        FechaNacimiento = fechaNacimiento,
                        EMail = email,
                        Direccion = dirección,
                        IdDomicilio = DomiciliosRepository.ObtenerIdDomicilio(db, domicilio),
                        Telefono = teléfono,
                        Estado = estado
                    };
                    db.Clientes.Add(c);
                    db.SaveChanges();
                    trx.Commit();
                    return c;
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
