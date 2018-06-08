namespace Desktop.Vistas.Administracion
{
    partial class frmEntradas
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
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.txtCantidad = new Controles.TextBoxNumerico();
            this.cboPresentacion = new Controles.CustomComboBox(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.lblLote = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.cboTipo = new Controles.CustomComboBox(this.components);
            this.cboArticulo = new Controles.CustomComboBox(this.components);
            this.lnkNuevoLote = new System.Windows.Forms.LinkLabel();
            this.cboLote = new Controles.CustomComboBox(this.components);
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.txtConcepto = new Controles.TextBoxQuimadh();
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(50, 86);
            this.lblTitulo.Size = new System.Drawing.Size(145, 45);
            this.lblTitulo.Text = "Entradas";
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(55, 43);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(64, 16);
            this.labelQuimadh6.TabIndex = 12;
            this.labelQuimadh6.Text = "Artículo:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Decimales = 2;
            this.txtCantidad.Enteros = 10;
            this.txtCantidad.EnterTabulacion = true;
            this.txtCantidad.Location = new System.Drawing.Point(125, 69);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(204, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboPresentacion
            // 
            this.cboPresentacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresentacion.FormattingEnabled = true;
            this.cboPresentacion.Location = new System.Drawing.Point(125, 95);
            this.cboPresentacion.Name = "cboPresentacion";
            this.cboPresentacion.Size = new System.Drawing.Size(204, 21);
            this.cboPresentacion.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(125, 148);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(204, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(45, 70);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(74, 16);
            this.labelQuimadh1.TabIndex = 31;
            this.labelQuimadh1.Text = "Cantidad:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(16, 96);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(103, 16);
            this.labelQuimadh2.TabIndex = 32;
            this.labelQuimadh2.Text = "Presentación:";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.BackColor = System.Drawing.Color.Transparent;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(57, 123);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(62, 16);
            this.lblLote.TabIndex = 33;
            this.lblLote.Text = "N° Lote:";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(64, 152);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(55, 16);
            this.labelQuimadh4.TabIndex = 34;
            this.labelQuimadh4.Text = "Fecha:";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.lblUnidad);
            this.gpbDatos.Controls.Add(this.labelQuimadh7);
            this.gpbDatos.Controls.Add(this.cboTipo);
            this.gpbDatos.Controls.Add(this.cboArticulo);
            this.gpbDatos.Controls.Add(this.lnkNuevoLote);
            this.gpbDatos.Controls.Add(this.cboLote);
            this.gpbDatos.Controls.Add(this.labelQuimadh5);
            this.gpbDatos.Controls.Add(this.txtConcepto);
            this.gpbDatos.Controls.Add(this.labelQuimadh6);
            this.gpbDatos.Controls.Add(this.labelQuimadh4);
            this.gpbDatos.Controls.Add(this.lblLote);
            this.gpbDatos.Controls.Add(this.txtCantidad);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.cboPresentacion);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.dtpFecha);
            this.gpbDatos.Location = new System.Drawing.Point(86, 151);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(417, 205);
            this.gpbDatos.TabIndex = 35;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(338, 102);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 13);
            this.lblUnidad.TabIndex = 43;
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(17, 16);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(102, 16);
            this.labelQuimadh7.TabIndex = 42;
            this.labelQuimadh7.Text = "Tipo Entrada:";
            // 
            // cboTipo
            // 
            this.cboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(125, 15);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(204, 21);
            this.cboTipo.TabIndex = 2;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // cboArticulo
            // 
            this.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(125, 42);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(204, 21);
            this.cboArticulo.TabIndex = 40;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            // 
            // lnkNuevoLote
            // 
            this.lnkNuevoLote.AutoSize = true;
            this.lnkNuevoLote.Location = new System.Drawing.Point(335, 125);
            this.lnkNuevoLote.Name = "lnkNuevoLote";
            this.lnkNuevoLote.Size = new System.Drawing.Size(81, 13);
            this.lnkNuevoLote.TabIndex = 8;
            this.lnkNuevoLote.TabStop = true;
            this.lnkNuevoLote.Text = "Gestionar Lotes";
            this.lnkNuevoLote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNuevoLote_LinkClicked);
            // 
            // cboLote
            // 
            this.cboLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLote.FormattingEnabled = true;
            this.cboLote.Location = new System.Drawing.Point(125, 122);
            this.cboLote.Name = "cboLote";
            this.cboLote.Size = new System.Drawing.Size(204, 21);
            this.cboLote.TabIndex = 5;
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(41, 175);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(78, 16);
            this.labelQuimadh5.TabIndex = 37;
            this.labelQuimadh5.Text = "Concepto:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(125, 174);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(204, 20);
            this.txtConcepto.TabIndex = 7;
            // 
            // frmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.ClientSize = new System.Drawing.Size(576, 394);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmEntradas";
            this.Text = "";
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.TextBoxNumerico txtCantidad;
        private Controles.CustomComboBox cboPresentacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh lblLote;
        private Controles.LabelQuimadh labelQuimadh4;
        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.TextBoxQuimadh txtConcepto;
        private Controles.CustomComboBox cboLote;
        private System.Windows.Forms.LinkLabel lnkNuevoLote;
        private Controles.CustomComboBox cboArticulo;
        private Controles.CustomComboBox cboTipo;
        private Controles.LabelQuimadh labelQuimadh7;
        private System.Windows.Forms.Label lblUnidad;
    }
}