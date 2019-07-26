namespace ERP.Forms.Ventas
{
    partial class frmEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdicion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtVentaNro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtVendedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCuit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLocalidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescuentoPesos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescuentoPorc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtsubtotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvDatos = new CustomLibrary.ComponentModel.CustomDataGridView();
            this.rbDescripcion = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCodigo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnArticuloNuevo = new System.Windows.Forms.Button();
            this.cbArticulos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarPresupuesto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAceptar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.9483F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.0517F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 685);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.txtVentaNro);
            this.gbCliente.Controls.Add(this.materialLabel5);
            this.gbCliente.Controls.Add(this.materialDivider1);
            this.gbCliente.Controls.Add(this.txtVendedor);
            this.gbCliente.Controls.Add(this.txtCuit);
            this.gbCliente.Controls.Add(this.materialLabel9);
            this.gbCliente.Controls.Add(this.materialLabel11);
            this.gbCliente.Controls.Add(this.txtLocalidad);
            this.gbCliente.Controls.Add(this.materialLabel10);
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Controls.Add(this.materialLabel4);
            this.gbCliente.Controls.Add(this.btnNuevoCliente);
            this.gbCliente.Controls.Add(this.cbCliente);
            this.gbCliente.Controls.Add(this.materialLabel3);
            this.gbCliente.Controls.Add(this.cbLista);
            this.gbCliente.Controls.Add(this.materialLabel2);
            this.gbCliente.Controls.Add(this.dtpFecha);
            this.gbCliente.Controls.Add(this.materialLabel1);
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(4, 4);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(788, 166);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "General";
            // 
            // txtVentaNro
            // 
            this.txtVentaNro.Depth = 0;
            this.txtVentaNro.Enabled = false;
            this.txtVentaNro.Hint = "";
            this.txtVentaNro.Location = new System.Drawing.Point(87, 73);
            this.txtVentaNro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVentaNro.Name = "txtVentaNro";
            this.txtVentaNro.PasswordChar = '\0';
            this.txtVentaNro.SelectedText = "";
            this.txtVentaNro.SelectionLength = 0;
            this.txtVentaNro.SelectionStart = 0;
            this.txtVentaNro.Size = new System.Drawing.Size(95, 23);
            this.txtVentaNro.TabIndex = 21;
            this.txtVentaNro.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(4, 77);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(74, 19);
            this.materialLabel5.TabIndex = 23;
            this.materialLabel5.Text = "Venta Nº:";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Teal;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(385, 13);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 140);
            this.materialDivider1.TabIndex = 22;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Depth = 0;
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Hint = "";
            this.txtVendedor.Location = new System.Drawing.Point(87, 28);
            this.txtVendedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.PasswordChar = '\0';
            this.txtVendedor.SelectedText = "";
            this.txtVendedor.SelectionLength = 0;
            this.txtVendedor.SelectionStart = 0;
            this.txtVendedor.Size = new System.Drawing.Size(174, 23);
            this.txtVendedor.TabIndex = 20;
            this.txtVendedor.UseSystemPasswordChar = false;
            // 
            // txtCuit
            // 
            this.txtCuit.Depth = 0;
            this.txtCuit.Enabled = false;
            this.txtCuit.Hint = "";
            this.txtCuit.Location = new System.Drawing.Point(528, 111);
            this.txtCuit.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.PasswordChar = '\0';
            this.txtCuit.SelectedText = "";
            this.txtCuit.SelectionLength = 0;
            this.txtCuit.SelectionStart = 0;
            this.txtCuit.Size = new System.Drawing.Size(247, 23);
            this.txtCuit.TabIndex = 24;
            this.txtCuit.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(4, 32);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(77, 19);
            this.materialLabel9.TabIndex = 11;
            this.materialLabel9.Text = "Vendedor:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(412, 115);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(77, 19);
            this.materialLabel11.TabIndex = 13;
            this.materialLabel11.Text = "CUIT/DNI:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Depth = 0;
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.Hint = "";
            this.txtLocalidad.Location = new System.Drawing.Point(528, 82);
            this.txtLocalidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.PasswordChar = '\0';
            this.txtLocalidad.SelectedText = "";
            this.txtLocalidad.SelectionLength = 0;
            this.txtLocalidad.SelectionStart = 0;
            this.txtLocalidad.Size = new System.Drawing.Size(247, 23);
            this.txtLocalidad.TabIndex = 23;
            this.txtLocalidad.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(412, 86);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(78, 19);
            this.materialLabel10.TabIndex = 11;
            this.materialLabel10.Text = "Localidad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(528, 53);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(247, 23);
            this.txtDireccion.TabIndex = 22;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(412, 57);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Dirección:";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.Image")));
            this.btnNuevoCliente.Location = new System.Drawing.Point(744, 26);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(31, 25);
            this.btnNuevoCliente.TabIndex = 6;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(528, 28);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(214, 21);
            this.cbCliente.TabIndex = 2;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(412, 32);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Cliente:";
            // 
            // cbLista
            // 
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Location = new System.Drawing.Point(87, 118);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(107, 21);
            this.cbLista.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 120);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Lista:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(257, 77);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(107, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(202, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescuentoPesos);
            this.groupBox2.Controls.Add(this.materialLabel15);
            this.groupBox2.Controls.Add(this.txtDescuentoPorc);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.txtsubtotal);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.dgvDatos);
            this.groupBox2.Controls.Add(this.rbDescripcion);
            this.groupBox2.Controls.Add(this.rbCodigo);
            this.groupBox2.Controls.Add(this.btnArticuloNuevo);
            this.groupBox2.Controls.Add(this.cbArticulos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 439);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Conceptos";
            // 
            // txtDescuentoPesos
            // 
            this.txtDescuentoPesos.Depth = 0;
            this.txtDescuentoPesos.Enabled = false;
            this.txtDescuentoPesos.Hint = "";
            this.txtDescuentoPesos.Location = new System.Drawing.Point(648, 374);
            this.txtDescuentoPesos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuentoPesos.Name = "txtDescuentoPesos";
            this.txtDescuentoPesos.PasswordChar = '\0';
            this.txtDescuentoPesos.SelectedText = "";
            this.txtDescuentoPesos.SelectionLength = 0;
            this.txtDescuentoPesos.SelectionStart = 0;
            this.txtDescuentoPesos.Size = new System.Drawing.Size(129, 23);
            this.txtDescuentoPesos.TabIndex = 19;
            this.txtDescuentoPesos.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(549, 378);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(93, 19);
            this.materialLabel15.TabIndex = 18;
            this.materialLabel15.Text = "Descuento $";
            // 
            // txtDescuentoPorc
            // 
            this.txtDescuentoPorc.Depth = 0;
            this.txtDescuentoPorc.Hint = "";
            this.txtDescuentoPorc.Location = new System.Drawing.Point(451, 373);
            this.txtDescuentoPorc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuentoPorc.Name = "txtDescuentoPorc";
            this.txtDescuentoPorc.PasswordChar = '\0';
            this.txtDescuentoPorc.SelectedText = "";
            this.txtDescuentoPorc.SelectionLength = 0;
            this.txtDescuentoPorc.SelectionStart = 0;
            this.txtDescuentoPorc.Size = new System.Drawing.Size(51, 23);
            this.txtDescuentoPorc.TabIndex = 5;
            this.txtDescuentoPorc.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(349, 378);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(96, 19);
            this.materialLabel8.TabIndex = 16;
            this.materialLabel8.Text = "Descuento %";
            // 
            // txtTotal
            // 
            this.txtTotal.Depth = 0;
            this.txtTotal.Enabled = false;
            this.txtTotal.Hint = "";
            this.txtTotal.Location = new System.Drawing.Point(649, 403);
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(129, 23);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(583, 408);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(60, 18);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "Total $";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Depth = 0;
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Hint = "";
            this.txtsubtotal.Location = new System.Drawing.Point(649, 345);
            this.txtsubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.PasswordChar = '\0';
            this.txtsubtotal.SelectedText = "";
            this.txtsubtotal.SelectionLength = 0;
            this.txtsubtotal.SelectionStart = 0;
            this.txtsubtotal.Size = new System.Drawing.Size(129, 23);
            this.txtsubtotal.TabIndex = 13;
            this.txtsubtotal.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(554, 350);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(85, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Sub Total $";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.EvenRowColor = System.Drawing.Color.Empty;
            this.dgvDatos.Location = new System.Drawing.Point(0, 79);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.OddRowColor = System.Drawing.Color.AliceBlue;
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(788, 260);
            this.dgvDatos.TabIndex = 11;
            // 
            // rbDescripcion
            // 
            this.rbDescripcion.AutoSize = true;
            this.rbDescripcion.Depth = 0;
            this.rbDescripcion.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDescripcion.Location = new System.Drawing.Point(8, 46);
            this.rbDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.rbDescripcion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDescripcion.Name = "rbDescripcion";
            this.rbDescripcion.Ripple = true;
            this.rbDescripcion.Size = new System.Drawing.Size(102, 30);
            this.rbDescripcion.TabIndex = 26;
            this.rbDescripcion.TabStop = true;
            this.rbDescripcion.Text = "Descripción";
            this.rbDescripcion.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Depth = 0;
            this.rbCodigo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbCodigo.Location = new System.Drawing.Point(8, 16);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.rbCodigo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Ripple = true;
            this.rbCodigo.Size = new System.Drawing.Size(73, 30);
            this.rbCodigo.TabIndex = 25;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // btnArticuloNuevo
            // 
            this.btnArticuloNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnArticuloNuevo.Image")));
            this.btnArticuloNuevo.Location = new System.Drawing.Point(377, 31);
            this.btnArticuloNuevo.Name = "btnArticuloNuevo";
            this.btnArticuloNuevo.Size = new System.Drawing.Size(31, 25);
            this.btnArticuloNuevo.TabIndex = 4;
            this.btnArticuloNuevo.UseVisualStyleBackColor = true;
            // 
            // cbArticulos
            // 
            this.cbArticulos.FormattingEnabled = true;
            this.cbArticulos.Location = new System.Drawing.Point(127, 33);
            this.cbArticulos.Name = "cbArticulos";
            this.cbArticulos.Size = new System.Drawing.Size(244, 21);
            this.cbArticulos.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscarPresupuesto);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 58);
            this.panel1.TabIndex = 2;
            // 
            // btnBuscarPresupuesto
            // 
            this.btnBuscarPresupuesto.Depth = 0;
            this.btnBuscarPresupuesto.Location = new System.Drawing.Point(9, 7);
            this.btnBuscarPresupuesto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarPresupuesto.Name = "btnBuscarPresupuesto";
            this.btnBuscarPresupuesto.Primary = true;
            this.btnBuscarPresupuesto.Size = new System.Drawing.Size(127, 47);
            this.btnBuscarPresupuesto.TabIndex = 8;
            this.btnBuscarPresupuesto.Text = "Buscar Presupuesto";
            this.btnBuscarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(647, 13);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(124, 31);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(484, 13);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = true;
            this.btnAceptar.Size = new System.Drawing.Size(124, 31);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 748);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEdicion";
            this.Text = "frmEdicion1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVendedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCuit;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocalidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cbLista;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuentoPorc;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsubtotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private CustomLibrary.ComponentModel.CustomDataGridView dgvDatos;
        private MaterialSkin.Controls.MaterialRadioButton rbDescripcion;
        private MaterialSkin.Controls.MaterialRadioButton rbCodigo;
        private System.Windows.Forms.Button btnArticuloNuevo;
        private System.Windows.Forms.ComboBox cbArticulos;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnAceptar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuentoPesos;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarPresupuesto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVentaNro;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}