using CustomLibrary.Lib.Extensions;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System;

namespace ERP.Lib.Validations
{
    public class FormValidations
    {
        private ErrorProvider _errorProvider;
        private Form _parent;

        public FormValidations(Form parent, ErrorProvider errorProvider)
        {
            this._errorProvider = errorProvider;
            this._parent = parent;
        }

        public FormValidations(MaterialForm parentM, ErrorProvider errorProvider)
        {
            this._errorProvider = errorProvider;
            this._parent = parentM;
        }

        public bool Validar(TextBox txt, bool condición, string error)
        {
            bool result = true;
            if (!condición)
            {
                _errorProvider.SetError(txt, error);
                new ToolTip().ShowError(_parent, txt, error);
                result = false;
            }
            else
            {
                _errorProvider.SetError(txt, "");
            }
            return result;
        }

        public bool ValidarMaterial(bool condición, string error)
        {
            bool result = true;
            if (!condición)
            {
                MessageBox.Show(error, "SGO - Sistemas",   MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = false;
            }
            return result;
        }

        public bool ControlVaciosPorCalculos(MaterialSingleLineTextField txt1, MaterialSkin.Controls.MaterialSingleLineTextField txt2)
        {
            if (
                    String.IsNullOrEmpty(txt1.Text.Trim()) |
                    String.IsNullOrEmpty(txt2.Text.Trim()) |
                    txt1.Text.Trim() == "," |        //.Contains(",")
                    txt2.Text.Trim() == ","
                )
            {
                return false;
            }
            return true;
        }

        public bool ControlVacio(MaterialSingleLineTextField txt1)
        {
            if (
                    String.IsNullOrEmpty(txt1.Text) |
                    txt1.Text.Trim() == ","
                )
            {
                return false;
            }
            return true;
        }

        public void IngresaDecimal(object sender, KeyPressEventArgs e)
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

    }
}
