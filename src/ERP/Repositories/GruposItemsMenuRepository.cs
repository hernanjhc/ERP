using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    class GruposItemsMenuRepository
    {
        internal static IList<ItemsMenu> ObtenerItemsMenuPorGrupoId(int idGrupo)
        {
            using (var db = new ERPEntities())
            {
                var query = (
                            from it in db.ItemsMenu
                             join gim in db.GruposItemsMenu on it.Id equals gim.IdItemMenu
                             where gim.IdGrupo == idGrupo
                             select it)
                             .ToList()
                                .Select(
                                    u => new ItemsMenu
                                    {
                                        Id = u.Id,
                                        IdPadre = u.IdPadre,
                                        Nombre = u.Nombre,
                                        Descripcion = u.Descripcion
                                    });
                return query.OrderBy(u => u.Nombre).ToList();
            }
        }

        public static List<Grupos> ObtenerGruposPorItemMenu(int idItemMenu, bool asignados)
        {
            using (var db = new ERPEntities())
            {                
                var query = (from gim in db.GruposItemsMenu
                             join g in db.Grupos on gim.IdGrupo equals g.Id
                             where gim.IdItemMenu == idItemMenu
                             select g)
                             .ToList()
                             .Select(
                                t => new Grupos
                                {
                                    Id = t.Id,
                                    Descripcion = t.Descripcion
                                }
                             );
                if (asignados)
                {
                    return query.ToList();
                }
                else
                {
                    var grupos = db.Grupos.ToList();
                    grupos.RemoveAll(g => query.Select(g1 => g1.Id).Contains(g.Id));
                    return grupos;
                }
            }
        }

        public static List<Usuarios> ObtenerUsuariosPorItemMenu(int idItemMenu, bool asignados)
        {
            using (var db = new ERPEntities())
            {
                var query = (from uim in db.UsuariosItemsMenu
                             join u in db.Usuarios on uim.IdUsuario equals u.Id
                             where uim.IdItemMenu == idItemMenu
                             select u)
                             .ToList()
                             .Select(
                                t => new Usuarios
                                {
                                    Id = t.Id,
                                    NombreCompleto = t.NombreCompleto
                                }
                             );
                if (asignados)
                {
                    return query.ToList();
                }
                else
                {
                    var usuarios = db.Usuarios.ToList();
                    usuarios.RemoveAll(u => query.Select(u1 => u1.Id).Contains(u.Id));
                    return usuarios.Select(
                                u => new Usuarios {
                                    Id = u.Id,
                                    NombreCompleto = u.NombreCompleto })
                                .ToList();
                }
            }
        }

        internal static void Insertar(int idGrupo, int idItemMenu)
        {
            using (var db = new ERPEntities())
            {
                var id = db.GruposItemsMenu.Any() ? db.GruposItemsMenu.Max(g1 => g1.Id) + 1 : 1;
                var gu = new GruposItemsMenu { Id = id, IdGrupo = idGrupo, IdItemMenu = idItemMenu };
                db.GruposItemsMenu.Add(gu);
                db.SaveChanges();
            }
        }

        internal static void Eliminar(int idGrupo, int idItemMenu)
        {
            using (var db = new ERPEntities())
            {
                var gu = db.GruposItemsMenu.FirstOrDefault(t => t.IdGrupo == idGrupo && t.IdItemMenu == idItemMenu);
                if (gu == null) return;
                db.GruposItemsMenu.Remove(gu);
                db.SaveChanges();
            }
        }

        public static IList<ItemsMenu> ObtenerItemsMenuPorIdGrupo(int idgrupo)
        {
            using (var db = new ERPEntities())
            {
                var query = (from gi in db.GruposItemsMenu
                             join im in db.ItemsMenu
                             on gi.IdItemMenu equals im.Id
                             where gi.IdGrupo == idgrupo
                             select im)
                             .ToList()
                             .Select(
                             im => new ItemsMenu
                             {
                                 Id = im.Id,
                                 IdPadre = im.IdPadre,
                                 Nombre = im.Nombre,
                                 Descripcion = im.Descripcion
                             });
                return query.OrderBy(q => q.Id).ToList();
            }
        }

    }
}
