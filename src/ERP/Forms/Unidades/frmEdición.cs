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

namespace ERP.Forms.Unidades
{
    public partial class frmEdición : FormBase
    {
        public frmEdición()
        {
            InitializeComponent();

            this.Text = "Nueva Unidad";
            ckEstado.Checked = true;
        }

        public frmEdición(Models.Unidades unidad) : this()
        {
            this.Text = "Edición de la Unidad";

            txtUnidad.Text = unidad.Unidad;
            txtObservaciones.Text = unidad.Observaciones;
            ckEstado.Checked = unidad.Estado == 1;
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string Unidad
        {
            get
            {
                return txtUnidad.Text.Trim();
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
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
