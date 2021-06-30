using ERP.Lib;
using ERP.Lib.Validations;
using ERP.Repositories;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Forms
{
    
    public partial class frmLoginM : Lib.AppForms.FormBase  // : MaterialSkin.Controls.MaterialForm
    {
        public frmLoginM()
        {
            InitializeComponent();

            _validator = new FormValidations(this, errorProvider1);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var repo = new UsuariosRepository();
            if (_validator.ValidarMaterial(repo.VerificarLoginUsuario(mtxtUsuario.Text, mtxtContraseña.Text),
                "El usuario o la contraseña son incorrectos"))
            {
                Session.CurrentUser = repo.ObtenerUsuario(mtxtUsuario.Text);
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.None;
        }

        private void btnAceptar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void mtxtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnAceptar.PerformClick();
        }

        private void mtxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Login();
            }
        }
    }
}
