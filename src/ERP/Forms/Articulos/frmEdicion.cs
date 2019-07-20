using ERP.Lib.AppForms;
using ERP.Lib.Validations;
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

namespace ERP.Forms.Articulos
{
    public partial class frmEdicion : FormBase
    {
        public frmEdicion()
        {
            InitializeComponent();

            this.Text = "Nuevo Artículo";
            txtCodigo.Select();
            _validator = new FormValidations(this, errorProvider1);
            CargaInicial();
            ckEstado.Checked = true;
        }

        private void CargaInicial()
        {
            CargaMarcas();
            CargaRubros();
            CargaProveedores();
            CargaUnidades();
        }

        private void CargaUnidades()
        {
            var u = UnidadesRepository.ObtenerUnidades();
            cbUnidad.DataSource = u;
            cbUnidad.DisplayMember = "Unidad";
            cbUnidad.ValueMember = "Id";
            if (u.Any()) cbUnidad.SelectedIndex = 0;
        }

        private void CargaProveedores()
        {
            var p = ProveedoresRepository.ObtenerProveedores();
            cbProveedores.DataSource = p;
            cbProveedores.DisplayMember = "RazonSocial";
            cbProveedores.ValueMember = "Id";
            if (p.Any()) cbProveedores.SelectedIndex = 0;
        }

        private void CargaRubros()
        {
            var r = RubrosRepository.ObtenerRubros();
            cbRubro.DataSource = r;
            cbRubro.DisplayMember = "Rubro";
            cbRubro.ValueMember = "Id";
            if (r.Any()) cbRubro.SelectedIndex = 0;
        }

        private void CargaMarcas()
        {
            var m = MarcasRepository.ObtenerMarcas(); ;
            cbMarca.DataSource = m;
            cbMarca.DisplayMember = "Marca";
            cbMarca.ValueMember = "Id";
            if (m.Any()) cbMarca.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string Observaciones
        {
            get
            {
                return txtObservaciones.Text.Trim();
            }
        }

        public decimal Stock
        {
            get
            {
                return Convert.ToDecimal(txtStock.Text.Trim());
            }
        }

        public decimal StockMinimo
        {
            get
            {
                return Convert.ToDecimal(txtStockMinimo.Text.Trim());
            }
        }

        public decimal IVA
        {
            get
            {
                return Convert.ToDecimal(txtIVA.Text.Trim());
            }
        }

        public decimal Lista3
        {
            get
            {
                return Convert.ToDecimal(txtLista3.Text.Trim());
            }
        }

        public decimal ListaPorc3
        {
            get
            {
                return Convert.ToDecimal(txtListaPorc3.Text.Trim());
            }
        }

        public decimal Lista2
        {
            get
            {
                return Convert.ToDecimal(txtLista2.Text.Trim());
            }
        }

        public decimal ListaPorc2
        {
            get
            {
                return Convert.ToDecimal(txtListaPorc2.Text.Trim());
            }
        }

        public decimal Lista1
        {
            get
            {
                return Convert.ToDecimal(txtLista1.Text.Trim());
            }
        }

        public decimal ListaPorc1
        {
            get
            {
                return Convert.ToDecimal(txtListaPorc1.Text.Trim());
            }
        }

        public decimal Costo
        {
            get
            {
                return Convert.ToDecimal(txtCosto.Text.Trim());
            }
        }

        public decimal Descuento3
        {
            get
            {
                return Convert.ToDecimal(txtDesc3.Text.Trim());
            }
        }

        public decimal DescuentoPorc3
        {
            get
            {
                return Convert.ToDecimal(txtDescPorc3.Text.Trim());
            }
        }

        public decimal Descuento2
        {
            get
            {
                return Convert.ToDecimal(txtDesc2.Text.Trim());
            }
        }

        public decimal DescuentoPorc2
        {
            get
            {
                return Convert.ToDecimal(txtDescPorc2.Text.Trim());
            }
        }

        public decimal Descuento1
        {
            get
            {
                return Convert.ToDecimal(txtDesc1.Text.Trim());
            }
        }

        public decimal DescuentoPorc1
        {
            get
            {
                return Convert.ToDecimal(txtDescPorc1.Text.Trim());
            }
        }

        public decimal CostoInicial
        {
            get
            {
                return Convert.ToDecimal(txtCostoInicial.Text.Trim());
            }
        }
        public int IdUnidad
        {
            get
            {
                return Convert.ToInt32(cbUnidad.SelectedValue);
            }
        }

        public int IdProveedor
        {
            get
            {
                return Convert.ToInt32(cbProveedores.SelectedValue);
            }
        }

        public int IdRubro
        {
            get
            {
                return Convert.ToInt32(cbRubro.SelectedValue);
            }
        }

        public int IdMarca
        {
            get
            {
                return Convert.ToInt32(cbMarca.SelectedValue);
            }
        }

        public string Descripcion
        {
            get
            {
                return txtDescripcion.Text.Trim();
            }
        }

        public string CodigoBarra
        {
            get
            {
                return txtCodBarra.Text.Trim();
            }
        }

        public string Codigo
        {
            get
            {
                return txtCodigo.Text.Trim();
            }
        }

        public byte Estado
        {
            get
            {
                return (byte)(ckEstado.Checked ? 1 : 0);
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            if (this.ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
