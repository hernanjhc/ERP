using ERP.Lib;
using ERP.Lib.Validations;
using ERP.Repositories;
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
    
    public partial class frmLoginM : MaterialSkin.Controls.MaterialForm
    {
        private FormValidations _validator;

        public frmLoginM()
        {
            InitializeComponent();
            _validator = new FormValidations(this, errorProvider1);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var repo = new UsuariosRepository();
            if (_validator.Validar(txtUsuario2, repo.VerificarLoginUsuario(txtUsuario2.Text, txtContraseña2.Text),
                "El usuario o la contraseña son incorrectos"))
            {
                Session.CurrentUser = repo.ObtenerUsuario(txtUsuario2.Text);
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
    }
}
