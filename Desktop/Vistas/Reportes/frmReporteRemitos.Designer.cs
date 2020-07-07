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
            this.rpvGeneral.Location = new System.Drawing.Point(16, 187);
            this.rpvGeneral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpvGeneral.Name = "rpvGeneral";
            this.rpvGeneral.ServerReport.BearerToken = null;
            this.rpvGeneral.Size = new System.Drawing.Size(1508, 618);
            this.rpvGeneral.TabIndex = 4;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(426, 128);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(123, 23);
            this.dtpFechaDesde.TabIndex = 52;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(677, 128);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnVerReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // frmReporteRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 818);
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
            this.Controls.Add(this.rpvGeneral);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReporteRemitos";
            this.Text = "frmReporteFacturacion";
            this.Load += new System.EventHandler(this.frmReporteFacturacion_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.rpvGeneral, 0);
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
    }
}