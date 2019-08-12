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

            definirMinimosMaximos();
            lblCosto.Visible = false;
        }

        private void definirMinimosMaximos()
        {
            txtDescPorc1.Minimum = 0;
            txtDescPorc1.Maximum = 100;

            txtDescPorc2.Minimum = 0;
            txtDescPorc2.Maximum = 100;

            txtDescPorc3.Minimum = 0;
            txtDescPorc3.Maximum = 100;

            txtIVA.Minimum = 0;
            txtIVA.Maximum = 21;

            txtStock.Minimum = 0;

            txtStockMinimo.Minimum = 0;

            txtLista1.Maximum = 100000;
            txtLista2.Maximum = 100000;
            txtLista3.Maximum = 100000;

            txtListaPorc1.Maximum = 1000;
            txtListaPorc2.Maximum = 1000;
            txtListaPorc3.Maximum = 1000;
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
            //txtCostoInicial2.Text = Convert.ToString(articulo.CostoInicial);
            txtCostoInicial.Value = articulo.CostoInicial.Value;
            txtDescPorc1.Value = articulo.DescuentoPorc1.Value;
            txtDesc1.Value = articulo.Descuento1.Value;
            txtDescPorc2.Value = articulo.DescuentoPorc2.Value;
            txtDesc2.Value = articulo.Descuento2.Value;
            txtDescPorc3.Value = articulo.DescuentoPorc3.Value;
            txtDesc3.Value = articulo.Descuento3.Value;
            txtCosto.Value = articulo.Costo;

            txtListaPorc1.Value = articulo.PrecioPorcL1.Value;
            txtLista1.Value= articulo.PrecioL1.Value;
            txtListaPorc2.Value = articulo.PrecioPorcL2.Value;
            txtLista2.Value = articulo.PrecioL2.Value;
            txtListaPorc3.Value = articulo.PrecioPorcL3.Value;
            txtLista3.Value = articulo.PrecioL3.Value;

            txtIVA.Value = articulo.IVA.Value;
            txtStock.Value = articulo.Stock.Value;
            txtStockMinimo.Value = articulo.StockMinimo;

            txtObservaciones.Text = Convert.ToString(articulo.Observaciones);
            ckEstado.Checked = articulo.Estado == 1;
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
                //if (!string.IsNullOrEmpty(txtStock.Text.Trim()))
                //{
                //    return Convert.ToDecimal(txtStock.Text.Trim());
                //}
                //else
                //{
                //    return 0;
                //}
                return txtStock.Value;
            }
        }

        public decimal StockMinimo
        {
            get
            {
                return txtStockMinimo.Value;
            }
        }

        public decimal IVA
        {
            get
            {
                return txtIVA.Value;
            }
        }

        public decimal Lista3
        {
            get
            {
                return txtLista3.Value;
            }
        }

        public decimal ListaPorc3
        {
            get
            {
                return txtListaPorc3.Value;
            }
        }

        public decimal Lista2
        {
            get
            {
                return txtLista2.Value;
            }
        }

        public decimal ListaPorc2
        {
            get
            {
                return txtListaPorc2.Value;
            }
        }

        public decimal Lista1
        {
            get
            {
                return txtLista1.Value;
            }
        }

        public decimal ListaPorc1
        {
            get
            {
                return txtListaPorc1.Value;
            }
        }

        public decimal Costo
        {
            get
            {
                return txtCosto.Value;
            }
        }

        public decimal Descuento3
        {
            get
            {
                return txtDesc3.Value;
            }
        }

        public decimal DescuentoPorc3
        {
            get
            {
                return txtDescPorc3.Value;
            }
        }

        public decimal Descuento2
        {
            get
            {
                return txtDesc2.Value;
            }
        }

        public decimal DescuentoPorc2
        {
            get
            {
                return txtDescPorc2.Value;
            }
        }

        public decimal Descuento1
        {
            get
            {
                return txtDesc1.Value;
            }
        }

        public decimal DescuentoPorc1
        {
            get
            {
                return txtDescPorc1.Value;
            }
        }

        public decimal CostoInicial
        {
            get
            {
                return txtCostoInicial.Value;
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

        private void CalcularCostoArticuloPorcentaje(NumericUpDown desc)
        {
            //if (String.IsNullOrEmpty(txtCostoInicial2.Text)) return;
            if (txtCostoInicial.Value == 0) return;
            //if (_validator.ControlVaciosPorCalculos(txtCostoInicial2, txtDescPorc12))
            //{
            //    txtDesc12.Text =
            //    (
            //        Math.Round(
            //            (Convert.ToDecimal(txtDescPorc12.Text) / 100) *
            //            (Convert.ToDecimal(txtCostoInicial2.Text))
            //        , 2)
            //    ).ToString();
            //}
            if(desc == txtDescPorc1) txtDesc1.Value = (txtDescPorc1.Value / 100) * txtCostoInicial.Value;

            if (desc == txtDescPorc2) txtDesc2.Value = (txtDescPorc2.Value / 100) * txtCosto.Value;

            if (desc == txtDescPorc3) txtDesc3.Value = (txtDescPorc3.Value / 100) * txtCosto.Value;

            CalcularCosto();
        }

        private void CalcularCosto()
        {
            _costoInicial = 0;
            _descuento1 = 0;
            _descuento2 = 0;
            _descuento3 = 0;
            _costo = 0;

            //if (_validator.ControlVacio(txtCostoInicial2))
            //{
            //    _costoInicial = Convert.ToDecimal(txtCostoInicial2.Text);
            //}

            _costoInicial = txtCostoInicial.Value;
            _descuento1 = txtDesc1.Value;
            _descuento2 = txtDesc2.Value;
            _descuento3 = txtDesc3.Value;
            _costo = _costoInicial - _descuento1 - _descuento2 - _descuento3;

            if (_costo >= 0)
            {
                lblCosto.Visible = false;
                txtCosto.Value = _costo;
            }
            else
            {
                lblCosto.Visible = true;
                txtCosto.Value = 0;
            }
        }

        

        private void CalcularCostoArticulo(NumericUpDown desc)
        {
            //if (String.IsNullOrEmpty(txtCostoInicial2.Text)) return;
            if (txtCostoInicial.Value <= 0 | txtCosto.Value <= 0) return;

            //if (_validator.ControlVaciosPorCalculos(txtCostoInicial2, txtDesc12))
            //{
            //    txtDescPorc12.Text =
            //    (
            //        Math.Round(
            //            (Convert.ToDecimal(txtDesc12.Text) * 100) /
            //            (Convert.ToDecimal(txtCostoInicial2.Text))
            //            , 2)
            //    ).ToString();
            //}

            if (desc == txtDesc1 ) txtDescPorc1.Value = (txtDesc1.Value * 100) / txtCostoInicial.Value;

            if (desc == txtDesc2 & txtDesc2.Value > 0) txtDescPorc2.Value = (txtDesc2.Value * 100) / txtCosto.Value;

            if (desc == txtDesc3 & txtDesc3.Value > 0) txtDescPorc3.Value = (txtDesc3.Value * 100) / txtCosto.Value;

            CalcularCosto();
        }

        private void calcularPreciosPorcentaje()
        {
            if (txtCosto.Value <= 0) return;
            decimal costo = 0;
            costo = txtCosto.Value;

            txtLista1.Value =   txtCosto.Value +
                        (txtListaPorc1.Value * txtCosto.Value) / 100;
                        
            txtLista2.Value =   txtCosto.Value +
                        (txtListaPorc2.Value * txtCosto.Value) / 100;

            txtLista3.Value = txtCosto.Value +
                        (txtListaPorc3.Value * txtCosto.Value) / 100;
        }

        private void calcularPrecios()
        {
            //((Convert.ToDecimal(txtLista1.Text) - Convert.ToDecimal(txtCosto.Text)) * 100) /
            //Convert.ToDecimal(txtCosto.Text)

            if (txtCosto.Value <= 0) return;

            if((txtLista1.Value - txtCosto.Value) > 0)
            {
                txtListaPorc1.Value =
                ((txtLista1.Value - txtCosto.Value) * 100) /
                txtCosto.Value;
            }
            if ((txtLista2.Value - txtCosto.Value) > 0)
            {
                txtListaPorc2.Value =
                ((txtLista2.Value - txtCosto.Value) * 100) /
                txtCosto.Value;
            }
                
            if ((txtLista3.Value - txtCosto.Value) > 0)
            {
                txtListaPorc3.Value =
                ((txtLista3.Value - txtCosto.Value) * 100) /
                txtCosto.Value;
            }
            

            //return;
        }

        private void txtDescPorc1_ValueChanged(object sender, EventArgs e)
        {
            CalcularCostoArticuloPorcentaje(txtDescPorc1);
        }

        private void txtDescPorc2_ValueChanged(object sender, EventArgs e)
        {
            CalcularCostoArticuloPorcentaje(txtDescPorc2);
        }

        private void txtDescPorc3_ValueChanged(object sender, EventArgs e)
        {
            CalcularCostoArticuloPorcentaje(txtDescPorc3);
        }

        private void txtDesc1_ValueChanged(object sender, EventArgs e)
        {
            CalcularCostoArticulo(txtDesc1);
        }

        private void txtDesc2_ValueChanged(object sender, EventArgs e)
        {
            CalcularCostoArticulo(txtDesc2);
        }

        private void txtDesc3_ValueChanged(object sender, EventArgs e)
        {
            CalcularCostoArticulo(txtDesc3);
        }

        private void txtListaPorc1_ValueChanged(object sender, EventArgs e)
        {
            calcularPreciosPorcentaje();
        }

        private void txtListaPorc2_ValueChanged(object sender, EventArgs e)
        {
            calcularPreciosPorcentaje();
        }

        private void txtListaPorc3_ValueChanged(object sender, EventArgs e)
        {
            calcularPreciosPorcentaje();
        }

        private void txtLista1_ValueChanged(object sender, EventArgs e)
        {
            calcularPrecios();
        }

        private void txtLista2_ValueChanged(object sender, EventArgs e)
        {
            calcularPrecios();
        }

        private void txtLista3_ValueChanged(object sender, EventArgs e)
        {
            calcularPrecios();
        }

        private void txtCostoInicial_ValueChanged(object sender, EventArgs e)
        {
            //Si actualiza costo inicial. Se mueve Costo Final
            txtCosto.Value = txtCostoInicial.Value;
        }
    }
}
