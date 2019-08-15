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
            using (var f = new frmEdicion())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var venta = VentasRepository.Insertar(f.IdCliente, f.Fecha, f.ImporteB, f.Descuento,
                                                            f.DescPorc, f.ImporteTotal, f.PrecioLista, f.IdUsuario, f.Estado);


                        for (int i = 0; i <= Convert.ToInt32(f.dgvDetalles.Rows.Count - 1); i++)
                        {
                            VentasDetallesRepository.Insertar(venta.Id, Convert.ToInt32(f.dgvDetalles.Rows[i].Cells[0].Value),
                                    Convert.ToInt16(f.dgvDetalles.Rows[i].Cells[3].Value), Convert.ToDecimal(f.dgvDetalles.Rows[i].Cells[4].Value),
                                    Convert.ToDecimal(f.dgvDetalles.Rows[i].Cells[5].Value));

                        }
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

            cargarDetalles(p.Id);
        }

        private void cargarDetalles(int idVenta)
        {
            dgvDetalles.SetDataSource(
                    from d in VentasDetallesRepository.ObtenerDetallesDeVenta(idVenta)
                    select new
                    {
                        ArticulosRepository.ObtenerArticulosPorId(
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
                DateTime hasta = Convert.ToDateTime(dtpHasta.Text);
                dgvDatos.SetDataSource(
                    from p in VentasRepository.ObtenerVentas()
                    .Where(p => p.Fecha >= desde && p.Fecha <= hasta)
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
    }
}
