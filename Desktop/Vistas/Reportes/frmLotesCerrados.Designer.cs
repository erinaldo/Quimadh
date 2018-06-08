namespace Desktop.Vistas.Administracion
{
    partial class frmLotesCerrados
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
            this.cboLote = new Controles.CustomComboBox(this.components);
            this.cboArticulo = new Controles.CustomComboBox(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.btnVerReporte = new Controles.ButtonQuimadh(this.components);
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(214, 45);
            this.lblTitulo.Text = "Reporte Lotes";
            // 
            // rpvGeneral
            // 
            this.rpvGeneral.Location = new System.Drawing.Point(12, 119);
            this.rpvGeneral.Name = "rpvGeneral";
            this.rpvGeneral.Size = new System.Drawing.Size(932, 358);
            this.rpvGeneral.TabIndex = 4;
            // 
            // cboLote
            // 
            this.cboLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLote.FormattingEnabled = true;
            this.cboLote.Location = new System.Drawing.Point(524, 90);
            this.cboLote.Name = "cboLote";
            this.cboLote.Size = new System.Drawing.Size(167, 21);
            this.cboLote.TabIndex = 44;
            // 
            // cboArticulo
            // 
            this.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(257, 90);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(207, 21);
            this.cboArticulo.TabIndex = 43;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(484, 92);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(39, 15);
            this.labelQuimadh2.TabIndex = 42;
            this.labelQuimadh2.Text = "Lote:";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(192, 92);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(64, 15);
            this.labelQuimadh1.TabIndex = 41;
            this.labelQuimadh1.Text = "Artículo:";
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(724, 90);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(88, 23);
            this.btnVerReporte.TabIndex = 45;
            this.btnVerReporte.Text = "Ver Reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // frmLotesCerrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 489);
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.cboLote);
            this.Controls.Add(this.cboArticulo);
            this.Controls.Add(this.labelQuimadh2);
            this.Controls.Add(this.labelQuimadh1);
            this.Controls.Add(this.rpvGeneral);
            this.Name = "frmLotesCerrados";
            this.Text = "frmLotesCerrados";
            this.Load += new System.EventHandler(this.frmLotesCerrados_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.rpvGeneral, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.Controls.SetChildIndex(this.cboArticulo, 0);
            this.Controls.SetChildIndex(this.cboLote, 0);
            this.Controls.SetChildIndex(this.btnVerReporte, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvGeneral;
        private Controles.CustomComboBox cboLote;
        private Controles.CustomComboBox cboArticulo;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.ButtonQuimadh btnVerReporte;
    }
}