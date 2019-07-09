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
using ERP.Repositories;

namespace ERP.Forms.Unidades
{
    public partial class frmListado : FormBase
    {
        public frmListado()
        {
            InitializeComponent();
            ConsultarDatos();
        }

        private void ConsultarDatos()
        {
            dgvDatos.SetDataSource(from u in UnidadesRepository.ObtenerUsuarios()
                                   select new
                                   {
                                       u.Id,
                                       u.Unidad,
                                       u.Observaciones,
                                       u.Estado
                                   });
            dgvDatos.Columns[0].Visible = false;
        }
    }
    }
}
