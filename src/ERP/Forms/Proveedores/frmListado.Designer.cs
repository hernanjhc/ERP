namespace ERP.Forms.Proveedores
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
            this.dgvDatos = new CustomLibrary.ComponentModel.CustomDataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDepartamento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBarrio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProvincia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLocalidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEstado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFechaNacimiento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDatos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.27088F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.72912F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 520);
            this.tableLayoutPanel1.TabIndex = 7;
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
            this.dgvDatos.Location = new System.Drawing.Point(4, 30);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.OddRowColor = System.Drawing.Color.AliceBlue;
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(841, 289);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDatos_DataBindingComplete);
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            this.dgvDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBuscar,
            this.btnEliminar,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(847, 25);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = global::ERP.Properties.Resources.zoom;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "toolStripButton1";
            this.btnBuscar.ToolTipText = "Buscar";
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.materialLabel14);
            this.panel1.Controls.Add(this.materialLabel11);
            this.panel1.Controls.Add(this.materialLabel12);
            this.panel1.Controls.Add(this.materialLabel10);
            this.panel1.Controls.Add(this.materialLabel9);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.txtDepartamento);
            this.panel1.Controls.Add(this.txtBarrio);
            this.panel1.Controls.Add(this.txtProvincia);
            this.panel1.Controls.Add(this.txtLocalidad);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtEMail);
            this.panel1.Controls.Add(this.txtFechaNacimiento);
            this.panel1.Controls.Add(this.txtRazonSocial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 190);
            this.panel1.TabIndex = 4;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Teal;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(94, 111);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(729, 2);
            this.materialDivider1.TabIndex = 56;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(535, 127);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(104, 19);
            this.materialLabel14.TabIndex = 55;
            this.materialLabel14.Text = "Departamento";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(277, 153);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(49, 19);
            this.materialLabel11.TabIndex = 54;
            this.materialLabel11.Text = "Barrio";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(277, 127);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(71, 19);
            this.materialLabel12.TabIndex = 53;
            this.materialLabel12.Text = "Provincia";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(15, 153);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(74, 19);
            this.materialLabel10.TabIndex = 52;
            this.materialLabel10.Text = "Localidad";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(15, 127);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(73, 19);
            this.materialLabel9.TabIndex = 51;
            this.materialLabel9.Text = "Dirección";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(15, 100);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(74, 19);
            this.materialLabel8.TabIndex = 50;
            this.materialLabel8.Text = "Domicilio";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(14, 68);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(56, 19);
            this.materialLabel7.TabIndex = 49;
            this.materialLabel7.Text = "Estado";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(535, 11);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(87, 19);
            this.materialLabel6.TabIndex = 48;
            this.materialLabel6.Text = "Documento";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(536, 39);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(69, 19);
            this.materialLabel5.TabIndex = 47;
            this.materialLabel5.Text = "Teléfono";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(277, 39);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 19);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = "E-Mail";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 39);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(84, 19);
            this.materialLabel2.TabIndex = 44;
            this.materialLabel2.Text = "Fecha Nac.";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 11);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 19);
            this.materialLabel1.TabIndex = 43;
            this.materialLabel1.Text = "Razón Social";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Depth = 0;
            this.txtDepartamento.Hint = "";
            this.txtDepartamento.Location = new System.Drawing.Point(645, 123);
            this.txtDepartamento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.PasswordChar = '\0';
            this.txtDepartamento.SelectedText = "";
            this.txtDepartamento.SelectionLength = 0;
            this.txtDepartamento.SelectionStart = 0;
            this.txtDepartamento.Size = new System.Drawing.Size(154, 23);
            this.txtDepartamento.TabIndex = 42;
            this.txtDepartamento.UseSystemPasswordChar = false;
            // 
            // txtBarrio
            // 
            this.txtBarrio.Depth = 0;
            this.txtBarrio.Hint = "";
            this.txtBarrio.Location = new System.Drawing.Point(354, 150);
            this.txtBarrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.PasswordChar = '\0';
            this.txtBarrio.SelectedText = "";
            this.txtBarrio.SelectionLength = 0;
            this.txtBarrio.SelectionStart = 0;
            this.txtBarrio.Size = new System.Drawing.Size(175, 23);
            this.txtBarrio.TabIndex = 41;
            this.txtBarrio.UseSystemPasswordChar = false;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Depth = 0;
            this.txtProvincia.Hint = "";
            this.txtProvincia.Location = new System.Drawing.Point(354, 121);
            this.txtProvincia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.PasswordChar = '\0';
            this.txtProvincia.SelectedText = "";
            this.txtProvincia.SelectionLength = 0;
            this.txtProvincia.SelectionStart = 0;
            this.txtProvincia.Size = new System.Drawing.Size(175, 23);
            this.txtProvincia.TabIndex = 40;
            this.txtProvincia.UseSystemPasswordChar = false;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Depth = 0;
            this.txtLocalidad.Hint = "";
            this.txtLocalidad.Location = new System.Drawing.Point(95, 152);
            this.txtLocalidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.PasswordChar = '\0';
            this.txtLocalidad.SelectedText = "";
            this.txtLocalidad.SelectionLength = 0;
            this.txtLocalidad.SelectionStart = 0;
            this.txtLocalidad.Size = new System.Drawing.Size(177, 23);
            this.txtLocalidad.TabIndex = 39;
            this.txtLocalidad.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(94, 123);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(177, 23);
            this.txtDireccion.TabIndex = 38;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Depth = 0;
            this.txtEstado.Hint = "";
            this.txtEstado.Location = new System.Drawing.Point(119, 66);
            this.txtEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.Size = new System.Drawing.Size(153, 23);
            this.txtEstado.TabIndex = 37;
            this.txtEstado.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Hint = "";
            this.txtDocumento.Location = new System.Drawing.Point(628, 8);
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(171, 23);
            this.txtDocumento.TabIndex = 36;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(628, 37);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(171, 23);
            this.txtTelefono.TabIndex = 35;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtEMail
            // 
            this.txtEMail.Depth = 0;
            this.txtEMail.Hint = "";
            this.txtEMail.Location = new System.Drawing.Point(334, 37);
            this.txtEMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.PasswordChar = '\0';
            this.txtEMail.SelectedText = "";
            this.txtEMail.SelectionLength = 0;
            this.txtEMail.SelectionStart = 0;
            this.txtEMail.Size = new System.Drawing.Size(194, 23);
            this.txtEMail.TabIndex = 34;
            this.txtEMail.UseSystemPasswordChar = false;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Depth = 0;
            this.txtFechaNacimiento.Hint = "";
            this.txtFechaNacimiento.Location = new System.Drawing.Point(119, 37);
            this.txtFechaNacimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.PasswordChar = '\0';
            this.txtFechaNacimiento.SelectedText = "";
            this.txtFechaNacimiento.SelectionLength = 0;
            this.txtFechaNacimiento.SelectionStart = 0;
            this.txtFechaNacimiento.Size = new System.Drawing.Size(152, 23);
            this.txtFechaNacimiento.TabIndex = 32;
            this.txtFechaNacimiento.UseSystemPasswordChar = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Depth = 0;
            this.txtRazonSocial.Hint = "";
            this.txtRazonSocial.Location = new System.Drawing.Point(119, 8);
            this.txtRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.SelectionLength = 0;
            this.txtRazonSocial.SelectionStart = 0;
            this.txtRazonSocial.Size = new System.Drawing.Size(410, 23);
            this.txtRazonSocial.TabIndex = 31;
            this.txtRazonSocial.UseSystemPasswordChar = false;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 583);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListado";
            this.Text = "Proveedores";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomLibrary.ComponentModel.CustomDataGridView dgvDatos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        protected System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtDepartamento;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtBarrio;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtProvincia;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtLocalidad;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtEstado;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtEMail;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtFechaNacimiento;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtRazonSocial;
    }
}