namespace ERP.Forms.Presupuestos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDatos = new CustomLibrary.ComponentModel.CustomDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.chbFiltrarFecha = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFiltrar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLista = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtCuit = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLocalidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPresupuestoNro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.customDataGridView1 = new CustomLibrary.ComponentModel.CustomDataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSubtotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 545F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.35497F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.64503F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(998, 608);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnEliminar,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(450, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNuevo.Image = global::ERP.Properties.Resources.add;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnNuevo.Text = "toolStripButton1";
            this.btnNuevo.ToolTipText = "Nuevo (Ctrl + N)";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::ERP.Properties.Resources.page_white_edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "toolStripButton2";
            this.btnEditar.ToolTipText = "Editar (Ctrl + F4)";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::ERP.Properties.Resources.cross;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "toolStripButton3";
            this.btnEliminar.ToolTipText = "Eliminar (Ctrl + Delete)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = global::ERP.Properties.Resources.door;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "toolStripButton4";
            this.btnSalir.ToolTipText = "Salir (Escape)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDatos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 361);
            this.panel2.TabIndex = 6;
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
            this.dgvDatos.Size = new System.Drawing.Size(444, 361);
            this.dgvDatos.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.materialLabel2);
            this.panel3.Controls.Add(this.materialLabel1);
            this.panel3.Controls.Add(this.dtpHasta);
            this.panel3.Controls.Add(this.dtpDesde);
            this.panel3.Controls.Add(this.chbFiltrarFecha);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Controls.Add(this.txtFiltrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 118);
            this.panel3.TabIndex = 7;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(188, 80);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Hasta";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(245, 80);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(91, 20);
            this.dtpHasta.TabIndex = 4;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(82, 80);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(84, 20);
            this.dtpDesde.TabIndex = 3;
            // 
            // chbFiltrarFecha
            // 
            this.chbFiltrarFecha.AutoSize = true;
            this.chbFiltrarFecha.Depth = 0;
            this.chbFiltrarFecha.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbFiltrarFecha.Location = new System.Drawing.Point(18, 50);
            this.chbFiltrarFecha.Margin = new System.Windows.Forms.Padding(0);
            this.chbFiltrarFecha.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbFiltrarFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbFiltrarFecha.Name = "chbFiltrarFecha";
            this.chbFiltrarFecha.Ripple = true;
            this.chbFiltrarFecha.Size = new System.Drawing.Size(128, 30);
            this.chbFiltrarFecha.TabIndex = 2;
            this.chbFiltrarFecha.Text = "Filtrar por fecha";
            this.chbFiltrarFecha.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 13);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Buscar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Depth = 0;
            this.txtFiltrar.Hint = "Ingrese el presupuesto que desea buscar";
            this.txtFiltrar.Location = new System.Drawing.Point(79, 13);
            this.txtFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.SelectionLength = 0;
            this.txtFiltrar.SelectionStart = 0;
            this.txtFiltrar.Size = new System.Drawing.Size(286, 23);
            this.txtFiltrar.TabIndex = 0;
            this.txtFiltrar.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLista);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.txtCuit);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.txtLocalidad);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.materialLabel12);
            this.panel1.Controls.Add(this.materialLabel13);
            this.panel1.Controls.Add(this.txtPresupuestoNro);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(455, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 118);
            this.panel1.TabIndex = 8;
            // 
            // txtLista
            // 
            this.txtLista.Depth = 0;
            this.txtLista.Enabled = false;
            this.txtLista.Hint = "";
            this.txtLista.Location = new System.Drawing.Point(66, 80);
            this.txtLista.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLista.Name = "txtLista";
            this.txtLista.PasswordChar = '\0';
            this.txtLista.SelectedText = "";
            this.txtLista.SelectionLength = 0;
            this.txtLista.SelectionStart = 0;
            this.txtLista.Size = new System.Drawing.Size(139, 23);
            this.txtLista.TabIndex = 28;
            this.txtLista.UseSystemPasswordChar = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Depth = 0;
            this.txtCliente.Enabled = false;
            this.txtCliente.Hint = "";
            this.txtCliente.Location = new System.Drawing.Point(338, 1);
            this.txtCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.SelectedText = "";
            this.txtCliente.SelectionLength = 0;
            this.txtCliente.SelectionStart = 0;
            this.txtCliente.Size = new System.Drawing.Size(192, 23);
            this.txtCliente.TabIndex = 27;
            this.txtCliente.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Teal;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(233, 11);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 95);
            this.materialDivider1.TabIndex = 26;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtCuit
            // 
            this.txtCuit.Depth = 0;
            this.txtCuit.Enabled = false;
            this.txtCuit.Hint = "";
            this.txtCuit.Location = new System.Drawing.Point(338, 88);
            this.txtCuit.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.PasswordChar = '\0';
            this.txtCuit.SelectedText = "";
            this.txtCuit.SelectionLength = 0;
            this.txtCuit.SelectionStart = 0;
            this.txtCuit.Size = new System.Drawing.Size(192, 23);
            this.txtCuit.TabIndex = 25;
            this.txtCuit.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(259, 92);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(46, 19);
            this.materialLabel7.TabIndex = 24;
            this.materialLabel7.Text = "CUIT:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Depth = 0;
            this.txtLocalidad.Enabled = false;
            this.txtLocalidad.Hint = "";
            this.txtLocalidad.Location = new System.Drawing.Point(338, 59);
            this.txtLocalidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.PasswordChar = '\0';
            this.txtLocalidad.SelectedText = "";
            this.txtLocalidad.SelectionLength = 0;
            this.txtLocalidad.SelectionStart = 0;
            this.txtLocalidad.Size = new System.Drawing.Size(192, 23);
            this.txtLocalidad.TabIndex = 23;
            this.txtLocalidad.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(259, 64);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(78, 19);
            this.materialLabel8.TabIndex = 22;
            this.materialLabel8.Text = "Localidad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(338, 30);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(192, 23);
            this.txtDireccion.TabIndex = 21;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(259, 34);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(77, 19);
            this.materialLabel12.TabIndex = 20;
            this.materialLabel12.Text = "Dirección:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(259, 7);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(60, 19);
            this.materialLabel13.TabIndex = 17;
            this.materialLabel13.Text = "Cliente:";
            // 
            // txtPresupuestoNro
            // 
            this.txtPresupuestoNro.Depth = 0;
            this.txtPresupuestoNro.Enabled = false;
            this.txtPresupuestoNro.Hint = "";
            this.txtPresupuestoNro.Location = new System.Drawing.Point(110, 13);
            this.txtPresupuestoNro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPresupuestoNro.Name = "txtPresupuestoNro";
            this.txtPresupuestoNro.PasswordChar = '\0';
            this.txtPresupuestoNro.SelectedText = "";
            this.txtPresupuestoNro.SelectionLength = 0;
            this.txtPresupuestoNro.SelectionStart = 0;
            this.txtPresupuestoNro.Size = new System.Drawing.Size(95, 23);
            this.txtPresupuestoNro.TabIndex = 16;
            this.txtPresupuestoNro.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(11, 18);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(97, 19);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Presupuesto:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(11, 82);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Lista";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(66, 50);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(139, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(11, 50);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(49, 19);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Fecha";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.customDataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(455, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(539, 361);
            this.panel4.TabIndex = 9;
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.AllowUserToAddRows = false;
            this.customDataGridView1.AllowUserToDeleteRows = false;
            this.customDataGridView1.AllowUserToResizeRows = false;
            this.customDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGridView1.EvenRowColor = System.Drawing.Color.Empty;
            this.customDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.customDataGridView1.MultiSelect = false;
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.OddRowColor = System.Drawing.Color.AliceBlue;
            this.customDataGridView1.ReadOnly = true;
            this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView1.Size = new System.Drawing.Size(539, 361);
            this.customDataGridView1.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtDescuento);
            this.panel5.Controls.Add(this.materialLabel11);
            this.panel5.Controls.Add(this.txtTotal);
            this.panel5.Controls.Add(this.materialLabel9);
            this.panel5.Controls.Add(this.txtSubtotal);
            this.panel5.Controls.Add(this.materialLabel10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(455, 523);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(539, 81);
            this.panel5.TabIndex = 10;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Hint = "";
            this.txtDescuento.Location = new System.Drawing.Point(106, 6);
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(50, 23);
            this.txtDescuento.TabIndex = 10;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(12, 10);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(96, 19);
            this.materialLabel11.TabIndex = 9;
            this.materialLabel11.Text = "Descuento %";
            // 
            // txtTotal
            // 
            this.txtTotal.Depth = 0;
            this.txtTotal.Enabled = false;
            this.txtTotal.Hint = "";
            this.txtTotal.Location = new System.Drawing.Point(407, 35);
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(107, 23);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(349, 40);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(48, 19);
            this.materialLabel9.TabIndex = 7;
            this.materialLabel9.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Depth = 0;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Hint = "";
            this.txtSubtotal.Location = new System.Drawing.Point(407, 5);
            this.txtSubtotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.SelectionLength = 0;
            this.txtSubtotal.SelectionStart = 0;
            this.txtSubtotal.Size = new System.Drawing.Size(107, 23);
            this.txtSubtotal.TabIndex = 6;
            this.txtSubtotal.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(320, 10);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(77, 19);
            this.materialLabel10.TabIndex = 5;
            this.materialLabel10.Text = "Sub Total:";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 672);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListado";
            this.Text = "Presupuestos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private CustomLibrary.ComponentModel.CustomDataGridView dgvDatos;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFiltrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private MaterialSkin.Controls.MaterialCheckBox chbFiltrarFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private CustomLibrary.ComponentModel.CustomDataGridView customDataGridView1;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubtotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPresupuestoNro;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLista;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCliente;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCuit;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocalidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
    }
}