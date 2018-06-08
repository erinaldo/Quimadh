namespace Desktop.Vistas.Analisis
{
    partial class frmBusquedaRutinas
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
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cboPlanta = new Controles.CustomComboBox(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboCliente = new Controles.CustomComboBox(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.cboTipoRutina = new Controles.CustomComboBox(this.components);
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.cboTipoRutina);
            this.gpbFiltros.Controls.Add(this.labelQuimadh5);
            this.gpbFiltros.Controls.Add(this.cboCliente);
            this.gpbFiltros.Controls.Add(this.labelQuimadh2);
            this.gpbFiltros.Controls.Add(this.dtpFechaHasta);
            this.gpbFiltros.Controls.Add(this.labelQuimadh4);
            this.gpbFiltros.Controls.Add(this.labelQuimadh3);
            this.gpbFiltros.Controls.Add(this.dtpFechaDesde);
            this.gpbFiltros.Controls.Add(this.cboPlanta);
            this.gpbFiltros.Controls.Add(this.labelQuimadh1);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cboPlanta, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.dtpFechaDesde, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.dtpFechaHasta, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cboCliente, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh5, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cboTipoRutina, 0);
            // 
            // ltvBusqueda
            // 
            this.ltvBusqueda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvBusqueda.Location = new System.Drawing.Point(16, 229);
            this.ltvBusqueda.MultiSelect = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(151, 18);
            this.lblTitulo.Size = new System.Drawing.Size(322, 45);
            this.lblTitulo.Text = "Búsqueda de Rutinas";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(309, 73);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaHasta.TabIndex = 46;
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(212, 78);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(100, 16);
            this.labelQuimadh4.TabIndex = 45;
            this.labelQuimadh4.Text = "Fecha Hasta:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(13, 78);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(105, 16);
            this.labelQuimadh3.TabIndex = 44;
            this.labelQuimadh3.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(112, 73);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaDesde.TabIndex = 43;
            // 
            // cboPlanta
            // 
            this.cboPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPlanta.Enabled = false;
            this.cboPlanta.FormattingEnabled = true;
            this.cboPlanta.Location = new System.Drawing.Point(112, 46);
            this.cboPlanta.Name = "cboPlanta";
            this.cboPlanta.Size = new System.Drawing.Size(221, 21);
            this.cboPlanta.TabIndex = 41;
            this.cboPlanta.SelectedIndexChanged += new System.EventHandler(this.cboPlanta_SelectedIndexChanged);
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(13, 49);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(56, 16);
            this.labelQuimadh1.TabIndex = 42;
            this.labelQuimadh1.Text = "Planta:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Planta";
            this.columnHeader2.Width = 276;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fecha Análisis";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha Muestreo";
            this.columnHeader4.Width = 109;
            // 
            // cboCliente
            // 
            this.cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(112, 19);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(221, 21);
            this.cboCliente.TabIndex = 47;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(13, 22);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(60, 16);
            this.labelQuimadh2.TabIndex = 48;
            this.labelQuimadh2.Text = "Cliente:";
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(351, 22);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(44, 16);
            this.labelQuimadh5.TabIndex = 49;
            this.labelQuimadh5.Text = "Tipo:";
            // 
            // cboTipoRutina
            // 
            this.cboTipoRutina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoRutina.FormattingEnabled = true;
            this.cboTipoRutina.Items.AddRange(new object[] {
            "",
            "ANÁLISIS DE AGUA",
            "ANÁLISIS BACTERIOLÓGICO",
            "ANÁLISIS DE EFLUENTE"});
            this.cboTipoRutina.Location = new System.Drawing.Point(401, 19);
            this.cboTipoRutina.Name = "cboTipoRutina";
            this.cboTipoRutina.Size = new System.Drawing.Size(162, 21);
            this.cboTipoRutina.TabIndex = 50;
            // 
            // frmBusquedaRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 594);
            this.Name = "frmBusquedaRutinas";
            this.TopMost = true;
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh3;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private Controles.CustomComboBox cboPlanta;
        private Controles.LabelQuimadh labelQuimadh1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Controles.CustomComboBox cboCliente;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.CustomComboBox cboTipoRutina;
    }
}