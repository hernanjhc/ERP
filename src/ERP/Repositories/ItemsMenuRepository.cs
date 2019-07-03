using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Models;

namespace ERP.Repositories
{
    class ItemsMenuRepository
    {
        public static void Actualizar(string nombre, string descripción, string nombrePadre)
        {
            using (var db = new VentasConexión())
            {
                var padre = ObtenerMenuItem(nombrePadre) ?? new ItemsMenu { Id = 0 };
                if (!db.ItemsMenu.Any(im => im.Nombre == nombre && padre.Nombre == nombrePadre))
                {
                    var im = new ItemsMenu();
                    im.Id = db.ItemsMenu.Any() ? db.ItemsMenu.Max(c1 => c1.Id) + 1 : 1;
                    im.Nombre = nombre;
                    im.Descripcion = descripción;
                    im.IdPadre = padre.Id;
                    db.ItemsMenu.Add(im);
                }
                else
                {
                    var im = db.ItemsMenu.First(im1 => im1.Nombre == nombre);
                    im.Nombre = nombre;
                    im.Descripcion = descripción;
                    im.IdPadre = padre.Id;
                }
                db.SaveChanges();
            }
        }

        public static void EliminarItemsInexistentes(IList<string> menuItemsNames)
        {
            using (var db = new VentasConexión())
            {
                foreach (var item in db.ItemsMenu)
                {
                    if (!menuItemsNames.Contains(item.Nombre))
                    {
                        db.ItemsMenu.Remove(item);
                    }
                }
                db.SaveChanges();
            }
        }

        private static ItemsMenu ObtenerMenuItem(string nombre)
        {
            using (var db = new VentasConexión())
            {
                return db.ItemsMenu.FirstOrDefault(im => im.Nombre == nombre);
            }
        }

        public static IList<ItemsMenu> ObtenerItemsMenu()
        {
            using (var db = new VentasConexión())
            {
                var query = (from c in db.ItemsMenu select c)
                                .ToList()
                                .Select(
                                    c => new ItemsMenu
                                    {
                                        Id = c.Id,
                                        IdPadre = c.IdPadre,
                                        Nombre = c.Nombre,
                                        Descripcion = c.Descripcion
                                    });
                return query.OrderBy(c => c.Id).ToList();
            }
        }

        public static IList<ItemsMenu> ObtenerItemsMenu(int idusuario)
        {
            using (var db = new VentasConexión())
            {
                var query = (from ui in db.UsuariosItemsMenu
                             join ime in db.ItemsMenu
                             on ui.IdItemMenu equals ime.Id
                             where ui.IdUsuario == idusuario
                             select ime)
                             .ToList()
                             .Select(
                                ime => new ItemsMenu
                                {
                                    Id = ime.Id,
                                    IdPadre = ime.IdPadre,
                                    Nombre = ime.Nombre,
                                    Descripcion = ime.Descripcion
                                });
                return query.OrderBy(q => q.Id).ToList();
            }
        }

        
    }
}
