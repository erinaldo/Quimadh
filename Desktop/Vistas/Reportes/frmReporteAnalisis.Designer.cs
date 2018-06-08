namespace Desktop.Vistas.Reportes
{
    partial class frmReporteAnalisis
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvGeneral = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(291, 45);
            this.lblTitulo.Text = "Reporte de análisis";
            // 
            // rpvGeneral
            // 
            reportDataSource1.Name = "Rutina";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "MuestrasRutina";
            reportDataSource2.Value = null;
            this.rpvGeneral.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvGeneral.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvGeneral.LocalReport.ReportEmbeddedResource = "Desktop.Reportes.Analisis.rdlc";
            this.rpvGeneral.Location = new System.Drawing.Point(12, 91);
            this.rpvGeneral.Name = "rpvGeneral";
            this.rpvGeneral.Size = new System.Drawing.Size(1095, 603);
            this.rpvGeneral.TabIndex = 4;
            // 
            // frmReporteAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1119, 706);
            this.Controls.Add(this.rpvGeneral);
            this.Name = "frmReporteAnalisis";
            this.Load += new System.EventHandler(this.frmReporteAnalisis_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.rpvGeneral, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvGeneral;
    }
}