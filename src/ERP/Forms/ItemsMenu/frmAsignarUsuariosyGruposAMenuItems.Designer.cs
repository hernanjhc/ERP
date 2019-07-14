namespace ERP.Forms.ItemsMenu
{
    partial class frmAsignarUsuariosyGruposAMenuItems
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tvItemsMenu = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbUsuarios = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbGrupos = new MaterialSkin.Controls.MaterialRadioButton();
            this.lbSinAsignar = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAsignados = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbAsignados = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.1285F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.8715F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tvItemsMenu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbSinAsignar, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.82979F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.17021F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(273, 489);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tvItemsMenu
            // 
            this.tvItemsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvItemsMenu.Location = new System.Drawing.Point(3, 3);
            this.tvItemsMenu.Name = "tvItemsMenu";
            this.tvItemsMenu.Size = new System.Drawing.Size(267, 220);
            this.tvItemsMenu.TabIndex = 0;
            this.tvItemsMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvItemsMenu_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbUsuarios);
            this.panel1.Controls.Add(this.rbGrupos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 37);
            this.panel1.TabIndex = 1;
            // 
            // rbUsuarios
            // 
            this.rbUsuarios.AutoSize = true;
            this.rbUsuarios.Depth = 0;
            this.rbUsuarios.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbUsuarios.Location = new System.Drawing.Point(178, 5);
            this.rbUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.rbUsuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbUsuarios.Name = "rbUsuarios";
            this.rbUsuarios.Ripple = true;
            this.rbUsuarios.Size = new System.Drawing.Size(83, 30);
            this.rbUsuarios.TabIndex = 1;
            this.rbUsuarios.TabStop = true;
            this.rbUsuarios.Text = "Usuarios";
            this.rbUsuarios.UseVisualStyleBackColor = true;
            this.rbUsuarios.CheckedChanged += new System.EventHandler(this.rbUsuarios_CheckedChanged);
            // 
            // rbGrupos
            // 
            this.rbGrupos.AutoSize = true;
            this.rbGrupos.Depth = 0;
            this.rbGrupos.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbGrupos.Location = new System.Drawing.Point(2, 5);
            this.rbGrupos.Margin = new System.Windows.Forms.Padding(0);
            this.rbGrupos.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbGrupos.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbGrupos.Name = "rbGrupos";
            this.rbGrupos.Ripple = true;
            this.rbGrupos.Size = new System.Drawing.Size(73, 30);
            this.rbGrupos.TabIndex = 0;
            this.rbGrupos.TabStop = true;
            this.rbGrupos.Text = "Grupos";
            this.rbGrupos.UseVisualStyleBackColor = true;
            this.rbGrupos.CheckedChanged += new System.EventHandler(this.rbGrupos_CheckedChanged);
            // 
            // lbSinAsignar
            // 
            this.lbSinAsignar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSinAsignar.FormattingEnabled = true;
            this.lbSinAsignar.Location = new System.Drawing.Point(3, 272);
            this.lbSinAsignar.Name = "lbSinAsignar";
            this.lbSinAsignar.Size = new System.Drawing.Size(267, 214);
            this.lbSinAsignar.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.1875F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.8125F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(284, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(320, 489);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnQuitar);
            this.panel2.Controls.Add(this.btnAsignar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 483);
            this.panel2.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ERP.Properties.Resources.door;
            this.btnSalir.Location = new System.Drawing.Point(3, 455);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::ERP.Properties.Resources.control_rewind_blue;
            this.btnQuitar.Location = new System.Drawing.Point(3, 269);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(27, 23);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Image = global::ERP.Properties.Resources.control_fastforward_blue;
            this.btnAsignar.Location = new System.Drawing.Point(3, 197);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(27, 23);
            this.btnAsignar.TabIndex = 0;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblAsignados, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbAsignados, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(42, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.832298F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.1677F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(275, 483);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lblAsignados
            // 
            this.lblAsignados.Depth = 0;
            this.lblAsignados.Hint = "";
            this.lblAsignados.Location = new System.Drawing.Point(3, 3);
            this.lblAsignados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAsignados.Name = "lblAsignados";
            this.lblAsignados.PasswordChar = '\0';
            this.lblAsignados.SelectedText = "";
            this.lblAsignados.SelectionLength = 0;
            this.lblAsignados.SelectionStart = 0;
            this.lblAsignados.Size = new System.Drawing.Size(269, 23);
            this.lblAsignados.TabIndex = 0;
            this.lblAsignados.Text = "Asignados";
            this.lblAsignados.UseSystemPasswordChar = false;
            // 
            // lbAsignados
            // 
            this.lbAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAsignados.FormattingEnabled = true;
            this.lbAsignados.Location = new System.Drawing.Point(3, 35);
            this.lbAsignados.Name = "lbAsignados";
            this.lbAsignados.Size = new System.Drawing.Size(269, 445);
            this.lbAsignados.TabIndex = 1;
            // 
            // frmAsignarUsuariosyGruposAMenuItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAsignarUsuariosyGruposAMenuItems";
            this.Text = "Asignar permisos a Usuarios y Grupos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TreeView tvItemsMenu;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRadioButton rbUsuarios;
        private MaterialSkin.Controls.MaterialRadioButton rbGrupos;
        private System.Windows.Forms.ListBox lbSinAsignar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblAsignados;
        private System.Windows.Forms.ListBox lbAsignados;
    }
}