namespace Desktop.Vistas.Ventas
{
    partial class frmRelPagosFacturas
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
            this.btnBuscar = new Controles.ButtonQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.txtCliente = new Controles.TextBoxQuimadh();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.txtSaldo = new Controles.TextBoxQuimadh();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNroRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImpEf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImpTransf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImpTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImpTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImpChe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(132, 54);
            this.lblTitulo.Text = "Pagos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(851, 150);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 30);
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(496, 155);
            this.labelQuimadh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(68, 20);
            this.labelQuimadh1.TabIndex = 71;
            this.labelQuimadh1.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(571, 154);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(219, 23);
            this.txtCliente.TabIndex = 70;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(836, 114);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(123, 23);
            this.dtpFechaHasta.TabIndex = 69;
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(706, 115);
            this.labelQuimadh4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(122, 20);
            this.labelQuimadh4.TabIndex = 68;
            this.labelQuimadh4.Text = "Fecha Hasta:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(438, 115);
            this.labelQuimadh3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(126, 20);
            this.labelQuimadh3.TabIndex = 67;
            this.labelQuimadh3.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(571, 114);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(123, 23);
            this.dtpFechaDesde.TabIndex = 66;
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.AllowUserToAddRows = false;
            this.dgvRecibos.AllowUserToDeleteRows = false;
            this.dgvRecibos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFecha,
            this.clmCliente,
            this.clmNroRecibo,
            this.clmFact,
            this.clmImpEf,
            this.clmImpTransf,
            this.clmImpTC,
            this.clmImpTD,
            this.clmImpChe});
            this.dgvRecibos.GridColor = System.Drawing.Color.Black;
            this.dgvRecibos.Location = new System.Drawing.Point(13, 214);
            this.dgvRecibos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.ReadOnly = true;
            this.dgvRecibos.Size = new System.Drawing.Size(1417, 409);
            this.dgvRecibos.TabIndex = 73;
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(507, 186);
            this.labelQuimadh2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(56, 20);
            this.labelQuimadh2.TabIndex = 75;
            this.labelQuimadh2.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(571, 185);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(219, 23);
            this.txtSaldo.TabIndex = 74;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.Width = 70;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.ReadOnly = true;
            this.clmCliente.Width = 200;
            // 
            // clmNroRecibo
            // 
            this.clmNroRecibo.HeaderText = "Nro Recibo";
            this.clmNroRecibo.Name = "clmNroRecibo";
            this.clmNroRecibo.ReadOnly = true;
            // 
            // clmFact
            // 
            this.clmFact.HeaderText = "Facturas";
            this.clmFact.Name = "clmFact";
            this.clmFact.ReadOnly = true;
            this.clmFact.Width = 250;
            // 
            // clmImpEf
            // 
            this.clmImpEf.HeaderText = "Efectivo";
            this.clmImpEf.Name = "clmImpEf";
            this.clmImpEf.ReadOnly = true;
            this.clmImpEf.Width = 80;
            // 
            // clmImpTransf
            // 
            this.clmImpTransf.HeaderText = "Transf.";
            this.clmImpTransf.Name = "clmImpTransf";
            this.clmImpTransf.ReadOnly = true;
            this.clmImpTransf.Width = 80;
            // 
            // clmImpTC
            // 
            this.clmImpTC.HeaderText = "Tarj. Cred.";
            this.clmImpTC.Name = "clmImpTC";
            this.clmImpTC.ReadOnly = true;
            this.clmImpTC.Width = 80;
            // 
            // clmImpTD
            // 
            this.clmImpTD.HeaderText = "Tarj. Deb.";
            this.clmImpTD.Name = "clmImpTD";
            this.clmImpTD.ReadOnly = true;
            this.clmImpTD.Width = 80;
            // 
            // clmImpChe
            // 
            this.clmImpChe.HeaderText = "Cheques";
            this.clmImpChe.Name = "clmImpChe";
            this.clmImpChe.ReadOnly = true;
            this.clmImpChe.Width = 80;
            // 
            // frmRelPagosFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 629);
            this.Controls.Add(this.labelQuimadh2);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.dgvRecibos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.labelQuimadh1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.labelQuimadh4);
            this.Controls.Add(this.labelQuimadh3);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "frmRelPagosFacturas";
            this.Load += new System.EventHandler(this.frmRelPagosFacturas_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.dtpFechaDesde, 0);
            this.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.Controls.SetChildIndex(this.dtpFechaHasta, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.dgvRecibos, 0);
            this.Controls.SetChildIndex(this.txtSaldo, 0);
            this.Controls.SetChildIndex(this.labelQuimadh2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ButtonQuimadh btnBuscar;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.TextBoxQuimadh txtCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh3;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DataGridView dgvRecibos;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.TextBoxQuimadh txtSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNroRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImpEf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImpTransf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImpTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImpTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImpChe;
    }
}