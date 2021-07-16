using CustomLibrary.Extensions.Controls;
using ERP.Lib.AppForms;
using ERP.Models;
using ERP.Repositories;
using FileHelpers;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ERP.Forms.Articulos
{
    public partial class frmImportarTxt : FormBase
    {
        public frmImportarTxt()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, System.EventArgs e)
        {
            Exportar();

        }

        private static void Exportar()
        {
            var engine = new FileHelperAsyncEngine<EArticulosImport>();
            var productos = EArticulosRepository.ObtenerArticulosParaExportar();
            var destino = VerificarDestino();
            using (engine.BeginWriteFile(destino))
            {
                foreach (EArticulosImport cust in productos)
                {
                    engine.WriteNext(cust);
                }
            }
        }

        private static string VerificarDestino()
        {
            var destino = String.Format(@"C:/Temp/Productos {0:dd-MM-yyyy}.txt", DateTime.Now);
            if (!Directory.Exists("C:/Temp/"))
            {
                System.IO.Directory.CreateDirectory("C:/Temp/");
            }
            return destino;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            ProcesarTxt();
        }

        private void ProcesarTxt()
        {
            var engine = new FileHelperEngine<EArticulosImport>();
            // Switch error mode on
            engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;

            var productosLeídos = engine.ReadFile(@"C:/Temp/AltaProductos.txt");

            if (engine.ErrorManager.HasErrors)
                engine.ErrorManager.SaveErrors(@"C:/Temp/erroresLectura.txt");

            foreach (var item in productosLeídos)
            {
                if (item.Id == 0)   //Alta
                {
                    EArticulosRepository.ProcesarAltaProducto(item);
                }
                if (item.Id > 0)   //Modificación
                {
                    EArticulosRepository.ProcesarModificacionProducto(item);
                }
            }
            dgvArticulos.Rows.Clear();
            var q = from fila in productosLeídos
                    select new
                    {
                        Id = fila.Id,
                        CodBarra = fila.CodBarra,
                        Descripcion = fila.Descripcion,
                        Costo = fila.Costo,
                        PrecioL1 = fila.PrecioL1,
                        PrecioL2 = fila.PrecioL2,
                        PrecioL3 = fila.PrecioL3,
                        LecturaArchivo = fila.LecturaArchivo,
                        MensajeLecturaArchivo = fila.MensajeLecturaArchivo
                    };
            if (q.Any())
            {
                dgvArticulos.SetDataSource(q);
                lblFilasLeidas.Text = string.Format("{0} Filas leídas.", q.Count());
                lblAltasCorrectas.Text = string.Format("{0} Altas Correctas.", q.Where(a => a.Id==0 && a.LecturaArchivo == 3).Count());
                lblAltasIncorrectas.Text = string.Format("{0} Altas Incorrectas.", q.Where(a => a.Id==0 && a.LecturaArchivo == 2).Count());
                lblModificacionesCorrectas.Text = string.Format("{0} Modificaciones Correctas.", q.Where(a => a.Id > 0 && a.LecturaArchivo == 3).Count());
                lblModificacionesIncorrectas.Text = string.Format("{0} Modificaciones Incorrectas.", q.Where(a => a.Id > 0 && a.LecturaArchivo == 2).Count());
            }

        }

        private static void ImportarTxt()
        {
            int registradosEnBD = 0;

            var engine = new FileHelperEngine<EArticulosImport>();
            var productosLeídos = engine.ReadFile(@"C:/Temp/AltaProductos.txt");
            foreach (var item in productosLeídos)
            {
                if (EArticulosRepository.GuardarProductoLeidoPorTxt(item)) registradosEnBD++;
            }
        }

        private void dgvArticulos_RowPrePaint(object sender, System.Windows.Forms.DataGridViewRowPrePaintEventArgs e)
        {
            var estado = (short)dgvArticulos.Rows[e.RowIndex].Cells[7].Value;
            if (estado == 0)    //Alta
            {
                dgvArticulos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
            }
            if (estado == 1)    //Modificacion
            {
                dgvArticulos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Yellow;
            }
            if (estado == 2)    //Error
            {
                dgvArticulos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void dgvArticulos_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn item in dgvArticulos.Columns)
            {
                item.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvArticulos.Columns[0].HeaderText = "Id";
            dgvArticulos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvArticulos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //autoajusta

            dgvArticulos.Columns[1].HeaderText = "Cód. Barra";
            dgvArticulos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvArticulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; 

            dgvArticulos.Columns[2].HeaderText = "Descripción";
            dgvArticulos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvArticulos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells; 

            dgvArticulos.Columns[3].HeaderText = "Costo";
            dgvArticulos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvArticulos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //autoajusta

            dgvArticulos.Columns[4].HeaderText = "Precio L1";
            dgvArticulos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvArticulos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //autoajusta

            dgvArticulos.Columns[5].HeaderText = "Precio L2";
            dgvArticulos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvArticulos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //autoajusta

            dgvArticulos.Columns[6].HeaderText = "Precio L3";
            dgvArticulos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvArticulos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; //autoajusta

            dgvArticulos.Columns[7].Visible = false;

            dgvArticulos.Columns[8].HeaderText = "Observación";
            dgvArticulos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvArticulos.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
    }
}
