using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Forms.Presupuestos
{
    public partial class frmListado : Lib.AppForms.FormBase
    {
        public frmListado()
        {
            InitializeComponent();
        }

             
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            using (var f = new Presupuestos.frmEdicion()) f.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }

      
    }
}
