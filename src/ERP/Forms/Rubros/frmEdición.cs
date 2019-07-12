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

namespace ERP.Forms.Rubros
{
    public partial class frmEdición : FormBase
    {
        public frmEdición()
        {
            InitializeComponent();

            this.Text = "Nuevo Rubro";
            ckEstado.Checked = true;
        }

        public frmEdición(Models.ERubros rubro) : this()
        {
            this.Text = "Edición del Rubro";

            txtRubro.Text = rubro.Rubro;
            txtObservaciones.Text = rubro.Observaciones;
            ckEstado.Checked = rubro.Estado == 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string Rubro
        {
            get
            {
                return txtRubro.Text.Trim();
            }
        }

        public string Observaciones
        {
            get
            {
                return txtObservaciones.Text.Trim();
            }
        }

        public byte Estado
        {
            get
            {
                return (byte)(ckEstado.Checked ? 1 : 0);
            }
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
            //_validator.ValidarMaterial(!String.IsNullOrEmpty(Rubro), "No puede estar vacío");
        }
    }
}
