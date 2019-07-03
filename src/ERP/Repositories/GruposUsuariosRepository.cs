using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repositories
{
    class GruposUsuariosRepository
    {
        internal static IList<Usuarios> ObtenerUsuariosPorGrupoId(int idGrupo)
        {
            using (var db = new VentasConexión())
            {
                var query = (from u in db.Usuarios
                             join gu in db.GruposUsuarios on u.Id equals gu.IdUsuario
                            where u.Estado == 1 && gu.IdGrupo == idGrupo
                             select u)
                             .ToList()
                                .Select(
                                    u => new Usuarios
                                    {
                                        Id = u.Id,
                                        Nombre = u.Nombre,
                                        Contraseña = u.Contraseña,
                                        FechaAlta = u.FechaAlta,
                                        Estado = u.Estado,
                                        FechaBaja = u.FechaBaja,
                                        NombreCompleto = u.NombreCompleto
                                    });
                return query.OrderBy(u => u.Nombre).ToList();
            }
        }

        internal static void Insertar(int idGrupo, int idUsuario)
        {
            using (var db = new VentasConexión())
            {
                var id = db.GruposUsuarios.Any() ? db.GruposUsuarios.Max(g1 => g1.Id) + 1 : 1;
                var gu = new GruposUsuarios { Id = id, IdGrupo = idGrupo, IdUsuario = idUsuario };
                db.GruposUsuarios.Add(gu);
                db.SaveChanges();
            }
        }

        internal static void Eliminar(int idGrupo, int idUsuario)
        {
            using (var db = new VentasConexión())
            {
                var gu = db.GruposUsuarios.FirstOrDefault(t => t.IdGrupo == idGrupo && t.IdUsuario == idUsuario);
                if (gu == null) return;
                db.GruposUsuarios.Remove(gu);
                db.SaveChanges();
            }
        }

        internal static List<Grupos> ObtenerGruposPorIdUsuario(decimal idusuario)
        {
            using (var db = new VentasConexión())
            {
                var query = (from g in db.Grupos
                             join gu in db.GruposUsuarios
                             on g.Id equals gu.IdGrupo
                             where gu.IdUsuario == idusuario
                             select g)
                                .ToList()
                                .Select(
                                    g => new Grupos
                                    {
                                        Id = g.Id,
                                        Descripcion = g.Descripcion,
                                        Estado = g.Estado
                                    });
                return query.OrderBy(g => g.Descripcion).ToList();
            }
        }

    }
}
