﻿namespace Desktop.Vistas.Administracion
{
    partial class frmPrecios
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
            this.gpbPrecios = new System.Windows.Forms.GroupBox();
            this.labelQuimadh10 = new Controles.LabelQuimadh(this.components);
            this.cboCliente = new Controles.CustomComboBox(this.components);
            this.lblUltimaModificacion = new Controles.LabelQuimadh(this.components);
            this.txtPrecioFinal = new Controles.TextBoxNumerico();
            this.txtCotizacion = new Controles.TextBoxNumerico();
            this.txtIVA = new Controles.TextBoxNumerico();
            this.cboMoneda = new Controles.CustomComboBox(this.components);
            this.txtPrecioInicial = new Controles.TextBoxNumerico();
            this.txtUnidad = new Controles.TextBoxQuimadh();
            this.txtNumero = new Controles.TextBoxNumerico();
            this.cboArticulo = new Controles.CustomComboBox(this.components);
            this.cboPlanta = new Controles.CustomComboBox(this.components);
            this.labelQuimadh9 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh8 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.clmPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuimadh11 = new Controles.LabelQuimadh(this.components);
            this.gpbPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(150, 86);
            this.lblTitulo.Size = new System.Drawing.Size(391, 45);
            this.lblTitulo.Text = "Administración de Precios";
            // 
            // gpbPrecios
            // 
            this.gpbPrecios.BackColor = System.Drawing.Color.Transparent;
            this.gpbPrecios.Controls.Add(this.labelQuimadh10);
            this.gpbPrecios.Controls.Add(this.cboCliente);
            this.gpbPrecios.Controls.Add(this.lblUltimaModificacion);
            this.gpbPrecios.Controls.Add(this.txtPrecioFinal);
            this.gpbPrecios.Controls.Add(this.txtCotizacion);
            this.gpbPrecios.Controls.Add(this.txtIVA);
            this.gpbPrecios.Controls.Add(this.cboMoneda);
            this.gpbPrecios.Controls.Add(this.txtPrecioInicial);
            this.gpbPrecios.Controls.Add(this.txtUnidad);
            this.gpbPrecios.Controls.Add(this.txtNumero);
            this.gpbPrecios.Controls.Add(this.cboArticulo);
            this.gpbPrecios.Controls.Add(this.cboPlanta);
            this.gpbPrecios.Controls.Add(this.labelQuimadh9);
            this.gpbPrecios.Controls.Add(this.labelQuimadh8);
            this.gpbPrecios.Controls.Add(this.labelQuimadh7);
            this.gpbPrecios.Controls.Add(this.labelQuimadh6);
            this.gpbPrecios.Controls.Add(this.labelQuimadh5);
            this.gpbPrecios.Controls.Add(this.labelQuimadh4);
            this.gpbPrecios.Controls.Add(this.labelQuimadh3);
            this.gpbPrecios.Controls.Add(this.labelQuimadh2);
            this.gpbPrecios.Controls.Add(this.labelQuimadh1);
            this.gpbPrecios.Location = new System.Drawing.Point(12, 162);
            this.gpbPrecios.Name = "gpbPrecios";
            this.gpbPrecios.Size = new System.Drawing.Size(656, 202);
            this.gpbPrecios.TabIndex = 3;
            this.gpbPrecios.TabStop = false;
            this.gpbPrecios.Text = "Datos";
            // 
            // labelQuimadh10
            // 
            this.labelQuimadh10.AutoSize = true;
            this.labelQuimadh10.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh10.Location = new System.Drawing.Point(36, 26);
            this.labelQuimadh10.Name = "labelQuimadh10";
            this.labelQuimadh10.Size = new System.Drawing.Size(60, 16);
            this.labelQuimadh10.TabIndex = 21;
            this.labelQuimadh10.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(137, 25);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(193, 21);
            this.cboCliente.TabIndex = 20;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // lblUltimaModificacion
            // 
            this.lblUltimaModificacion.AutoSize = true;
            this.lblUltimaModificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUltimaModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaModificacion.Location = new System.Drawing.Point(336, 164);
            this.lblUltimaModificacion.Name = "lblUltimaModificacion";
            this.lblUltimaModificacion.Size = new System.Drawing.Size(148, 16);
            this.lblUltimaModificacion.TabIndex = 19;
            this.lblUltimaModificacion.Text = "Última modificación:";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Decimales = 2;
            this.txtPrecioFinal.Enteros = 18;
            this.txtPrecioFinal.EnterTabulacion = true;
            this.txtPrecioFinal.Location = new System.Drawing.Point(137, 160);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.ReadOnly = true;
            this.txtPrecioFinal.Size = new System.Drawing.Size(193, 20);
            this.txtPrecioFinal.TabIndex = 18;
            this.txtPrecioFinal.TabStop = false;
            this.txtPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Decimales = 13;
            this.txtCotizacion.Enteros = 2;
            this.txtCotizacion.EnterTabulacion = true;
            this.txtCotizacion.Location = new System.Drawing.Point(415, 136);
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.ReadOnly = true;
            this.txtCotizacion.Size = new System.Drawing.Size(204, 20);
            this.txtCotizacion.TabIndex = 17;
            this.txtCotizacion.TabStop = false;
            this.txtCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIVA
            // 
            this.txtIVA.Decimales = 2;
            this.txtIVA.Enteros = 16;
            this.txtIVA.EnterTabulacion = true;
            this.txtIVA.Location = new System.Drawing.Point(137, 134);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(193, 20);
            this.txtIVA.TabIndex = 16;
            this.txtIVA.TabStop = false;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(415, 109);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(204, 21);
            this.cboMoneda.TabIndex = 14;
            this.cboMoneda.SelectedIndexChanged += new System.EventHandler(this.cboMoneda_SelectedIndexChanged);
            // 
            // txtPrecioInicial
            // 
            this.txtPrecioInicial.Decimales = 2;
            this.txtPrecioInicial.Enteros = 16;
            this.txtPrecioInicial.EnterTabulacion = true;
            this.txtPrecioInicial.Location = new System.Drawing.Point(137, 108);
            this.txtPrecioInicial.Name = "txtPrecioInicial";
            this.txtPrecioInicial.Size = new System.Drawing.Size(193, 20);
            this.txtPrecioInicial.TabIndex = 13;
            this.txtPrecioInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioInicial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrecioInicial_KeyUp);
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(415, 82);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size(204, 20);
            this.txtUnidad.TabIndex = 12;
            this.txtUnidad.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Decimales = 0;
            this.txtNumero.Enteros = 10;
            this.txtNumero.EnterTabulacion = true;
            this.txtNumero.Location = new System.Drawing.Point(137, 82);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(193, 20);
            this.txtNumero.TabIndex = 11;
            this.txtNumero.TabStop = false;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboArticulo
            // 
            this.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(415, 52);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(204, 21);
            this.cboArticulo.TabIndex = 10;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            // 
            // cboPlanta
            // 
            this.cboPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPlanta.FormattingEnabled = true;
            this.cboPlanta.Location = new System.Drawing.Point(137, 52);
            this.cboPlanta.Name = "cboPlanta";
            this.cboPlanta.Size = new System.Drawing.Size(193, 21);
            this.cboPlanta.TabIndex = 9;
            this.cboPlanta.SelectedIndexChanged += new System.EventHandler(this.cboPlanta_SelectedIndexChanged);
            // 
            // labelQuimadh9
            // 
            this.labelQuimadh9.AutoSize = true;
            this.labelQuimadh9.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh9.Location = new System.Drawing.Point(336, 137);
            this.labelQuimadh9.Name = "labelQuimadh9";
            this.labelQuimadh9.Size = new System.Drawing.Size(84, 16);
            this.labelQuimadh9.TabIndex = 8;
            this.labelQuimadh9.Text = "Cotización:";
            // 
            // labelQuimadh8
            // 
            this.labelQuimadh8.AutoSize = true;
            this.labelQuimadh8.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh8.Location = new System.Drawing.Point(336, 112);
            this.labelQuimadh8.Name = "labelQuimadh8";
            this.labelQuimadh8.Size = new System.Drawing.Size(68, 16);
            this.labelQuimadh8.TabIndex = 7;
            this.labelQuimadh8.Text = "Moneda:";
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(336, 85);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(62, 16);
            this.labelQuimadh7.TabIndex = 6;
            this.labelQuimadh7.Text = "Unidad:";
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(336, 55);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(64, 16);
            this.labelQuimadh6.TabIndex = 5;
            this.labelQuimadh6.Text = "Artículo:";
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(36, 163);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(95, 16);
            this.labelQuimadh5.TabIndex = 4;
            this.labelQuimadh5.Text = "Precio Final:";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(36, 139);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(36, 16);
            this.labelQuimadh4.TabIndex = 3;
            this.labelQuimadh4.Text = "IVA:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(36, 112);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(102, 16);
            this.labelQuimadh3.TabIndex = 2;
            this.labelQuimadh3.Text = "Precio Inicial:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(36, 85);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(62, 16);
            this.labelQuimadh2.TabIndex = 1;
            this.labelQuimadh2.Text = "Código:";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(36, 55);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(56, 16);
            this.labelQuimadh1.TabIndex = 0;
            this.labelQuimadh1.Text = "Planta:";
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPresent,
            this.clmPrecio});
            this.dgvPrecios.Location = new System.Drawing.Point(218, 370);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.Size = new System.Drawing.Size(240, 130);
            this.dgvPrecios.TabIndex = 4;
            this.dgvPrecios.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrecios_CellLeave);
            this.dgvPrecios.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvPrecios_EditingControlShowing);
            // 
            // clmPresent
            // 
            this.clmPresent.HeaderText = "Presentación";
            this.clmPresent.Name = "clmPresent";
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.Name = "clmPrecio";
            // 
            // labelQuimadh11
            // 
            this.labelQuimadh11.AutoSize = true;
            this.labelQuimadh11.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh11.Location = new System.Drawing.Point(61, 370);
            this.labelQuimadh11.Name = "labelQuimadh11";
            this.labelQuimadh11.Size = new System.Drawing.Size(151, 16);
            this.labelQuimadh11.TabIndex = 22;
            this.labelQuimadh11.Text = "Precios Adicionales:";
            // 
            // frmPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.ClientSize = new System.Drawing.Size(680, 515);
            this.Controls.Add(this.labelQuimadh11);
            this.Controls.Add(this.dgvPrecios);
            this.Controls.Add(this.gpbPrecios);
            this.Name = "frmPrecios";
            this.Text = "";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbPrecios, 0);
            this.Controls.SetChildIndex(this.dgvPrecios, 0);
            this.Controls.SetChildIndex(this.labelQuimadh11, 0);
            this.gpbPrecios.ResumeLayout(false);
            this.gpbPrecios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPrecios;
        private Controles.TextBoxNumerico txtPrecioFinal;
        private Controles.TextBoxNumerico txtCotizacion;
        private Controles.TextBoxNumerico txtIVA;
        private Controles.CustomComboBox cboMoneda;
        private Controles.TextBoxNumerico txtPrecioInicial;
        private Controles.TextBoxQuimadh txtUnidad;
        private Controles.TextBoxNumerico txtNumero;
        private Controles.CustomComboBox cboArticulo;
        private Controles.CustomComboBox cboPlanta;
        private Controles.LabelQuimadh labelQuimadh9;
        private Controles.LabelQuimadh labelQuimadh8;
        private Controles.LabelQuimadh labelQuimadh7;
        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh lblUltimaModificacion;
        private Controles.LabelQuimadh labelQuimadh10;
        private Controles.CustomComboBox cboCliente;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private Controles.LabelQuimadh labelQuimadh11;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
    }
}