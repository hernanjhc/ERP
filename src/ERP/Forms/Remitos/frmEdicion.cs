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

namespace ERP.Forms.Remitos
{
    public partial class frmEdicion : FormBase
    {
        decimal _subTotal;
        int _filaArticulo;

        public frmEdicion()
        {
            InitializeComponent();
            this.Text = "Nuevo Remito";
            CargarClientes();
            CargarVendedor();
            cargarVentas();
            rbCodigo.Checked = true;
            CargarProductosCodBarra();
            
        }

        private void cargarVentas()
        {
            var c = VentasRepository.ObtenerVentas();
            cbVentas.DataSource = c;
            cbVentas.DisplayMember = "Id";
            cbVentas.ValueMember = "Id";
            if (c.Any()) cbClientes.SelectedIndex = 0;
        }

        private void CargarProductosCodBarra()
        {
            var a = ArticulosRepository.ObtenerArticulos();
            cbArticulos.DataSource = a;
            cbArticulos.DisplayMember = "CodBarra";
            cbArticulos.ValueMember = "Id";
            if (a.Any()) cbClientes.SelectedIndex = 0;
        }

        private void CargarProductosDescripcion()
        {
            var a = ArticulosRepository.ObtenerArticulos();
            cbArticulos.DataSource = a;
            cbArticulos.DisplayMember = "Descripcion";
            cbArticulos.ValueMember = "Id";
            if (a.Any()) cbClientes.SelectedIndex = 0;
        }

        private void CargarVendedor()
        {
            var usuario = UsuariosRepository.ObtenerUsuarioPorId(Lib.Configuration.IdUsuarioConectado);
            lVendedor.Text = "Vendedor " + usuario.Id + " - " + usuario.NombreCompleto;
        }

        private void CargarClientes()
        {
            var c = ClientesRepository.ObtenerClientes();
            cbClientes.DataSource = c;
            cbClientes.DisplayMember = "RazonSocial";
            cbClientes.ValueMember = "Id";
            if (c.Any()) cbClientes.SelectedIndex = 0;
        }

        public int IdCliente
        {
            get
            {
                return Convert.ToInt32(cbClientes.SelectedValue);
            }
        }

        public int IdVenta
        {
            get
            {
                return Convert.ToInt32(cbVentas.SelectedValue);
            }
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductosCodBarra();
        }

        private void rbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductosDescripcion();
        }

        private void cbClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var c = ClientesRepository.ObtenerClientePorId(IdCliente);
            txtDireccion.Text = c.Direccion;
            txtDocumento.Text = TiposDocumentoRepository.TiposDocumentoPorId(c.IdTipoDocumento).Descripcion +
                "  " + c.NroDocumento.ToString().Trim();
        }

        private void cbArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAgregar.PerformClick();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo(Convert.ToInt32(cbArticulos.SelectedValue));  //enviamos id Artículo
        }

        private void AgregarArticulo(int idarticulo)
        {

            var art = ArticulosRepository.ObtenerArticulosPorId(idarticulo);

            if (buscarArticuloEnDetalle(idarticulo))
            {
                modificarCantidadDetalles(_filaArticulo);
            }
            else
            {
                //decimal precio = ObtenerPrecioPorLista(Convert.ToInt16(cbLista.Text), art.Id);
                //dgvDetalles.Rows.Add(art.Id, art.CodBarra, art.Descripcion, 1, precio, precio);
                dgvDetalles.Rows.Add(art.Id, art.CodBarra, art.Descripcion, 1);
                modificarCantidadDetalles(dgvDetalles.Rows.Count - 1);
                //calcularImportes();
            }

        }

        private bool buscarArticuloEnDetalle(int idarticulo)
        {
            bool articuloEnDetalle = false;
            for (int i = 0; i <= dgvDetalles.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dgvDetalles.Rows[i].Cells[0].Value) == idarticulo)
                {
                    _filaArticulo = i;
                    i = dgvDetalles.Rows.Count;
                    articuloEnDetalle = true;
                }
            }
            return articuloEnDetalle;
        }

        private void modificarCantidadDetalles(int i)
        {
            dgvDetalles.CurrentCell = dgvDetalles.Rows[i].Cells[3];
            dgvDetalles.BeginEdit(true);
        }

        private void dgvDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            cbArticulos.Focus();
        }

        private void dgvDetalles_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //COntrola ingreso de valores decimales
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }

        void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            ingresaDecimal(sender, e);
        }

        private void ingresaDecimal(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',')
            {
                if (((TextBox)sender).Text.Contains(","))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (this.ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            return true;
        }

        public DateTime Fecha
        {
            get
            {
                return Convert.ToDateTime(dtpFecha.Value);
            }
        }

        public byte Estado
        {
            get
            {
                return 1; //Revisar
            }
        }

        public int IdUsuario
        {
            get
            {
                //var usuario = UsuariosRepository.ObtenerUsuarioPorId(Lib.Configuration.IdUsuarioConectado);
                //return  usuario.Id;
                return Lib.Configuration.IdUsuarioConectado;
            }

        }

        private void cbClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var c = ClientesRepository.ObtenerClientePorId(IdCliente);
                txtDireccion.Text = c.Direccion;
                txtDocumento.Text = TiposDocumentoRepository.TiposDocumentoPorId(c.IdTipoDocumento).Descripcion +
                    "  " + c.NroDocumento.ToString().Trim();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
