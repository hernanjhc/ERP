using ERP.Lib.AppForms;
using ERP.Models;
using ERP.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Forms.Sucursales
{
    public partial class frmListado : FormBase
    {
        public frmListado()
        {
            InitializeComponent();

            cbBancos.DataSource = BancosRepository.ObtenerBancos();
            cbBancos.ValueMember = "Id";
            cbBancos.DisplayMember = "Nombre";
            Action<ComboBox, string> seleccionar = (cb, s) =>
            {
                for (int i = 0; i < cb.Items.Count; i++)
                {
                    if (cb.GetItemText(cb.Items[i]).Contains(s))
                    {
                        cb.SelectedIndex = i;
                        break;
                    }
                }
            };

            ConsultarDatos();
        }

        private void ConsultarDatos()
        {
            var tds = BancosRepository.ObtenerBancos();
            dgvDatos.SetDataSource(from s in SucursalesRepository.ObtenerSucursales()
                                   orderby s.Id
                                   select new
                                   {
                                       s.Id,
                                       Bancos = s.Bancos.Nombre,
                                       s.Sucursal,
                                       s.Numero,
                                       s.Direccion,
                                       s.EMail,
                                       s.Telefono,
                                       s.Web
                                   });

        }

        private void dgvDatos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnSalir.PerformClick();
            else if (e.Control && e.KeyCode == Keys.N) btnNuevo.PerformClick();
            else if (e.Control && e.KeyCode == Keys.F4) btnEditar.PerformClick();
            else if (e.Control && e.KeyCode == Keys.Delete) btnEliminar.PerformClick();
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

            dgvDatos.Columns[1].HeaderText = "Banco";
            dgvDatos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[2].HeaderText = "Sucursal";
            dgvDatos.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[3].HeaderText = "Numero";
            dgvDatos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[4].HeaderText = "Direccion";
            dgvDatos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[5].HeaderText = "Email";
            dgvDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[6].HeaderText = "Telefono";
            dgvDatos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDatos.Columns[7].HeaderText = "Web";
            dgvDatos.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDatos.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private Models.Sucursales ObtenerSucursalSeleccionada()
        {
            try
            {
                int rowindex = dgvDatos.CurrentCell.RowIndex;
                var id = (Int32)dgvDatos.Rows[rowindex].Cells[0].Value;
                var a = SucursalesRepository.ObtenerSucursalPorId(id);
                return a;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var f = new frmEdicion())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var a = SucursalesRepository.Insertar(f.Sucursal,f.Numero, f.IdBanco, f.Domicilio, f.Dirección,  f.Email,  f.Teléfono,f.Web, f.Estado);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Models.Sucursales a = ObtenerSucursalSeleccionado();
            using (var f = new frmEdicion(a))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int IdEmpresa = Lib.Configuration.IdEmpresa;
                        SucursalesRepository.Actualizar(a.Id, IdEmpresa, f.Sucursal, f.Numero, f.IdBanco, f.Domicilio, f.Dirección, 
                             f.Email,  f.Teléfono, f.Web,  f.Estado);
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

        private Models.Sucursales ObtenerSucursalSeleccionado()
        {
            try
            {
                int rowindex = dgvDatos.CurrentCell.RowIndex;
                var id = (Int32)dgvDatos.Rows[rowindex].Cells[0].Value;
                var a = SucursalesRepository.ObtenerSucursalPorId(id);
                return a;
            }
            catch (Exception)
            {

                return null;
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var a = ObtenerSucursalSeleccionada();
            if (MessageBox.Show("¿Está seguro de que desea eliminar la sucursal seleccionada?",
                "Eliminar Sucursales", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    SucursalesRepository.Eliminar(a.Id);
                    ConsultarDatos();
                    dgvDatos.SetRow(r => Convert.ToDecimal(r.Cells[0].Value) == a.Id);
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void ConsultarSucursalesPorBanco()
        {
            //var query = SucursalesRepository.ObtenerSucursalesPorBanco(IdBanco);
            //dgvDatos.SetDataSource(from d in query select new { d.Id, d.Sucursal });
            var tds = BancosRepository.ObtenerBancos();
            dgvDatos.SetDataSource(from s in SucursalesRepository.ObtenerSucursalesPorBanco(IdBanco)
                                   orderby s.Id
                                   select new
                                   {
                                       s.Id,
                                       Bancos = s.Bancos.Nombre,
                                       s.Sucursal,
                                       s.Numero,
                                       s.Direccion,
                                       s.EMail,
                                       s.Telefono,
                                       s.Web
                                   });
        }

        public int IdBanco
        {
            get
            {
                return Convert.ToInt32(cbBancos.SelectedValue);
            }
        }

        //private void cbBancos_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ConsultarSucursalesPorBanco();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarSucursalesPorBanco();
        }

        
    }
}
