namespace ERP.Forms.Remitos
{
    partial class frmListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.chbFiltrarFecha = new MaterialSkin.Controls.MaterialCheckBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFiltrar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDatos = new CustomLibrary.ComponentModel.CustomDataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDetalles = new CustomLibrary.ComponentModel.CustomDataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtEstado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtVentaNro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNroDoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRemito = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.66019F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 346);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnBuscar);
            this.panel5.Controls.Add(this.materialLabel2);
            this.panel5.Controls.Add(this.materialLabel1);
            this.panel5.Controls.Add(this.dtpHasta);
            this.panel5.Controls.Add(this.chbFiltrarFecha);
            this.panel5.Controls.Add(this.dtpDesde);
            this.panel5.Controls.Add(this.materialLabel3);
            this.panel5.Controls.Add(this.txtFiltrar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(797, 69);
            this.panel5.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::ERP.Properties.Resources.zoom;
            this.btnBuscar.Location = new System.Drawing.Point(708, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 32);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Tag = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(560, 42);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Hasta";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(421, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(611, 42);
            this.dtpHasta.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(91, 20);
            this.dtpHasta.TabIndex = 10;
            // 
            // chbFiltrarFecha
            // 
            this.chbFiltrarFecha.AutoSize = true;
            this.chbFiltrarFecha.Depth = 0;
            this.chbFiltrarFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbFiltrarFecha.Location = new System.Drawing.Point(419, 8);
            this.chbFiltrarFecha.Margin = new System.Windows.Forms.Padding(0);
            this.chbFiltrarFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbFiltrarFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbFiltrarFecha.Name = "chbFiltrarFecha";
            this.chbFiltrarFecha.Ripple = true;
            this.chbFiltrarFecha.Size = new System.Drawing.Size(128, 30);
            this.chbFiltrarFecha.TabIndex = 8;
            this.chbFiltrarFecha.Text = "Filtrar por fecha";
            this.chbFiltrarFecha.UseVisualStyleBackColor = true;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(474, 42);
            this.dtpDesde.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(84, 20);
            this.dtpDesde.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 12);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Buscar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Depth = 0;
            this.txtFiltrar.Hint = "Ingrese el remito que desea buscar";
            this.txtFiltrar.Location = new System.Drawing.Point(73, 12);
            this.txtFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.SelectionLength = 0;
            this.txtFiltrar.SelectionStart = 0;
            this.txtFiltrar.Size = new System.Drawing.Size(286, 23);
            this.txtFiltrar.TabIndex = 0;
            this.txtFiltrar.UseSystemPasswordChar = false;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDatos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 262);
            this.panel3.TabIndex = 11;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.EvenRowColor = System.Drawing.Color.Empty;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.OddRowColor = System.Drawing.Color.AliceBlue;
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(797, 262);
            this.dgvDatos.TabIndex = 4;
            this.dgvDatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDatos_DataBindingComplete);
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(807, 64);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(172, 346);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAnular);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 338);
            this.panel1.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(18, 196);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(130, 38);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(18, 240);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 38);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(18, 152);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(130, 38);
            this.btnAnular.TabIndex = 6;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(18, 108);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(130, 38);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(18, 64);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 38);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDetalles);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(971, 198);
            this.panel4.TabIndex = 1;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToResizeRows = false;
            this.dgvDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalles.EvenRowColor = System.Drawing.Color.Empty;
            this.dgvDetalles.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.OddRowColor = System.Drawing.Color.AliceBlue;
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(971, 198);
            this.dgvDetalles.TabIndex = 6;
            this.dgvDetalles.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDetalles_DataBindingComplete);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEstado);
            this.panel2.Controls.Add(this.materialLabel6);
            this.panel2.Controls.Add(this.txtVentaNro);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.txtNroDoc);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.txtRemito);
            this.panel2.Controls.Add(this.materialLabel14);
            this.panel2.Controls.Add(this.txtCliente);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.txtDireccion);
            this.panel2.Controls.Add(this.materialLabel15);
            this.panel2.Controls.Add(this.materialLabel10);
            this.panel2.Controls.Add(this.materialLabel11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 76);
            this.panel2.TabIndex = 0;
            // 
            // txtEstado
            // 
            this.txtEstado.Depth = 0;
            this.txtEstado.Enabled = false;
            this.txtEstado.Hint = "";
            this.txtEstado.Location = new System.Drawing.Point(779, 3);
            this.txtEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.Size = new System.Drawing.Size(117, 23);
            this.txtEstado.TabIndex = 31;
            this.txtEstado.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(702, 8);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(60, 19);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "Estado:";
            // 
            // txtVentaNro
            // 
            this.txtVentaNro.Depth = 0;
            this.txtVentaNro.Enabled = false;
            this.txtVentaNro.Hint = "";
            this.txtVentaNro.Location = new System.Drawing.Point(549, 3);
            this.txtVentaNro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVentaNro.Name = "txtVentaNro";
            this.txtVentaNro.PasswordChar = '\0';
            this.txtVentaNro.SelectedText = "";
            this.txtVentaNro.SelectionLength = 0;
            this.txtVentaNro.SelectionStart = 0;
            this.txtVentaNro.Size = new System.Drawing.Size(117, 23);
            this.txtVentaNro.TabIndex = 29;
            this.txtVentaNro.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(472, 8);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(81, 19);
            this.materialLabel5.TabIndex = 28;
            this.materialLabel5.Text = "Venta Nro:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Depth = 0;
            this.txtNroDoc.Enabled = false;
            this.txtNroDoc.Hint = "";
            this.txtNroDoc.Location = new System.Drawing.Point(351, 32);
            this.txtNroDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.PasswordChar = '\0';
            this.txtNroDoc.SelectedText = "";
            this.txtNroDoc.SelectionLength = 0;
            this.txtNroDoc.SelectionStart = 0;
            this.txtNroDoc.Size = new System.Drawing.Size(111, 23);
            this.txtNroDoc.TabIndex = 25;
            this.txtNroDoc.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(268, 36);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(77, 19);
            this.materialLabel4.TabIndex = 24;
            this.materialLabel4.Text = "CUIT/DNI:";
            // 
            // txtRemito
            // 
            this.txtRemito.Depth = 0;
            this.txtRemito.Enabled = false;
            this.txtRemito.Hint = "";
            this.txtRemito.Location = new System.Drawing.Point(73, 3);
            this.txtRemito.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRemito.Name = "txtRemito";
            this.txtRemito.PasswordChar = '\0';
            this.txtRemito.SelectedText = "";
            this.txtRemito.SelectionLength = 0;
            this.txtRemito.SelectionStart = 0;
            this.txtRemito.Size = new System.Drawing.Size(127, 23);
            this.txtRemito.TabIndex = 16;
            this.txtRemito.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(6, 8);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(61, 19);
            this.materialLabel14.TabIndex = 15;
            this.materialLabel14.Text = "Remito:";
            // 
            // txtCliente
            // 
            this.txtCliente.Depth = 0;
            this.txtCliente.Enabled = false;
            this.txtCliente.Hint = "";
            this.txtCliente.Location = new System.Drawing.Point(75, 32);
            this.txtCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.Size = new System.Drawing.Size(189, 23);
            this.txtCliente.TabIndex = 27;
            this.txtCliente.UseSystemPasswordChar = false;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(293, 7);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(127, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(549, 32);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(347, 23);
            this.txtDireccion.TabIndex = 21;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(226, 7);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(49, 19);
            this.materialLabel15.TabIndex = 11;
            this.materialLabel15.Text = "Fecha";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(470, 36);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(77, 19);
            this.materialLabel10.TabIndex = 20;
            this.materialLabel10.Text = "Dirección:";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(7, 38);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(60, 19);
            this.materialLabel11.TabIndex = 17;
            this.materialLabel11.Text = "Cliente:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 412);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.81944F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.18056F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(979, 289);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 701);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListado";
            this.Text = "Remitos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFiltrar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private CustomLibrary.ComponentModel.CustomDataGridView dgvDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panel4;
        private CustomLibrary.ComponentModel.CustomDataGridView dgvDetalles;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroDoc;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRemito;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEstado;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVentaNro;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Button btnBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private MaterialSkin.Controls.MaterialCheckBox chbFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
    }
}