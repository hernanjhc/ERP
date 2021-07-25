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
using ERP.Reports.DataSet;
using ERP.Reports.Designs;
using ERP.Lib;

namespace ERP.Forms.Ventas
{
    public partial class frmEdicion : FormBase
    {
        decimal _subTotal;
        int _filaArticulo;

        public frmEdicion()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            InitializeComponent();
            this.Text = "Nueva Venta";
            CargarClientes();
            CargarVendedor();
            rbCodigo.Checked = true;
            CargarProductosCodBarra();
            cbLista.SelectedIndex = 0;
        }

        private void CargarProductosCodBarra()
        {
            var a = EArticulosRepository.ObtenerArticulos();
            cbArticulos.DataSource = a;
            cbArticulos.DisplayMember = "CodBarra";
            cbArticulos.ValueMember = "Id";
            if (a.Any()) cbClientes.SelectedIndex = 0;
        }

        private void CargarProductosDescripcion()
        {
            var a = EArticulosRepository.ObtenerArticulos();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.None;
            //if (this.ValidarDatos())
            //{
            //    DialogResult = DialogResult.OK;
            //}
            GuardarVenta();
            LimpiarVentana();
        }

        private void LimpiarVentana()
        {
            txtDireccion.Text = "";
            txtDocumento.Text = "";
            dgvDetalles.Rows.Clear();
            txtsubtotal.Text = "";
            txtDescuentoPesos.Text = "";
            txtTotal.Text = "";
            nudDescuento.Value = 0;
            rbCodigo.Select();
            dtpFecha.Value = DateTime.Now;
            cbLista.SelectedIndex = 0;
            cbArticulos.Focus();
        }

        private void GuardarVenta()
        {
            EVentas _venta = new EVentas();
            List<EVentasDetalles> _detalleVenta = new List<EVentasDetalles>();

            try
            {
                _venta.IdCliente = IdCliente;
                _venta.Fecha = Fecha;
                _venta.Importe = Subtotal;
                _venta.Descuento = Descuento;
                _venta.DescuentoPorc = DescPorc;
                _venta.ImporteTotal = ImporteTotal;
                _venta.PrecioLista = PrecioLista;
                _venta.IdUsuario = IdUsuario;
                _venta.Estado = Estado;
                var idVentaRegistrada = VentasRepository.Insertar(_venta);
                if (idVentaRegistrada == 0)
                {
                    MessageBox.Show("Error al registrar Venta", "Registrar venta");
                    return;
                }

                for (int i = 0; i <= Convert.ToInt32(dgvDetalles.Rows.Count - 1); i++)
                {
                    EVentasDetalles detalle = new EVentasDetalles();
                    detalle.IdArticulo = Convert.ToInt32(dgvDetalles.Rows[i].Cells[0].Value);
                    detalle.Cantidad = Convert.ToInt32(dgvDetalles.Rows[i].Cells[3].Value);
                    detalle.Precio = Convert.ToInt32(dgvDetalles.Rows[i].Cells[4].Value);
                    detalle.Importe = Convert.ToInt32(dgvDetalles.Rows[i].Cells[5].Value);
                    detalle.IdVenta = idVentaRegistrada;
                    _detalleVenta.Add(detalle);
                    if (!VentasDetallesRepository.Insertar(detalle))
                    {
                        VentasRepository.EliminarVentaRegistradaIncorrectamente(idVentaRegistrada);
                        VentasDetallesRepository.EliminarDetallesVentaRegistradosIncorrectamente(idVentaRegistrada);
                        MessageBox.Show("Error al registrar Venta", "Registrar venta");
                        return;
                    }
                }
                if (Configuration.ImprimeVentas) ImprimirVenta(_venta.Id);
                if (Configuration.VentaDescuentaStock)
                {
                    foreach (var item in _detalleVenta)
                    {
                        EArticulosRepository.DescontarStockArticulo(
                            Convert.ToDecimal(item.IdArticulo), Convert.ToDecimal(item.Cantidad));
                    }
                }
                if (Configuration.SoloCobroEfectivo)
                {
                }
                MessageBox.Show("Venta registrada correctamente", "Registrar venta");
                LimpiarVentana();
            }
            catch (Exception ex)
            {
                ShowError("Error al intentar leer los datos: \n" + ex.Message);
            }

        }

        private void ImprimirVenta(object idVenta)
        {
            using (var dt = ObtenerDetalles())
            {
                if (dt.Rows.Count > 0)
                {
                    string documento = Documento.ToString();
                    string tipoDocumento = TipoDocumento.ToString();
                    string comprobante = "Venta";
                    string número = idVenta.ToString();
                    string fecha = Fecha.Date.ToString("dd/MM/yyyy");
                    string subTotal = Subtotal.ToString();
                    string descuento = Descuento.ToString();
                    string total = ImporteTotal.ToString();
                    MostrarReporte(dt, DireccionCliente, RazónSocialCliente, documento,
                        tipoDocumento, comprobante, número, fecha,
                        subTotal, descuento, total);
                }
                else
                {
                    ShowError("No pudo imprimir el documento.");
                }
            }
        }

        private void MostrarReporte(DataTable detalles, string dirección, string razónSocial, string documento,
                string tipoDocumento, string comprobante, string número, string fecha,
                string subtotal, string descuento, string total)
        {
            using (var reporte = new Presupuesto())
            {
                reporte.Database.Tables["Detalles"].SetDataSource(detalles);
                using (
                    var f = new frmReporte(reporte, dirección, razónSocial, documento,
                                            tipoDocumento, comprobante, número, fecha,
                                            subtotal, descuento, total, "")) f.ShowDialog();
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
            CompletarDatosCliente();
        }

        private void CompletarDatosCliente()
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
            if (idarticulo <= 0) return;
            var art = EArticulosRepository.ObtenerArticulosPorId(idarticulo);
            if (art == null) return;
            if (buscarArticuloEnDetalle(idarticulo))
            {
                modificarCantidadDetalles(_filaArticulo);
            }
            else
            {
                decimal precio = ObtenerPrecioPorLista(Convert.ToInt16(cbLista.Text), art.Id);
                dgvDetalles.Rows.Add(art.Id, art.CodBarra, art.Descripcion, 1, precio, precio);
                modificarCantidadDetalles(dgvDetalles.Rows.Count - 1);
                calcularImportes();
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

        private decimal ObtenerPrecioPorLista(short lista, int idarticulo)
        {
            decimal precio = -1;
            var articulo = EArticulosRepository.ObtenerArticulosPorId(idarticulo);
            if (lista == 1 && articulo.PrecioL1 > 0) precio = Convert.ToDecimal(articulo.PrecioL1);
            if (lista == 2 && articulo.PrecioL2 > 0) precio = Convert.ToDecimal(articulo.PrecioL2);
            if (lista == 3 && articulo.PrecioL3 > 0) precio = Convert.ToDecimal(articulo.PrecioL3);
            return precio;
        }

        private void dgvDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //calcularImportes();
                cbArticulos.Focus();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvDetalles_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Controla ingreso de valores decimales
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }

        void dText_KeyPress(object sender, KeyPressEventArgs e)
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

        public String DireccionCliente
        {
            get
            {
                return ClientesRepository.ObtenerClientePorId(IdCliente).Direccion;
            }
        }

        public String RazónSocialCliente
        {
            get
            {
                return ClientesRepository.ObtenerClientePorId(IdCliente).RazonSocial;
            }
        }

        public String TipoDocumento
        {
            get
            {
                var c = ClientesRepository.ObtenerClientePorId(IdCliente);
                return TiposDocumentoRepository.TiposDocumentoPorId(c.IdTipoDocumento).Descripcion.ToString();
            }
        }

        public decimal Documento
        {
            get
            {
                return ClientesRepository.ObtenerClientePorId(IdCliente).NroDocumento;
            }
        }

        public int PrecioLista
        {
            get
            {
                return Convert.ToInt16(cbLista.Text);
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
                CompletarDatosCliente();
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
    }
}
