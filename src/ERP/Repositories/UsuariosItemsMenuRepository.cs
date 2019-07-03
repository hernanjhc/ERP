using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    class UsuariosItemsMenuRepository
    {
        internal static void Insertar(int idUsuario, int idItemMenu)
        {
            using (var db = new VentasConexión())
            {
                var id = db.UsuariosItemsMenu.Any() ? db.UsuariosItemsMenu.Max(g1 => g1.Id) + 1 : 1;
                var uu = new UsuariosItemsMenu { Id = id, IdUsuario = idUsuario, IdItemMenu = idItemMenu };
                db.UsuariosItemsMenu.Add(uu);
                db.SaveChanges();
            }
        }

        internal static void Eliminar(int idUsuario, int idItemMenu)
        {
            using (var db = new VentasConexión())
            {
                var uu = db.UsuariosItemsMenu.FirstOrDefault(t => t.IdUsuario == idUsuario && t.IdItemMenu == idItemMenu);
                if (uu == null) return;
                db.UsuariosItemsMenu.Remove(uu);
                db.SaveChanges();
            }
        }
    }
}
