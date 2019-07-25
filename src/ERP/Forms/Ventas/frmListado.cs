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

namespace ERP.Forms.Ventas
{
    public partial class frmListado : FormBase
    {
        public frmListado()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var f = new Ventas.frmEdicion1()) f.ShowDialog();
        }
    }
}
