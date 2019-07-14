using CustomLibrary.Lib.Extensions;
using ERP.Lib.AppForms;
using ERP.Models;
using System;
using System.Windows.Forms;

namespace ERP.Forms.Usuarios
{
    public partial class frmEdición : FormBase
    {
        public frmEdición()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            txtNombre.Select();
        }

        public frmEdición(Models.Usuarios usuario)
            : this()
        {
            if (usuario == null)
            {
                this.Text = "Nuevo usuario";
                ckEstado.Checked = true;
            }
            else
            {
                this.Text = "Edición de usuario";
                txtNombre.Text = usuario.Nombre;
                txtNombreCompleto.Text = usuario.NombreCompleto;
                ckEstado.Checked = usuario.Estado == 1;
            }
        }

        

        private bool ValidarDatos()
        {
            bool result = true;
            result = ValidarVaciosyEspacios();
            return result;
        }

        private bool ValidarVaciosyEspacios()
        {
            bool result = true;
            if (String.IsNullOrWhiteSpace(txtNombre.Text) &&
                String.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                MessageBox.Show("No puede estar vacío", "SGO-Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            return result;
        }

        public string Nombre
        {
            get
            {
                return txtNombre.Text.Trim();
            }
        }

        public string NombreCompleto
        {
            get
            {
                return txtNombreCompleto.Text.Trim();
            }
        }

        public byte Estado
        {
            get
            {
                return (byte)(ckEstado.Checked ? 1 : 0);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (this.ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
