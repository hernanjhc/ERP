using ERP.Lib;
using ERP.Lib.AppForms;
using ERP.Models;
using ERP.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ERP.Forms.Compras
{
    public partial class frmListado : FormBase
    {
        public frmListado()
        {
            InitializeComponent();
            dtpHasta.Text = Configuration.CurrentDate.ToString();
            dtpDesde.Text = Configuration.CurrentDate.AddDays(-30).ToString();
            ConsultarDatos();
        }

        private void ConsultarDatos()
        {
            dgvDatos.SetDataSource(
                from p in EComprasRepository.ObtenerCompras()
                orderby p.Id
                select new
                {
                    p.Id,
                    p.Fecha,
                    Proveedor = ProveedoresRepository.ObtenerProveedorPorId(Convert.ToDecimal(p.IdProveedor)).RazonSocial,
                    Usuario = UsuariosRepository.ObtenerUsuarioPorId(Convert.ToDecimal(p.IdUsuario)).NombreCompleto
                }
            );
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDatos_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn c in dgvDatos.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvDatos.Columns[0].HeaderText = "Compra";
            dgvDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[1].HeaderText = "Fecha";
            dgvDatos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[2].HeaderText = "Proveedor";
            dgvDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[3].HeaderText = "Usuario";
            dgvDatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private ECompras ObtenerCompraSeleccionada()
        {
            try
            {
                int rowindex = dgvDatos.CurrentCell.RowIndex;
                var id = (Int32)dgvDatos.Rows[rowindex].Cells[0].Value;
                var p = EComprasRepository.ObtenerCompraPorId(id);
                return p;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarDatosEntreFechas();
        }

        private void ConsultarDatosEntreFechas()
        {
            if (chbFiltrarFecha.Checked == true)
            {
                DateTime desde = Convert.ToDateTime(dtpDesde.Text);
                DateTime h = Convert.ToDateTime(dtpHasta.Text);
                DateTime hasta = h.AddDays(1);
                dgvDatos.SetDataSource(
                    from p in EComprasRepository.ObtenerCompras()
                    .Where(p => p.Fecha >= desde && p.Fecha < hasta)
                    orderby p.Id
                    select new
                    {
                        p.Id,
                        p.Fecha,
                        Proveedor = ProveedoresRepository.ObtenerProveedorPorId(Convert.ToDecimal(p.IdProveedor)).RazonSocial,
                        Usuario = UsuariosRepository.ObtenerUsuarioPorId(Convert.ToDecimal(p.IdUsuario)).NombreCompleto
                    }
                );
            }
            else
            {
                ConsultarDatos();
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            var p = ObtenerCompraSeleccionada();
            if (p == null)
            {
                limpiarTxt();
                return;
            }
            limpiarTxt();
            //var cliente = ClientesRepository.ObtenerClientePorId(Convert.ToDecimal(p.IdCliente));
            var proveedor = ProveedoresRepository.ObtenerProveedorPorId(Convert.ToDecimal(p.IdProveedor));

            txtCompraNro.Text = p.Id.ToString().Trim();
            txtProveedor.Text = proveedor.RazonSocial;
            txtNroDoc.Text = proveedor.NroDocumento.ToString();
            txtDireccion.Text = proveedor.Direccion;
            txtTotal.Text = p.Importe.ToString().Trim();
            txtRetirado.Text = p.Retirado == 1 ? "Si" : "No";
            txtPagado.Text = p.Pagado == 1 ? "Si" : "No";

            cargarDetalles(p.Id);
        }

        private void cargarDetalles(int idCompra)
        {
            dgvDetalles.SetDataSource(
                    from d in EComprasDetallesRepository.ObtenerDetallesDeCompra(idCompra)
                    select new
                    {
                        EArticulosRepository.ObtenerArticulosPorId(
                            Convert.ToDecimal(d.IdArticulo)).Descripcion,
                        d.Precio,
                        d.Cantidad,
                        d.Importe
                    }
                );
        }
        private void limpiarTxt()
        {
            dgvDetalles.Rows.Clear();
            txtCompraNro.Text = "";
            txtProveedor.Text = "";
            txtDireccion.Text = "";
            txtRetirado.Text = "";
            txtPagado.Text = "";
            txtNroDoc.Text = "";
            txtTotal.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaCompra();
        }

        private void NuevaCompra()
        {
            using (var f = new frmEdicion())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var compra = EComprasRepository.Insertar(f.IdProveedor, f.Fecha, f.ImporteTotal, f.Retirado, f.Pagado, f.IdUsuario);

                        for (int i = 0; i <= Convert.ToInt32(f.dgvDetalles.Rows.Count - 1); i++)
                        {
                            EComprasDetallesRepository.Insertar(compra.Id, Convert.ToInt32(f.dgvDetalles.Rows[i].Cells[0].Value),
                                    Convert.ToInt16(f.dgvDetalles.Rows[i].Cells[3].Value), Convert.ToDecimal(f.dgvDetalles.Rows[i].Cells[4].Value),
                                    Convert.ToDecimal(f.dgvDetalles.Rows[i].Cells[5].Value));

                        }
                        //if (Configuration.ImprimeVentas) ImprimirVenta(f, venta.Id);
                        if (Configuration.CompraIncrementaStock)
                        {
                            for (int i = 0; i <= Convert.ToInt32(f.dgvDetalles.Rows.Count - 1); i++)
                            {
                                EArticulosRepository.IncrementarStockArticulo(Convert.ToInt32(f.dgvDetalles.Rows[i].Cells[0].Value),
                                        Convert.ToInt16(f.dgvDetalles.Rows[i].Cells[3].Value));
                            }
                        }

                        if (f.Pagado == 1)
                        {
                            MovimientosRepository.InsertarCompra(compra);
                        }

                        ConsultarDatos();
                        dgvDatos.SetRow(r => Convert.ToDecimal(r.Cells[0].Value) == compra.Id);
                    }
                    catch (Exception ex)
                    {
                        ShowError("Error al intentar grabar los datos: \n" + ex.Message);
                    }
                }
            }
        }

        private void dgvDetalles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn c in dgvDetalles.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvDetalles.Columns[0].HeaderText = "Descripcion";
            dgvDetalles.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDetalles.Columns[1].HeaderText = "Precio";
            dgvDetalles.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //dgvDetalles.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvDetalles.Columns[2].HeaderText = "Cantidad";
            dgvDetalles.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDetalles.Columns[3].HeaderText = "Importe";
            dgvDetalles.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
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
    }
}
