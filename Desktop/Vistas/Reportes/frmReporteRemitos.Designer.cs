namespace Desktop.Vistas.Reportes
{
    partial class frmReporteRemitos
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
            this.rpvGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtCliente = new Controles.TextBoxQuimadh();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.btnVerReporte = new Controles.ButtonQuimadh(this.components);
            this.chkNF = new System.Windows.Forms.CheckBox();
            this.chkPend = new System.Windows.Forms.CheckBox();
            this.chkPF = new System.Windows.Forms.CheckBox();
            this.chkTF = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRemitos = new System.Windows.Forms.DataGridView();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNroRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFacturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFacturar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Size = new System.Drawing.Size(316, 54);
            this.lblTitulo.Text = "Reporte Remitos";
            // 
            // rpvGeneral
            // 
            this.rpvGeneral.Location = new System.Drawing.Point(5, 4);
            this.rpvGeneral.Margin = new System.Windows.Forms.Padding(4);
            this.rpvGeneral.Name = "rpvGeneral";
            this.rpvGeneral.ServerReport.BearerToken = null;
            this.rpvGeneral.Size = new System.Drawing.Size(1508, 602);
            this.rpvGeneral.TabIndex = 4;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(426, 128);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(123, 23);
            this.dtpFechaHasta.TabIndex = 55;
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(297, 130);
            this.labelQuimadh4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(122, 20);
            this.labelQuimadh4.TabIndex = 54;
            this.labelQuimadh4.Text = "Fecha Hasta:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(17, 130);
            this.labelQuimadh3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(126, 20);
            this.labelQuimadh3.TabIndex = 53;
            this.labelQuimadh3.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(165, 128);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(123, 23);
            this.dtpFechaDesde.TabIndex = 52;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(677, 128);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(219, 23);
            this.txtCliente.TabIndex = 56;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(594, 130);
            this.labelQuimadh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(68, 20);
            this.labelQuimadh1.TabIndex = 57;
            this.labelQuimadh1.Text = "Cliente";
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(1261, 137);
            this.btnVerReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(117, 30);
            this.btnVerReporte.TabIndex = 58;
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // chkNF
            // 
            this.chkNF.AutoSize = true;
            this.chkNF.BackColor = System.Drawing.SystemColors.Info;
            this.chkNF.Location = new System.Drawing.Point(927, 119);
            this.chkNF.Name = "chkNF";
            this.chkNF.Size = new System.Drawing.Size(158, 21);
            this.chkNF.TabIndex = 59;
            this.chkNF.Text = "No Facturables (NF)";
            this.chkNF.UseVisualStyleBackColor = false;
            // 
            // chkPend
            // 
            this.chkPend.AutoSize = true;
            this.chkPend.BackColor = System.Drawing.SystemColors.Info;
            this.chkPend.Checked = true;
            this.chkPend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPend.Location = new System.Drawing.Point(1102, 119);
            this.chkPend.Name = "chkPend";
            this.chkPend.Size = new System.Drawing.Size(124, 21);
            this.chkPend.TabIndex = 60;
            this.chkPend.Text = "Pendientes (P)";
            this.chkPend.UseVisualStyleBackColor = false;
            // 
            // chkPF
            // 
            this.chkPF.AutoSize = true;
            this.chkPF.BackColor = System.Drawing.SystemColors.Info;
            this.chkPF.Checked = true;
            this.chkPF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPF.Location = new System.Drawing.Point(927, 146);
            this.chkPF.Name = "chkPF";
            this.chkPF.Size = new System.Drawing.Size(178, 21);
            this.chkPF.TabIndex = 61;
            this.chkPF.Text = "Parcialmente Fact. (PF)";
            this.chkPF.UseVisualStyleBackColor = false;
            // 
            // chkTF
            // 
            this.chkTF.AutoSize = true;
            this.chkTF.BackColor = System.Drawing.SystemColors.Info;
            this.chkTF.Checked = true;
            this.chkTF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTF.Location = new System.Drawing.Point(1102, 146);
            this.chkTF.Name = "chkTF";
            this.chkTF.Size = new System.Drawing.Size(132, 21);
            this.chkTF.TabIndex = 62;
            this.chkTF.Text = "Facturados (TF)";
            this.chkTF.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 173);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1525, 644);
            this.tabControl1.TabIndex = 63;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rpvGeneral);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1517, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vista Reporte";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRemitos);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1517, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vista Facturable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRemitos
            // 
            this.dgvRemitos.AllowUserToAddRows = false;
            this.dgvRemitos.AllowUserToDeleteRows = false;
            this.dgvRemitos.BackgroundColor = System.Drawing.Color.White;
            this.dgvRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFecha,
            this.clmNroRemito,
            this.clmCliente,
            this.clmEstado,
            this.clmFacturas,
            this.clmFacturar});
            this.dgvRemitos.GridColor = System.Drawing.Color.Black;
            this.dgvRemitos.Location = new System.Drawing.Point(7, 7);
            this.dgvRemitos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRemitos.Name = "dgvRemitos";
            this.dgvRemitos.ReadOnly = true;
            this.dgvRemitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRemitos.Size = new System.Drawing.Size(1503, 599);
            this.dgvRemitos.TabIndex = 65;
            this.dgvRemitos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemitos_CellContentClick);
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmNroRemito
            // 
            this.clmNroRemito.HeaderText = "Nro Remito";
            this.clmNroRemito.Name = "clmNroRemito";
            this.clmNroRemito.ReadOnly = true;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.ReadOnly = true;
            this.clmCliente.Width = 200;
            // 
            // clmEstado
            // 
            this.clmEstado.HeaderText = "Estado ";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // clmFacturas
            // 
            this.clmFacturas.HeaderText = "Facturas";
            this.clmFacturas.Name = "clmFacturas";
            this.clmFacturas.ReadOnly = true;
            this.clmFacturas.Width = 200;
            // 
            // clmFacturar
            // 
            this.clmFacturar.HeaderText = "";
            this.clmFacturar.Name = "clmFacturar";
            this.clmFacturar.ReadOnly = true;
            this.clmFacturar.Text = "Facturar";
            this.clmFacturar.UseColumnTextForLinkValue = true;
            // 
            // frmReporteRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 818);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chkTF);
            this.Controls.Add(this.chkPF);
            this.Controls.Add(this.chkPend);
            this.Controls.Add(this.chkNF);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.labelQuimadh1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.labelQuimadh4);
            this.Controls.Add(this.labelQuimadh3);
            this.Controls.Add(this.dtpFechaDesde);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReporteRemitos";
            this.Load += new System.EventHandler(this.frmReporteFacturacion_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.dtpFechaDesde, 0);
            this.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.Controls.SetChildIndex(this.dtpFechaHasta, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.btnVerReporte, 0);
            this.Controls.SetChildIndex(this.chkNF, 0);
            this.Controls.SetChildIndex(this.chkPend, 0);
            this.Controls.SetChildIndex(this.chkPF, 0);
            this.Controls.SetChildIndex(this.chkTF, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvGeneral;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh3;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private Controles.TextBoxQuimadh txtCliente;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.ButtonQuimadh btnVerReporte;
        private System.Windows.Forms.CheckBox chkNF;
        private System.Windows.Forms.CheckBox chkPend;
        private System.Windows.Forms.CheckBox chkPF;
        private System.Windows.Forms.CheckBox chkTF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvRemitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNroRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFacturas;
        private System.Windows.Forms.DataGridViewLinkColumn clmFacturar;
    }
}