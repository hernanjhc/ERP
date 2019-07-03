﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ERP.Forms.Grupos;
using ERP.Models;
using ERP.Repositories;

namespace ERP.Forms
{
    public partial class frmPrincipal : Form
    {
        IList<string> _menuItems;
        IList<ItemsMenu> _permisos;

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
                //CargarPermisosUsuarioActual(idUsuario);
                //CargarPermisosGruposDeUsuarioActual(idUsuario);
                //ArmarMenu(menuStrip1.Items);
                //archivoToolStripMenuItem.Enabled = true;
                //archivoToolStripMenuItem.Visible = true;
                //salirToolStripMenuItem.Enabled = true;
                //salirToolStripMenuItem.Visible = true;
                return true;
            }
            return false;
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
    }
}