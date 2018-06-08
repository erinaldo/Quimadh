namespace Desktop.Vistas.Administracion
{
    partial class frmBusquedaLote
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNroLote = new Controles.TextBoxQuimadh();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.labelQuimadh1);
            this.gpbFiltros.Controls.Add(this.txtNroLote);
            this.gpbFiltros.Controls.Add(this.cboArticulo);
            this.gpbFiltros.Controls.Add(this.labelQuimadh6);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh6, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cboArticulo, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtNroLote, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh1, 0);
            // 
            // ltvBusqueda
            // 
            this.ltvBusqueda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.ltvBusqueda.Location = new System.Drawing.Point(16, 229);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(167, 21);
            this.lblTitulo.Size = new System.Drawing.Size(244, 45);
            this.lblTitulo.Text = "Búsqueda Lotes";
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Articulo";
            this.columnHeader2.Width = 210;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha Inicio";
            this.columnHeader3.Width = 150;
            // 
            // txtNroLote
            // 
            this.txtNroLote.Location = new System.Drawing.Point(142, 60);
            this.txtNroLote.Name = "txtNroLote";
            this.txtNroLote.Size = new System.Drawing.Size(204, 20);
            this.txtNroLote.TabIndex = 31;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(61, 61);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(75, 16);
            this.labelQuimadh1.TabIndex = 32;
            this.labelQuimadh1.Text = "Nro. Lote:";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha Cierre";
            this.columnHeader5.Width = 150;
            // 
            // frmBusquedaLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 587);
            this.Name = "frmBusquedaLote";
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.CustomComboBox cboArticulo;
        private Controles.LabelQuimadh labelQuimadh6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.TextBoxQuimadh txtNroLote;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}