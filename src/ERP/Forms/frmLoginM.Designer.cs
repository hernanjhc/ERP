namespace ERP.Forms
{
    partial class frmLoginM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mtxtContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mtxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtxtContraseña
            // 
            this.mtxtContraseña.Depth = 0;
            this.mtxtContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtxtContraseña.Hint = "";
            this.mtxtContraseña.Location = new System.Drawing.Point(8, 61);
            this.mtxtContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtContraseña.Name = "mtxtContraseña";
            this.mtxtContraseña.PasswordChar = '*';
            this.mtxtContraseña.SelectedText = "";
            this.mtxtContraseña.SelectionLength = 0;
            this.mtxtContraseña.SelectionStart = 0;
            this.mtxtContraseña.Size = new System.Drawing.Size(261, 23);
            this.mtxtContraseña.TabIndex = 1;
            this.mtxtContraseña.Text = "Contraseña";
            this.mtxtContraseña.UseSystemPasswordChar = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(35, 12);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.Size = new System.Drawing.Size(223, 32);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAceptar_KeyDown);
            // 
            // mtxtUsuario
            // 
            this.mtxtUsuario.Depth = 0;
            this.mtxtUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtxtUsuario.Hint = "";
            this.mtxtUsuario.Location = new System.Drawing.Point(8, 13);
            this.mtxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtUsuario.Name = "mtxtUsuario";
            this.mtxtUsuario.PasswordChar = '\0';
            this.mtxtUsuario.SelectedText = "";
            this.mtxtUsuario.SelectionLength = 0;
            this.mtxtUsuario.SelectionStart = 0;
            this.mtxtUsuario.Size = new System.Drawing.Size(261, 23);
            this.mtxtUsuario.TabIndex = 0;
            this.mtxtUsuario.Text = "usuario";
            this.mtxtUsuario.UseSystemPasswordChar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.39005F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.60996F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 181);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtxtUsuario);
            this.panel1.Controls.Add(this.mtxtContraseña);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 114);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 55);
            this.panel2.TabIndex = 1;
            // 
            // frmLoginM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 247);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenidos!";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtContraseña;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private MaterialSkin.Controls.MaterialSingleLineTextField mtxtUsuario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}