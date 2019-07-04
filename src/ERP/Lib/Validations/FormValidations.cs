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
        
        

    }
}
