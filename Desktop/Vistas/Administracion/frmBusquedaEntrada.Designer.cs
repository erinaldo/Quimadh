namespace Desktop.Vistas.Administracion
{
    partial class frmBusquedaEntrada
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
            this.cboArticulo = new Controles.CustomComboBox(this.components);
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaD = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaH = new System.Windows.Forms.DateTimePicker();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.labelQuimadh1);
            this.gpbFiltros.Controls.Add(this.dtpFechaH);
            this.gpbFiltros.Controls.Add(this.labelQuimadh4);
            this.gpbFiltros.Controls.Add(this.dtpFechaD);
            this.gpbFiltros.Controls.Add(this.cboArticulo);
            this.gpbFiltros.Controls.Add(this.labelQuimadh6);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh6, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cboArticulo, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.dtpFechaD, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.dtpFechaH, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh1, 0);
            // 
            // ltvBusqueda
            // 
            this.ltvBusqueda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            // 
            // cboArticulo
            // 
            this.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(142, 23);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(204, 21);
            this.cboArticulo.TabIndex = 30;
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(72, 26);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(64, 16);
            this.labelQuimadh6.TabIndex = 29;
            this.labelQuimadh6.Text = "Artículo:";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(31, 54);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(105, 16);
            this.labelQuimadh4.TabIndex = 36;
            this.labelQuimadh4.Text = "Fecha Desde:";
            // 
            // dtpFechaD
            // 
            this.dtpFechaD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaD.Location = new System.Drawing.Point(142, 50);
            this.dtpFechaD.Name = "dtpFechaD";
            this.dtpFechaD.Size = new System.Drawing.Size(204, 20);
            this.dtpFechaD.TabIndex = 35;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(36, 80);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(100, 16);
            this.labelQuimadh1.TabIndex = 38;
            this.labelQuimadh1.Text = "Fecha Hasta:";
            // 
            // dtpFechaH
            // 
            this.dtpFechaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaH.Location = new System.Drawing.Point(142, 76);
            this.dtpFechaH.Name = "dtpFechaH";
            this.dtpFechaH.Size = new System.Drawing.Size(204, 20);
            this.dtpFechaH.TabIndex = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Artículo";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Presentación";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lote";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            this.columnHeader6.Width = 75;
            // 
            // frmBusquedaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 587);
            this.Name = "frmBusquedaEntrada";
            this.Text = "frmBusquedaEntradas";
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.CustomComboBox cboArticulo;
        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.LabelQuimadh labelQuimadh1;
        private System.Windows.Forms.DateTimePicker dtpFechaH;
        private Controles.LabelQuimadh labelQuimadh4;
        private System.Windows.Forms.DateTimePicker dtpFechaD;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}