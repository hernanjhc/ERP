using ERP.Lib.AppForms;
using ERP.Reports.DataSet;
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

namespace ERP.Forms.Compras
{
    public partial class frmEdicion : FormBase
    {
        decimal _subTotal;
        int _filaArticulo;

        public frmEdicion()
        {
            Inicializar();
        }

        public int IdProveedor
        {
            get
            {
                return Convert.ToInt32(cbProveedores.SelectedValue);
            }

        }
        private void Inicializar()
        {
            InitializeComponent();
            this.Text = "Nueva Compra";
            CargarProveedores();
            CargarUsuario();
            rbCodigo.Checked = true;
            CargarProductosCodBarra();
        }

        private void CargarProductosCodBarra()
        {
            var a = EArticulosRepository.ObtenerArticulos();
            cbArticulos.DataSource = a;
            cbArticulos.DisplayMember = "CodBarra";
            cbArticulos.ValueMember = "Id";
            if (a.Any()) cbProveedores.SelectedIndex = 0;
        }

        private void CargarUsuario()
        {
            var usuario = UsuariosRepository.ObtenerUsuarioPorId(Lib.Configuration.IdUsuarioConectado);
            lVendedor.Text = "Usuario " + usuario.Id + " - " + usuario.NombreCompleto;
        }

        private void CargarProveedores()
        {
            var p = ProveedoresRepository.ObtenerProveedores();
            cbProveedores.DataSource = p;
            cbProveedores.DisplayMember = "RazonSocial";
            cbProveedores.ValueMember = "Id";
            if (p.Any()) cbProveedores.SelectedIndex = 0;
        }

        private void cbProveedores_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CompletarDatosProveedor();
            }
        }

        private void cbProveedores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CompletarDatosProveedor();
        }

        private void CompletarDatosProveedor()
        {
            var p = ProveedoresRepository.ObtenerProveedorPorId(IdProveedor);
            txtDireccion.Text = p.Direccion;
            txtDocumento.Text = TiposDocumentoRepository.TiposDocumentoPorId(p.IdTipoDocumento).Descripcion +
                "  " + p.NroDocumento.ToString().Trim();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo(Convert.ToInt32(cbArticulos.SelectedValue));  //enviamos id Artículo
        }

        private void AgregarArticulo(int idarticulo)
        {

            var art = EArticulosRepository.ObtenerArticulosPorId(idarticulo);

            if (buscarArticuloEnDetalle(idarticulo))
            {
                modificarCantidadDetalles(_filaArticulo);
            }
            else
            {
                decimal precio = EArticulosRepository.ObtenerArticulosPorId(art.Id).Costo;
                dgvDetalles.Rows.Add(art.Id, art.CodBarra, art.Descripcion, 1, precio, precio);
                modificarCantidadDetalles(dgvDetalles.Rows.Count - 1);
                calcularImportes();
            }

        }
        private void calcularImportes()
        {
            _subTotal = 0;

            for (int i = 0; i <= Convert.ToInt32(dgvDetalles.Rows.Count - 1); i++)
            {
                dgvDetalles.Rows[i].Cells[5].Value =
                    Convert.ToDecimal(dgvDetalles.Rows[i].Cells[3].Value) *
                    Convert.ToDecimal(dgvDetalles.Rows[i].Cells[4].Value);

                _subTotal = _subTotal + Convert.ToDecimal(dgvDetalles.Rows[i].Cells[5].Value);

            }
            txtsubtotal.Text = Convert.ToString(_subTotal);

            if (nudDescuento.Value > 0)
            {
                txtDescuentoPesos.Text =
                    Convert.ToString(Math.Round((Convert.ToDecimal(txtsubtotal.Text) *
                    Convert.ToDecimal(nudDescuento.Text)) / 100, 2));
                txtTotal.Text =
                    Convert.ToString(Math.Round(Convert.ToDecimal(txtsubtotal.Text) -
                    (Convert.ToDecimal(txtsubtotal.Text) * Convert.ToDecimal(nudDescuento.Text)) / 100, 2));
            }
            else
            {
                txtDescuentoPesos.Text = "0.00";
                txtTotal.Text = txtsubtotal.Text;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbArticulos.Focus();
            }
        }

        private void dgvDetalles_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Controla ingreso de valores decimales
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }

        private void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            IngresaDecimal(sender, e);
        }

        private void IngresaDecimal(object sender, KeyPressEventArgs e)
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

        private void nudDescuento_ValueChanged(object sender, EventArgs e)
        {
            calcularImportes();
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

        public Decimal Subtotal
        {
            get
            {
                return Convert.ToDecimal(txtsubtotal.Text);
            }
        }

        public Decimal Descuento
        {
            get
            {
                return Convert.ToDecimal(txtDescuentoPesos.Text);
            }
        }

        public Decimal DescPorc
        {
            get
            {
                return Convert.ToDecimal(nudDescuento.Value);
            }
        }

        public Decimal ImporteTotal
        {
            get
            {
                return Convert.ToDecimal(txtTotal.Text);
            }
        }

        public String DireccionProveedor
        {
            get
            {
                return ProveedoresRepository.ObtenerProveedorPorId(IdProveedor).Direccion;
            }
        }

        public String RazónSocialProveedor
        {
            get
            {
                return ProveedoresRepository.ObtenerProveedorPorId(IdProveedor).RazonSocial;
            }
        }

        public String TipoDocumento
        {
            get
            {
                var proveedor = ProveedoresRepository.ObtenerProveedorPorId(IdProveedor);
                return TiposDocumentoRepository.TiposDocumentoPorId(proveedor.IdTipoDocumento).Descripcion.ToString();
            }
        }

        public decimal Documento
        {
            get
            {
                return ProveedoresRepository.ObtenerProveedorPorId(IdProveedor).NroDocumento;
            }
        }

        public byte Estado
        {
            get
            {
                return 1; //Revisar
            }
        }

        public byte Pagado
        {
            get
            {
                return 1; //Revisar
            }
        }

        public byte Retirado
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
                return Lib.Configuration.IdUsuarioConectado;
            }

        }

        private void dgvDetalles_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calcularImportes();
        }

        private void dgvDetalles_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcularImportes();
        }

        public DataTable ObtenerDetalles()
        {
            var detalles = CargarDetalles();
            return detalles;
        }
        private DataTable CargarDetalles()
        {
            var tabla = new dsImpresiones.DetallesDataTable();
            for (int i = 0; i <= Convert.ToInt32(dgvDetalles.Rows.Count - 1); i++)
            {
                string id = Convert.ToString(dgvDetalles.Rows[i].Cells[0].Value);
                string codBarra = Convert.ToString(dgvDetalles.Rows[i].Cells[1].Value);
                string descripcion = Convert.ToString(dgvDetalles.Rows[i].Cells[2].Value);
                string cantidad = Convert.ToString(dgvDetalles.Rows[i].Cells[3].Value);
                string precio = Convert.ToString(dgvDetalles.Rows[i].Cells[4].Value);
                string importe = Convert.ToString(dgvDetalles.Rows[i].Cells[5].Value);

                tabla.AddDetallesRow(id, codBarra, descripcion, cantidad, precio, importe);
            }
            return tabla;
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductosCodBarra();
        }

        private void rbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductosDescripcion();
        }

        private void CargarProductosDescripcion()
        {
            var a = EArticulosRepository.ObtenerArticulos();
            cbArticulos.DataSource = a;
            cbArticulos.DisplayMember = "Descripcion";
            cbArticulos.ValueMember = "Id";
            if (a.Any()) cbProveedores.SelectedIndex = 0;
        }

        private void cbArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAgregar.PerformClick();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (this.ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
