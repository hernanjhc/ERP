using ERP.Lib.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace ERP.Lib.AppForms
{
    public class FormBase : MaterialSkin.Controls.MaterialForm// : Form
    {
        protected FormValidations _validator;

        protected FormBase()
        {
        //    FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            //Icon = Properties.Resources.app2;

            //color form
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, Accent.Orange700, MaterialSkin.TextShade.WHITE);
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Cyan700, MaterialSkin.Primary.Cyan700, MaterialSkin.Primary.Blue500, Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

        }

        protected void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected void ShowError(string message, Exception ex)
        {
            string error = ex.Message;
            while (error.Contains("inner exception"))
            {
                if (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                    error = ex.Message;
                }
                else
                {
                    break;
                }
            }
            ShowError(message + error);
        }
    }
}
