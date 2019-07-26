namespace ERP.Forms.Cheques
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEndosaNroDoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEndosaTipoDoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEndosaDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEndosaRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
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
            this.txtNroDoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTitularTipoDoc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTitularRazonSocial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEstado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBanco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFechaVencimiento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFechaEmision = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtImporte = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDatos = new CustomLibrary.ComponentModel.CustomDataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFiltrar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.03909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 231F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 503);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialDivider2);
            this.panel1.Controls.Add(this.materialLabel11);
            this.panel1.Controls.Add(this.materialLabel15);
            this.panel1.Controls.Add(this.materialLabel16);
            this.panel1.Controls.Add(this.materialLabel17);
            this.panel1.Controls.Add(this.materialLabel18);
            this.panel1.Controls.Add(this.txtEndosaNroDoc);
            this.panel1.Controls.Add(this.txtEndosaTipoDoc);
            this.panel1.Controls.Add(this.txtEndosaDireccion);
            this.panel1.Controls.Add(this.txtEndosaRazonSocial);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.materialLabel14);
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
            this.panel1.Controls.Add(this.txtNroDoc);
            this.panel1.Controls.Add(this.txtTitularTipoDoc);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtTitularRazonSocial);
            this.panel1.Controls.Add(this.txtEstado);
            this.panel1.Controls.Add(this.txtBanco);
            this.panel1.Controls.Add(this.txtFechaVencimiento);
            this.panel1.Controls.Add(this.txtFechaEmision);
            this.panel1.Controls.Add(this.txtImporte);
            this.panel1.Controls.Add(this.txtNro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 226);
            this.panel1.TabIndex = 5;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.Teal;
            this.materialDivider2.Depth = 0;
            this.materialDivider2.ForeColor = System.Drawing.Color.Teal;
            this.materialDivider2.Location = new System.Drawing.Point(75, 154);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(690, 2);
            this.materialDivider2.TabIndex = 66;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(539, 170);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(69, 19);
            this.materialLabel11.TabIndex = 65;
            this.materialLabel11.Text = "Nro Doc.";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(391, 170);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(74, 19);
            this.materialLabel15.TabIndex = 64;
            this.materialLabel15.Text = "Tipo Doc.";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(15, 196);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(73, 19);
            this.materialLabel16.TabIndex = 63;
            this.materialLabel16.Text = "Dirección";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(15, 170);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(96, 19);
            this.materialLabel17.TabIndex = 62;
            this.materialLabel17.Text = "Razón Social";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(15, 143);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(59, 19);
            this.materialLabel18.TabIndex = 61;
            this.materialLabel18.Text = "Endosa";
            // 
            // txtEndosaNroDoc
            // 
            this.txtEndosaNroDoc.Depth = 0;
            this.txtEndosaNroDoc.Hint = "";
            this.txtEndosaNroDoc.Location = new System.Drawing.Point(613, 166);
            this.txtEndosaNroDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndosaNroDoc.Name = "txtEndosaNroDoc";
            this.txtEndosaNroDoc.PasswordChar = '\0';
            this.txtEndosaNroDoc.SelectedText = "";
            this.txtEndosaNroDoc.SelectionLength = 0;
            this.txtEndosaNroDoc.SelectionStart = 0;
            this.txtEndosaNroDoc.Size = new System.Drawing.Size(154, 23);
            this.txtEndosaNroDoc.TabIndex = 60;
            this.txtEndosaNroDoc.UseSystemPasswordChar = false;
            // 
            // txtEndosaTipoDoc
            // 
            this.txtEndosaTipoDoc.Depth = 0;
            this.txtEndosaTipoDoc.Hint = "";
            this.txtEndosaTipoDoc.Location = new System.Drawing.Point(468, 164);
            this.txtEndosaTipoDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndosaTipoDoc.Name = "txtEndosaTipoDoc";
            this.txtEndosaTipoDoc.PasswordChar = '\0';
            this.txtEndosaTipoDoc.SelectedText = "";
            this.txtEndosaTipoDoc.SelectionLength = 0;
            this.txtEndosaTipoDoc.SelectionStart = 0;
            this.txtEndosaTipoDoc.Size = new System.Drawing.Size(59, 23);
            this.txtEndosaTipoDoc.TabIndex = 59;
            this.txtEndosaTipoDoc.UseSystemPasswordChar = false;
            // 
            // txtEndosaDireccion
            // 
            this.txtEndosaDireccion.Depth = 0;
            this.txtEndosaDireccion.Hint = "";
            this.txtEndosaDireccion.Location = new System.Drawing.Point(95, 195);
            this.txtEndosaDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndosaDireccion.Name = "txtEndosaDireccion";
            this.txtEndosaDireccion.PasswordChar = '\0';
            this.txtEndosaDireccion.SelectedText = "";
            this.txtEndosaDireccion.SelectionLength = 0;
            this.txtEndosaDireccion.SelectionStart = 0;
            this.txtEndosaDireccion.Size = new System.Drawing.Size(432, 23);
            this.txtEndosaDireccion.TabIndex = 58;
            this.txtEndosaDireccion.UseSystemPasswordChar = false;
            // 
            // txtEndosaRazonSocial
            // 
            this.txtEndosaRazonSocial.Depth = 0;
            this.txtEndosaRazonSocial.Hint = "";
            this.txtEndosaRazonSocial.Location = new System.Drawing.Point(116, 166);
            this.txtEndosaRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndosaRazonSocial.Name = "txtEndosaRazonSocial";
            this.txtEndosaRazonSocial.PasswordChar = '\0';
            this.txtEndosaRazonSocial.SelectedText = "";
            this.txtEndosaRazonSocial.SelectionLength = 0;
            this.txtEndosaRazonSocial.SelectionStart = 0;
            this.txtEndosaRazonSocial.Size = new System.Drawing.Size(269, 23);
            this.txtEndosaRazonSocial.TabIndex = 57;
            this.txtEndosaRazonSocial.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.Teal;
            this.materialDivider1.Depth = 0;
            this.materialDivider1.ForeColor = System.Drawing.Color.Teal;
            this.materialDivider1.Location = new System.Drawing.Point(66, 76);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(700, 2);
            this.materialDivider1.TabIndex = 56;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(539, 92);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(69, 19);
            this.materialLabel14.TabIndex = 55;
            this.materialLabel14.Text = "Nro Doc.";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(391, 92);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(74, 19);
            this.materialLabel12.TabIndex = 53;
            this.materialLabel12.Text = "Tipo Doc.";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(15, 118);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(73, 19);
            this.materialLabel10.TabIndex = 52;
            this.materialLabel10.Text = "Dirección";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(15, 92);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(96, 19);
            this.materialLabel9.TabIndex = 51;
            this.materialLabel9.Text = "Razón Social";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(15, 65);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(52, 19);
            this.materialLabel8.TabIndex = 50;
            this.materialLabel8.Text = "Titular";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(534, 12);
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
            this.materialLabel6.Location = new System.Drawing.Point(257, 12);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(51, 19);
            this.materialLabel6.TabIndex = 48;
            this.materialLabel6.Text = "Banco";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(509, 35);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(81, 19);
            this.materialLabel5.TabIndex = 47;
            this.materialLabel5.Text = "Fecha Vto.";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(243, 35);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(108, 19);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = "Fecha Emisión";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(15, 35);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 44;
            this.materialLabel2.Text = "Importe $";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(15, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(34, 19);
            this.materialLabel1.TabIndex = 43;
            this.materialLabel1.Text = "Nro";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Depth = 0;
            this.txtNroDoc.Hint = "";
            this.txtNroDoc.Location = new System.Drawing.Point(613, 88);
            this.txtNroDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.PasswordChar = '\0';
            this.txtNroDoc.SelectedText = "";
            this.txtNroDoc.SelectionLength = 0;
            this.txtNroDoc.SelectionStart = 0;
            this.txtNroDoc.Size = new System.Drawing.Size(154, 23);
            this.txtNroDoc.TabIndex = 42;
            this.txtNroDoc.UseSystemPasswordChar = false;
            // 
            // txtTitularTipoDoc
            // 
            this.txtTitularTipoDoc.Depth = 0;
            this.txtTitularTipoDoc.Hint = "";
            this.txtTitularTipoDoc.Location = new System.Drawing.Point(468, 86);
            this.txtTitularTipoDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTitularTipoDoc.Name = "txtTitularTipoDoc";
            this.txtTitularTipoDoc.PasswordChar = '\0';
            this.txtTitularTipoDoc.SelectedText = "";
            this.txtTitularTipoDoc.SelectionLength = 0;
            this.txtTitularTipoDoc.SelectionStart = 0;
            this.txtTitularTipoDoc.Size = new System.Drawing.Size(59, 23);
            this.txtTitularTipoDoc.TabIndex = 40;
            this.txtTitularTipoDoc.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(95, 117);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(432, 23);
            this.txtDireccion.TabIndex = 39;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtTitularRazonSocial
            // 
            this.txtTitularRazonSocial.Depth = 0;
            this.txtTitularRazonSocial.Hint = "";
            this.txtTitularRazonSocial.Location = new System.Drawing.Point(116, 88);
            this.txtTitularRazonSocial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTitularRazonSocial.Name = "txtTitularRazonSocial";
            this.txtTitularRazonSocial.PasswordChar = '\0';
            this.txtTitularRazonSocial.SelectedText = "";
            this.txtTitularRazonSocial.SelectionLength = 0;
            this.txtTitularRazonSocial.SelectionStart = 0;
            this.txtTitularRazonSocial.Size = new System.Drawing.Size(269, 23);
            this.txtTitularRazonSocial.TabIndex = 38;
            this.txtTitularRazonSocial.UseSystemPasswordChar = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Depth = 0;
            this.txtEstado.Hint = "";
            this.txtEstado.Location = new System.Drawing.Point(596, 10);
            this.txtEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.Size = new System.Drawing.Size(175, 23);
            this.txtEstado.TabIndex = 37;
            this.txtEstado.UseSystemPasswordChar = false;
            // 
            // txtBanco
            // 
            this.txtBanco.Depth = 0;
            this.txtBanco.Hint = "";
            this.txtBanco.Location = new System.Drawing.Point(314, 8);
            this.txtBanco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.PasswordChar = '\0';
            this.txtBanco.SelectedText = "";
            this.txtBanco.SelectionLength = 0;
            this.txtBanco.SelectionStart = 0;
            this.txtBanco.Size = new System.Drawing.Size(180, 23);
            this.txtBanco.TabIndex = 36;
            this.txtBanco.UseSystemPasswordChar = false;
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Depth = 0;
            this.txtFechaVencimiento.Hint = "";
            this.txtFechaVencimiento.Location = new System.Drawing.Point(596, 33);
            this.txtFechaVencimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.PasswordChar = '\0';
            this.txtFechaVencimiento.SelectedText = "";
            this.txtFechaVencimiento.SelectionLength = 0;
            this.txtFechaVencimiento.SelectionStart = 0;
            this.txtFechaVencimiento.Size = new System.Drawing.Size(176, 23);
            this.txtFechaVencimiento.TabIndex = 35;
            this.txtFechaVencimiento.UseSystemPasswordChar = false;
            // 
            // txtFechaEmision
            // 
            this.txtFechaEmision.Depth = 0;
            this.txtFechaEmision.Hint = "";
            this.txtFechaEmision.Location = new System.Drawing.Point(357, 33);
            this.txtFechaEmision.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFechaEmision.Name = "txtFechaEmision";
            this.txtFechaEmision.PasswordChar = '\0';
            this.txtFechaEmision.SelectedText = "";
            this.txtFechaEmision.SelectionLength = 0;
            this.txtFechaEmision.SelectionStart = 0;
            this.txtFechaEmision.Size = new System.Drawing.Size(137, 23);
            this.txtFechaEmision.TabIndex = 34;
            this.txtFechaEmision.UseSystemPasswordChar = false;
            // 
            // txtImporte
            // 
            this.txtImporte.Depth = 0;
            this.txtImporte.Hint = "";
            this.txtImporte.Location = new System.Drawing.Point(94, 33);
            this.txtImporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.PasswordChar = '\0';
            this.txtImporte.SelectedText = "";
            this.txtImporte.SelectionLength = 0;
            this.txtImporte.SelectionStart = 0;
            this.txtImporte.Size = new System.Drawing.Size(140, 23);
            this.txtImporte.TabIndex = 32;
            this.txtImporte.UseSystemPasswordChar = false;
            // 
            // txtNro
            // 
            this.txtNro.Depth = 0;
            this.txtNro.Hint = "";
            this.txtNro.Location = new System.Drawing.Point(55, 4);
            this.txtNro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNro.Name = "txtNro";
            this.txtNro.PasswordChar = '\0';
            this.txtNro.SelectedText = "";
            this.txtNro.SelectionLength = 0;
            this.txtNro.SelectionStart = 0;
            this.txtNro.Size = new System.Drawing.Size(179, 23);
            this.txtNro.TabIndex = 31;
            this.txtNro.UseSystemPasswordChar = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnEliminar,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(1, 1);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ERP.Properties.Resources.add;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.ToolTipText = "Nuevo (Ctrl + N)";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ERP.Properties.Resources.page_white_edit;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.ToolTipText = "Editar (Ctrl + F4)";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ERP.Properties.Resources.cross;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(62, 22);
            this.btnEliminar.Text = "Anular";
            this.btnEliminar.ToolTipText = "Eliminar (Ctrl + Delete)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 22);
            this.toolStripButton1.Text = "Depositar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton2.Text = "Rechazado";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ERP.Properties.Resources.door;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.ToolTipText = "Salir (Escape)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDatos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 197);
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
            this.dgvDatos.Size = new System.Drawing.Size(778, 197);
            this.dgvDatos.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFiltrar);
            this.panel3.Controls.Add(this.cbEstado);
            this.panel3.Controls.Add(this.materialLabel13);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Controls.Add(this.txtFiltrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 32);
            this.panel3.TabIndex = 7;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(721, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(36, 25);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(550, 4);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(164, 21);
            this.cbEstado.TabIndex = 3;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(483, 7);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(60, 19);
            this.materialLabel13.TabIndex = 2;
            this.materialLabel13.Text = "Estado:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 6);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(59, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Buscar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Depth = 0;
            this.txtFiltrar.Hint = "Ingrese el cheque que desea buscar";
            this.txtFiltrar.Location = new System.Drawing.Point(79, 6);
            this.txtFiltrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PasswordChar = '\0';
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.SelectionLength = 0;
            this.txtFiltrar.SelectionStart = 0;
            this.txtFiltrar.Size = new System.Drawing.Size(269, 23);
            this.txtFiltrar.TabIndex = 0;
            this.txtFiltrar.UseSystemPasswordChar = false;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListado";
            this.Text = "Cheques";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
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
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtNroDoc;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtTitularTipoDoc;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtTitularRazonSocial;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtEstado;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtBanco;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtFechaVencimiento;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtFechaEmision;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtImporte;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtNro;
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
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbEstado;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtEndosaNroDoc;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtEndosaTipoDoc;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtEndosaDireccion;
        protected MaterialSkin.Controls.MaterialSingleLineTextField txtEndosaRazonSocial;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}