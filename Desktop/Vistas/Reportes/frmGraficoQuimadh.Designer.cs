namespace Desktop.Vistas.Reportes
{
    partial class frmGraficoQuimadh
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblPlanta = new Controles.LabelQuimadh(this.components);
            this.btnVerReporte = new System.Windows.Forms.Button();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.txtMinimo = new Controles.TextBoxQuimadh();
            this.txtMaximo = new Controles.TextBoxQuimadh();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(367, 45);
            this.lblTitulo.Text = "Comparativo de Rutinas";
            // 
            // rpvGeneral
            // 
            reportDataSource1.Name = "Rutina";
            reportDataSource1.Value = null;
            this.rpvGeneral.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvGeneral.LocalReport.ReportEmbeddedResource = "Desktop.Reportes.GraficoQuimadh.rdlc";
            this.rpvGeneral.Location = new System.Drawing.Point(12, 143);
            this.rpvGeneral.Name = "rpvGeneral";
            this.rpvGeneral.Size = new System.Drawing.Size(1120, 573);
            this.rpvGeneral.TabIndex = 4;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(958, 90);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaHasta.TabIndex = 51;
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(861, 92);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(100, 16);
            this.labelQuimadh4.TabIndex = 50;
            this.labelQuimadh4.Text = "Fecha Hasta:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(651, 92);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(105, 16);
            this.labelQuimadh3.TabIndex = 49;
            this.labelQuimadh3.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(762, 90);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaDesde.TabIndex = 48;
            // 
            // lblPlanta
            // 
            this.lblPlanta.AutoSize = true;
            this.lblPlanta.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanta.Location = new System.Drawing.Point(12, 93);
            this.lblPlanta.Name = "lblPlanta";
            this.lblPlanta.Size = new System.Drawing.Size(56, 16);
            this.lblPlanta.TabIndex = 52;
            this.lblPlanta.Text = "Planta:";
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(1057, 88);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(75, 23);
            this.btnVerReporte.TabIndex = 53;
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(651, 118);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(102, 16);
            this.labelQuimadh1.TabIndex = 56;
            this.labelQuimadh1.Text = "Valor Mínimo:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(861, 116);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(65, 16);
            this.labelQuimadh2.TabIndex = 57;
            this.labelQuimadh2.Text = "Máximo:";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(762, 116);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(93, 20);
            this.txtMinimo.TabIndex = 58;
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(958, 116);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(93, 20);
            this.txtMaximo.TabIndex = 59;
            // 
            // frmGraficoQuimadh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 716);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.labelQuimadh2);
            this.Controls.Add(this.labelQuimadh1);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.lblPlanta);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.labelQuimadh4);
            this.Controls.Add(this.labelQuimadh3);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.rpvGeneral);
            this.Name = "frmGraficoQuimadh";
            this.Text = "Comparativo Rutinas";
            this.Load += new System.EventHandler(this.frmGraficoQuimadh_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.rpvGeneral, 0);
            this.Controls.SetChildIndex(this.dtpFechaDesde, 0);
            this.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.Controls.SetChildIndex(this.dtpFechaHasta, 0);
            this.Controls.SetChildIndex(this.lblPlanta, 0);
            this.Controls.SetChildIndex(this.btnVerReporte, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.Controls.SetChildIndex(this.txtMinimo, 0);
            this.Controls.SetChildIndex(this.txtMaximo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvGeneral;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh3;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private Controles.LabelQuimadh lblPlanta;
        private System.Windows.Forms.Button btnVerReporte;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.TextBoxQuimadh txtMinimo;
        private Controles.TextBoxQuimadh txtMaximo;
    }
}