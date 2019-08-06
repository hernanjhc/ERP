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

namespace ERP.Forms.Presupuestos
{
    public partial class frmEdicion : FormBase 
    {
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
            cbLista.Enabled = false;                                    //no cambia lista de precios luego de elegir el primer articulo
        }

        private void AgregarArticulo(int idarticulo)
        {
            //id    /   descripcion /   cantidad    /   precio  /   importe
            var art = ArticulosRepository.ObtenerArticulosPorId(idarticulo);
            decimal precio = ObtenerPrecioPorLista(Convert.ToInt16(cbLista.Text), art.Id);
            if (precio >= 0)
            {
                dgvDetalles.Rows.Add(art.CodBarra, art.Descripcion, 1, precio, precio);
                
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

       // private void dgvDetalles_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
       // {
       //     foreach (DataGridViewColumn c in dgvDetalles.Columns)
       //     {
       //         c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
       //     }
       //     
       //     dgvDetalles.Columns[0].HeaderText = "Id";
       //     dgvDetalles.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
       //     dgvDetalles.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
       //     
       //     dgvDetalles.Columns[1].HeaderText = "Descripción";
       //     dgvDetalles.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
       //     dgvDetalles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
       //     
       //     dgvDetalles.Columns[2].HeaderText = "Cantidad";
       //     dgvDetalles.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
       //     dgvDetalles.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
       //     
       //     dgvDetalles.Columns[3].HeaderText = "Precio";
       //     dgvDetalles.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
       //     dgvDetalles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
       //     
       //     dgvDetalles.Columns[3].HeaderText = "Importe";
       //     dgvDetalles.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
       //     dgvDetalles.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
       // }
    }
}
