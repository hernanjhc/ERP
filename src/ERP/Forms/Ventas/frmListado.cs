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
using ERP.Models;
using ERP.Lib;
using ERP.Reports.Designs;

namespace ERP.Forms.Ventas
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
                from p in VentasRepository.ObtenerVentas()                
                orderby p.Id
                select new
                {
                    p.Id,
                    p.Fecha,                    
                    Cliente = ClientesRepository.ObtenerClientePorId(Convert.ToDecimal(p.IdCliente)).RazonSocial,
                    Usuario = UsuariosRepository.ObtenerUsuarioPorId(Convert.ToDecimal(p.IdUsuario)).NombreCompleto
                }
            );            //dgvDatos.Columns[0].Visible = false;   
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaVenta();
        }

        private void NuevaVenta()
        {
            using (var f = new frmEdicion())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var venta = VentasRepository.Insertar(f.IdCliente, f.Fecha, f.Subtotal, f.Descuento,
                                                            f.DescPorc, f.ImporteTotal, f.PrecioLista, f.IdUsuario, f.Estado);


                        for (int i = 0; i <= Convert.ToInt32(f.dgvDetalles.Rows.Count - 1); i++)
                        {
                            VentasDetallesRepository.Insertar(venta.Id, Convert.ToInt32(f.dgvDetalles.Rows[i].Cells[0].Value),
                                    Convert.ToInt16(f.dgvDetalles.Rows[i].Cells[3].Value), Convert.ToDecimal(f.dgvDetalles.Rows[i].Cells[4].Value),
                                    Convert.ToDecimal(f.dgvDetalles.Rows[i].Cells[5].Value));

                        }
                        if (Configuration.ImprimeVentas)    ImprimirVenta(f, venta.Id);
                        if (Configuration.VentaDescuentaStock)
                        {
                            for (int i = 0; i <= Convert.ToInt32(f.dgvDetalles.Rows.Count - 1); i++)
                            {
                                EArticulosRepository.ActualizarStockArticulo(Convert.ToInt32(f.dgvDetalles.Rows[i].Cells[0].Value),
                                        Convert.ToInt16(f.dgvDetalles.Rows[i].Cells[3].Value));
                            }
                        }
                        

                        MovimientosRepository.InsertarVenta(venta);

                        ConsultarDatos();
                        dgvDatos.SetRow(r => Convert.ToDecimal(r.Cells[0].Value) == venta.Id);
                    }
                    catch (Exception ex)
                    {
                        ShowError("Error al intentar grabar los datos: \n" + ex.Message);
                    }
                }
            }
        }

        private void ImprimirVenta(frmEdicion f, object idVenta)
        {
            using (var dt = f.ObtenerDetalles())
            {
                if (dt.Rows.Count > 0)
                {
                    string dirección = f.DireccionCliente;
                    string razónSocial = f.RazónSocialCliente;
                    string documento = f.Documento.ToString();
                    string tipoDocumento = f.TipoDocumento.ToString();
                    string comprobante = "Venta";
                    string número = idVenta.ToString();
                    string fecha = f.Fecha.Date.ToString("dd/MM/yyyy");
                    string subTotal = f.Subtotal.ToString();
                    string descuento = f.Descuento.ToString();
                    string total = f.ImporteTotal.ToString();
                    //string validez = f.DiasValidez.ToString();
                    //MostrarReporte(dt, dirección, razónSocial, documento,
                    //    tipoDocumento, comprobante, número, fecha,
                    //    subTotal, descuento, total, validez);
                    MostrarReporte(dt, dirección, razónSocial, documento,
                        tipoDocumento, comprobante, número, fecha,
                        subTotal, descuento, total);
                }
                else
                {
                    ShowError("No pudo imprimir el documento.");
                }
            }
        }

        //private void MostrarReporte(DataTable detalles, string dirección, string razónSocial, string documento,
        //        string tipoDocumento, string comprobante, string número, string fecha,
        //        string subtotal, string descuento, string total, string validez)
        private void MostrarReporte(DataTable detalles, string dirección, string razónSocial, string documento,
                string tipoDocumento, string comprobante, string número, string fecha,
                string subtotal, string descuento, string total)
        {
            using (var reporte = new Presupuesto())
            {
                reporte.Database.Tables["Detalles"].SetDataSource(detalles);
                using (
                    //var f = new frmReporte(reporte, dirección, razónSocial, documento,
                    //                        tipoDocumento, comprobante, número, fecha,
                    //                        subtotal, descuento, total, validez)) f.ShowDialog();
                    var f = new frmReporte(reporte, dirección, razónSocial, documento,
                                            tipoDocumento, comprobante, número, fecha,
                                            subtotal, descuento, total,"")) f.ShowDialog();
            }
        }

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn c in dgvDatos.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvDatos.Columns[0].HeaderText = "Venta";
            dgvDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[1].HeaderText = "Fecha";
            dgvDatos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            
            dgvDatos.Columns[2].HeaderText = "Cliente";
            dgvDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[3].HeaderText = "Vendedor";
            dgvDatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private EVentas ObtenerVentaSeleccionada()
        {
            try
            {
                int rowindex = dgvDatos.CurrentCell.RowIndex;
                var id = (Int32)dgvDatos.Rows[rowindex].Cells[0].Value;
                var p = VentasRepository.ObtenerVentaPorId(id);
                return p;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            var p = ObtenerVentaSeleccionada();
            if (p == null)
            {
                limpiarTxt();
                return;
            }
            limpiarTxt();
            var cliente = ClientesRepository.ObtenerClientePorId(Convert.ToDecimal(p.IdCliente));

            txtVentaNro.Text = p.Id.ToString().Trim();            
            txtCliente.Text = cliente.RazonSocial;
            txtNroDoc.Text = cliente.NroDocumento.ToString();
            txtDescuentoPesos.Text = p.Descuento.ToString().Trim() + " (" + p.DescuentoPorc.ToString().Trim() + "%)";
            txtDireccion.Text = cliente.Direccion;
            txtSubTotal.Text = p.Importe.ToString().Trim();
            txtTotal.Text = p.ImporteTotal.ToString().Trim();
            txtEstado.Text = cargarEstado(p.Estado);

            cargarDetalles(p.Id);
        }

        private string cargarEstado(int? estado)
        {
            string valor = "";
            if (estado == 1) valor = "Activo";
            if (estado == 2) valor = "Anulado";
            return valor;
        }

        private void cargarDetalles(int idVenta)
        {
            dgvDetalles.SetDataSource(
                    from d in VentasDetallesRepository.ObtenerDetallesDeVenta(idVenta)
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
            txtVentaNro.Text = "";            
            txtCliente.Text = "";
            txtDescuentoPesos.Text = "";
            txtDireccion.Text = "";
            txtNroDoc.Text = "";
            txtSubTotal.Text = "";
            txtTotal.Text = "";
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
                    from p in VentasRepository.ObtenerVentas()
                    .Where(p => p.Fecha >= desde && p.Fecha < hasta)
                    orderby p.Id
                    select new
                    {
                        p.Id,
                        p.Fecha,                        
                        Cliente = ClientesRepository.ObtenerClientePorId(Convert.ToDecimal(p.IdCliente)).RazonSocial,
                        Usuario = UsuariosRepository.ObtenerUsuarioPorId(Convert.ToDecimal(p.IdUsuario)).NombreCompleto
                    }
                );
            }
            else
            {
                ConsultarDatos();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            AnularRemito();
        }

        private void AnularRemito()
        {
            var p = ObtenerVentaSeleccionada();
            if (p == null) return;

            if (MessageBox.Show("¿Está seguro de que desea anular la venta seleccionada?",
                "Anular Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                VentasRepository.Anular(p.Id);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ReImprimir();
        }

        private void ReImprimir()
        {
            var p = ObtenerVentaSeleccionada();
            if (p == null) return;

            if (MessageBox.Show("¿Está seguro de que desea ReImprimir la venta seleccionada?",
                "Imprimir Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                ImprimirVenta(p);
            }
        }

        private void ImprimirVenta(EVentas p)
        {
            var cliente = ClientesRepository.ObtenerClientePorId(Convert.ToDecimal(p.IdCliente));
            string dirección = cliente.Direccion;
            string razónSocial = cliente.RazonSocial;
            string documento = cliente.NroDocumento.ToString();
            string tipoDocumento = TiposDocumentoRepository.TiposDocumentoPorId(cliente.IdTipoDocumento).Descripcion;
            string comprobante = "Venta";
            string número = p.Id.ToString();
            string fecha = String.Format("{0: dd/MM/yyyy}", p.Fecha);
            string subTotal = p.Importe.ToString();
            string descuento = p.Descuento.ToString();
            string total = p.ImporteTotal.ToString();
            //string validez = p.DiasValidez.ToString();
            DataTable dt = VentasDetallesRepository.CargarDetalles(p.Id);

            //MostrarReporte(dt, dirección, razónSocial, documento,
            //    tipoDocumento, comprobante, número, fecha,
            //    subTotal, descuento, total, validez);
            MostrarReporte(dt, dirección, razónSocial, documento,
                tipoDocumento, comprobante, número, fecha,
                subTotal, descuento, total);
        }
    }
}
