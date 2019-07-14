using ERP.Lib.AppForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Models;
using ERP.Repositories;

namespace ERP.Forms.ItemsMenu
{
    public partial class frmAsignarUsuariosyGruposAMenuItems : FormBase
    {
        private IList<Models.ItemsMenu> _itemsMenu;

        public frmAsignarUsuariosyGruposAMenuItems()
        {
            InitializeComponent();

            _itemsMenu = ItemsMenuRepository.ObtenerItemsMenu();
            var tn = tvItemsMenu.Nodes.Add("ERP");
            CargarMenu(tn, _itemsMenu.Where(im => im.IdPadre == 0).ToList());
            tvItemsMenu.ExpandAll();
            tvItemsMenu.SelectedNode = tn.FirstNode;
            rbUsuarios.Checked = true;
            ConsultarUsuarios();
            tvItemsMenu.Select();
        }

        private void CargarMenu(TreeNode padre, List<Models.ItemsMenu> items)
        {
            foreach (var item in items)
            {
                TreeNode tn = new TreeNode();
                tn.Text = item.Descripcion;
                tn.Name = item.Nombre;
                tn.Tag = item;
                padre.Nodes.Add(tn);
                CargarMenu(tn, _itemsMenu.Where(im => im.IdPadre == item.Id).ToList());
            }
        }

        private int IdGrupo
        {
            get
            {
                return (int)lbSinAsignar.SelectedValue;
            }
        }

        private int IdUsuario
        {
            get
            {
                return (int)lbSinAsignar.SelectedValue;
            }
        }

        public Models.ItemsMenu ItemMenu
        {
            get
            {
                if (tvItemsMenu.SelectedNode != null && tvItemsMenu.SelectedNode.Tag is Models.ItemsMenu)
                {
                    return (Models.ItemsMenu)tvItemsMenu.SelectedNode.Tag;
                }
                else
                {
                    return new Models.ItemsMenu();
                }

            }
        }

        private void rbGrupos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGrupos.Checked)
            {
                ConsultarGrupos();
            }
        }

        private void ConsultarGrupos()
        {
            Consultar(GruposItemsMenuRepository.ObtenerGruposPorItemMenu, false, lbSinAsignar);
            Consultar(GruposItemsMenuRepository.ObtenerGruposPorItemMenu, true, lbAsignados);
        }

        private void Consultar<T>(Func<int, bool, List<T>> consulta, bool asignados, ListBox lbAsignados)
        {
            var datos = consulta(ItemMenu.Id, asignados);
            lbAsignados.DataSource = datos;
            lbAsignados.ValueMember = "Id";
            if (typeof(T).Name == "Usuario")
            {
                lbAsignados.DisplayMember = "NombreCompleto";
            }
            else
            {
                lbAsignados.DisplayMember = "Descripcion";
            }
            lblAsignados.Text = "Asignados a " + ItemMenu.Descripcion;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (rbGrupos.Checked == true)
            {
                GruposItemsMenuRepository.Insertar(IdGrupo, ItemMenu.Id);
                ConsultarGrupos();
            }
            else
            {
                UsuariosItemsMenuRepository.Insertar(IdUsuario, ItemMenu.Id);
                ConsultarUsuarios();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (rbGrupos.Checked == true)
            {
                var id = ((Models.Grupos)lbAsignados.SelectedItem).Id;
                GruposItemsMenuRepository.Eliminar(id, ItemMenu.Id);
                ConsultarGrupos();
            }
            if (rbUsuarios.Checked == true)
            {
                var id = ((Models.Usuarios)lbAsignados.SelectedItem).Id;
                UsuariosItemsMenuRepository.Eliminar(id, ItemMenu.Id);
                ConsultarUsuarios();
            }
        }

        private void rbUsuarios_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsuarios.Checked)
            {
                ConsultarUsuarios();
            }
        }

        private void ConsultarUsuarios()
        {
            Consultar(GruposItemsMenuRepository.ObtenerUsuariosPorItemMenu, false, lbSinAsignar);
            Consultar(GruposItemsMenuRepository.ObtenerUsuariosPorItemMenu, true, lbAsignados);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tvItemsMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (rbGrupos.Checked)
            {
                ConsultarGrupos();
            }
            else
            {
                ConsultarUsuarios();
            }
        }
    }
}
