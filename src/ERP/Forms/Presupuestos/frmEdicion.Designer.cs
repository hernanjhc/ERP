namespace ERP.Forms.Presupuestos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nDias = new System.Windows.Forms.NumericUpDown();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lVendedor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPresupuestoNro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbLista = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescuentoPesos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtsubtotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvDetalles = new CustomLibrary.ComponentModel.CustomDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbDescripcion = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbCodigo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnArticuloNuevo = new System.Windows.Forms.Button();
            this.cbArticulos = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDias)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.54605F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.45395F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 668);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nDias);
            this.groupBox1.Controls.Add(this.materialLabel13);
            this.groupBox1.Controls.Add(this.materialLabel12);
            this.groupBox1.Controls.Add(this.materialDivider1);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.lVendedor);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.txtPresupuestoNro);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.btnNuevoCliente);
            this.groupBox1.Controls.Add(this.cbClientes);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.cbLista);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(859, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // nDias
            // 
            this.nDias.Location = new System.Drawing.Point(368, 77);
            this.nDias.Name = "nDias";
            this.nDias.Size = new System.Drawing.Size(58, 20);
            this.nDias.TabIndex = 19;
            this.nDias.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(428, 77);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(37, 19);
            this.materialLabel13.TabIndex = 18;
            this.materialLabel13.Text = "dias";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(307, 77);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(58, 19);
            this.materialLabel12.TabIndex = 16;
            this.materialLabel12.Text = "Validez";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(483, 16);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 100);
            this.materialDivider1.TabIndex = 15;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Hint = "";
            this.txtDocumento.Location = new System.Drawing.Point(604, 77);
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(200, 23);
            this.txtDocumento.TabIndex = 14;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // lVendedor
            // 
            this.lVendedor.AutoSize = true;
            this.lVendedor.Depth = 0;
            this.lVendedor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lVendedor.Location = new System.Drawing.Point(11, 25);
            this.lVendedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lVendedor.Name = "lVendedor";
            this.lVendedor.Size = new System.Drawing.Size(73, 19);
            this.lVendedor.TabIndex = 11;
            this.lVendedor.Text = "Vendedor";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(511, 81);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(87, 19);
            this.materialLabel11.TabIndex = 13;
            this.materialLabel11.Text = "Documento";
            // 
            // txtPresupuestoNro
            // 
            this.txtPresupuestoNro.Depth = 0;
            this.txtPresupuestoNro.Hint = "";
            this.txtPresupuestoNro.Location = new System.Drawing.Point(110, 73);
            this.txtPresupuestoNro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPresupuestoNro.Name = "txtPresupuestoNro";
            this.txtPresupuestoNro.PasswordChar = '\0';
            this.txtPresupuestoNro.SelectedText = "";
            this.txtPresupuestoNro.SelectionLength = 0;
            this.txtPresupuestoNro.SelectionStart = 0;
            this.txtPresupuestoNro.Size = new System.Drawing.Size(73, 23);
            this.txtPresupuestoNro.TabIndex = 1;
            this.txtPresupuestoNro.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(11, 78);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(93, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Presupuesto";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(590, 48);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(214, 23);
            this.txtDireccion.TabIndex = 8;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(511, 52);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(73, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Dirección";
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCliente.Image")));
            this.btnNuevoCliente.Location = new System.Drawing.Point(812, 19);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(31, 25);
            this.btnNuevoCliente.TabIndex = 6;
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // cbClientes
            // 
            this.cbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(590, 21);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(214, 21);
            this.cbClientes.TabIndex = 5;
            this.cbClientes.SelectionChangeCommitted += new System.EventHandler(this.cbClientes_SelectionChangeCommitted);
            this.cbClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbClientes_KeyDown);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(511, 25);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Cliente";
            // 
            // cbLista
            // 
            this.cbLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLista.FormattingEnabled = true;
            this.cbLista.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbLista.Location = new System.Drawing.Point(247, 75);
            this.cbLista.Name = "cbLista";
            this.cbLista.Size = new System.Drawing.Size(41, 21);
            this.cbLista.TabIndex = 3;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(203, 75);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(42, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Lista";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(358, 19);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(107, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(306, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(49, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescuentoPesos);
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Controls.Add(this.nudDescuento);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.materialLabel8);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.materialLabel7);
            this.groupBox2.Controls.Add(this.txtsubtotal);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.dgvDetalles);
            this.groupBox2.Controls.Add(this.rbDescripcion);
            this.groupBox2.Controls.Add(this.rbCodigo);
            this.groupBox2.Controls.Add(this.btnArticuloNuevo);
            this.groupBox2.Controls.Add(this.cbArticulos);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(859, 470);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Conceptos";
            // 
            // txtDescuentoPesos
            // 
            this.txtDescuentoPesos.Depth = 0;
            this.txtDescuentoPesos.Enabled = false;
            this.txtDescuentoPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoPesos.Hint = "";
            this.txtDescuentoPesos.Location = new System.Drawing.Point(703, 411);
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
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(595, 415);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(93, 19);
            this.materialLabel9.TabIndex = 18;
            this.materialLabel9.Text = "Descuento $";
            // 
            // nudDescuento
            // 
            this.nudDescuento.DecimalPlaces = 2;
            this.nudDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDescuento.Location = new System.Drawing.Point(110, 412);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(76, 20);
            this.nudDescuento.TabIndex = 17;
            this.nudDescuento.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ERP.Properties.Resources.accept;
            this.btnAgregar.Location = new System.Drawing.Point(471, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(31, 25);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Tag = "Agregar artículo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(8, 412);
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
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Hint = "";
            this.txtTotal.Location = new System.Drawing.Point(703, 440);
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
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(632, 446);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "Total $";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Depth = 0;
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Hint = "";
            this.txtsubtotal.Location = new System.Drawing.Point(703, 382);
            this.txtsubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.PasswordChar = '\0';
            this.txtsubtotal.SelectedText = "";
            this.txtsubtotal.SelectionLength = 0;
            this.txtsubtotal.SelectionStart = 0;
            this.txtsubtotal.Size = new System.Drawing.Size(129, 23);
            this.txtsubtotal.TabIndex = 8;
            this.txtsubtotal.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(603, 387);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(85, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Sub Total $";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Código,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Importe});
            this.dgvDetalles.EvenRowColor = System.Drawing.Color.Empty;
            this.dgvDetalles.Location = new System.Drawing.Point(3, 84);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.OddRowColor = System.Drawing.Color.AliceBlue;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(860, 294);
            this.dgvDetalles.TabIndex = 11;
            this.dgvDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellEndEdit);
            this.dgvDetalles.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDetalles_EditingControlShowing);
            this.dgvDetalles.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDetalles_UserDeletingRow);
            this.dgvDetalles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetalles_KeyDown);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 71;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ToolTipText = "Ingrese cantidad";
            this.Cantidad.Width = 82;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 68;
            // 
            // Importe
            // 
            this.Importe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.Width = 74;
            // 
            // rbDescripcion
            // 
            this.rbDescripcion.AutoSize = true;
            this.rbDescripcion.Depth = 0;
            this.rbDescripcion.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDescripcion.Location = new System.Drawing.Point(11, 46);
            this.rbDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.rbDescripcion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDescripcion.Name = "rbDescripcion";
            this.rbDescripcion.Ripple = true;
            this.rbDescripcion.Size = new System.Drawing.Size(102, 30);
            this.rbDescripcion.TabIndex = 10;
            this.rbDescripcion.TabStop = true;
            this.rbDescripcion.Text = "Descripción";
            this.rbDescripcion.UseVisualStyleBackColor = true;
            this.rbDescripcion.CheckedChanged += new System.EventHandler(this.rbDescripcion_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Depth = 0;
            this.rbCodigo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbCodigo.Location = new System.Drawing.Point(11, 16);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.rbCodigo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Ripple = true;
            this.rbCodigo.Size = new System.Drawing.Size(128, 30);
            this.rbCodigo.TabIndex = 9;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código de Barra";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // btnArticuloNuevo
            // 
            this.btnArticuloNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnArticuloNuevo.Image")));
            this.btnArticuloNuevo.Location = new System.Drawing.Point(508, 34);
            this.btnArticuloNuevo.Name = "btnArticuloNuevo";
            this.btnArticuloNuevo.Size = new System.Drawing.Size(31, 25);
            this.btnArticuloNuevo.TabIndex = 8;
            this.btnArticuloNuevo.UseVisualStyleBackColor = true;
            // 
            // cbArticulos
            // 
            this.cbArticulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbArticulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbArticulos.FormattingEnabled = true;
            this.cbArticulos.Location = new System.Drawing.Point(152, 37);
            this.cbArticulos.Name = "cbArticulos";
            this.cbArticulos.Size = new System.Drawing.Size(313, 21);
            this.cbArticulos.TabIndex = 6;
            this.cbArticulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbArticulos_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 612);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 52);
            this.panel1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(456, 13);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(124, 31);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(293, 13);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(124, 31);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 732);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEdicion";
            this.Text = "frmEdicion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPresupuestoNro;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.ComboBox cbClientes;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cbLista;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnArticuloNuevo;
        private System.Windows.Forms.ComboBox cbArticulos;
        private MaterialSkin.Controls.MaterialRadioButton rbDescripcion;
        private MaterialSkin.Controls.MaterialRadioButton rbCodigo;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsubtotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialLabel lVendedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.NumericUpDown nDias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudDescuento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuentoPesos;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        public CustomLibrary.ComponentModel.CustomDataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}