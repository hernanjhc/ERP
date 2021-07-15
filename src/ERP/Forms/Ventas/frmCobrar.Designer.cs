namespace ERP.Forms.Ventas
{
    partial class frmCobrar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Efectivo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtVuelto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAbonaCon = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Tarjeta = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotalTarjeta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRecargoPorc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.cbTarjeta = new System.Windows.Forms.ComboBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNroTarjeta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMontoTarjeta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Cheque = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtpFechaVencCheque = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNroCheque = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMontoCheque = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CtaCorriente = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSaldoAnterior = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPagoContado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.txtMontoCta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCtaCorriente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCheque = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTarjeta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEfectivo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtACobrar = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Efectivo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Tarjeta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Cheque.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.CtaCorriente.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.23741F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.76259F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 341);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.Efectivo);
            this.tabControl1.Controls.Add(this.Tarjeta);
            this.tabControl1.Controls.Add(this.Cheque);
            this.tabControl1.Controls.Add(this.CtaCorriente);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 341);
            this.tabControl1.TabIndex = 1;
            // 
            // Efectivo
            // 
            this.Efectivo.Controls.Add(this.groupBox1);
            this.Efectivo.ForeColor = System.Drawing.Color.Teal;
            this.Efectivo.Location = new System.Drawing.Point(4, 4);
            this.Efectivo.Name = "Efectivo";
            this.Efectivo.Padding = new System.Windows.Forms.Padding(3);
            this.Efectivo.Size = new System.Drawing.Size(261, 333);
            this.Efectivo.TabIndex = 0;
            this.Efectivo.Text = "Efectivo";
            this.Efectivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtVuelto);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtAbonaCon);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(14, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EFECTIVO";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(37, 141);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(62, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "vuelto $";
            // 
            // txtVuelto
            // 
            this.txtVuelto.Depth = 0;
            this.txtVuelto.Hint = "";
            this.txtVuelto.Location = new System.Drawing.Point(108, 141);
            this.txtVuelto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtVuelto.Name = "txtVuelto";
            this.txtVuelto.PasswordChar = '\0';
            this.txtVuelto.SelectedText = "";
            this.txtVuelto.SelectionLength = 0;
            this.txtVuelto.SelectionStart = 0;
            this.txtVuelto.Size = new System.Drawing.Size(97, 23);
            this.txtVuelto.TabIndex = 6;
            this.txtVuelto.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(6, 96);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(93, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Abona con $";
            // 
            // txtAbonaCon
            // 
            this.txtAbonaCon.Depth = 0;
            this.txtAbonaCon.Hint = "";
            this.txtAbonaCon.Location = new System.Drawing.Point(108, 96);
            this.txtAbonaCon.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAbonaCon.Name = "txtAbonaCon";
            this.txtAbonaCon.PasswordChar = '\0';
            this.txtAbonaCon.SelectedText = "";
            this.txtAbonaCon.SelectionLength = 0;
            this.txtAbonaCon.SelectionStart = 0;
            this.txtAbonaCon.Size = new System.Drawing.Size(97, 23);
            this.txtAbonaCon.TabIndex = 4;
            this.txtAbonaCon.UseSystemPasswordChar = false;
            // 
            // Tarjeta
            // 
            this.Tarjeta.Controls.Add(this.groupBox2);
            this.Tarjeta.ForeColor = System.Drawing.Color.Teal;
            this.Tarjeta.Location = new System.Drawing.Point(4, 4);
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.Padding = new System.Windows.Forms.Padding(3);
            this.Tarjeta.Size = new System.Drawing.Size(261, 333);
            this.Tarjeta.TabIndex = 1;
            this.Tarjeta.Text = "Tarjeta";
            this.Tarjeta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.txtTotalTarjeta);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.txtRecargoPorc);
            this.groupBox2.Controls.Add(this.materialDivider1);
            this.groupBox2.Controls.Add(this.cbTarjeta);
            this.groupBox2.Controls.Add(this.materialLabel9);
            this.groupBox2.Controls.Add(this.materialLabel10);
            this.groupBox2.Controls.Add(this.txtNroTarjeta);
            this.groupBox2.Controls.Add(this.materialLabel11);
            this.groupBox2.Controls.Add(this.txtMontoTarjeta);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(15, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TARJETA";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(42, 233);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(56, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Total $";
            // 
            // txtTotalTarjeta
            // 
            this.txtTotalTarjeta.Depth = 0;
            this.txtTotalTarjeta.Hint = "";
            this.txtTotalTarjeta.Location = new System.Drawing.Point(111, 233);
            this.txtTotalTarjeta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalTarjeta.Name = "txtTotalTarjeta";
            this.txtTotalTarjeta.PasswordChar = '\0';
            this.txtTotalTarjeta.SelectedText = "";
            this.txtTotalTarjeta.SelectionLength = 0;
            this.txtTotalTarjeta.SelectionStart = 0;
            this.txtTotalTarjeta.Size = new System.Drawing.Size(97, 23);
            this.txtTotalTarjeta.TabIndex = 24;
            this.txtTotalTarjeta.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(19, 194);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 19);
            this.materialLabel4.TabIndex = 23;
            this.materialLabel4.Text = "Recargo %";
            // 
            // txtRecargoPorc
            // 
            this.txtRecargoPorc.Depth = 0;
            this.txtRecargoPorc.Hint = "";
            this.txtRecargoPorc.Location = new System.Drawing.Point(111, 194);
            this.txtRecargoPorc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRecargoPorc.Name = "txtRecargoPorc";
            this.txtRecargoPorc.PasswordChar = '\0';
            this.txtRecargoPorc.SelectedText = "";
            this.txtRecargoPorc.SelectionLength = 0;
            this.txtRecargoPorc.SelectionStart = 0;
            this.txtRecargoPorc.Size = new System.Drawing.Size(42, 23);
            this.txtRecargoPorc.TabIndex = 22;
            this.txtRecargoPorc.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(22, 165);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(195, 1);
            this.materialDivider1.TabIndex = 21;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.FormattingEnabled = true;
            this.cbTarjeta.Location = new System.Drawing.Point(87, 105);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(121, 24);
            this.cbTarjeta.TabIndex = 20;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(18, 104);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(56, 19);
            this.materialLabel9.TabIndex = 19;
            this.materialLabel9.Text = "Tarjeta";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(40, 74);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(34, 19);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Nro";
            // 
            // txtNroTarjeta
            // 
            this.txtNroTarjeta.Depth = 0;
            this.txtNroTarjeta.Enabled = false;
            this.txtNroTarjeta.Hint = "";
            this.txtNroTarjeta.Location = new System.Drawing.Point(87, 71);
            this.txtNroTarjeta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroTarjeta.Name = "txtNroTarjeta";
            this.txtNroTarjeta.PasswordChar = '\0';
            this.txtNroTarjeta.SelectedText = "";
            this.txtNroTarjeta.SelectionLength = 0;
            this.txtNroTarjeta.SelectionStart = 0;
            this.txtNroTarjeta.Size = new System.Drawing.Size(121, 23);
            this.txtNroTarjeta.TabIndex = 17;
            this.txtNroTarjeta.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(9, 44);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(65, 19);
            this.materialLabel11.TabIndex = 16;
            this.materialLabel11.Text = "Monto $";
            // 
            // txtMontoTarjeta
            // 
            this.txtMontoTarjeta.Depth = 0;
            this.txtMontoTarjeta.Enabled = false;
            this.txtMontoTarjeta.Hint = "";
            this.txtMontoTarjeta.Location = new System.Drawing.Point(87, 41);
            this.txtMontoTarjeta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMontoTarjeta.Name = "txtMontoTarjeta";
            this.txtMontoTarjeta.PasswordChar = '\0';
            this.txtMontoTarjeta.SelectedText = "";
            this.txtMontoTarjeta.SelectionLength = 0;
            this.txtMontoTarjeta.SelectionStart = 0;
            this.txtMontoTarjeta.Size = new System.Drawing.Size(121, 23);
            this.txtMontoTarjeta.TabIndex = 15;
            this.txtMontoTarjeta.UseSystemPasswordChar = false;
            // 
            // Cheque
            // 
            this.Cheque.Controls.Add(this.groupBox3);
            this.Cheque.ForeColor = System.Drawing.Color.Teal;
            this.Cheque.Location = new System.Drawing.Point(4, 4);
            this.Cheque.Name = "Cheque";
            this.Cheque.Size = new System.Drawing.Size(261, 333);
            this.Cheque.TabIndex = 2;
            this.Cheque.Text = "Cheque";
            this.Cheque.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.materialRaisedButton1);
            this.groupBox3.Controls.Add(this.dtpFechaVencCheque);
            this.groupBox3.Controls.Add(this.materialLabel5);
            this.groupBox3.Controls.Add(this.cbBanco);
            this.groupBox3.Controls.Add(this.materialLabel6);
            this.groupBox3.Controls.Add(this.materialLabel12);
            this.groupBox3.Controls.Add(this.txtNroCheque);
            this.groupBox3.Controls.Add(this.materialLabel13);
            this.groupBox3.Controls.Add(this.txtMontoCheque);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(14, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 258);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CHEQUE";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(62, 216);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(128, 36);
            this.materialRaisedButton1.TabIndex = 26;
            this.materialRaisedButton1.Text = "Cargar Cheque";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // dtpFechaVencCheque
            // 
            this.dtpFechaVencCheque.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVencCheque.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencCheque.Location = new System.Drawing.Point(98, 182);
            this.dtpFechaVencCheque.Name = "dtpFechaVencCheque";
            this.dtpFechaVencCheque.Size = new System.Drawing.Size(121, 23);
            this.dtpFechaVencCheque.TabIndex = 25;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(1, 185);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(91, 19);
            this.materialLabel5.TabIndex = 24;
            this.materialLabel5.Text = "Fecha Venc.";
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(98, 142);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(121, 24);
            this.cbBanco.TabIndex = 23;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(41, 143);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(51, 19);
            this.materialLabel6.TabIndex = 22;
            this.materialLabel6.Text = "Banco";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(58, 103);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(34, 19);
            this.materialLabel12.TabIndex = 21;
            this.materialLabel12.Text = "Nro";
            // 
            // txtNroCheque
            // 
            this.txtNroCheque.Depth = 0;
            this.txtNroCheque.Hint = "";
            this.txtNroCheque.Location = new System.Drawing.Point(98, 99);
            this.txtNroCheque.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNroCheque.Name = "txtNroCheque";
            this.txtNroCheque.PasswordChar = '\0';
            this.txtNroCheque.SelectedText = "";
            this.txtNroCheque.SelectionLength = 0;
            this.txtNroCheque.SelectionStart = 0;
            this.txtNroCheque.Size = new System.Drawing.Size(121, 23);
            this.txtNroCheque.TabIndex = 20;
            this.txtNroCheque.UseSystemPasswordChar = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(27, 66);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(65, 19);
            this.materialLabel13.TabIndex = 19;
            this.materialLabel13.Text = "Monto $";
            // 
            // txtMontoCheque
            // 
            this.txtMontoCheque.Depth = 0;
            this.txtMontoCheque.Hint = "";
            this.txtMontoCheque.Location = new System.Drawing.Point(98, 62);
            this.txtMontoCheque.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMontoCheque.Name = "txtMontoCheque";
            this.txtMontoCheque.PasswordChar = '\0';
            this.txtMontoCheque.SelectedText = "";
            this.txtMontoCheque.SelectionLength = 0;
            this.txtMontoCheque.SelectionStart = 0;
            this.txtMontoCheque.Size = new System.Drawing.Size(121, 23);
            this.txtMontoCheque.TabIndex = 18;
            this.txtMontoCheque.UseSystemPasswordChar = false;
            // 
            // CtaCorriente
            // 
            this.CtaCorriente.Controls.Add(this.groupBox4);
            this.CtaCorriente.ForeColor = System.Drawing.Color.Teal;
            this.CtaCorriente.Location = new System.Drawing.Point(4, 4);
            this.CtaCorriente.Name = "CtaCorriente";
            this.CtaCorriente.Size = new System.Drawing.Size(261, 333);
            this.CtaCorriente.TabIndex = 3;
            this.CtaCorriente.Text = "Cta. Corriente";
            this.CtaCorriente.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.materialLabel7);
            this.groupBox4.Controls.Add(this.txtSaldoAnterior);
            this.groupBox4.Controls.Add(this.materialLabel8);
            this.groupBox4.Controls.Add(this.txtPagoContado);
            this.groupBox4.Controls.Add(this.materialLabel14);
            this.groupBox4.Controls.Add(this.txtMontoCta);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Teal;
            this.groupBox4.Location = new System.Drawing.Point(16, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 258);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CTA. CORRIENTE";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(7, 166);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(117, 19);
            this.materialLabel7.TabIndex = 15;
            this.materialLabel7.Text = "Saldo Anterior $";
            // 
            // txtSaldoAnterior
            // 
            this.txtSaldoAnterior.Depth = 0;
            this.txtSaldoAnterior.Hint = "";
            this.txtSaldoAnterior.Location = new System.Drawing.Point(128, 166);
            this.txtSaldoAnterior.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSaldoAnterior.Name = "txtSaldoAnterior";
            this.txtSaldoAnterior.PasswordChar = '\0';
            this.txtSaldoAnterior.SelectedText = "";
            this.txtSaldoAnterior.SelectionLength = 0;
            this.txtSaldoAnterior.SelectionStart = 0;
            this.txtSaldoAnterior.Size = new System.Drawing.Size(97, 23);
            this.txtSaldoAnterior.TabIndex = 14;
            this.txtSaldoAnterior.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(7, 119);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(116, 19);
            this.materialLabel8.TabIndex = 13;
            this.materialLabel8.Text = "Pago Contado $";
            // 
            // txtPagoContado
            // 
            this.txtPagoContado.Depth = 0;
            this.txtPagoContado.Hint = "";
            this.txtPagoContado.Location = new System.Drawing.Point(128, 119);
            this.txtPagoContado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPagoContado.Name = "txtPagoContado";
            this.txtPagoContado.PasswordChar = '\0';
            this.txtPagoContado.SelectedText = "";
            this.txtPagoContado.SelectionLength = 0;
            this.txtPagoContado.SelectionStart = 0;
            this.txtPagoContado.Size = new System.Drawing.Size(97, 23);
            this.txtPagoContado.TabIndex = 12;
            this.txtPagoContado.UseSystemPasswordChar = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(3, 78);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(120, 19);
            this.materialLabel14.TabIndex = 11;
            this.materialLabel14.Text = "A cta corriente $";
            // 
            // txtMontoCta
            // 
            this.txtMontoCta.Depth = 0;
            this.txtMontoCta.Hint = "";
            this.txtMontoCta.Location = new System.Drawing.Point(128, 74);
            this.txtMontoCta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMontoCta.Name = "txtMontoCta";
            this.txtMontoCta.PasswordChar = '\0';
            this.txtMontoCta.SelectedText = "";
            this.txtMontoCta.SelectionLength = 0;
            this.txtMontoCta.SelectionStart = 0;
            this.txtMontoCta.Size = new System.Drawing.Size(97, 23);
            this.txtMontoCta.TabIndex = 10;
            this.txtMontoCta.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(299, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 341);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtACobrar);
            this.panel7.Controls.Add(this.btnCancelar);
            this.panel7.Controls.Add(this.btnConfirmar);
            this.panel7.Controls.Add(this.materialLabel19);
            this.panel7.Controls.Add(this.txtTotal);
            this.panel7.Controls.Add(this.materialLabel18);
            this.panel7.Controls.Add(this.txtCtaCorriente);
            this.panel7.Controls.Add(this.materialLabel15);
            this.panel7.Controls.Add(this.txtCheque);
            this.panel7.Controls.Add(this.materialLabel16);
            this.panel7.Controls.Add(this.txtTarjeta);
            this.panel7.Controls.Add(this.materialLabel17);
            this.panel7.Controls.Add(this.txtEfectivo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(253, 341);
            this.panel7.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(138, 290);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(94, 36);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.Location = new System.Drawing.Point(28, 290);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Primary = true;
            this.btnConfirmar.Size = new System.Drawing.Size(94, 36);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(61, 236);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(67, 19);
            this.materialLabel19.TabIndex = 19;
            this.materialLabel19.Text = "TOTAL $";
            // 
            // txtTotal
            // 
            this.txtTotal.Depth = 0;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Hint = "";
            this.txtTotal.Location = new System.Drawing.Point(141, 236);
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(97, 23);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(13, 196);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(122, 19);
            this.materialLabel18.TabIndex = 17;
            this.materialLabel18.Text = "A cta Corriente $";
            // 
            // txtCtaCorriente
            // 
            this.txtCtaCorriente.Depth = 0;
            this.txtCtaCorriente.Enabled = false;
            this.txtCtaCorriente.Hint = "";
            this.txtCtaCorriente.Location = new System.Drawing.Point(141, 196);
            this.txtCtaCorriente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCtaCorriente.Name = "txtCtaCorriente";
            this.txtCtaCorriente.PasswordChar = '\0';
            this.txtCtaCorriente.SelectedText = "";
            this.txtCtaCorriente.SelectionLength = 0;
            this.txtCtaCorriente.SelectionStart = 0;
            this.txtCtaCorriente.Size = new System.Drawing.Size(97, 23);
            this.txtCtaCorriente.TabIndex = 16;
            this.txtCtaCorriente.UseSystemPasswordChar = false;
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(63, 159);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(72, 19);
            this.materialLabel15.TabIndex = 15;
            this.materialLabel15.Text = "Cheque $";
            // 
            // txtCheque
            // 
            this.txtCheque.Depth = 0;
            this.txtCheque.Enabled = false;
            this.txtCheque.Hint = "";
            this.txtCheque.Location = new System.Drawing.Point(141, 155);
            this.txtCheque.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.PasswordChar = '\0';
            this.txtCheque.SelectedText = "";
            this.txtCheque.SelectionLength = 0;
            this.txtCheque.SelectionStart = 0;
            this.txtCheque.Size = new System.Drawing.Size(97, 23);
            this.txtCheque.TabIndex = 14;
            this.txtCheque.UseSystemPasswordChar = false;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(67, 118);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(68, 19);
            this.materialLabel16.TabIndex = 13;
            this.materialLabel16.Text = "Tarjeta $";
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Depth = 0;
            this.txtTarjeta.Enabled = false;
            this.txtTarjeta.Hint = "";
            this.txtTarjeta.Location = new System.Drawing.Point(141, 114);
            this.txtTarjeta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.PasswordChar = '\0';
            this.txtTarjeta.SelectedText = "";
            this.txtTarjeta.SelectionLength = 0;
            this.txtTarjeta.SelectionStart = 0;
            this.txtTarjeta.Size = new System.Drawing.Size(97, 23);
            this.txtTarjeta.TabIndex = 12;
            this.txtTarjeta.UseSystemPasswordChar = false;
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(59, 83);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(76, 19);
            this.materialLabel17.TabIndex = 11;
            this.materialLabel17.Text = "Efectivo $";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Depth = 0;
            this.txtEfectivo.Enabled = false;
            this.txtEfectivo.Hint = "";
            this.txtEfectivo.Location = new System.Drawing.Point(141, 79);
            this.txtEfectivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.PasswordChar = '\0';
            this.txtEfectivo.SelectedText = "";
            this.txtEfectivo.SelectionLength = 0;
            this.txtEfectivo.SelectionStart = 0;
            this.txtEfectivo.Size = new System.Drawing.Size(97, 23);
            this.txtEfectivo.TabIndex = 10;
            this.txtEfectivo.UseSystemPasswordChar = false;
            // 
            // txtACobrar
            // 
            this.txtACobrar.AutoSize = true;
            this.txtACobrar.Depth = 0;
            this.txtACobrar.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtACobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtACobrar.Location = new System.Drawing.Point(160, 23);
            this.txtACobrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtACobrar.Name = "txtACobrar";
            this.txtACobrar.Size = new System.Drawing.Size(78, 19);
            this.txtACobrar.TabIndex = 23;
            this.txtACobrar.Text = "A cobrar $";
            // 
            // frmCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCobrar";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Efectivo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Tarjeta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Cheque.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.CtaCorriente.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCtaCorriente;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCheque;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTarjeta;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEfectivo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Efectivo;
        private System.Windows.Forms.TabPage Tarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtVuelto;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAbonaCon;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalTarjeta;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRecargoPorc;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ComboBox cbTarjeta;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroTarjeta;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMontoTarjeta;
        private System.Windows.Forms.TabPage Cheque;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaVencCheque;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox cbBanco;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNroCheque;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMontoCheque;
        private System.Windows.Forms.TabPage CtaCorriente;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSaldoAnterior;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPagoContado;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMontoCta;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel txtACobrar;
    }
}