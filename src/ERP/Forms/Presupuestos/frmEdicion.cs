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

namespace ERP.Forms.Presupuestos
{
    public partial class frmEdicion : FormBase 
    {
        decimal subTotal;
        public frmEdicion()
        {
            InitializeComponent();
            this.Text = "Nuevo Presupuesto";
            CargarClientes();
            CargarVendedor();
            rbCodigo.Checked = true;
            CargarProductosCodBarra();
            cbLista.SelectedIndex = 0;
            
            
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
            //dgvDetalles.CurrentCell = dgvDetalles.CurrentRow.Cells[3];
            
            cbLista.Enabled = false;                                    //no cambia lista de precios luego de elegir el primer articulo

            decimal cantidad = Convert.ToDecimal(dgvDetalles.CurrentRow.Cells[2].Value);
            decimal precio = Convert.ToDecimal(dgvDetalles.CurrentRow.Cells[3].Value);
            calcularImportes(cantidad, precio);
        }

        private void AgregarArticulo(int idarticulo)
        {
            //id    /   descripcion /   cantidad    /   precio  /   importe
            var art = ArticulosRepository.ObtenerArticulosPorId(idarticulo);
            decimal precio = ObtenerPrecioPorLista(Convert.ToInt16(cbLista.Text), art.Id);
            if (precio >= 0)
            {
                dgvDetalles.Rows.Add(art.CodBarra, art.Descripcion, 1, precio, precio);
                //dgvDetalles.CurrentCell = dgvDetalles.CurrentRow.Cells[2];
                dgvDetalles.CurrentCell = dgvDetalles.Rows[dgvDetalles.Rows.Count - 1].Cells[2];
                dgvDetalles.BeginEdit(true);

            }
            
        }
       
        private decimal ObtenerPrecioPorLista(short lista, int idarticulo)
        {
            decimal precio = -1;
            var articulo = ArticulosRepository.ObtenerArticulosPorId(idarticulo);
            if (lista == 1 && articulo.PrecioL1 > 0) precio = Convert.ToDecimal(articulo.PrecioL1);
            if (lista == 2 && articulo.PrecioL2 > 0) precio = Convert.ToDecimal(articulo.PrecioL2);
            if (lista == 3 && articulo.PrecioL3 > 0) precio = Convert.ToDecimal(articulo.PrecioL3);
            return precio;
        }

        private void dgvDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal cantidad = Convert.ToDecimal(dgvDetalles.CurrentRow.Cells[2].Value);
                decimal precio = Convert.ToDecimal(dgvDetalles.CurrentRow.Cells[3].Value);
                calcularImportes(cantidad, precio);
                cbArticulos.Focus();
            }


        }

        private void calcularImportes(decimal cantidad, decimal precio)
        {
            subTotal = 0;
            decimal importe = cantidad * precio;
            dgvDetalles.CurrentRow.Cells[4].Value = importe;

            //foreach (DataGridViewRow row in dgvDetalles.Rows)
            for (int i = 0; i <= Convert.ToInt32(dgvDetalles.Rows.Count - 1); i++)
            {
                //subTotal = subTotal + Convert.ToDecimal(dgvDetalles.CurrentRow.Cells[4].Value);
                subTotal = subTotal + Convert.ToDecimal(dgvDetalles.Rows[i].Cells[4].Value);

            }
            txtsubtotal.Text = Convert.ToString(subTotal);

            if (nudDescuento.Text != "")
            {
                txtDescuentoPesos.Text = Convert.ToString(Math.Round((Convert.ToDecimal(txtsubtotal.Text) * Convert.ToDecimal(nudDescuento.Text)) / 100, 2));
                txtTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(txtsubtotal.Text)-(Convert.ToDecimal(txtsubtotal.Text) * Convert.ToDecimal(nudDescuento.Text))/100, 2));
            }else
            {
                txtTotal.Text = txtsubtotal.Text;
            }
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDetalles_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }
        void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // _validator.IngresaDecimal(sender, e);
            ingresaDecimal(sender,e);

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

            
        private void nudDescuento_ValueChanged(object sender, EventArgs e)
        {
            calcularImporteDescuento();
        }

        private void calcularImporteDescuento()
        {
            if (nudDescuento.Text != "")
            {
                txtDescuentoPesos.Text = Convert.ToString(Math.Round((Convert.ToDecimal(txtsubtotal.Text) * Convert.ToDecimal(nudDescuento.Text)) / 100, 2));
                txtTotal.Text = Convert.ToString(Math.Round(Convert.ToDecimal(txtsubtotal.Text) - (Convert.ToDecimal(txtsubtotal.Text) * Convert.ToDecimal(nudDescuento.Text)) / 100, 2));
            }
            else
            {
                txtTotal.Text = txtsubtotal.Text;
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

        public int DiasValidez
        {
            get
            {
                return Convert.ToInt16(nDias.Value);
            }
        }

        public Decimal ImporteB
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
                var usuario = UsuariosRepository.ObtenerUsuarioPorId(Lib.Configuration.IdUsuarioConectado);
                return  usuario.Id;
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

        
    }
}
