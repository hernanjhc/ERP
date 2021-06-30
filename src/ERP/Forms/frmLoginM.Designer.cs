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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginM));
            this.mtxtContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mtxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mtxtContraseña
            // 
            this.mtxtContraseña.Depth = 0;
            this.mtxtContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtxtContraseña.Hint = "Contraseña";
            this.mtxtContraseña.Location = new System.Drawing.Point(46, 175);
            this.mtxtContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtContraseña.Name = "mtxtContraseña";
            this.mtxtContraseña.PasswordChar = '*';
            this.mtxtContraseña.SelectedText = "";
            this.mtxtContraseña.SelectionLength = 0;
            this.mtxtContraseña.SelectionStart = 0;
            this.mtxtContraseña.Size = new System.Drawing.Size(249, 23);
            this.mtxtContraseña.TabIndex = 1;
            this.mtxtContraseña.UseSystemPasswordChar = false;
            this.mtxtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtxtContraseña_KeyDown);
            this.mtxtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtContraseña_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(46, 238);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.Size = new System.Drawing.Size(249, 32);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAceptar_KeyDown);
            // 
            // mtxtUsuario
            // 
            this.mtxtUsuario.Depth = 0;
            this.mtxtUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtxtUsuario.Hint = "Usuario";
            this.mtxtUsuario.Location = new System.Drawing.Point(46, 132);
            this.mtxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtxtUsuario.Name = "mtxtUsuario";
            this.mtxtUsuario.PasswordChar = '\0';
            this.mtxtUsuario.SelectedText = "";
            this.mtxtUsuario.SelectionLength = 0;
            this.mtxtUsuario.SelectionStart = 0;
            this.mtxtUsuario.Size = new System.Drawing.Size(249, 23);
            this.mtxtUsuario.TabIndex = 0;
            this.mtxtUsuario.UseSystemPasswordChar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.85714F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 351);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.mtxtUsuario);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.mtxtContraseña);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 283);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 53);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // frmLoginM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 415);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoginM";
            this.Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}