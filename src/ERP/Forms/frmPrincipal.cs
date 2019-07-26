using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using ERP.Forms.Grupos;
using ERP.Models;
using ERP.Repositories;
using MaterialSkin;
using ERP.Lib.AppForms;
using System.Linq;
using ERP.Forms.Grupos;

namespace ERP.Forms
{
    public partial class frmPrincipal : FormBase
    {
        IList<string> _menuItems;
        IList<Models.ItemsMenu> _permisos;

        public frmPrincipal()
        {
            InitializeComponent();
            
            _menuItems = new List<string>();
            RecorrerMenu(this.menuStrip1.Items, null);
            ItemsMenuRepository.EliminarItemsInexistentes(_menuItems);
            //Icon = Properties.Resources.app2;
        }

        internal bool Inicializar()
        {
            if (new frmLoginM().ShowDialog() == DialogResult.OK)
            {
                int idUsuario = Lib.Session.CurrentUser.Id;
                CargarPermisosUsuarioActual(idUsuario);
                CargarPermisosGruposDeUsuarioActual(idUsuario);
                ArmarMenu(menuStrip1.Items);
                archivoToolStripMenuItem.Enabled = true;
                archivoToolStripMenuItem.Visible = true;
                salirToolStripMenuItem.Enabled = true;
                salirToolStripMenuItem.Visible = true;
                return true;
            }
            return false;
        }

        private void ArmarMenu(ToolStripItemCollection items)
        {
            foreach (var i in items)
            {
                if (i is ToolStripMenuItem)
                {
                    var m = (ToolStripMenuItem)i;
                    m.Enabled = _permisos.Any(p => p.Nombre == m.Name);
                    m.Visible = m.Enabled;
                    ArmarMenu(m.DropDownItems);
                }
            }
        }

        private void CargarPermisosGruposDeUsuarioActual(int idUsuario)
        {
            List<Models.Grupos> grupos = new List<Models.Grupos>();
            grupos = GruposUsuariosRepository.ObtenerGruposPorIdUsuario(idUsuario);

            if (grupos == null) return;

            foreach (var item in grupos)
            {
                List<Models.ItemsMenu> itemsMenu = new List<Models.ItemsMenu>();
                itemsMenu = (List<Models.ItemsMenu>)GruposItemsMenuRepository.ObtenerItemsMenuPorIdGrupo(item.Id);

                foreach (var i in itemsMenu)
                {
                    if (!_permisos.Contains(i))
                    {
                        _permisos.Add(i);
                    }
                }

            }
        }

        private void CargarPermisosUsuarioActual(int idUsuario)
        {
            _permisos = ItemsMenuRepository.ObtenerItemsMenu(idUsuario);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Usuarios.frmListado()) f.ShowDialog();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new frmCambiarContraseña()) f.ShowDialog();
        }

        private void gruposDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new frmListado()) f.ShowDialog();
        }

        private void RecorrerMenu(ToolStripItemCollection items, string nombrePadre)
        {
            foreach (var m in items)
            {
                if (m is ToolStripMenuItem)
                {
                    var m1 = (ToolStripMenuItem)m;
                    _menuItems.Add(m1.Name);
                    ItemsMenuRepository.Actualizar(m1.Name, m1.Text, nombrePadre);
                    this.RecorrerMenu(m1.DropDownItems, m1.Name);
                }
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Clientes.frmListado()) f.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Unidades.frmListado()) f.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Proveedores.frmListado()) f.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Marcas.frmListado()) f.ShowDialog();
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Rubros.frmListado()) f.ShowDialog();
        }

        private void asignarPermisosAGruposYUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new ItemsMenu.frmAsignarUsuariosyGruposAMenuItems()) f.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Departamentos.frmListado()) f.ShowDialog();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Localidades.frmListado()) f.ShowDialog();
        }

        private void asignarUsuariosAGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Usuarios.frmAsignarUsuariosAGrupos()) f.ShowDialog();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var f = new Articulos.frmListado()) f.ShowDialog();
        }

        private void presupuestosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var f = new Presupuestos.frmListado()) f.ShowDialog();
        }

        private void remitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Remitos.frmListado()) f.ShowDialog();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var f = new Ventas.frmListado()) f.ShowDialog();
        }

        private void chequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new Cheques.frmListado()) f.ShowDialog();
        }
    }
}
