namespace Desktop.Vistas.Ventas
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
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.labelQuimadh8 = new Controles.LabelQuimadh(this.components);
            this.txtRazonSocial = new Controles.TextBoxQuimadh();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.txtCUIT = new Controles.TextBoxNumerico();
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh10 = new Controles.LabelQuimadh(this.components);
            this.txtTotal1 = new Controles.TextBoxNumerico();
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.txtEfectivo = new Controles.TextBoxNumerico();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.clmTransfImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransfNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuimadh12 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh13 = new Controles.LabelQuimadh(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmTarjImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTarjTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuimadh11 = new Controles.LabelQuimadh(this.components);
            this.dgvCheques = new System.Windows.Forms.DataGridView();
            this.clmChqImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqCuitLib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqNombreLib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqFechaVto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChqEcheq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemitos = new System.Windows.Forms.DataGridView();
            this.clmNroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuimadh9 = new Controles.LabelQuimadh(this.components);
            this.btnMasTransf = new Controles.ButtonQuimadh(this.components);
            this.btnMenosTransf = new Controles.ButtonQuimadh(this.components);
            this.btnMenosChq = new Controles.ButtonQuimadh(this.components);
            this.btnMasChq = new Controles.ButtonQuimadh(this.components);
            this.btnMenosTarj = new Controles.ButtonQuimadh(this.components);
            this.btnMasTarj = new Controles.ButtonQuimadh(this.components);
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(40, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Size = new System.Drawing.Size(132, 54);
            this.lblTitulo.Text = "Pagos";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.labelQuimadh8);
            this.gpbDatos.Controls.Add(this.txtRazonSocial);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.txtCUIT);
            this.gpbDatos.Controls.Add(this.labelQuimadh5);
            this.gpbDatos.Location = new System.Drawing.Point(4, 79);
            this.gpbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gpbDatos.Size = new System.Drawing.Size(1064, 70);
            this.gpbDatos.TabIndex = 5;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // labelQuimadh8
            // 
            this.labelQuimadh8.AutoSize = true;
            this.labelQuimadh8.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh8.Location = new System.Drawing.Point(111, 27);
            this.labelQuimadh8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh8.Name = "labelQuimadh8";
            this.labelQuimadh8.Size = new System.Drawing.Size(57, 20);
            this.labelQuimadh8.TabIndex = 24;
            this.labelQuimadh8.Text = "CUIT:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(568, 27);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(211, 23);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(422, 28);
            this.labelQuimadh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(132, 20);
            this.labelQuimadh1.TabIndex = 8;
            this.labelQuimadh1.Text = "Razón Social: ";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(63, 125);
            this.labelQuimadh2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(0, 20);
            this.labelQuimadh2.TabIndex = 9;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Decimales = 0;
            this.txtCUIT.Enteros = 11;
            this.txtCUIT.EnterTabulacion = true;
            this.txtCUIT.Location = new System.Drawing.Point(187, 27);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(211, 23);
            this.txtCUIT.TabIndex = 1;
            this.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(63, 226);
            this.labelQuimadh5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(0, 20);
            this.labelQuimadh5.TabIndex = 12;
            // 
            // labelQuimadh10
            // 
            this.labelQuimadh10.AutoSize = true;
            this.labelQuimadh10.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh10.Location = new System.Drawing.Point(468, 467);
            this.labelQuimadh10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh10.Name = "labelQuimadh10";
            this.labelQuimadh10.Size = new System.Drawing.Size(63, 20);
            this.labelQuimadh10.TabIndex = 51;
            this.labelQuimadh10.Text = "Total: ";
            // 
            // txtTotal1
            // 
            this.txtTotal1.Decimales = 2;
            this.txtTotal1.Enteros = 12;
            this.txtTotal1.EnterTabulacion = true;
            this.txtTotal1.Location = new System.Drawing.Point(539, 466);
            this.txtTotal1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.ReadOnly = true;
            this.txtTotal1.Size = new System.Drawing.Size(171, 23);
            this.txtTotal1.TabIndex = 50;
            this.txtTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(106, 154);
            this.labelQuimadh7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(77, 20);
            this.labelQuimadh7.TabIndex = 26;
            this.labelQuimadh7.Text = "Efectivo";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Decimales = 0;
            this.txtEfectivo.Enteros = 11;
            this.txtEfectivo.EnterTabulacion = true;
            this.txtEfectivo.Location = new System.Drawing.Point(189, 154);
            this.txtEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(211, 23);
            this.txtEfectivo.TabIndex = 25;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.AllowUserToAddRows = false;
            this.dgvPrecios.AllowUserToDeleteRows = false;
            this.dgvPrecios.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTransfImporte,
            this.clmTransfNro});
            this.dgvPrecios.Location = new System.Drawing.Point(189, 195);
            this.dgvPrecios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.ReadOnly = true;
            this.dgvPrecios.Size = new System.Drawing.Size(257, 97);
            this.dgvPrecios.TabIndex = 64;
            // 
            // clmTransfImporte
            // 
            this.clmTransfImporte.HeaderText = "Importe";
            this.clmTransfImporte.Name = "clmTransfImporte";
            this.clmTransfImporte.ReadOnly = true;
            // 
            // clmTransfNro
            // 
            this.clmTransfNro.HeaderText = "Nro/Cbte";
            this.clmTransfNro.Name = "clmTransfNro";
            this.clmTransfNro.ReadOnly = true;
            // 
            // labelQuimadh12
            // 
            this.labelQuimadh12.AutoSize = true;
            this.labelQuimadh12.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh12.Location = new System.Drawing.Point(46, 195);
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
            this.labelQuimadh13.Location = new System.Drawing.Point(559, 195);
            this.labelQuimadh13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh13.Name = "labelQuimadh13";
            this.labelQuimadh13.Size = new System.Drawing.Size(78, 20);
            this.labelQuimadh13.TabIndex = 67;
            this.labelQuimadh13.Text = "Tarjetas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTarjImporte,
            this.clmTarjTipo});
            this.dataGridView1.Location = new System.Drawing.Point(648, 195);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(257, 99);
            this.dataGridView1.TabIndex = 66;
            // 
            // clmTarjImporte
            // 
            this.clmTarjImporte.HeaderText = "Importe";
            this.clmTarjImporte.Name = "clmTarjImporte";
            this.clmTarjImporte.ReadOnly = true;
            // 
            // clmTarjTipo
            // 
            this.clmTarjTipo.HeaderText = "Tipo";
            this.clmTarjTipo.Name = "clmTarjTipo";
            this.clmTarjTipo.ReadOnly = true;
            // 
            // labelQuimadh11
            // 
            this.labelQuimadh11.AutoSize = true;
            this.labelQuimadh11.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh11.Location = new System.Drawing.Point(100, 314);
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
            this.clmChqCuitLib,
            this.clmChqNombreLib,
            this.clmChqFechaVto,
            this.clmChqTipo,
            this.clmChqEcheq});
            this.dgvCheques.Location = new System.Drawing.Point(189, 314);
            this.dgvCheques.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCheques.MultiSelect = false;
            this.dgvCheques.Name = "dgvCheques";
            this.dgvCheques.ReadOnly = true;
            this.dgvCheques.Size = new System.Drawing.Size(716, 113);
            this.dgvCheques.TabIndex = 68;
            // 
            // clmChqImporte
            // 
            this.clmChqImporte.HeaderText = "Importe";
            this.clmChqImporte.Name = "clmChqImporte";
            this.clmChqImporte.ReadOnly = true;
            // 
            // clmChqNumero
            // 
            this.clmChqNumero.HeaderText = "Numero";
            this.clmChqNumero.Name = "clmChqNumero";
            this.clmChqNumero.ReadOnly = true;
            // 
            // clmChqCuitLib
            // 
            this.clmChqCuitLib.HeaderText = "Cuit Lib";
            this.clmChqCuitLib.Name = "clmChqCuitLib";
            this.clmChqCuitLib.ReadOnly = true;
            // 
            // clmChqNombreLib
            // 
            this.clmChqNombreLib.HeaderText = "Nombre Lib";
            this.clmChqNombreLib.Name = "clmChqNombreLib";
            this.clmChqNombreLib.ReadOnly = true;
            // 
            // clmChqFechaVto
            // 
            this.clmChqFechaVto.HeaderText = "Fecha Vto";
            this.clmChqFechaVto.Name = "clmChqFechaVto";
            this.clmChqFechaVto.ReadOnly = true;
            // 
            // clmChqTipo
            // 
            this.clmChqTipo.HeaderText = "Tipo";
            this.clmChqTipo.Name = "clmChqTipo";
            this.clmChqTipo.ReadOnly = true;
            // 
            // clmChqEcheq
            // 
            this.clmChqEcheq.HeaderText = "ECheq";
            this.clmChqEcheq.Name = "clmChqEcheq";
            this.clmChqEcheq.ReadOnly = true;
            this.clmChqEcheq.Width = 60;
            // 
            // dgvRemitos
            // 
            this.dgvRemitos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNroFact});
            this.dgvRemitos.GridColor = System.Drawing.Color.Black;
            this.dgvRemitos.Location = new System.Drawing.Point(189, 466);
            this.dgvRemitos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRemitos.Name = "dgvRemitos";
            this.dgvRemitos.Size = new System.Drawing.Size(229, 134);
            this.dgvRemitos.TabIndex = 73;
            // 
            // clmNroFact
            // 
            this.clmNroFact.HeaderText = "Nro Factura";
            this.clmNroFact.MaxInputLength = 15;
            this.clmNroFact.Name = "clmNroFact";
            this.clmNroFact.Width = 160;
            // 
            // labelQuimadh9
            // 
            this.labelQuimadh9.AutoSize = true;
            this.labelQuimadh9.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh9.Location = new System.Drawing.Point(93, 466);
            this.labelQuimadh9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh9.Name = "labelQuimadh9";
            this.labelQuimadh9.Size = new System.Drawing.Size(95, 20);
            this.labelQuimadh9.TabIndex = 72;
            this.labelQuimadh9.Text = "Facturas: ";
            // 
            // btnMasTransf
            // 
            this.btnMasTransf.Location = new System.Drawing.Point(453, 195);
            this.btnMasTransf.Name = "btnMasTransf";
            this.btnMasTransf.Size = new System.Drawing.Size(50, 28);
            this.btnMasTransf.TabIndex = 74;
            this.btnMasTransf.Text = "+";
            this.btnMasTransf.UseVisualStyleBackColor = true;
            this.btnMasTransf.Click += new System.EventHandler(this.btnMasTransf_Click);
            // 
            // btnMenosTransf
            // 
            this.btnMenosTransf.Location = new System.Drawing.Point(453, 229);
            this.btnMenosTransf.Name = "btnMenosTransf";
            this.btnMenosTransf.Size = new System.Drawing.Size(50, 28);
            this.btnMenosTransf.TabIndex = 75;
            this.btnMenosTransf.Text = "-";
            this.btnMenosTransf.UseVisualStyleBackColor = true;
            this.btnMenosTransf.Click += new System.EventHandler(this.btnMenosTransf_Click);
            // 
            // btnMenosChq
            // 
            this.btnMenosChq.Location = new System.Drawing.Point(912, 348);
            this.btnMenosChq.Name = "btnMenosChq";
            this.btnMenosChq.Size = new System.Drawing.Size(50, 28);
            this.btnMenosChq.TabIndex = 77;
            this.btnMenosChq.Text = "-";
            this.btnMenosChq.UseVisualStyleBackColor = true;
            this.btnMenosChq.Click += new System.EventHandler(this.btnMenosChq_Click);
            // 
            // btnMasChq
            // 
            this.btnMasChq.Location = new System.Drawing.Point(912, 314);
            this.btnMasChq.Name = "btnMasChq";
            this.btnMasChq.Size = new System.Drawing.Size(50, 28);
            this.btnMasChq.TabIndex = 76;
            this.btnMasChq.Text = "+";
            this.btnMasChq.UseVisualStyleBackColor = true;
            this.btnMasChq.Click += new System.EventHandler(this.btnMasChq_Click);
            // 
            // btnMenosTarj
            // 
            this.btnMenosTarj.Location = new System.Drawing.Point(912, 229);
            this.btnMenosTarj.Name = "btnMenosTarj";
            this.btnMenosTarj.Size = new System.Drawing.Size(50, 28);
            this.btnMenosTarj.TabIndex = 79;
            this.btnMenosTarj.Text = "-";
            this.btnMenosTarj.UseVisualStyleBackColor = true;
            this.btnMenosTarj.Click += new System.EventHandler(this.btnMenosTarj_Click);
            // 
            // btnMasTarj
            // 
            this.btnMasTarj.Location = new System.Drawing.Point(912, 195);
            this.btnMasTarj.Name = "btnMasTarj";
            this.btnMasTarj.Size = new System.Drawing.Size(50, 28);
            this.btnMasTarj.TabIndex = 78;
            this.btnMasTarj.Text = "+";
            this.btnMasTarj.UseVisualStyleBackColor = true;
            this.btnMasTarj.Click += new System.EventHandler(this.btnMasTarj_Click);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 636);
            this.Controls.Add(this.labelQuimadh10);
            this.Controls.Add(this.btnMenosTarj);
            this.Controls.Add(this.btnMasTarj);
            this.Controls.Add(this.btnMenosChq);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.btnMasChq);
            this.Controls.Add(this.btnMenosTransf);
            this.Controls.Add(this.btnMasTransf);
            this.Controls.Add(this.dgvRemitos);
            this.Controls.Add(this.labelQuimadh9);
            this.Controls.Add(this.labelQuimadh11);
            this.Controls.Add(this.dgvCheques);
            this.Controls.Add(this.labelQuimadh13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelQuimadh12);
            this.Controls.Add(this.dgvPrecios);
            this.Controls.Add(this.labelQuimadh7);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.gpbDatos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPagos";
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.Controls.SetChildIndex(this.txtEfectivo, 0);
            this.Controls.SetChildIndex(this.labelQuimadh7, 0);
            this.Controls.SetChildIndex(this.dgvPrecios, 0);
            this.Controls.SetChildIndex(this.labelQuimadh12, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.labelQuimadh13, 0);
            this.Controls.SetChildIndex(this.dgvCheques, 0);
            this.Controls.SetChildIndex(this.labelQuimadh11, 0);
            this.Controls.SetChildIndex(this.labelQuimadh9, 0);
            this.Controls.SetChildIndex(this.dgvRemitos, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.btnMasTransf, 0);
            this.Controls.SetChildIndex(this.btnMenosTransf, 0);
            this.Controls.SetChildIndex(this.btnMasChq, 0);
            this.Controls.SetChildIndex(this.txtTotal1, 0);
            this.Controls.SetChildIndex(this.btnMenosChq, 0);
            this.Controls.SetChildIndex(this.btnMasTarj, 0);
            this.Controls.SetChildIndex(this.btnMenosTarj, 0);
            this.Controls.SetChildIndex(this.labelQuimadh10, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.TextBoxQuimadh txtRazonSocial;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.LabelQuimadh labelQuimadh8;
        private Controles.TextBoxNumerico txtCUIT;
        private Controles.LabelQuimadh labelQuimadh7;
        private Controles.TextBoxNumerico txtEfectivo;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private Controles.LabelQuimadh labelQuimadh12;
        private Controles.LabelQuimadh labelQuimadh13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controles.LabelQuimadh labelQuimadh11;
        private System.Windows.Forms.DataGridView dgvCheques;
        private System.Windows.Forms.DataGridView dgvRemitos;
        private Controles.LabelQuimadh labelQuimadh9;
        private Controles.TextBoxNumerico txtTotal1;
        private Controles.LabelQuimadh labelQuimadh10;
        private Controles.ButtonQuimadh btnMasTransf;
        private Controles.ButtonQuimadh btnMenosTransf;
        private Controles.ButtonQuimadh btnMenosChq;
        private Controles.ButtonQuimadh btnMasChq;
        private Controles.ButtonQuimadh btnMenosTarj;
        private Controles.ButtonQuimadh btnMasTarj;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransfImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransfNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTarjImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTarjTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqCuitLib;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqNombreLib;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqFechaVto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChqEcheq;
    }
}