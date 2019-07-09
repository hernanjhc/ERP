using ERP.Lib.AppForms;
using ERP.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ERP.Forms.Clientes
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
            var tds = TiposDocumentoRepository.ObtenerTiposDocumento();
            dgvDatos.SetDataSource(from a in ClientesRepository.ObtenerClientes()
                                   orderby a.Id
                                   select new
                                   {
                                       a.Id,
                                       a.RazonSocial,
                                       TipoDocumento = a.TiposDocumento.Descripcion,                                       
                                       a.NroDocumento,
                                       a.FechaNacimiento,
                                       a.Direccion,
                                       a.Telefono,
                                       a.Estado
                                   });
        }

        private Models.Clientes ObtenerClienteseleccionado()
        {
            try
            {
                int rowindex = dgvDatos.CurrentCell.RowIndex;
                var id = (Int32)dgvDatos.Rows[rowindex].Cells[0].Value;
                var a = ClientesRepository.ObtenerClientePorId(id);
                return a;
            }
            catch (Exception)
            {

                return null;
            }
            
            
        }

        
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            using (var f = new frmEdición())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var a = ClientesRepository.Insertar(f.RazonSocial, f.IdTipoDocumento, f.NroDocumento,
                            f.FechaNacimiento, f.Email, f.Dirección, f.Domicilio, f.Teléfono, f.Estado);
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
            var a = ObtenerClienteseleccionado();
            if (MessageBox.Show("¿Está seguro de que desea eliminar el alumno seleccionado?",
                "Eliminar Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    ClientesRepository.Eliminar(a.Id);
                    ConsultarDatos();
                    dgvDatos.SetRow(r => Convert.ToDecimal(r.Cells[0].Value) == a.Id);
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            var a = ObtenerClienteseleccionado();
            if (a == null)
            {
                txtRazonSocial.Text = "";
                txtDocumento.Text = "";
                txtFechaNacimiento.Text = "";
                txtEMail.Text = "";
                txtEstado.Text = "";
                txtDireccion.Text = "";
                txtProvincia.Text = "";
                txtDepartamento.Text = "";
                txtLocalidad.Text = "";
                txtBarrio.Text = "";
                return;
            }
            txtRazonSocial.Text = a.RazonSocial;
            txtDocumento.Text = String.Format("{0} {1:N0}", a.TiposDocumento.Descripcion, a.NroDocumento);
            txtFechaNacimiento.Text = String.Format("{0:dd/MM/yyyy}", a.FechaNacimiento);
            txtEMail.Text = a.EMail;
            txtTelefono.Text = a.Telefono;
            //txtEstado.Text = a.LeyendaEstado;
            txtDireccion.Text = a.Direccion;
            if (a.Domicilios == null)
            {
                txtProvincia.Text = "";
                txtDepartamento.Text = "";
                txtLocalidad.Text = "";
                txtBarrio.Text = "";
            }
            else
            {
                txtProvincia.Text = a.Domicilios.Provincias.Nombre;
                txtDepartamento.Text = a.Domicilios.Departamentos.Nombre;
                txtLocalidad.Text = a.Domicilios.Localidades.Nombre;
                txtBarrio.Text = a.Domicilios.Barrios.Nombre;
            }
        }

        private void dgvDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnSalir.PerformClick();
            else if (e.Control && e.KeyCode == Keys.N) btnNuevo.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F4) btnEditar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.Delete) btnEliminar.PerformClick();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Models.Clientes a = ObtenerClienteseleccionado();
            using (var f = new frmEdición(a))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int IdEmpresa = Lib.Configuration.IdEmpresa;
                        ClientesRepository.Actualizar(a.Id, IdEmpresa, f.RazonSocial, f.IdTipoDocumento, f.NroDocumento,
                            f.FechaNacimiento, f.Email, f.Dirección, f.Teléfono, f.Domicilio, f.Estado);
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

        private void dgvDatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn c in dgvDatos.Columns)
            {
                c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvDatos.Columns[0].HeaderText = "Código";
            dgvDatos.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[1].HeaderText = "Razón Social";
            dgvDatos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[2].HeaderText = "Tip. Doc.";
            dgvDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[3].HeaderText = "Nº Documento";
            dgvDatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvDatos.Columns[3].DefaultCellStyle.Format = "N0";

            dgvDatos.Columns[4].HeaderText = "Fec. Nac.";
            dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvDatos.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvDatos.Columns[5].HeaderText = "Dirección";
            dgvDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[6].HeaderText = "Teléfono";
            dgvDatos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dgvDatos.Columns[7].HeaderText = "Estado";
            dgvDatos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }
    }
}
