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
using CustomLibrary.Extensions.Controls;
using ERP.Models;

namespace ERP.Forms.Articulos
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
        //    var tds = TiposDocumentoRepository.ObtenerTiposDocumento();
            dgvDatos.SetDataSource(from a in ArticulosRepository.ObtenerArticulos()
                                   orderby a.Id
                                   select new
                                   {
                                       a.Id,
                                       a.Codigo,
                                       a.Descripcion,
                                       a.Stock,
                                       a.StockMinimo,
                                       a.Costo,
                                       a.PrecioL1,
                                       a.PrecioL2,
                                       a.PrecioL3
                                   });
            dgvDatos.Columns[0].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn c in dgvDatos.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            //dgvDatos.Columns[0].HeaderText = "Código";
            //dgvDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvDatos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[1].HeaderText = "Código";
            dgvDatos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[2].HeaderText = "Descripción";
            dgvDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[3].HeaderText = "Stock";
            dgvDatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[4].HeaderText = "Stock Min.";
            dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //dgvDatos.Columns[4].DefaultCellStyle.Format = "N0";

            dgvDatos.Columns[5].HeaderText = "Costo";
            dgvDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //dgvDatos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvDatos.Columns[6].HeaderText = "Lista 1";
            dgvDatos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[7].HeaderText = "Lista 2";
            dgvDatos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[8].HeaderText = "Lista 3";
            dgvDatos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void dgvDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnSalir.PerformClick();
            else if (e.Control && e.KeyCode == Keys.N) btnNuevo.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F4) btnEditar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.Delete) btnEliminar.PerformClick();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var f = new frmEdicion())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var a = ArticulosRepository.Insertar(f.Codigo, f.CodigoBarra, f.Descripcion, f.IdMarca, f.IdRubro,
                                                            f.IdProveedor, f.IdUnidad, f.CostoInicial, f.Descuento1, f.DescuentoPorc1,
                                                            f.Descuento2, f.DescuentoPorc2, f.Descuento3, f.DescuentoPorc3, f.Costo,
                                                            f.Stock, f.StockMinimo, f.Lista1, f.ListaPorc1, f.Lista2,
                                                            f.ListaPorc2, f.Lista3, f.ListaPorc3, f.IVA, f.Observaciones, f.Estado);
                        ConsultarDatos();
                        dgvDatos.SetRow(r => Convert.ToDecimal(r.Cells[0].Value) == a.Id);
                    }
                    catch (Exception ex)
                    {
                        ShowError("Error al intentar grabar los datos: \n" + ex.Message);
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var a = ObtenerArticuloSeleccionado();
            if (MessageBox.Show("¿Está seguro de que desea eliminar el articulo seleccionado?",
                "Eliminar Artículos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    ArticulosRepository.Eliminar(a.Id);
                    ConsultarDatos();
                    dgvDatos.SetRow(r => Convert.ToDecimal(r.Cells[0].Value) == a.Id);
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        private EArticulos ObtenerArticuloSeleccionado()
        {
            try
            {
                int rowindex = dgvDatos.CurrentCell.RowIndex;
                var id = (Int32)dgvDatos.Rows[rowindex].Cells[0].Value;
                var a = ArticulosRepository.ObtenerArticulosPorId(id);
                return a;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            var a = ObtenerArticuloSeleccionado();
            if (a == null)
            {
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                txtCodBarra.Text = "";
                txtMarca.Text = "";
                txtRubro.Text = "";
                txtProveedor.Text = "";
                txtStock.Text = "";
                txtStockMin.Text = "";
                txtCostoInicial.Text = "";
                txtDesc1.Text = "";
                txtDesc2.Text = "";
                txtDesc3.Text = "";
                txtCosto.Text = "";
                txtLista1.Text = "";
                txtLista2.Text = "";
                txtLista3.Text = "";
                txtIVA.Text = "";
                return;
            }
            txtCodigo.Text = a.Codigo;
            txtDescripcion.Text = a.Descripcion;
            txtCodBarra.Text = a.CodBarra;
            txtMarca.Text = MarcasRepository.ObtenerMarcaPorId(Convert.ToInt16(a.IdMarca)).Marca;
            txtRubro.Text = RubrosRepository.ObtenerRubroPorId(Convert.ToInt16(a.IdRubro)).Rubro;
            txtProveedor.Text = ProveedoresRepository.ObtenerProveedorPorId(Convert.ToInt16(a.IdProveedor)).RazonSocial;
            txtStock.Text = Convert.ToString(a.Stock);
            txtStockMin.Text = Convert.ToString(a.StockMinimo);
            txtCostoInicial.Text = "$ " + Convert.ToString(a.CostoInicial);
            txtDesc1.Text = "$ " + Convert.ToString(a.Descuento1) +" ("+ Convert.ToString(a.DescuentoPorc1) + "%)";
            txtDesc2.Text = "$ " + Convert.ToString(a.Descuento2) + " (" + Convert.ToString(a.DescuentoPorc2) + "%)"; ;
            txtDesc3.Text = "$ " + Convert.ToString(a.Descuento3) + " (" + Convert.ToString(a.DescuentoPorc3) + "%)"; ;
            txtCosto.Text = "$ " + Convert.ToString(a.Costo);
            txtLista1.Text = "$ " + Convert.ToString(a.PrecioL1) + " (" + Convert.ToString(a.PrecioPorcL1) + "%)";
            txtLista2.Text = "$ " + Convert.ToString(a.PrecioL2) + " (" + Convert.ToString(a.PrecioPorcL2) + "%)";
            txtLista3.Text = "$ " + Convert.ToString(a.PrecioL3) + " (" + Convert.ToString(a.PrecioPorcL3) + "%)";
            txtIVA.Text = Convert.ToString(a.IVA);
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrar.Text != "")
            {
                dgvDatos.CurrentCell = null;
                foreach (DataGridViewRow r in dgvDatos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvDatos.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtFiltrar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                ConsultarDatos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EArticulos a = ObtenerArticuloSeleccionado();
            using (var f = new frmEdicion(a))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int IdEmpresa = Lib.Configuration.IdEmpresa;
                        ArticulosRepository.Actualizar(a.Id, IdEmpresa, a.Codigo, a.CodBarra, a.Descripcion,
                            a.IdMarca, a.IdRubro, a.IdProveedor, a.IdUnidad, a.CostoInicial,
                            a.Descuento1, a.DescuentoPorc1, a.Descuento2, a.DescuentoPorc2, a.Descuento3,
                            a.DescuentoPorc3, a.Costo, a.Stock, a.StockMinimo, a.PrecioL1,
                            a.PrecioPorcL1, a.PrecioL2, a.PrecioPorcL2, a.PrecioL3, a.PrecioPorcL3,
                            a.IVA, a.Observaciones, a.Estado);
                        ConsultarDatos();
                        dgvDatos.SetRow(r => Convert.ToDecimal(r.Cells[0].Value) == a.Id);
                    }
                    catch (Exception ex)
                    {
                        ShowError("Error al intentar grabar los datos: \n" + ex.Message);
                    }
                }
            }
        }
    }
}
