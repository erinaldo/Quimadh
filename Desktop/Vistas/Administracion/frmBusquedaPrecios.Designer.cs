namespace Desktop.Vistas.Administracion
{
    partial class frmBusquedaPrecios
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
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.cboMoneda = new Controles.CustomComboBox(this.components);
            this.txtPrecioInicial = new Controles.TextBoxNumerico();
            this.cboPlanta = new Controles.CustomComboBox(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboArticulo = new Controles.CustomComboBox(this.components);
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.txtCodigo = new Controles.TextBoxQuimadh();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkMostrarHistorico = new System.Windows.Forms.CheckBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelQuimadh10 = new Controles.LabelQuimadh(this.components);
            this.cboCliente = new Controles.CustomComboBox(this.components);
            this.chkMostraEliminados = new System.Windows.Forms.CheckBox();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.chkMostraEliminados);
            this.gpbFiltros.Controls.Add(this.labelQuimadh10);
            this.gpbFiltros.Controls.Add(this.cboCliente);
            this.gpbFiltros.Controls.Add(this.chkMostrarHistorico);
            this.gpbFiltros.Controls.Add(this.txtCodigo);
            this.gpbFiltros.Controls.Add(this.labelQuimadh4);
            this.gpbFiltros.Controls.Add(this.cboArticulo);
            this.gpbFiltros.Controls.Add(this.labelQuimadh6);
            this.gpbFiltros.Controls.Add(this.labelQuimadh3);
            this.gpbFiltros.Controls.Add(this.labelQuimadh2);
            this.gpbFiltros.Controls.Add(this.labelQuimadh1);
            this.gpbFiltros.Controls.Add(this.cboMoneda);
            this.gpbFiltros.Controls.Add(this.txtPrecioInicial);
            this.gpbFiltros.Controls.Add(this.cboPlanta);
            this.gpbFiltros.Location = new System.Drawing.Point(20, 97);
            this.gpbFiltros.Margin = new System.Windows.Forms.Padding(5);
            this.gpbFiltros.Padding = new System.Windows.Forms.Padding(5);
            this.gpbFiltros.Size = new System.Drawing.Size(880, 159);
            this.gpbFiltros.Controls.SetChildIndex(this.cboPlanta, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtPrecioInicial, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cboMoneda, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh6, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cboArticulo, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtCodigo, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.chkMostrarHistorico, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cboCliente, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh10, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.chkMostraEliminados, 0);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(16, 260);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // cboNumeroRegistros
            // 
            this.cboNumeroRegistros.Location = new System.Drawing.Point(836, 256);
            this.cboNumeroRegistros.Margin = new System.Windows.Forms.Padding(5);
            this.cboNumeroRegistros.Size = new System.Drawing.Size(63, 24);
            // 
            // lblNumeroRegistros
            // 
            this.lblNumeroRegistros.Location = new System.Drawing.Point(773, 260);
            this.lblNumeroRegistros.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // ltvBusqueda
            // 
            this.ltvBusqueda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.ltvBusqueda.Margin = new System.Windows.Forms.Padding(5);
            this.ltvBusqueda.Size = new System.Drawing.Size(880, 389);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(193, 23);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Size = new System.Drawing.Size(392, 54);
            this.lblTitulo.Text = "Búsqueda de Precios";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(401, 64);
            this.labelQuimadh3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(80, 20);
            this.labelQuimadh3.TabIndex = 26;
            this.labelQuimadh3.Text = "Moneda:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(8, 100);
            this.labelQuimadh2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(69, 20);
            this.labelQuimadh2.TabIndex = 25;
            this.labelQuimadh2.Text = "Precio:";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(8, 64);
            this.labelQuimadh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(68, 20);
            this.labelQuimadh1.TabIndex = 24;
            this.labelQuimadh1.Text = "Planta:";
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(492, 60);
            this.cboMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(271, 24);
            this.cboMoneda.TabIndex = 23;
            // 
            // txtPrecioInicial
            // 
            this.txtPrecioInicial.Decimales = 2;
            this.txtPrecioInicial.Enteros = 16;
            this.txtPrecioInicial.EnterTabulacion = true;
            this.txtPrecioInicial.Location = new System.Drawing.Point(96, 98);
            this.txtPrecioInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioInicial.Name = "txtPrecioInicial";
            this.txtPrecioInicial.Size = new System.Drawing.Size(280, 22);
            this.txtPrecioInicial.TabIndex = 22;
            this.txtPrecioInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboPlanta
            // 
            this.cboPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPlanta.FormattingEnabled = true;
            this.cboPlanta.Location = new System.Drawing.Point(96, 63);
            this.cboPlanta.Margin = new System.Windows.Forms.Padding(4);
            this.cboPlanta.Name = "cboPlanta";
            this.cboPlanta.Size = new System.Drawing.Size(280, 24);
            this.cboPlanta.TabIndex = 21;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Planta";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Artículo";
            this.columnHeader2.Width = 202;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Moneda";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            // 
            // cboArticulo
            // 
            this.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(492, 23);
            this.cboArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(271, 24);
            this.cboArticulo.TabIndex = 28;
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(401, 27);
            this.labelQuimadh6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(80, 20);
            this.labelQuimadh6.TabIndex = 27;
            this.labelQuimadh6.Text = "Artículo:";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(8, 129);
            this.labelQuimadh4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(73, 20);
            this.labelQuimadh4.TabIndex = 30;
            this.labelQuimadh4.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(96, 128);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(112, 22);
            this.txtCodigo.TabIndex = 31;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Código";
            // 
            // chkMostrarHistorico
            // 
            this.chkMostrarHistorico.AutoSize = true;
            this.chkMostrarHistorico.Location = new System.Drawing.Point(217, 132);
            this.chkMostrarHistorico.Margin = new System.Windows.Forms.Padding(4);
            this.chkMostrarHistorico.Name = "chkMostrarHistorico";
            this.chkMostrarHistorico.Size = new System.Drawing.Size(161, 21);
            this.chkMostrarHistorico.TabIndex = 32;
            this.chkMostrarHistorico.Text = "Mostrar Precios Hist.";
            this.chkMostrarHistorico.UseVisualStyleBackColor = true;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha Cambio";
            // 
            // labelQuimadh10
            // 
            this.labelQuimadh10.AutoSize = true;
            this.labelQuimadh10.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh10.Location = new System.Drawing.Point(8, 27);
            this.labelQuimadh10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh10.Name = "labelQuimadh10";
            this.labelQuimadh10.Size = new System.Drawing.Size(74, 20);
            this.labelQuimadh10.TabIndex = 34;
            this.labelQuimadh10.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(96, 26);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(280, 24);
            this.cboCliente.TabIndex = 33;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // chkMostraEliminados
            // 
            this.chkMostraEliminados.AutoSize = true;
            this.chkMostraEliminados.Location = new System.Drawing.Point(383, 131);
            this.chkMostraEliminados.Margin = new System.Windows.Forms.Padding(4);
            this.chkMostraEliminados.Name = "chkMostraEliminados";
            this.chkMostraEliminados.Size = new System.Drawing.Size(150, 21);
            this.chkMostraEliminados.TabIndex = 35;
            this.chkMostraEliminados.Text = "Mostrar Eliminados";
            this.chkMostraEliminados.UseVisualStyleBackColor = true;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Eliminado";
            this.columnHeader7.Width = 50;
            // 
            // frmBusquedaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 716);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmBusquedaPrecios";
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.CustomComboBox cboMoneda;
        private Controles.TextBoxNumerico txtPrecioInicial;
        private Controles.CustomComboBox cboPlanta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Controles.CustomComboBox cboArticulo;
        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.TextBoxQuimadh txtCodigo;
        private Controles.LabelQuimadh labelQuimadh4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox chkMostrarHistorico;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private Controles.LabelQuimadh labelQuimadh10;
        private Controles.CustomComboBox cboCliente;
        private System.Windows.Forms.CheckBox chkMostraEliminados;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}