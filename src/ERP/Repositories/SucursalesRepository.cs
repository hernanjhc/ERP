using ERP.Models;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    class SucursalesRepository
    {
        public static IList<Sucursales> ObtenerSucursales()
        {
            using (var db = new VentasConexión())
            {
                var query = (from s in db.Sucursales
                             join b in db.Bancos on s.IdBanco equals b.Id
                             select s)
                             .ToList()
                                .Select(
                                    s => new Sucursales
                                    {
                                        Id = s.Id,
                                        IdEmpresa = s.IdEmpresa,
                                        IdBanco = s.IdBanco,
                                        Bancos = s.Bancos,
                                        Sucursal = s.Sucursal,
                                        //IdTipoDocumento = c.IdTipoDocumento,
                                        // Preparar un modelo
                                        //TiposDocumento = c.TiposDocumento,
                                        Numero = s.Numero,
                                        IdDomicilio = s.IdDomicilio,
                                        Direccion = s.Direccion,
                                        EMail = s.EMail,
                                        Telefono = s.Telefono,
                                        Web = s.Web,
                                        Estado = s.Estado
                                    });
                return query.OrderBy(s => s.Sucursal).ToList();
            }
        }

        internal static Sucursales ObtenerSucursalPorId(int id)
        {
            using (var db = new VentasConexión())
            {
                return db.Sucursales.Find(id);
            }
        }

        public static Sucursales Insertar(string sucursal, int numero, int idBanco, Domicilios domicilio, 
            string dirección, string email, string teléfono, string web, byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    var id = db.Sucursales.Any() ? db.Sucursales.Max(a1 => a1.Id) + 1 : 1;
                    var c = new Sucursales
                    {
                        Id = id,
                        IdEmpresa = Lib.Configuration.IdEmpresa,
                        IdBanco = idBanco,
                        Sucursal = sucursal,
                        Numero = numero,
                        IdDomicilio = DomiciliosRepository.ObtenerIdDomicilio(db, domicilio),
                        Direccion = dirección,
                        EMail = email,
                        Telefono = teléfono,
                        Web = web,
                        Estado = estado
                    };
                    db.Sucursales.Add(c);
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

        internal static Domicilios ObtenerDomicilio(Int32? id)
        {
            using (var db = new VentasConexión())
            {
                return db.Domicilios.Find(id);
            }
        }

        public static void Actualizar(decimal id, int idEmpresa, string sucursal,int numero, int idBanco, Domicilios domicilio, string dirección, string email,  string teléfono, string web,  byte estado)
        {
            using (var db = new VentasConexión())
            {
                var trx = db.Database.BeginTransaction();
                try
                {
                    if (!db.Sucursales.Any(t => t.Id == id))
                    {
                        throw new Exception(String.Format("No existe la Sucursal {0} - {1}, {2}", id, sucursal));
                    }
                    var c = db.Sucursales.Find(id);
                    c.IdEmpresa = idEmpresa;
                    c.Sucursal = sucursal;
                    c.Numero = numero;
                    c.IdBanco = idBanco;
                    c.IdDomicilio = DomiciliosRepository.ObtenerIdDomicilio(db, domicilio);
                    c.Direccion = dirección;
                    c.EMail = email;
                    c.Telefono = teléfono;
                    c.Web = web;
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
                if (!db.Sucursales.Any(t => t.Id == id))
                {
                    throw new Exception("No existe la Sucursal con Id " + id);
                }
                var Sucursal = db.Sucursales.Find(id);
                db.Sucursales.Remove(Sucursal);
                db.SaveChanges();
            }
        }

        public static IEnumerable<Sucursales> ObtenerSucursalesPorBanco(int idBanco)
        {
            using (var db = new Models.VentasConexión())
            {
                var sucu = db.Sucursales.Where(d => d.IdBanco == idBanco).ToList()
                                .Select(
                                    d => new Sucursales
                                    {
                                        Id = d.Id,
                                        Sucursal = d.Sucursal
                                    }
                                 ).ToList();
                return sucu.OrderBy(b => b.Sucursal).ToList();
            }
        }

    }
}
