using ERP.Lib;
using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ERP.Repositories
{
    public class UsuariosRepository
    {
        public bool VerificarLoginUsuario(string nombre, string contraseña)
        {
            Usuarios usr = ObtenerUsuario(nombre);
            if (usr == null)
            {
                return false;
            }
            if (usr.Contraseña == Lib.Security.Cryptography.CalcularSHA512(contraseña))
            {
                Configuration.IdUsuarioConectado = usr.Id;
                return true;
            }
            else
            {
                return false;
            }
           
        }

        internal Usuarios ObtenerUsuario(string nombre)
        {
            using (var db = new VentasConexión())
            {
                return (from u in db.Usuarios where u.Nombre.ToLower() == nombre.ToLower() select u).FirstOrDefault();
            }
        }

        public static IEnumerable<Usuarios> ObtenerUsuarios()
        {
            using (var db = new VentasConexión())
            {
                return (from u in db.Usuarios orderby u.Nombre select u).ToList();
            }
        }

        internal static Usuarios Insertar(string nombre, string nombreCompleto, byte estado)
        {
            using (var db = new VentasConexión())
            {
                if (db.Usuarios.Any(c => c.Nombre.ToLower().Trim() == nombre.ToLower().Trim()))
                {
                    throw new Exception("Ya existe un usuario con este nombre.");
                }
                var id = db.Usuarios.Max(c => c.Id) + 1;
                var usr = new Usuarios
                {
                    Id = id,
                    Nombre = nombre,
                    NombreCompleto = nombreCompleto,
                    FechaAlta = Configuration.CurrentDate,
                    Estado = estado,
                    FechaBaja = estado == 1 ? (DateTime?)null : Configuration.CurrentDate,
                    Contraseña = Lib.Security.Cryptography.CalcularSHA512("123456")
                };
                db.Usuarios.Add(usr);
                db.SaveChanges();
                return usr;
            }
        }

        internal static Usuarios ObtenerUsuarioPorId(decimal id)
        {
            using (var db = new VentasConexión())
            {
                return db.Usuarios.Find(id);
            }
        }

        internal static void Actualizar(int id, string nombre, string nombreCompleto, byte estado)
        {
            using (var db = new VentasConexión())
            {
                if (!db.Usuarios.Any(t => t.Id == id))
                {
                    throw new Exception("No existe el usuario con Id " + id);
                }
                var u = db.Usuarios.Find(id);
                u.Nombre = nombre.Trim();
                u.NombreCompleto = nombreCompleto.Trim();
                u.Estado = estado;
                db.SaveChanges();
            }
        }

        internal static void ReiniciarContraseña(int id, string contraseña)
        {
            using (var db = new VentasConexión())
            {
                if (!db.Usuarios.Any(t => t.Id == id))
                {
                    throw new Exception("No existe el usuario con Id " + id);
                }
                var u = db.Usuarios.Find(id);
                u.Contraseña = Lib.Security.Cryptography.CalcularSHA512(contraseña);
                db.SaveChanges();
            }
        }
    }
}
