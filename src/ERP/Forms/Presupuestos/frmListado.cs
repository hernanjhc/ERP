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

namespace ERP.Forms.Presupuestos
{
    public partial class frmListado : Lib.AppForms.FormBase
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
                    from p in PresupuestosRepository.ObtenerPresupuestos()
                    /*Controla presupuestos con fecha de validez*/
                    .Where(x => 
                    //fecha de presupuesto + días validez >= día actual
                        x.Fecha.Value.AddDays(Convert.ToInt16(x.DiasValidez)) >= Configuration.CurrentDate
                    )
                    orderby p.Id
                    select new
                    {
                        p.Id,
                        p.Fecha,
                        DiasValidez = p.DiasValidez + " días.",
                        Cliente= ClientesRepository.ObtenerClientePorId(Convert.ToDecimal(p.IdCliente)).RazonSocial,
                        Usuario = UsuariosRepository.ObtenerUsuarioPorId(Convert.ToDecimal(p.IdUsuario)).NombreCompleto
                    }
                );            //dgvDatos.Columns[0].Visible = false;   
        }


        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            using (var f = new Presupuestos.frmEdicion()) f.ShowDialog();
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

            dgvDatos.Columns[0].HeaderText = "Presupuesto";
            dgvDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[1].HeaderText = "Fecha";
            dgvDatos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[2].HeaderText = "Validez";
            dgvDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[3].HeaderText = "Cliente";
            dgvDatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[4].HeaderText = "Vendedor";
            dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private EPresupuestos ObtenerPresupuestoSeleccionado()
        {
            try
            {
                int rowindex = dgvDatos.CurrentCell.RowIndex;
                var id = (Int32)dgvDatos.Rows[rowindex].Cells[0].Value;
                var p = PresupuestosRepository.ObtenerPresupuestoPorId(id);
                return p;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            var p = ObtenerPresupuestoSeleccionado();
            if (p == null)
            {
                limpiarTxt();
                return;
            }
            limpiarTxt();
            var cliente = ClientesRepository.ObtenerClientePorId(Convert.ToDecimal(p.IdCliente));

            txtPresupuesto.Text = p.Id.ToString().Trim();
            txtValidez.Text = p.DiasValidez.ToString().Trim();
            txtCliente.Text = cliente.RazonSocial;
            txtNroDoc.Text = cliente.NroDocumento.ToString();
            txtDescuento.Text = p.Descuento.ToString().Trim() + " (" + p.DescuentoPorc.ToString().Trim() + "%)";
            txtDireccion.Text = cliente.Direccion; 
            txtSubTotal.Text = p.Importe.ToString().Trim(); 
            txtTotal.Text = p.ImporteTotal.ToString().Trim();

            cargarDetalles(p.Id);
        }

        private void cargarDetalles(int idpresupuesto)
        {
            dgvDetalles.SetDataSource(
                    from d in PresupuestosDetallesRepository.ObtenerDetallesDelPresupuesto(idpresupuesto)
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
            txtPresupuesto.Text = "";
            txtValidez.Text = "";
            txtCliente.Text = "";
            txtDescuento.Text = "";
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
                    from p in PresupuestosRepository.ObtenerPresupuestos()
                    .Where(p => p.Fecha >= desde && p.Fecha <= hasta)
                    orderby p.Id
                    select new
                    {
                        p.Id,
                        p.Fecha,
                        DiasValidez = p.DiasValidez + " días.",
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
    }
}
