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

namespace ERP.Forms.Marcas
{
    public partial class frmEdición : FormBase
    {
        public frmEdición()
        {
            InitializeComponent();

            this.Text = "Nueva Marca";
        }

        public frmEdición(Models.EMarcas marca) : this()
        {
            this.Text = "Edición de la Marca";

            txtMarca.Text = marca.Marca;
            txtObservaciones.Text = marca.Observaciones;
        }

        public string Marca
        {
            get
            {
                return txtMarca.Text.Trim();
            }
        }

        public string Observaciones
        {
            get
            {
                return txtObservaciones.Text.Trim();
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (this.ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            return
            true;
            //_validator.ValidarMaterial(!String.IsNullOrEmpty(Unidad), "No puede estar vacío");
        }
    }
}
