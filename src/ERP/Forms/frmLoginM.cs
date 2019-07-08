using ERP.Lib;
using ERP.Lib.Validations;
using ERP.Repositories;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Forms
{
    
    public partial class frmLoginM : MaterialSkin.Controls.MaterialForm
    {
        private FormValidations _validator;

        public frmLoginM()
        {
            InitializeComponent();

            //color form
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, Accent.Orange700, MaterialSkin.TextShade.WHITE);
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Cyan700, MaterialSkin.Primary.Cyan700, MaterialSkin.Primary.Blue500, Accent.LightBlue400, MaterialSkin.TextShade.WHITE);

            _validator = new FormValidations(this, errorProvider1);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var repo = new UsuariosRepository();
            if (_validator.ValidarMaterial(repo.VerificarLoginUsuario(mtxtUsuario.Text, mtxtContraseña.Text),
                "El usuario o la contraseña son incorrectos"))
            {
                Session.CurrentUser = repo.ObtenerUsuario(mtxtUsuario.Text);
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.None;
        }

        private void btnAceptar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
