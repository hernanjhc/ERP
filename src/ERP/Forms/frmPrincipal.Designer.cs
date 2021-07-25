﻿namespace ERP.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importarArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domiciliosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraciónGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruposDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.asignarUsuariosAGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarPermisosAGruposYUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.remitosDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasDeRecepciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.remitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 34);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(524, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.cajaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(93, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.domiciliosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.bancosToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.configuraciónGeneralToolStripMenuItem});
            this.ediciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ediciónToolStripMenuItem.Image")));
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem1,
            this.unidadesToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.rubrosToolStripMenuItem});
            this.productosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem.Image")));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.productosToolStripMenuItem.Text = "Artículos";
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarArtículosToolStripMenuItem});
            this.productosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem1.Image")));
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.productosToolStripMenuItem1.Text = "Artículos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // importarArtículosToolStripMenuItem
            // 
            this.importarArtículosToolStripMenuItem.Image = global::ERP.Properties.Resources.box_down;
            this.importarArtículosToolStripMenuItem.Name = "importarArtículosToolStripMenuItem";
            this.importarArtículosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importarArtículosToolStripMenuItem.Text = "Importar Artículos";
            this.importarArtículosToolStripMenuItem.Click += new System.EventHandler(this.importarArtículosToolStripMenuItem_Click);
            // 
            // unidadesToolStripMenuItem
            // 
            this.unidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadesToolStripMenuItem.Image")));
            this.unidadesToolStripMenuItem.Name = "unidadesToolStripMenuItem";
            this.unidadesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.unidadesToolStripMenuItem.Text = "Unidades";
            this.unidadesToolStripMenuItem.Click += new System.EventHandler(this.unidadesToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("marcasToolStripMenuItem.Image")));
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // rubrosToolStripMenuItem
            // 
            this.rubrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rubrosToolStripMenuItem.Image")));
            this.rubrosToolStripMenuItem.Name = "rubrosToolStripMenuItem";
            this.rubrosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.rubrosToolStripMenuItem.Text = "Rubros";
            this.rubrosToolStripMenuItem.Click += new System.EventHandler(this.rubrosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // domiciliosToolStripMenuItem
            // 
            this.domiciliosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentosToolStripMenuItem,
            this.localidadesToolStripMenuItem});
            this.domiciliosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("domiciliosToolStripMenuItem.Image")));
            this.domiciliosToolStripMenuItem.Name = "domiciliosToolStripMenuItem";
            this.domiciliosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.domiciliosToolStripMenuItem.Text = "Domicilios";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("departamentosToolStripMenuItem.Image")));
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // localidadesToolStripMenuItem
            // 
            this.localidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localidadesToolStripMenuItem.Image")));
            this.localidadesToolStripMenuItem.Name = "localidadesToolStripMenuItem";
            this.localidadesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.localidadesToolStripMenuItem.Text = "Localidades";
            this.localidadesToolStripMenuItem.Click += new System.EventHandler(this.localidadesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("proveedoresToolStripMenuItem.Image")));
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // bancosToolStripMenuItem1
            // 
            this.bancosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancosToolStripMenuItem2,
            this.sucursalesToolStripMenuItem});
            this.bancosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("bancosToolStripMenuItem1.Image")));
            this.bancosToolStripMenuItem1.Name = "bancosToolStripMenuItem1";
            this.bancosToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.bancosToolStripMenuItem1.Text = "Bancos";
            // 
            // bancosToolStripMenuItem2
            // 
            this.bancosToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("bancosToolStripMenuItem2.Image")));
            this.bancosToolStripMenuItem2.Name = "bancosToolStripMenuItem2";
            this.bancosToolStripMenuItem2.Size = new System.Drawing.Size(129, 22);
            this.bancosToolStripMenuItem2.Text = "Bancos";
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sucursalesToolStripMenuItem.Image")));
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            this.sucursalesToolStripMenuItem.Click += new System.EventHandler(this.sucursalesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 6);
            // 
            // configuraciónGeneralToolStripMenuItem
            // 
            this.configuraciónGeneralToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configuraciónGeneralToolStripMenuItem.Image")));
            this.configuraciónGeneralToolStripMenuItem.Name = "configuraciónGeneralToolStripMenuItem";
            this.configuraciónGeneralToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.configuraciónGeneralToolStripMenuItem.Text = "Configuración general";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.gruposDeUsuariosToolStripMenuItem,
            this.toolStripMenuItem4,
            this.asignarUsuariosAGruposToolStripMenuItem,
            this.asignarPermisosAGruposYUsuariosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seguridadToolStripMenuItem.Image")));
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarContraseñaToolStripMenuItem.Image")));
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // gruposDeUsuariosToolStripMenuItem
            // 
            this.gruposDeUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gruposDeUsuariosToolStripMenuItem.Image")));
            this.gruposDeUsuariosToolStripMenuItem.Name = "gruposDeUsuariosToolStripMenuItem";
            this.gruposDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.gruposDeUsuariosToolStripMenuItem.Text = "Grupos";
            this.gruposDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gruposDeUsuariosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(269, 6);
            // 
            // asignarUsuariosAGruposToolStripMenuItem
            // 
            this.asignarUsuariosAGruposToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("asignarUsuariosAGruposToolStripMenuItem.Image")));
            this.asignarUsuariosAGruposToolStripMenuItem.Name = "asignarUsuariosAGruposToolStripMenuItem";
            this.asignarUsuariosAGruposToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.asignarUsuariosAGruposToolStripMenuItem.Text = "Asignar usuarios a Grupos";
            this.asignarUsuariosAGruposToolStripMenuItem.Click += new System.EventHandler(this.asignarUsuariosAGruposToolStripMenuItem_Click);
            // 
            // asignarPermisosAGruposYUsuariosToolStripMenuItem
            // 
            this.asignarPermisosAGruposYUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("asignarPermisosAGruposYUsuariosToolStripMenuItem.Image")));
            this.asignarPermisosAGruposYUsuariosToolStripMenuItem.Name = "asignarPermisosAGruposYUsuariosToolStripMenuItem";
            this.asignarPermisosAGruposYUsuariosToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.asignarPermisosAGruposYUsuariosToolStripMenuItem.Text = "Asignar permisos a Grupos y Usuarios";
            this.asignarPermisosAGruposYUsuariosToolStripMenuItem.Click += new System.EventHandler(this.asignarPermisosAGruposYUsuariosToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem1,
            this.remitosDeCompraToolStripMenuItem,
            this.notasDeRecepciónToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.comprasToolStripMenuItem1.Text = "Compras";
            this.comprasToolStripMenuItem1.Click += new System.EventHandler(this.comprasToolStripMenuItem1_Click);
            // 
            // remitosDeCompraToolStripMenuItem
            // 
            this.remitosDeCompraToolStripMenuItem.Name = "remitosDeCompraToolStripMenuItem";
            this.remitosDeCompraToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.remitosDeCompraToolStripMenuItem.Text = "Remitos de Compra";
            // 
            // notasDeRecepciónToolStripMenuItem
            // 
            this.notasDeRecepciónToolStripMenuItem.Name = "notasDeRecepciónToolStripMenuItem";
            this.notasDeRecepciónToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.notasDeRecepciónToolStripMenuItem.Text = "Notas de Recepción";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presupuestosToolStripMenuItem1,
            this.remitosToolStripMenuItem,
            this.ventasToolStripMenuItem1,
            this.facturasDeVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventasToolStripMenuItem.Image")));
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // presupuestosToolStripMenuItem1
            // 
            this.presupuestosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("presupuestosToolStripMenuItem1.Image")));
            this.presupuestosToolStripMenuItem1.Name = "presupuestosToolStripMenuItem1";
            this.presupuestosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.presupuestosToolStripMenuItem1.Text = "Presupuestos";
            this.presupuestosToolStripMenuItem1.Click += new System.EventHandler(this.presupuestosToolStripMenuItem1_Click);
            // 
            // remitosToolStripMenuItem
            // 
            this.remitosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("remitosToolStripMenuItem.Image")));
            this.remitosToolStripMenuItem.Name = "remitosToolStripMenuItem";
            this.remitosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.remitosToolStripMenuItem.Text = "Remitos";
            this.remitosToolStripMenuItem.Click += new System.EventHandler(this.remitosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajeroToolStripMenuItem});
            this.ventasToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ventasToolStripMenuItem1.Image")));
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.ventasToolStripMenuItem1_Click);
            // 
            // facturasDeVentaToolStripMenuItem
            // 
            this.facturasDeVentaToolStripMenuItem.Name = "facturasDeVentaToolStripMenuItem";
            this.facturasDeVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasDeVentaToolStripMenuItem.Text = "Facturas de Venta";
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chequesToolStripMenuItem1});
            this.cajaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cajaToolStripMenuItem.Image")));
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.cajaToolStripMenuItem.Text = "Caja";
            this.cajaToolStripMenuItem.Click += new System.EventHandler(this.chequesToolStripMenuItem_Click);
            // 
            // chequesToolStripMenuItem1
            // 
            this.chequesToolStripMenuItem1.Name = "chequesToolStripMenuItem1";
            this.chequesToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.chequesToolStripMenuItem1.Text = "Cheques";
            this.chequesToolStripMenuItem1.Click += new System.EventHandler(this.chequesToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLogin,
            this.tsVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(530, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLogin
            // 
            this.tsLogin.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(122, 19);
            this.tsLogin.Text = "toolStripStatusLabel1";
            // 
            // tsVersion
            // 
            this.tsVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsVersion.Name = "tsVersion";
            this.tsVersion.Size = new System.Drawing.Size(393, 19);
            this.tsVersion.Spring = true;
            this.tsVersion.Text = "toolStripStatusLabel1";
            this.tsVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cajeroToolStripMenuItem
            // 
            this.cajeroToolStripMenuItem.Name = "cajeroToolStripMenuItem";
            this.cajeroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cajeroToolStripMenuItem.Text = "Cajero";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(530, 333);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Corralón Vaca Huañuna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem configuraciónGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem asignarUsuariosAGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarPermisosAGruposYUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rubrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domiciliosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem remitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLogin;
        private System.Windows.Forms.ToolStripStatusLabel tsVersion;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem remitosDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasDeRecepciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasDeVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importarArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
    }
}