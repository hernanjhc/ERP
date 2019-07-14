using ERP.Lib;
using ERP.Lib.Validations;
using ERP.Repositories;
using System;
using System.Windows.Forms;
using CustomLibrary.Lib.Extensions;
using ERP.Lib.AppForms;

namespace ERP.Forms
{
    public partial class frmCambiarContraseña : FormBase
    {
        public frmCambiarContraseña()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            txtAnterior.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (this.ValidarDatos())
            {
                try
                {
                    UsuariosRepository.ReiniciarContraseña(Session.CurrentUser.Id, txtNueva.Text);
                    MessageBox.Show("Se cambió correctamente su contraseña.", "Cambiar Contraseña",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cambiar contraseña", MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDatos()
        {
            bool result =   
                        ValidarVaciosyEspacios()    &&
                        ValidarContraseñaRepetida();
            return result;
        }

        private bool ValidarContraseñaRepetida()
        {
            bool result = true;
            if (txtNueva.Text != txtRepetir.Text)
            {
                MessageBox.Show("Debe reingresar la nueva contraseña.", "SGO -Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            else
            {
                errorProvider1.SetError(txtRepetir, "");
            }
            return result;
        }

        private bool ValidarVaciosyEspacios()
        {
            bool result = true;
            if (String.IsNullOrWhiteSpace(txtAnterior.Text) &&
                String.IsNullOrWhiteSpace(txtNueva.Text) &&
                String.IsNullOrWhiteSpace(txtRepetir.Text))
            {
                MessageBox.Show("No puede estar vacío", "SGO-Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
           return result;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (this.ValidarDatos())
            {
                try
                {
                    UsuariosRepository.ReiniciarContraseña(Session.CurrentUser.Id, txtNueva.Text);
                    MessageBox.Show("Se cambió correctamente su contraseña.", "Cambiar Contraseña",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cambiar contraseña", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
