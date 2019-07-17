namespace ERP.Forms.Articulos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFiltrar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodBarra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIVA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLista3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLista2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLista1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField11 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDesc3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDesc2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDesc1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCostoInicial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtStockMin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProveedor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRubro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMarca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvDatos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 491);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.toolStrip1.Size = new System.Drawing.Size(807, 25);
            this.toolStrip1.TabIndex = 4;
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.txtFiltrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 27);
            this.panel1.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(463, 3);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Buscar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Depth = 0;
            this.txtFiltrar.Hint = "Ingrese el artículo que desea buscar";
            this.txtFiltrar.Location = new System.Drawing.Point(528, 3);
            this.txtFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.SelectionLength = 0;
            this.txtFiltrar.SelectionStart = 0;
            this.txtFiltrar.Size = new System.Drawing.Size(269, 23);
            this.txtFiltrar.TabIndex = 2;
            this.txtFiltrar.UseSystemPasswordChar = false;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(4, 64);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(801, 296);
            this.dgvDatos.TabIndex = 6;
            this.dgvDatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDatos_DataBindingComplete);
            this.dgvDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDatos_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialLabel19);
            this.panel2.Controls.Add(this.txtCodBarra);
            this.panel2.Controls.Add(this.materialLabel18);
            this.panel2.Controls.Add(this.txtIVA);
            this.panel2.Controls.Add(this.materialLabel14);
            this.panel2.Controls.Add(this.txtLista3);
            this.panel2.Controls.Add(this.materialLabel15);
            this.panel2.Controls.Add(this.txtLista2);
            this.panel2.Controls.Add(this.materialLabel16);
            this.panel2.Controls.Add(this.txtLista1);
            this.panel2.Controls.Add(this.materialLabel17);
            this.panel2.Controls.Add(this.materialSingleLineTextField11);
            this.panel2.Controls.Add(this.materialLabel13);
            this.panel2.Controls.Add(this.txtDesc3);
            this.panel2.Controls.Add(this.materialLabel12);
            this.panel2.Controls.Add(this.txtDesc2);
            this.panel2.Controls.Add(this.materialLabel11);
            this.panel2.Controls.Add(this.txtDesc1);
            this.panel2.Controls.Add(this.materialLabel10);
            this.panel2.Controls.Add(this.txtCostoInicial);
            this.panel2.Controls.Add(this.materialLabel9);
            this.panel2.Controls.Add(this.txtStockMin);
            this.panel2.Controls.Add(this.materialLabel8);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.materialLabel7);
            this.panel2.Controls.Add(this.txtProveedor);
            this.panel2.Controls.Add(this.materialLabel6);
            this.panel2.Controls.Add(this.txtRubro);
            this.panel2.Controls.Add(this.materialLabel5);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Controls.Add(this.materialLabel4);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 120);
            this.panel2.TabIndex = 7;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(3, 95);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(115, 19);
            this.materialLabel19.TabIndex = 34;
            this.materialLabel19.Text = "Precio de Venta";
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.Depth = 0;
            this.txtCodBarra.Hint = "";
            this.txtCodBarra.Location = new System.Drawing.Point(689, 5);
            this.txtCodBarra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.PasswordChar = '\0';
            this.txtCodBarra.SelectedText = "";
            this.txtCodBarra.SelectionLength = 0;
            this.txtCodBarra.SelectionStart = 0;
            this.txtCodBarra.Size = new System.Drawing.Size(103, 23);
            this.txtCodBarra.TabIndex = 33;
            this.txtCodBarra.UseSystemPasswordChar = false;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(589, 5);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(96, 19);
            this.materialLabel18.TabIndex = 32;
            this.materialLabel18.Text = "Código Barra";
            // 
            // txtIVA
            // 
            this.txtIVA.Depth = 0;
            this.txtIVA.Hint = "";
            this.txtIVA.Location = new System.Drawing.Point(691, 95);
            this.txtIVA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.PasswordChar = '\0';
            this.txtIVA.SelectedText = "";
            this.txtIVA.SelectionLength = 0;
            this.txtIVA.SelectionStart = 0;
            this.txtIVA.Size = new System.Drawing.Size(49, 23);
            this.txtIVA.TabIndex = 30;
            this.txtIVA.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(655, 95);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(33, 19);
            this.materialLabel14.TabIndex = 28;
            this.materialLabel14.Text = "IVA";
            // 
            // txtLista3
            // 
            this.txtLista3.Depth = 0;
            this.txtLista3.Hint = "";
            this.txtLista3.Location = new System.Drawing.Point(551, 95);
            this.txtLista3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLista3.Name = "txtLista3";
            this.txtLista3.PasswordChar = '\0';
            this.txtLista3.SelectedText = "";
            this.txtLista3.SelectionLength = 0;
            this.txtLista3.SelectionStart = 0;
            this.txtLista3.Size = new System.Drawing.Size(100, 23);
            this.txtLista3.TabIndex = 31;
            this.txtLista3.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(493, 95);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(54, 19);
            this.materialLabel15.TabIndex = 29;
            this.materialLabel15.Text = "Lista 3";
            // 
            // txtLista2
            // 
            this.txtLista2.Depth = 0;
            this.txtLista2.Hint = "";
            this.txtLista2.Location = new System.Drawing.Point(386, 95);
            this.txtLista2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLista2.Name = "txtLista2";
            this.txtLista2.PasswordChar = '\0';
            this.txtLista2.SelectedText = "";
            this.txtLista2.SelectionLength = 0;
            this.txtLista2.SelectionStart = 0;
            this.txtLista2.Size = new System.Drawing.Size(100, 23);
            this.txtLista2.TabIndex = 27;
            this.txtLista2.UseSystemPasswordChar = false;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(328, 95);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(54, 19);
            this.materialLabel16.TabIndex = 26;
            this.materialLabel16.Text = "Lista 2";
            // 
            // txtLista1
            // 
            this.txtLista1.Depth = 0;
            this.txtLista1.Hint = "";
            this.txtLista1.Location = new System.Drawing.Point(223, 95);
            this.txtLista1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLista1.Name = "txtLista1";
            this.txtLista1.PasswordChar = '\0';
            this.txtLista1.SelectedText = "";
            this.txtLista1.SelectionLength = 0;
            this.txtLista1.SelectionStart = 0;
            this.txtLista1.Size = new System.Drawing.Size(100, 23);
            this.txtLista1.TabIndex = 25;
            this.txtLista1.UseSystemPasswordChar = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(165, 95);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(54, 19);
            this.materialLabel17.TabIndex = 24;
            this.materialLabel17.Text = "Lista 1";
            // 
            // materialSingleLineTextField11
            // 
            this.materialSingleLineTextField11.Depth = 0;
            this.materialSingleLineTextField11.Hint = "";
            this.materialSingleLineTextField11.Location = new System.Drawing.Point(707, 66);
            this.materialSingleLineTextField11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField11.Name = "materialSingleLineTextField11";
            this.materialSingleLineTextField11.PasswordChar = '\0';
            this.materialSingleLineTextField11.SelectedText = "";
            this.materialSingleLineTextField11.SelectionLength = 0;
            this.materialSingleLineTextField11.SelectionStart = 0;
            this.materialSingleLineTextField11.Size = new System.Drawing.Size(86, 23);
            this.materialSingleLineTextField11.TabIndex = 21;
            this.materialSingleLineTextField11.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(654, 66);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(50, 19);
            this.materialLabel13.TabIndex = 20;
            this.materialLabel13.Text = "Costo";
            // 
            // txtDesc3
            // 
            this.txtDesc3.Depth = 0;
            this.txtDesc3.Hint = "";
            this.txtDesc3.Location = new System.Drawing.Point(553, 66);
            this.txtDesc3.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDesc3.Name = "txtDesc3";
            this.txtDesc3.PasswordChar = '\0';
            this.txtDesc3.SelectedText = "";
            this.txtDesc3.SelectionLength = 0;
            this.txtDesc3.SelectionStart = 0;
            this.txtDesc3.Size = new System.Drawing.Size(100, 23);
            this.txtDesc3.TabIndex = 21;
            this.txtDesc3.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(492, 66);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(59, 19);
            this.materialLabel12.TabIndex = 20;
            this.materialLabel12.Text = "Desc. 3";
            // 
            // txtDesc2
            // 
            this.txtDesc2.Depth = 0;
            this.txtDesc2.Hint = "";
            this.txtDesc2.Location = new System.Drawing.Point(388, 66);
            this.txtDesc2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDesc2.Name = "txtDesc2";
            this.txtDesc2.PasswordChar = '\0';
            this.txtDesc2.SelectedText = "";
            this.txtDesc2.SelectionLength = 0;
            this.txtDesc2.SelectionStart = 0;
            this.txtDesc2.Size = new System.Drawing.Size(100, 23);
            this.txtDesc2.TabIndex = 19;
            this.txtDesc2.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(327, 66);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(59, 19);
            this.materialLabel11.TabIndex = 18;
            this.materialLabel11.Text = "Desc. 2";
            // 
            // txtDesc1
            // 
            this.txtDesc1.Depth = 0;
            this.txtDesc1.Hint = "";
            this.txtDesc1.Location = new System.Drawing.Point(225, 66);
            this.txtDesc1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.PasswordChar = '\0';
            this.txtDesc1.SelectedText = "";
            this.txtDesc1.SelectionLength = 0;
            this.txtDesc1.SelectionStart = 0;
            this.txtDesc1.Size = new System.Drawing.Size(100, 23);
            this.txtDesc1.TabIndex = 17;
            this.txtDesc1.UseSystemPasswordChar = false;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(164, 66);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(59, 19);
            this.materialLabel10.TabIndex = 16;
            this.materialLabel10.Text = "Desc. 1";
            // 
            // txtCostoInicial
            // 
            this.txtCostoInicial.Depth = 0;
            this.txtCostoInicial.Hint = "";
            this.txtCostoInicial.Location = new System.Drawing.Point(74, 67);
            this.txtCostoInicial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCostoInicial.Name = "txtCostoInicial";
            this.txtCostoInicial.PasswordChar = '\0';
            this.txtCostoInicial.SelectedText = "";
            this.txtCostoInicial.SelectionLength = 0;
            this.txtCostoInicial.SelectionStart = 0;
            this.txtCostoInicial.Size = new System.Drawing.Size(86, 23);
            this.txtCostoInicial.TabIndex = 15;
            this.txtCostoInicial.UseSystemPasswordChar = false;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(2, 67);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(70, 19);
            this.materialLabel9.TabIndex = 14;
            this.materialLabel9.Text = "Costo ini";
            // 
            // txtStockMin
            // 
            this.txtStockMin.Depth = 0;
            this.txtStockMin.Hint = "";
            this.txtStockMin.Location = new System.Drawing.Point(747, 35);
            this.txtStockMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.PasswordChar = '\0';
            this.txtStockMin.SelectedText = "";
            this.txtStockMin.SelectionLength = 0;
            this.txtStockMin.SelectionStart = 0;
            this.txtStockMin.Size = new System.Drawing.Size(46, 23);
            this.txtStockMin.TabIndex = 30;
            this.txtStockMin.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(662, 35);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(81, 19);
            this.materialLabel8.TabIndex = 12;
            this.materialLabel8.Text = "Stock Mín.";
            // 
            // txtStock
            // 
            this.txtStock.Depth = 0;
            this.txtStock.Hint = "";
            this.txtStock.Location = new System.Drawing.Point(578, 37);
            this.txtStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.Size = new System.Drawing.Size(82, 23);
            this.txtStock.TabIndex = 25;
            this.txtStock.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(525, 37);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(48, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Stock";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Depth = 0;
            this.txtProveedor.Hint = "";
            this.txtProveedor.Location = new System.Drawing.Point(373, 38);
            this.txtProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.PasswordChar = '\0';
            this.txtProveedor.SelectedText = "";
            this.txtProveedor.SelectionLength = 0;
            this.txtProveedor.SelectionStart = 0;
            this.txtProveedor.Size = new System.Drawing.Size(152, 23);
            this.txtProveedor.TabIndex = 20;
            this.txtProveedor.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(293, 38);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(77, 19);
            this.materialLabel6.TabIndex = 8;
            this.materialLabel6.Text = "Proveedor";
            // 
            // txtRubro
            // 
            this.txtRubro.Depth = 0;
            this.txtRubro.Hint = "";
            this.txtRubro.Location = new System.Drawing.Point(203, 38);
            this.txtRubro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.PasswordChar = '\0';
            this.txtRubro.SelectedText = "";
            this.txtRubro.SelectionLength = 0;
            this.txtRubro.SelectionStart = 0;
            this.txtRubro.Size = new System.Drawing.Size(90, 23);
            this.txtRubro.TabIndex = 15;
            this.txtRubro.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(149, 38);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Rubro";
            // 
            // txtMarca
            // 
            this.txtMarca.Depth = 0;
            this.txtMarca.Hint = "";
            this.txtMarca.Location = new System.Drawing.Point(57, 40);
            this.txtMarca.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PasswordChar = '\0';
            this.txtMarca.SelectedText = "";
            this.txtMarca.SelectionLength = 0;
            this.txtMarca.SelectionStart = 0;
            this.txtMarca.Size = new System.Drawing.Size(89, 23);
            this.txtMarca.TabIndex = 10;
            this.txtMarca.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 40);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Marca";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.Hint = "";
            this.txtDescripcion.Location = new System.Drawing.Point(270, 7);
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.Size = new System.Drawing.Size(313, 23);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(179, 7);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(89, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Descripción";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "";
            this.txtCodigo.Location = new System.Drawing.Point(64, 9);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(112, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(4, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Código";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListado";
            this.Text = "Artículos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFiltrar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescripcion;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStockMin;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStock;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProveedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRubro;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMarca;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIVA;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLista3;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLista2;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLista1;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField11;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDesc3;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDesc2;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDesc1;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCostoInicial;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodBarra;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
    }
}