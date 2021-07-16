
namespace ERP.Forms.Articulos
{
    partial class frmImportarTxt
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblModificacionesIncorrectas = new MaterialSkin.Controls.MaterialLabel();
            this.lblModificacionesCorrectas = new MaterialSkin.Controls.MaterialLabel();
            this.lblAltasIncorrectas = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAltasCorrectas = new MaterialSkin.Controls.MaterialLabel();
            this.lblFilasLeidas = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnProcesar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtArchivo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvArticulos, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.396947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.60305F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblModificacionesIncorrectas);
            this.panel2.Controls.Add(this.lblModificacionesCorrectas);
            this.panel2.Controls.Add(this.lblAltasIncorrectas);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.materialLabel3);
            this.panel2.Controls.Add(this.lblAltasCorrectas);
            this.panel2.Controls.Add(this.lblFilasLeidas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 36);
            this.panel2.TabIndex = 3;
            // 
            // lblModificacionesIncorrectas
            // 
            this.lblModificacionesIncorrectas.AutoSize = true;
            this.lblModificacionesIncorrectas.Depth = 0;
            this.lblModificacionesIncorrectas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblModificacionesIncorrectas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModificacionesIncorrectas.Location = new System.Drawing.Point(399, 6);
            this.lblModificacionesIncorrectas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModificacionesIncorrectas.Name = "lblModificacionesIncorrectas";
            this.lblModificacionesIncorrectas.Size = new System.Drawing.Size(193, 19);
            this.lblModificacionesIncorrectas.TabIndex = 13;
            this.lblModificacionesIncorrectas.Text = "Modificaciones Incorrectas";
            // 
            // lblModificacionesCorrectas
            // 
            this.lblModificacionesCorrectas.AutoSize = true;
            this.lblModificacionesCorrectas.Depth = 0;
            this.lblModificacionesCorrectas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblModificacionesCorrectas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModificacionesCorrectas.Location = new System.Drawing.Point(280, 6);
            this.lblModificacionesCorrectas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModificacionesCorrectas.Name = "lblModificacionesCorrectas";
            this.lblModificacionesCorrectas.Size = new System.Drawing.Size(113, 19);
            this.lblModificacionesCorrectas.TabIndex = 12;
            this.lblModificacionesCorrectas.Text = "Modificaciones";
            // 
            // lblAltasIncorrectas
            // 
            this.lblAltasIncorrectas.AutoSize = true;
            this.lblAltasIncorrectas.Depth = 0;
            this.lblAltasIncorrectas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAltasIncorrectas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAltasIncorrectas.Location = new System.Drawing.Point(150, 6);
            this.lblAltasIncorrectas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAltasIncorrectas.Name = "lblAltasIncorrectas";
            this.lblAltasIncorrectas.Size = new System.Drawing.Size(124, 19);
            this.lblAltasIncorrectas.TabIndex = 11;
            this.lblAltasIncorrectas.Text = "Altas Incorrectas";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Red;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(746, 7);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Error";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(627, 7);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(113, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Modificaciones";
            // 
            // lblAltasCorrectas
            // 
            this.lblAltasCorrectas.AutoSize = true;
            this.lblAltasCorrectas.Depth = 0;
            this.lblAltasCorrectas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAltasCorrectas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAltasCorrectas.Location = new System.Drawing.Point(100, 6);
            this.lblAltasCorrectas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAltasCorrectas.Name = "lblAltasCorrectas";
            this.lblAltasCorrectas.Size = new System.Drawing.Size(44, 19);
            this.lblAltasCorrectas.TabIndex = 6;
            this.lblAltasCorrectas.Text = "Altas";
            // 
            // lblFilasLeidas
            // 
            this.lblFilasLeidas.AutoSize = true;
            this.lblFilasLeidas.Depth = 0;
            this.lblFilasLeidas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFilasLeidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFilasLeidas.Location = new System.Drawing.Point(9, 6);
            this.lblFilasLeidas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFilasLeidas.Name = "lblFilasLeidas";
            this.lblFilasLeidas.Size = new System.Drawing.Size(85, 19);
            this.lblFilasLeidas.TabIndex = 4;
            this.lblFilasLeidas.Text = "Filas leídas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnProcesar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtArchivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 38);
            this.panel1.TabIndex = 1;
            // 
            // btnExportar
            // 
            this.btnExportar.Depth = 0;
            this.btnExportar.Location = new System.Drawing.Point(697, 6);
            this.btnExportar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Primary = true;
            this.btnExportar.Size = new System.Drawing.Size(88, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(459, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(88, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Depth = 0;
            this.btnProcesar.Location = new System.Drawing.Point(365, 6);
            this.btnProcesar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Primary = true;
            this.btnProcesar.Size = new System.Drawing.Size(88, 23);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(333, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(26, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Depth = 0;
            this.txtArchivo.Hint = "";
            this.txtArchivo.Location = new System.Drawing.Point(9, 7);
            this.txtArchivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.PasswordChar = '\0';
            this.txtArchivo.SelectedText = "";
            this.txtArchivo.SelectionLength = 0;
            this.txtArchivo.SelectionStart = 0;
            this.txtArchivo.Size = new System.Drawing.Size(303, 23);
            this.txtArchivo.TabIndex = 0;
            this.txtArchivo.Text = "Buscar txt con Artículos...";
            this.txtArchivo.UseSystemPasswordChar = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 47);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(794, 474);
            this.dgvArticulos.TabIndex = 2;
            this.dgvArticulos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvArticulos_DataBindingComplete);
            this.dgvArticulos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvArticulos_RowPrePaint);
            // 
            // frmImportarTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmImportarTxt";
            this.Text = "Importar TXT";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnProcesar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtArchivo;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblAltasCorrectas;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private MaterialSkin.Controls.MaterialRaisedButton btnExportar;
        private MaterialSkin.Controls.MaterialLabel lblFilasLeidas;
        private MaterialSkin.Controls.MaterialLabel lblAltasIncorrectas;
        private MaterialSkin.Controls.MaterialLabel lblModificacionesIncorrectas;
        private MaterialSkin.Controls.MaterialLabel lblModificacionesCorrectas;
    }
}