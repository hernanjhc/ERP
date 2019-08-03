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

namespace ERP.Forms.Remitos
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
                from p in RemitosRepository.ObtenerRemitos()
                
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

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn c in dgvDatos.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvDatos.Columns[0].HeaderText = "Remito";
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

        private ERemitos ObtenerRemittoSeleccionado()
        {
            try
            {
                int rowindex = dgvDatos.CurrentCell.RowIndex;
                var id = (Int32)dgvDatos.Rows[rowindex].Cells[0].Value;
                var p = RemitosRepository.ObtenerRemitoPorId(id);
                return p;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            var p = ObtenerRemittoSeleccionado();
            if (p == null)
            {
                limpiarTxt();
                return;
            }
            limpiarTxt();
            var cliente = ClientesRepository.ObtenerClientePorId(Convert.ToDecimal(p.IdCliente));

            txtRemito.Text = p.Id.ToString().Trim();
            dtpFecha.Value = Convert.ToDateTime(p.Fecha);          
            txtCliente.Text = cliente.RazonSocial;
            txtNroDoc.Text = cliente.NroDocumento.ToString();
            //txtVentaNro.Text = cliente.NroDocumento.ToString();
            txtDireccion.Text = cliente.Direccion;
            

            cargarDetalles(p.Id);
        }

        private void cargarDetalles(int idRemito)
        {
            dgvDetalles.SetDataSource(
                    from d in RemitosDetallesRepository.ObtenerDetallesDelRemito(idRemito)
                    select new
                    {
                        ArticulosRepository.ObtenerArticulosPorId(
                            Convert.ToDecimal(d.IdArticulo)).Descripcion,                        
                        d.Cantidad
                        
                    }
                );
        }

        private void limpiarTxt()
        {
            dgvDetalles.Rows.Clear();
            txtRemito.Text = "";
            txtVentaNro.Text = "";
            txtCliente.Text = "";            
            txtDireccion.Text = "";
            txtNroDoc.Text = "";
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

        private void btnBuscar_Click(object sender, EventArgs e)
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
                    from p in RemitosRepository.ObtenerRemitos()
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

            dgvDetalles.Columns[1].HeaderText = "Cantidad";
            dgvDetalles.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            
        }
    }
}
