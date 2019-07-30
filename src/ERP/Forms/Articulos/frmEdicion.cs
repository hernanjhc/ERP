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
using ERP.Models;

namespace ERP.Forms.Articulos
{
    public partial class frmEdicion : FormBase
    {
        decimal _costoInicial;
        decimal _descuento1;
        decimal _descuento2;
        decimal _descuento3;
        decimal _costo;

        protected FormValidations _validator;

        public frmEdicion()
        {
            InitializeComponent();

            this.Text = "Nuevo Artículo";
            txtCodigo.Select();
            _validator = new FormValidations(this, errorProvider1);
            CargaInicial();
            ckEstado.Checked = true;
        }

        public frmEdicion(EArticulos articulo) : this()
        {
            this.Text = "Edición del Artículo";
            txtCodigo.Text = articulo.Codigo;
            txtCodBarra.Text = articulo.CodBarra;
            txtDescripcion.Text = articulo.Descripcion;
            cbMarca.SelectedIndex = cbMarca.FindString(MarcasRepository.ObtenerMarcaStringPorId(articulo.IdMarca));
            cbRubro.SelectedIndex = cbRubro.FindString(RubrosRepository.ObtenerRubroStringPorId(articulo.IdRubro));
            cbProveedores.SelectedIndex = cbProveedores.FindString(ProveedoresRepository.ObtenerProveedorStringPorID(articulo.IdProveedor));
            cbUnidad.SelectedIndex = cbUnidad.FindString(UnidadesRepository.ObtenerUnidadStringPorId(articulo.IdUnidad));
            txtCostoInicial.Text = Convert.ToString(articulo.CostoInicial);
            txtDescPorc1.Text = Convert.ToString(articulo.DescuentoPorc1);
            txtDesc1.Text = Convert.ToString(articulo.Descuento1);
            txtDescPorc2.Text = Convert.ToString(articulo.DescuentoPorc2);
            txtDesc2.Text = Convert.ToString(articulo.Descuento2);
            txtDescPorc3.Text = Convert.ToString(articulo.DescuentoPorc3);
            txtDesc3.Text = Convert.ToString(articulo.Descuento3);
            txtCosto.Text = Convert.ToString(articulo.Costo);
            txtListaPorc1.Text = Convert.ToString(articulo.PrecioPorcL1);
            txtLista1.Text = Convert.ToString(articulo.PrecioL1);
            txtListaPorc2.Text = Convert.ToString(articulo.PrecioPorcL2);
            txtLista2.Text = Convert.ToString(articulo.PrecioL2);
            txtListaPorc3.Text = Convert.ToString(articulo.PrecioPorcL3);
            txtLista3.Text = Convert.ToString(articulo.PrecioL3);
            txtIVA.Text = Convert.ToString(articulo.IVA);
            txtStock.Text = Convert.ToString(articulo.Stock);
            txtStockMinimo.Text = Convert.ToString(articulo.StockMinimo);
            txtObservaciones.Text = Convert.ToString(articulo.Observaciones);
            ckEstado.Checked = articulo.Estado == 1;
        }

        private void CargaInicial()
        {
            CargaMarcas();
            CargaRubros();
            CargaProveedores();
            CargaUnidades();
            //txtCostoInicial.Text = "0";
            //txtDesc1.Text = "0";
            //txtDescPorc1.Text = "0";
            //txtDesc2.Text = "0";
            //txtDescPorc2.Text = "0";
            //txtDesc3.Text = "0";
            //txtDescPorc3.Text = "0";
            //txtCosto.Text = "0";
            //
            //txtLista1.Text = "0";
            //txtListaPorc1.Text = "0";
            //txtLista2.Text = "0";
            //txtListaPorc2.Text = "0";
            //txtLista3.Text = "0";
            //txtListaPorc3.Text = "0";

            txtIVA.Text = "0";
            txtStock.Text = "0";
            txtStockMinimo.Text = "0";
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
                if (!string.IsNullOrEmpty(txtObservaciones.Text.Trim()))
                {
                    return txtObservaciones.Text.Trim();
                }
                else
                {
                    return "";
                }
                
            }
        }

        public decimal Stock
        {
            get
            {
                if (!string.IsNullOrEmpty(txtStock.Text.Trim()))
                {
                    return Convert.ToDecimal(txtStock.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal StockMinimo
        {
            get
            {
                if (!string.IsNullOrEmpty(txtStockMinimo.Text.Trim()))
                {
                    return Convert.ToDecimal(txtStockMinimo.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal IVA
        {
            get
            {
                if (!string.IsNullOrEmpty(txtIVA.Text.Trim()))
                {
                    return Convert.ToDecimal(txtIVA.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Lista3
        {
            get
            {
                if (!string.IsNullOrEmpty(txtLista3.Text.Trim()))
                {
                    return Convert.ToDecimal(txtLista3.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal ListaPorc3
        {
            get
            {
                if (!string.IsNullOrEmpty(txtListaPorc3.Text.Trim()))
                {
                    return Convert.ToDecimal(txtListaPorc3.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Lista2
        {
            get
            {
                if (!string.IsNullOrEmpty(txtLista2.Text.Trim()))
                {
                    return Convert.ToDecimal(txtLista2.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal ListaPorc2
        {
            get
            {
                if (!string.IsNullOrEmpty(txtListaPorc2.Text.Trim()))
                {
                    return Convert.ToDecimal(txtListaPorc2.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Lista1
        {
            get
            {
                if (!string.IsNullOrEmpty(txtLista1.Text.Trim()))
                {
                    return Convert.ToDecimal(txtLista1.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal ListaPorc1
        {
            get
            {
                if (!string.IsNullOrEmpty(txtListaPorc1.Text.Trim()))
                {
                    return Convert.ToDecimal(txtListaPorc1.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Costo
        {
            get
            {
                if (!string.IsNullOrEmpty(txtCosto.Text.Trim()))
                {
                    return Convert.ToDecimal(txtCosto.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Descuento3
        {
            get
            {
                if (!string.IsNullOrEmpty(txtDesc3.Text.Trim()))
                {
                    return Convert.ToDecimal(txtDesc3.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal DescuentoPorc3
        {
            get
            {
                if (!string.IsNullOrEmpty(txtDescPorc3.Text.Trim()))
                {
                    return Convert.ToDecimal(txtDescPorc3.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Descuento2
        {
            get
            {
                if (!string.IsNullOrEmpty(txtDesc2.Text.Trim()))
                {
                    return Convert.ToDecimal(txtDesc2.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal DescuentoPorc2
        {
            get
            {
                if (!string.IsNullOrEmpty(txtDescPorc2.Text.Trim()))
                {
                    return Convert.ToDecimal(txtDescPorc2.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal Descuento1
        {
            get
            {
                if (!string.IsNullOrEmpty(txtDesc1.Text.Trim()))
                {
                    return Convert.ToDecimal(txtDesc1.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal DescuentoPorc1
        {
            get
            {
                if (!string.IsNullOrEmpty(txtDescPorc1.Text.Trim()))
                {
                    return Convert.ToDecimal(txtDescPorc1.Text.Trim());
                }
                else
                {
                    return 0;
                }
            }
        }

        public decimal CostoInicial
        {
            get
            {
                if (!string.IsNullOrEmpty(txtCostoInicial.Text.Trim()))
                {
                    return Convert.ToDecimal(txtCostoInicial.Text.Trim());
                }
                else
                {
                    return 0;
                }
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

        private void CalcularCostoArticuloPorcentaje()
        {
            if (String.IsNullOrEmpty(txtCostoInicial.Text)) return;

            if (_validator.ControlVaciosPorCalculos(txtCostoInicial, txtDescPorc1))
            {
                txtDesc1.Text =
                (
                    Math.Round(
                        (Convert.ToDecimal(txtDescPorc1.Text) / 100) *
                        (Convert.ToDecimal(txtCostoInicial.Text))
                    , 2)
                ).ToString();
            }

            if (_validator.ControlVaciosPorCalculos(txtDescPorc2, txtDesc1))
            {
                txtDesc2.Text =
                (
                    Math.Round(
                        (Convert.ToDecimal(txtDescPorc2.Text) / 100) *
                        (Convert.ToDecimal(txtDesc1.Text))
                    , 2)
                ).ToString();
            }

            if (_validator.ControlVaciosPorCalculos(txtDescPorc3, txtDesc2))
            {
                txtDesc3.Text =
                (
                    Math.Round(
                        (Convert.ToDecimal(txtDescPorc3.Text) / 100) *
                        (Convert.ToDecimal(txtDesc2.Text))
                    , 2)
                ).ToString();
            }

            CalcularCosto();
        }

        private void CalcularCosto()
        {
            _costoInicial = 0;
            _descuento1 = 0;
            _descuento2 = 0;
            _descuento3 = 0;
            _costo = 0;

            if (_validator.ControlVacio(txtCostoInicial))
            {
                _costoInicial = Convert.ToDecimal(txtCostoInicial.Text);
            }

            if (_validator.ControlVacio(txtDesc1))
            {
                _descuento1 = Convert.ToDecimal(txtDesc1.Text);
            }

            if (_validator.ControlVacio(txtDesc2))
            {
                _descuento2 = Convert.ToDecimal(txtDesc2.Text);
            }

            if (_validator.ControlVacio(txtDesc3))
            {
                _descuento3 = Convert.ToDecimal(txtDesc3.Text);
            }

            txtCosto.Text =
                (
                    Math.Round(
                        _costo = _costoInicial - _descuento1 - _descuento2 - _descuento3
                    , 2)
                ).ToString();
        }

        private void txtDescPorc1_TextChanged(object sender, EventArgs e)
        {
            CalcularCostoArticuloPorcentaje();
        }

        private void txtDescPorc2_TextChanged(object sender, EventArgs e)
        {
            CalcularCostoArticuloPorcentaje();
        }

        private void txtDescPorc3_TextChanged(object sender, EventArgs e)
        {
            CalcularCostoArticuloPorcentaje();
        }

        private void CalcularCostoArticulo()
        {
            if (String.IsNullOrEmpty(txtCostoInicial.Text)) return;

            if (_validator.ControlVaciosPorCalculos(txtCostoInicial, txtDesc1))
            {
                txtDescPorc1.Text =
                (
                    Math.Round(
                        (Convert.ToDecimal(txtDesc1.Text) * 100) /
                        (Convert.ToDecimal(txtCostoInicial.Text))
                        , 2)
                ).ToString();
            }

            if (_validator.ControlVaciosPorCalculos(txtDesc2, txtDesc1))
            {
                txtDescPorc2.Text =
                (
                    Math.Round(
                        (Convert.ToDecimal(txtDesc2.Text) * 100) /
                        (Convert.ToDecimal(txtDesc1.Text))
                        , 2)
                ).ToString();
            }

            if (_validator.ControlVaciosPorCalculos(txtDesc3, txtDesc2))
            {
                txtDescPorc3.Text =
                (
                    Math.Round(
                        (Convert.ToDecimal(txtDesc3.Text) * 100) /
                        (Convert.ToDecimal(txtDesc2.Text))
                        , 2)
                ).ToString();
            }

            CalcularCosto();
        }

        private void txtDesc1_TextChanged(object sender, EventArgs e)
        {
            CalcularCostoArticulo();
        }

        private void txtDesc2_TextChanged(object sender, EventArgs e)
        {
            CalcularCostoArticulo();
        }

        private void txtDesc3_TextChanged(object sender, EventArgs e)
        {
            CalcularCostoArticulo();
        }

        private void txtCostoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtDescPorc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtDesc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtDescPorc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtDesc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtDescPorc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtDesc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtListaPorc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtLista1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtListaPorc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtLista2_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtListaPorc3_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtLista3_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            _validator.IngresaDecimal(sender, e);
        }

        private void calcularPreciosPorcentaje()
        {
            decimal costo = 0;
            if (!String.IsNullOrEmpty(txtCosto.Text))
            {
                costo = Convert.ToDecimal(txtCosto.Text.Trim());
            }
            else
            {
                return;
            }

            if (_validator.ControlVaciosPorCalculos(txtCosto, txtListaPorc1))
            {
                txtLista1.Text =
                (
                Math.Round(
                        Convert.ToDecimal(txtCosto.Text)    +
                        (Convert.ToDecimal(txtListaPorc1.Text)  * Convert.ToDecimal(txtCosto.Text)
                        ) / 100

                    //((Convert.ToDecimal(txtCosto.Text) / 100) *
                    //(Convert.ToDecimal(txtListaPorc1.Text)))
                    , 2)
                ).ToString();
            }

            if (_validator.ControlVaciosPorCalculos(txtCosto, txtListaPorc2))
            {
                txtLista2.Text =
                (
                    Math.Round(
                        Convert.ToDecimal(txtCosto.Text) +
                        ((Convert.ToDecimal(txtCosto.Text) / 100) *
                        (Convert.ToDecimal(txtListaPorc2.Text)))
                    , 2)
                ).ToString();
            }

            if (_validator.ControlVaciosPorCalculos(txtCosto, txtListaPorc3))
            {
                txtLista3.Text =
                (
                    Math.Round(
                        Convert.ToDecimal(txtCosto.Text) +
                        ((Convert.ToDecimal(txtCosto.Text) / 100) *
                        (Convert.ToDecimal(txtListaPorc3.Text)))
                    , 2)
                ).ToString();
            }
        }

        private void calcularPrecios()
        {
            if (String.IsNullOrEmpty(txtCosto.Text)) return;
            //if (!String.IsNullOrEmpty(txtListaPorc1.Text)) return;

            if (_validator.ControlVaciosPorCalculos(txtCosto, txtLista1))
            {
                txtListaPorc1.Text =
                (
                    Math.Round(
                        //Convert.ToDecimal(txtCosto.Text) +
                        //((Convert.ToDecimal(txtLista1.Text) * 100) /
                        //(Convert.ToDecimal(txtCosto.Text)))
                        ((Convert.ToDecimal(txtLista1.Text) - Convert.ToDecimal(txtCosto.Text)) * 100) /
                        Convert.ToDecimal(txtCosto.Text)
                    , 2)
                ).ToString();
            }

            if (_validator.ControlVaciosPorCalculos(txtCosto, txtLista2))
            {
                txtListaPorc2.Text =
                (
                    Math.Round(
                        ((Convert.ToDecimal(txtLista2.Text) - Convert.ToDecimal(txtCosto.Text)) * 100) /
                        Convert.ToDecimal(txtCosto.Text)
                    , 2)
                ).ToString();
            }

            if (_validator.ControlVaciosPorCalculos(txtCosto, txtLista3))
            {
                txtListaPorc3.Text =
                (
                    Math.Round(
                        ((Convert.ToDecimal(txtLista3.Text) - Convert.ToDecimal(txtCosto.Text)) * 100) /
                        Convert.ToDecimal(txtCosto.Text)
                    , 2)
                ).ToString();
            }

            return;
        }

        private void txtListaPorc2_TextChanged(object sender, EventArgs e)
        {
            calcularPreciosPorcentaje();
        }

        private void txtListaPorc3_TextChanged(object sender, EventArgs e)
        {
            calcularPreciosPorcentaje();
        }

        private void txtLista1_TextChanged(object sender, EventArgs e)
        {
            calcularPrecios();
        }

        private void txtLista2_TextChanged(object sender, EventArgs e)
        {
            calcularPrecios();
        }

        private void txtLista3_TextChanged(object sender, EventArgs e)
        {
            calcularPrecios();
        }

        private void txtListaPorc1_TextChanged(object sender, EventArgs e)
        {
            calcularPreciosPorcentaje();
        }
    }
}
