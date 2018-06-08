namespace Desktop.Vistas.Administracion
{
    partial class frmSalidas
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
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.cboTipo = new Controles.CustomComboBox(this.components);
            this.cboVendedor = new Controles.CustomComboBox(this.components);
            this.cboCliente = new Controles.CustomComboBox(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.lblUnidad = new System.Windows.Forms.Label();
            this.cboArticulo = new Controles.CustomComboBox(this.components);
            this.cboLote = new Controles.CustomComboBox(this.components);
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.lblLote = new Controles.LabelQuimadh(this.components);
            this.txtCantidad = new Controles.TextBoxNumerico();
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.cboPresentacion = new Controles.CustomComboBox(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(42, 85);
            this.lblTitulo.Size = new System.Drawing.Size(122, 45);
            this.lblTitulo.Text = "Salidas";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.labelQuimadh7);
            this.gpbDatos.Controls.Add(this.cboTipo);
            this.gpbDatos.Controls.Add(this.cboVendedor);
            this.gpbDatos.Controls.Add(this.cboCliente);
            this.gpbDatos.Controls.Add(this.labelQuimadh3);
            this.gpbDatos.Controls.Add(this.lblUnidad);
            this.gpbDatos.Controls.Add(this.cboArticulo);
            this.gpbDatos.Controls.Add(this.cboLote);
            this.gpbDatos.Controls.Add(this.labelQuimadh5);
            this.gpbDatos.Controls.Add(this.labelQuimadh6);
            this.gpbDatos.Controls.Add(this.labelQuimadh4);
            this.gpbDatos.Controls.Add(this.lblLote);
            this.gpbDatos.Controls.Add(this.txtCantidad);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.cboPresentacion);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.dtpFecha);
            this.gpbDatos.Location = new System.Drawing.Point(50, 155);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(417, 230);
            this.gpbDatos.TabIndex = 36;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(24, 19);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(93, 16);
            this.labelQuimadh7.TabIndex = 46;
            this.labelQuimadh7.Text = "Tipo Salida:";
            // 
            // cboTipo
            // 
            this.cboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(132, 18);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(204, 21);
            this.cboTipo.TabIndex = 45;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // cboVendedor
            // 
            this.cboVendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(132, 177);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(204, 21);
            this.cboVendedor.TabIndex = 6;
            // 
            // cboCliente
            // 
            this.cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(132, 203);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(204, 21);
            this.cboCliente.TabIndex = 7;
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(62, 204);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(60, 16);
            this.labelQuimadh3.TabIndex = 44;
            this.labelQuimadh3.Text = "Cliente:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(336, 79);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 13);
            this.lblUnidad.TabIndex = 43;
            // 
            // cboArticulo
            // 
            this.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(132, 45);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(204, 21);
            this.cboArticulo.TabIndex = 1;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            // 
            // cboLote
            // 
            this.cboLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLote.FormattingEnabled = true;
            this.cboLote.Location = new System.Drawing.Point(132, 125);
            this.cboLote.Name = "cboLote";
            this.cboLote.Size = new System.Drawing.Size(204, 21);
            this.cboLote.TabIndex = 4;
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(48, 178);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(80, 16);
            this.labelQuimadh5.TabIndex = 37;
            this.labelQuimadh5.Text = "Vendedor:";
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(62, 46);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(64, 16);
            this.labelQuimadh6.TabIndex = 12;
            this.labelQuimadh6.Text = "Artículo:";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(71, 155);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(55, 16);
            this.labelQuimadh4.TabIndex = 34;
            this.labelQuimadh4.Text = "Fecha:";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.BackColor = System.Drawing.Color.Transparent;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(64, 126);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(62, 16);
            this.lblLote.TabIndex = 33;
            this.lblLote.Text = "N° Lote:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Decimales = 2;
            this.txtCantidad.Enteros = 10;
            this.txtCantidad.EnterTabulacion = true;
            this.txtCantidad.Location = new System.Drawing.Point(132, 72);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(204, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(23, 99);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(103, 16);
            this.labelQuimadh2.TabIndex = 32;
            this.labelQuimadh2.Text = "Presentación:";
            // 
            // cboPresentacion
            // 
            this.cboPresentacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresentacion.FormattingEnabled = true;
            this.cboPresentacion.Location = new System.Drawing.Point(132, 98);
            this.cboPresentacion.Name = "cboPresentacion";
            this.cboPresentacion.Size = new System.Drawing.Size(204, 21);
            this.cboPresentacion.TabIndex = 3;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(52, 73);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(74, 16);
            this.labelQuimadh1.TabIndex = 31;
            this.labelQuimadh1.Text = "Cantidad:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(132, 151);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(204, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // frmSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(531, 397);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmSalidas";
            this.Text = "Salidas";
            this.Load += new System.EventHandler(this.frmSalidas_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Label lblUnidad;
        private Controles.CustomComboBox cboLote;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh lblLote;
        private Controles.TextBoxNumerico txtCantidad;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.CustomComboBox cboPresentacion;
        private Controles.LabelQuimadh labelQuimadh1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Controles.CustomComboBox cboCliente;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.CustomComboBox cboArticulo;
        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.CustomComboBox cboVendedor;
        private Controles.LabelQuimadh labelQuimadh7;
        private Controles.CustomComboBox cboTipo;
    }
}