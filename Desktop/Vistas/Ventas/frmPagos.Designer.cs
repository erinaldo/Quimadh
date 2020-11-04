﻿namespace Desktop.Vistas.Ventas
{
    partial class frmPagos
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
            this.components = new System.ComponentModel.Container();
            this.labelQuimadh10 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.txtEfectivo = new Controles.TextBoxNumerico();
            this.dgvTransf = new System.Windows.Forms.DataGridView();
            this.clmTransfImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransfNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuimadh12 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh13 = new Controles.LabelQuimadh(this.components);
            this.dgvTarj = new System.Windows.Forms.DataGridView();
            this.clmTarjImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTarjTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTarjMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuimadh11 = new Controles.LabelQuimadh(this.components);
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.clmChqImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqCuitLib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqNombreLib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqFechaVto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqEcheq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.clmFactPvNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFactTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFactFCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuimadh9 = new Controles.LabelQuimadh(this.components);
            this.btnMasTransf = new Controles.ButtonQuimadh(this.components);
            this.btnMenosTransf = new Controles.ButtonQuimadh(this.components);
            this.btnMenosChq = new Controles.ButtonQuimadh(this.components);
            this.btnMasChq = new Controles.ButtonQuimadh(this.components);
            this.btnMenosTarj = new Controles.ButtonQuimadh(this.components);
            this.btnMasTarj = new Controles.ButtonQuimadh(this.components);
            this.btnAgregar = new Controles.ButtonQuimadh(this.components);
            this.txtTotal = new Controles.TextBoxQuimadh();
            this.btnMasFact = new Controles.ButtonQuimadh(this.components);
            this.btnMenosFact = new Controles.ButtonQuimadh(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(40, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Size = new System.Drawing.Size(132, 54);
            this.lblTitulo.Text = "Pagos";
            // 
            // labelQuimadh10
            // 
            this.labelQuimadh10.AutoSize = true;
            this.labelQuimadh10.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh10.Location = new System.Drawing.Point(707, 516);
            this.labelQuimadh10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh10.Name = "labelQuimadh10";
            this.labelQuimadh10.Size = new System.Drawing.Size(63, 20);
            this.labelQuimadh10.TabIndex = 51;
            this.labelQuimadh10.Text = "Total: ";
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(99, 154);
            this.labelQuimadh7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(77, 20);
            this.labelQuimadh7.TabIndex = 26;
            this.labelQuimadh7.Text = "Efectivo";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Decimales = 2;
            this.txtEfectivo.Enteros = 16;
            this.txtEfectivo.EnterTabulacion = true;
            this.txtEfectivo.Location = new System.Drawing.Point(182, 154);
            this.txtEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(211, 23);
            this.txtEfectivo.TabIndex = 25;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEfectivo.Leave += new System.EventHandler(this.txtEfectivo_Leave);
            // 
            // dgvTransf
            // 
            this.dgvTransf.AllowUserToAddRows = false;
            this.dgvTransf.AllowUserToDeleteRows = false;
            this.dgvTransf.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTransfImporte,
            this.clmTransfNro});
            this.dgvTransf.Location = new System.Drawing.Point(182, 195);
            this.dgvTransf.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTransf.Name = "dgvTransf";
            this.dgvTransf.ReadOnly = true;
            this.dgvTransf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransf.Size = new System.Drawing.Size(276, 128);
            this.dgvTransf.TabIndex = 64;
            // 
            // clmTransfImporte
            // 
            this.clmTransfImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmTransfImporte.HeaderText = "Importe";
            this.clmTransfImporte.Name = "clmTransfImporte";
            this.clmTransfImporte.ReadOnly = true;
            this.clmTransfImporte.Width = 80;
            // 
            // clmTransfNro
            // 
            this.clmTransfNro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmTransfNro.HeaderText = "Nro/Cbte";
            this.clmTransfNro.Name = "clmTransfNro";
            this.clmTransfNro.ReadOnly = true;
            this.clmTransfNro.Width = 80;
            // 
            // labelQuimadh12
            // 
            this.labelQuimadh12.AutoSize = true;
            this.labelQuimadh12.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh12.Location = new System.Drawing.Point(39, 195);
            this.labelQuimadh12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh12.Name = "labelQuimadh12";
            this.labelQuimadh12.Size = new System.Drawing.Size(135, 20);
            this.labelQuimadh12.TabIndex = 65;
            this.labelQuimadh12.Text = "Transferencias";
            // 
            // labelQuimadh13
            // 
            this.labelQuimadh13.AutoSize = true;
            this.labelQuimadh13.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh13.Location = new System.Drawing.Point(536, 195);
            this.labelQuimadh13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh13.Name = "labelQuimadh13";
            this.labelQuimadh13.Size = new System.Drawing.Size(78, 20);
            this.labelQuimadh13.TabIndex = 67;
            this.labelQuimadh13.Text = "Tarjetas";
            // 
            // dgvTarj
            // 
            this.dgvTarj.AllowUserToAddRows = false;
            this.dgvTarj.AllowUserToDeleteRows = false;
            this.dgvTarj.BackgroundColor = System.Drawing.Color.White;
            this.dgvTarj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTarjImporte,
            this.clmTarjTipo,
            this.clmTarjMarca});
            this.dgvTarj.Location = new System.Drawing.Point(622, 195);
            this.dgvTarj.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTarj.Name = "dgvTarj";
            this.dgvTarj.ReadOnly = true;
            this.dgvTarj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarj.Size = new System.Drawing.Size(322, 128);
            this.dgvTarj.TabIndex = 66;
            // 
            // clmTarjImporte
            // 
            this.clmTarjImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clmTarjImporte.HeaderText = "Importe";
            this.clmTarjImporte.Name = "clmTarjImporte";
            this.clmTarjImporte.ReadOnly = true;
            this.clmTarjImporte.Width = 80;
            // 
            // clmTarjTipo
            // 
            this.clmTarjTipo.HeaderText = "Tipo";
            this.clmTarjTipo.Name = "clmTarjTipo";
            this.clmTarjTipo.ReadOnly = true;
            this.clmTarjTipo.Width = 80;
            // 
            // clmTarjMarca
            // 
            this.clmTarjMarca.HeaderText = "Marca";
            this.clmTarjMarca.Name = "clmTarjMarca";
            this.clmTarjMarca.ReadOnly = true;
            // 
            // labelQuimadh11
            // 
            this.labelQuimadh11.AutoSize = true;
            this.labelQuimadh11.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh11.Location = new System.Drawing.Point(92, 331);
            this.labelQuimadh11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh11.Name = "labelQuimadh11";
            this.labelQuimadh11.Size = new System.Drawing.Size(82, 20);
            this.labelQuimadh11.TabIndex = 69;
            this.labelQuimadh11.Text = "Cheques";
            // 
            // dgvCheques
            // 
            this.dgvCheques.AllowUserToAddRows = false;
            this.dgvCheques.AllowUserToDeleteRows = false;
            this.dgvCheques.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmChqImporte,
            this.clmChqNumero,
            this.clmChqBanco,
            this.clmChqCuitLib,
            this.clmChqNombreLib,
            this.clmChqFechaVto,
            this.clmChqTipo,
            this.clmChqEcheq});
            this.dgvCheques.Location = new System.Drawing.Point(182, 331);
            this.dgvCheques.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCheques.MultiSelect = false;
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.ReadOnly = true;
            this.dgvCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheques.Size = new System.Drawing.Size(762, 127);
            this.dgvCheques.TabIndex = 68;
            // 
            // clmChqImporte
            // 
            this.clmChqImporte.HeaderText = "Importe";
            this.clmChqImporte.Name = "clmChqImporte";
            this.clmChqImporte.ReadOnly = true;
            this.clmChqImporte.Width = 80;
            // 
            // clmChqNumero
            // 
            this.clmChqNumero.HeaderText = "Numero";
            this.clmChqNumero.Name = "clmChqNumero";
            this.clmChqNumero.ReadOnly = true;
            this.clmChqNumero.Width = 70;
            // 
            // clmChqBanco
            // 
            this.clmChqBanco.HeaderText = "Banco";
            this.clmChqBanco.Name = "clmChqBanco";
            this.clmChqBanco.ReadOnly = true;
            this.clmChqBanco.Width = 70;
            // 
            // clmChqCuitLib
            // 
            this.clmChqCuitLib.HeaderText = "Cuit Lib";
            this.clmChqCuitLib.Name = "clmChqCuitLib";
            this.clmChqCuitLib.ReadOnly = true;
            this.clmChqCuitLib.Width = 80;
            // 
            // clmChqNombreLib
            // 
            this.clmChqNombreLib.HeaderText = "Nombre Lib";
            this.clmChqNombreLib.Name = "clmChqNombreLib";
            this.clmChqNombreLib.ReadOnly = true;
            this.clmChqNombreLib.Width = 80;
            // 
            // clmChqFechaVto
            // 
            this.clmChqFechaVto.HeaderText = "Fecha Vto";
            this.clmChqFechaVto.Name = "clmChqFechaVto";
            this.clmChqFechaVto.ReadOnly = true;
            this.clmChqFechaVto.Width = 70;
            // 
            // clmChqTipo
            // 
            this.clmChqTipo.HeaderText = "Tipo";
            this.clmChqTipo.Name = "clmChqTipo";
            this.clmChqTipo.ReadOnly = true;
            this.clmChqTipo.Width = 70;
            // 
            // clmChqEcheq
            // 
            this.clmChqEcheq.HeaderText = "ECheq";
            this.clmChqEcheq.Name = "clmChqEcheq";
            this.clmChqEcheq.ReadOnly = true;
            this.clmChqEcheq.Width = 50;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFactPvNro,
            this.clmFactTipo,
            this.clmFactFCE});
            this.dgvFacturas.GridColor = System.Drawing.Color.Black;
            this.dgvFacturas.Location = new System.Drawing.Point(182, 466);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(388, 134);
            this.dgvFacturas.TabIndex = 73;
            // 
            // clmFactPvNro
            // 
            this.clmFactPvNro.HeaderText = "Nro Factura";
            this.clmFactPvNro.MaxInputLength = 15;
            this.clmFactPvNro.Name = "clmFactPvNro";
            this.clmFactPvNro.ReadOnly = true;
            // 
            // clmFactTipo
            // 
            this.clmFactTipo.HeaderText = "Letra";
            this.clmFactTipo.Name = "clmFactTipo";
            this.clmFactTipo.ReadOnly = true;
            this.clmFactTipo.Width = 50;
            // 
            // clmFactFCE
            // 
            this.clmFactFCE.HeaderText = "FCE";
            this.clmFactFCE.Name = "clmFactFCE";
            this.clmFactFCE.ReadOnly = true;
            this.clmFactFCE.Width = 50;
            // 
            // labelQuimadh9
            // 
            this.labelQuimadh9.AutoSize = true;
            this.labelQuimadh9.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh9.Location = new System.Drawing.Point(86, 466);
            this.labelQuimadh9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh9.Name = "labelQuimadh9";
            this.labelQuimadh9.Size = new System.Drawing.Size(95, 20);
            this.labelQuimadh9.TabIndex = 72;
            this.labelQuimadh9.Text = "Facturas: ";
            // 
            // btnMasTransf
            // 
            this.btnMasTransf.Location = new System.Drawing.Point(465, 195);
            this.btnMasTransf.Name = "btnMasTransf";
            this.btnMasTransf.Size = new System.Drawing.Size(50, 28);
            this.btnMasTransf.TabIndex = 74;
            this.btnMasTransf.Text = "+";
            this.btnMasTransf.UseVisualStyleBackColor = true;
            this.btnMasTransf.Click += new System.EventHandler(this.btnMasTransf_Click);
            // 
            // btnMenosTransf
            // 
            this.btnMenosTransf.Location = new System.Drawing.Point(465, 229);
            this.btnMenosTransf.Name = "btnMenosTransf";
            this.btnMenosTransf.Size = new System.Drawing.Size(50, 28);
            this.btnMenosTransf.TabIndex = 75;
            this.btnMenosTransf.Text = "-";
            this.btnMenosTransf.UseVisualStyleBackColor = true;
            this.btnMenosTransf.Click += new System.EventHandler(this.btnMenosTransf_Click);
            // 
            // btnMenosChq
            // 
            this.btnMenosChq.Location = new System.Drawing.Point(951, 349);
            this.btnMenosChq.Name = "btnMenosChq";
            this.btnMenosChq.Size = new System.Drawing.Size(50, 28);
            this.btnMenosChq.TabIndex = 77;
            this.btnMenosChq.Text = "-";
            this.btnMenosChq.UseVisualStyleBackColor = true;
            this.btnMenosChq.Click += new System.EventHandler(this.btnMenosChq_Click);
            // 
            // btnMasChq
            // 
            this.btnMasChq.Location = new System.Drawing.Point(951, 315);
            this.btnMasChq.Name = "btnMasChq";
            this.btnMasChq.Size = new System.Drawing.Size(50, 28);
            this.btnMasChq.TabIndex = 76;
            this.btnMasChq.Text = "+";
            this.btnMasChq.UseVisualStyleBackColor = true;
            this.btnMasChq.Click += new System.EventHandler(this.btnMasChq_Click);
            // 
            // btnMenosTarj
            // 
            this.btnMenosTarj.Location = new System.Drawing.Point(951, 229);
            this.btnMenosTarj.Name = "btnMenosTarj";
            this.btnMenosTarj.Size = new System.Drawing.Size(50, 28);
            this.btnMenosTarj.TabIndex = 79;
            this.btnMenosTarj.Text = "-";
            this.btnMenosTarj.UseVisualStyleBackColor = true;
            this.btnMenosTarj.Click += new System.EventHandler(this.btnMenosTarj_Click);
            // 
            // btnMasTarj
            // 
            this.btnMasTarj.Location = new System.Drawing.Point(951, 195);
            this.btnMasTarj.Name = "btnMasTarj";
            this.btnMasTarj.Size = new System.Drawing.Size(50, 28);
            this.btnMasTarj.TabIndex = 78;
            this.btnMasTarj.Text = "+";
            this.btnMasTarj.UseVisualStyleBackColor = true;
            this.btnMasTarj.Click += new System.EventHandler(this.btnMasTarj_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(791, 555);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(153, 45);
            this.btnAgregar.TabIndex = 80;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(768, 516);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(176, 23);
            this.txtTotal.TabIndex = 81;
            // 
            // btnMasFact
            // 
            this.btnMasFact.Location = new System.Drawing.Point(577, 466);
            this.btnMasFact.Name = "btnMasFact";
            this.btnMasFact.Size = new System.Drawing.Size(50, 28);
            this.btnMasFact.TabIndex = 82;
            this.btnMasFact.Text = "+";
            this.btnMasFact.UseVisualStyleBackColor = true;
            this.btnMasFact.Click += new System.EventHandler(this.btnMasFact_Click);
            // 
            // btnMenosFact
            // 
            this.btnMenosFact.Location = new System.Drawing.Point(577, 500);
            this.btnMenosFact.Name = "btnMenosFact";
            this.btnMenosFact.Size = new System.Drawing.Size(50, 28);
            this.btnMenosFact.TabIndex = 83;
            this.btnMenosFact.Text = "-";
            this.btnMenosFact.UseVisualStyleBackColor = true;
            this.btnMenosFact.Click += new System.EventHandler(this.btnMenosFact_Click);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 609);
            this.Controls.Add(this.btnMenosFact);
            this.Controls.Add(this.btnMasFact);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelQuimadh10);
            this.Controls.Add(this.btnMenosTarj);
            this.Controls.Add(this.btnMasTarj);
            this.Controls.Add(this.btnMenosChq);
            this.Controls.Add(this.btnMasChq);
            this.Controls.Add(this.btnMenosTransf);
            this.Controls.Add(this.btnMasTransf);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.labelQuimadh9);
            this.Controls.Add(this.labelQuimadh11);
            this.Controls.Add(this.dgvCheques);
            this.Controls.Add(this.labelQuimadh13);
            this.Controls.Add(this.dgvTarj);
            this.Controls.Add(this.labelQuimadh12);
            this.Controls.Add(this.dgvTransf);
            this.Controls.Add(this.labelQuimadh7);
            this.Controls.Add(this.txtEfectivo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.Controls.SetChildIndex(this.txtEfectivo, 0);
            this.Controls.SetChildIndex(this.labelQuimadh7, 0);
            this.Controls.SetChildIndex(this.dgvTransf, 0);
            this.Controls.SetChildIndex(this.labelQuimadh12, 0);
            this.Controls.SetChildIndex(this.dgvTarj, 0);
            this.Controls.SetChildIndex(this.labelQuimadh13, 0);
            this.Controls.SetChildIndex(this.dgvCheques, 0);
            this.Controls.SetChildIndex(this.labelQuimadh11, 0);
            this.Controls.SetChildIndex(this.labelQuimadh9, 0);
            this.Controls.SetChildIndex(this.dgvFacturas, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnMasTransf, 0);
            this.Controls.SetChildIndex(this.btnMenosTransf, 0);
            this.Controls.SetChildIndex(this.btnMasChq, 0);
            this.Controls.SetChildIndex(this.btnMenosChq, 0);
            this.Controls.SetChildIndex(this.btnMasTarj, 0);
            this.Controls.SetChildIndex(this.btnMenosTarj, 0);
            this.Controls.SetChildIndex(this.labelQuimadh10, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.txtTotal, 0);
            this.Controls.SetChildIndex(this.btnMasFact, 0);
            this.Controls.SetChildIndex(this.btnMenosFact, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controles.LabelQuimadh labelQuimadh7;
        private Controles.TextBoxNumerico txtEfectivo;
        private System.Windows.Forms.DataGridView dgvTransf;
        private Controles.LabelQuimadh labelQuimadh12;
        private Controles.LabelQuimadh labelQuimadh13;
        private System.Windows.Forms.DataGridView dgvTarj;
        private Controles.LabelQuimadh labelQuimadh11;
        private System.Windows.Forms.DataGridView dgvCheques;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private Controles.LabelQuimadh labelQuimadh9;
        private Controles.LabelQuimadh labelQuimadh10;
        private Controles.ButtonQuimadh btnMasTransf;
        private Controles.ButtonQuimadh btnMenosTransf;
        private Controles.ButtonQuimadh btnMenosChq;
        private Controles.ButtonQuimadh btnMasChq;
        private Controles.ButtonQuimadh btnMenosTarj;
        private Controles.ButtonQuimadh btnMasTarj;
        private Controles.ButtonQuimadh btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransfImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransfNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqCuitLib;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqNombreLib;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqFechaVto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqEcheq;
        private Controles.TextBoxQuimadh txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTarjImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTarjTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTarjMarca;
        private Controles.ButtonQuimadh btnMasFact;
        private Controles.ButtonQuimadh btnMenosFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFactPvNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFactTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFactFCE;
    }
}