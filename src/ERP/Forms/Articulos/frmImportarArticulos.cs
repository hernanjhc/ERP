using ERP.Lib.AppForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Forms.Articulos
{
    public partial class frmImportarArticulos : FormBase
    {
        public frmImportarArticulos()
        {
            InitializeComponent();
            this.Text = "Importar artículos";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.Text = openFileDialog1.FileName;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Archivo))
            {
                MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //var rendición = RendicionBSERepository.CargarRendición(Archivo);

            //_pagos = from p in PagosBSERepository.ObtenerPagosRelacionados(rendición) orderby p.Id select p;
            //foreach (var p in _pagos)
            //{
            //    p.Válido = p.ImportePagado == p.ImporteAPagar && p.DetallePago != null;
            //}

            ////cómo es el código de barras de un pago de varias cuotas?
            //var query = from p in _pagos
            //            select new
            //            {
            //                p.Válido,
            //                p.Id,
            //                p.Comprobante,
            //                p.Documento,
            //                p.Alumno,
            //                p.Carrera,
            //                p.Curso,
            //                p.FechaVto,
            //                p.FechaPago,
            //                ImporteAPagar = p.ImporteAPagar,
            //                p.ImportePagado,
            //                p.CodigoBarra
            //            };
            //dgvDatos.SetDataSource(query);
            //toolStripStatusLabel1.Text = String.Format("Se han leído {0} filas", query.Count());
            //btnGrabar.Enabled = query.Any(t => t.Válido);

        }

        public string Archivo
        {
            get
            {
                return txtArchivo.Text.Trim();
            }
        }
    }
}
