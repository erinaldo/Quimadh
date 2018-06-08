namespace Desktop.Vistas.Reportes
{
    partial class frmTotalLts
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtClienteVendedor = new Controles.TextBoxQuimadh();
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.chkDetallarArticulos = new System.Windows.Forms.CheckBox();
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.cboPresentacion = new Controles.CustomComboBox(this.components);
            this.cboArticulo = new Controles.CustomComboBox(this.components);
            this.rpvGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboLote = new Controles.CustomComboBox(this.components);
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(543, 45);
            this.lblTitulo.Text = "Consulta total de Salidas por Cliente";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(836, 114);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(131, 16);
            this.labelQuimadh2.TabIndex = 66;
            this.labelQuimadh2.Text = "Detallar Artículos:";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(81, 115);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(64, 16);
            this.labelQuimadh1.TabIndex = 65;
            this.labelQuimadh1.Text = "Artículo:";
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(916, 86);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(75, 23);
            this.btnVerReporte.TabIndex = 64;
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(817, 88);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaHasta.TabIndex = 63;
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(720, 90);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(100, 16);
            this.labelQuimadh4.TabIndex = 62;
            this.labelQuimadh4.Text = "Fecha Hasta:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(510, 90);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(105, 16);
            this.labelQuimadh3.TabIndex = 61;
            this.labelQuimadh3.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(621, 88);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaDesde.TabIndex = 60;
            // 
            // txtClienteVendedor
            // 
            this.txtClienteVendedor.Location = new System.Drawing.Point(151, 91);
            this.txtClienteVendedor.Name = "txtClienteVendedor";
            this.txtClienteVendedor.Size = new System.Drawing.Size(208, 20);
            this.txtClienteVendedor.TabIndex = 71;
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(390, 114);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(42, 16);
            this.labelQuimadh5.TabIndex = 70;
            this.labelQuimadh5.Text = "Lote:";
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(12, 92);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(133, 16);
            this.labelQuimadh6.TabIndex = 69;
            this.labelQuimadh6.Text = "Cliente/Vendedor:";
            // 
            // chkDetallarArticulos
            // 
            this.chkDetallarArticulos.AutoSize = true;
            this.chkDetallarArticulos.Checked = true;
            this.chkDetallarArticulos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDetallarArticulos.Location = new System.Drawing.Point(973, 115);
            this.chkDetallarArticulos.Name = "chkDetallarArticulos";
            this.chkDetallarArticulos.Size = new System.Drawing.Size(15, 14);
            this.chkDetallarArticulos.TabIndex = 73;
            this.chkDetallarArticulos.UseVisualStyleBackColor = true;
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(652, 115);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(103, 16);
            this.labelQuimadh7.TabIndex = 75;
            this.labelQuimadh7.Text = "Presentación:";
            // 
            // cboPresentacion
            // 
            this.cboPresentacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresentacion.FormattingEnabled = true;
            this.cboPresentacion.Location = new System.Drawing.Point(761, 113);
            this.cboPresentacion.Name = "cboPresentacion";
            this.cboPresentacion.Size = new System.Drawing.Size(69, 21);
            this.cboPresentacion.TabIndex = 74;
            // 
            // cboArticulo
            // 
            this.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(151, 112);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(208, 21);
            this.cboArticulo.TabIndex = 76;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            // 
            // rpvGeneral
            // 
            reportDataSource4.Name = "Rutina";
            reportDataSource4.Value = null;
            this.rpvGeneral.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvGeneral.LocalReport.ReportEmbeddedResource = "Desktop.Reportes.ConsultaTotalesLts.rdlc";
            this.rpvGeneral.Location = new System.Drawing.Point(12, 140);
            this.rpvGeneral.Name = "rpvGeneral";
            this.rpvGeneral.Size = new System.Drawing.Size(976, 488);
            this.rpvGeneral.TabIndex = 77;
            // 
            // cboLote
            // 
            this.cboLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboLote.FormattingEnabled = true;
            this.cboLote.Location = new System.Drawing.Point(438, 112);
            this.cboLote.Name = "cboLote";
            this.cboLote.Size = new System.Drawing.Size(208, 21);
            this.cboLote.TabIndex = 78;
            // 
            // frmTotalLts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.cboLote);
            this.Controls.Add(this.rpvGeneral);
            this.Controls.Add(this.cboArticulo);
            this.Controls.Add(this.labelQuimadh7);
            this.Controls.Add(this.cboPresentacion);
            this.Controls.Add(this.chkDetallarArticulos);
            this.Controls.Add(this.txtClienteVendedor);
            this.Controls.Add(this.labelQuimadh5);
            this.Controls.Add(this.labelQuimadh6);
            this.Controls.Add(this.labelQuimadh2);
            this.Controls.Add(this.labelQuimadh1);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.labelQuimadh4);
            this.Controls.Add(this.labelQuimadh3);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "frmTotalLts";
            this.Text = "Consulta por totales";
            this.Load += new System.EventHandler(this.frmTotalLts_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.dtpFechaDesde, 0);
            this.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.Controls.SetChildIndex(this.dtpFechaHasta, 0);
            this.Controls.SetChildIndex(this.btnVerReporte, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.Controls.SetChildIndex(this.labelQuimadh6, 0);
            this.Controls.SetChildIndex(this.labelQuimadh5, 0);
            this.Controls.SetChildIndex(this.txtClienteVendedor, 0);
            this.Controls.SetChildIndex(this.chkDetallarArticulos, 0);
            this.Controls.SetChildIndex(this.cboPresentacion, 0);
            this.Controls.SetChildIndex(this.labelQuimadh7, 0);
            this.Controls.SetChildIndex(this.cboArticulo, 0);
            this.Controls.SetChildIndex(this.rpvGeneral, 0);
            this.Controls.SetChildIndex(this.cboLote, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh1;
        private System.Windows.Forms.Button btnVerReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh3;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private Controles.TextBoxQuimadh txtClienteVendedor;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.LabelQuimadh labelQuimadh6;
        private System.Windows.Forms.CheckBox chkDetallarArticulos;
        private Controles.LabelQuimadh labelQuimadh7;
        private Controles.CustomComboBox cboPresentacion;
        private Controles.CustomComboBox cboArticulo;
        private Microsoft.Reporting.WinForms.ReportViewer rpvGeneral;
        private Controles.CustomComboBox cboLote;
    }
}