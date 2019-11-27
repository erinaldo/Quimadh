namespace Desktop.Vistas.Ventas
{
    partial class frmBusquedaComp
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
            this.txtCodPlanta = new Controles.TextBoxQuimadh();
            this.txtNroComp = new Controles.TextBoxNumerico();
            this.txtNomPlanta = new Controles.TextBoxQuimadh();
            this.lblTipo = new System.Windows.Forms.Label();
            this.clmNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboPv = new Controles.CustomComboBox(this.components);
            this.txtNomCliente = new Controles.TextBoxQuimadh();
            this.clmNomCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.clmMiPyme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.labelQuimadh6);
            this.gpbFiltros.Controls.Add(this.labelQuimadh5);
            this.gpbFiltros.Controls.Add(this.labelQuimadh3);
            this.gpbFiltros.Controls.Add(this.labelQuimadh2);
            this.gpbFiltros.Controls.Add(this.labelQuimadh1);
            this.gpbFiltros.Controls.Add(this.txtNomCliente);
            this.gpbFiltros.Controls.Add(this.cboPv);
            this.gpbFiltros.Controls.Add(this.lblTipo);
            this.gpbFiltros.Controls.Add(this.txtNomPlanta);
            this.gpbFiltros.Controls.Add(this.txtNroComp);
            this.gpbFiltros.Controls.Add(this.txtCodPlanta);
            this.gpbFiltros.Size = new System.Drawing.Size(640, 116);
            this.gpbFiltros.Controls.SetChildIndex(this.txtCodPlanta, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtNroComp, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtNomPlanta, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblTipo, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cboPv, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtNomCliente, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh5, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh6, 0);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(12, 209);
            // 
            // cboNumeroRegistros
            // 
            this.cboNumeroRegistros.Location = new System.Drawing.Point(604, 209);
            // 
            // lblNumeroRegistros
            // 
            this.lblNumeroRegistros.Location = new System.Drawing.Point(563, 212);
            // 
            // ltvBusqueda
            // 
            this.ltvBusqueda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmFecha,
            this.clmNumero,
            this.clmNomCliente,
            this.clmImporte,
            this.clmTipo,
            this.clmMiPyme,
            this.clmEstado});
            this.ltvBusqueda.Location = new System.Drawing.Point(12, 233);
            this.ltvBusqueda.Size = new System.Drawing.Size(640, 317);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(145, 21);
            this.lblTitulo.Size = new System.Drawing.Size(379, 45);
            this.lblTitulo.Text = "Búsqueda Comprobantes";
            // 
            // txtCodPlanta
            // 
            this.txtCodPlanta.Location = new System.Drawing.Point(127, 16);
            this.txtCodPlanta.Name = "txtCodPlanta";
            this.txtCodPlanta.Size = new System.Drawing.Size(122, 20);
            this.txtCodPlanta.TabIndex = 34;
            // 
            // txtNroComp
            // 
            this.txtNroComp.Decimales = 0;
            this.txtNroComp.Enteros = 11;
            this.txtNroComp.EnterTabulacion = true;
            this.txtNroComp.Location = new System.Drawing.Point(127, 70);
            this.txtNroComp.Name = "txtNroComp";
            this.txtNroComp.Size = new System.Drawing.Size(122, 20);
            this.txtNroComp.TabIndex = 37;
            this.txtNroComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNomPlanta
            // 
            this.txtNomPlanta.Location = new System.Drawing.Point(376, 16);
            this.txtNomPlanta.Name = "txtNomPlanta";
            this.txtNomPlanta.Size = new System.Drawing.Size(210, 20);
            this.txtNomPlanta.TabIndex = 38;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(152, 16);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 39;
            // 
            // clmNumero
            // 
            this.clmNumero.Text = "Numero";
            this.clmNumero.Width = 100;
            // 
            // clmImporte
            // 
            this.clmImporte.Text = "Importe";
            this.clmImporte.Width = 100;
            // 
            // clmFecha
            // 
            this.clmFecha.Text = "Fecha";
            this.clmFecha.Width = 80;
            // 
            // clmTipo
            // 
            this.clmTipo.Text = "Tipo";
            this.clmTipo.Width = 80;
            // 
            // clmEstado
            // 
            this.clmEstado.Text = "Estado";
            this.clmEstado.Width = 100;
            // 
            // cboPv
            // 
            this.cboPv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPv.FormattingEnabled = true;
            this.cboPv.Location = new System.Drawing.Point(127, 43);
            this.cboPv.Name = "cboPv";
            this.cboPv.Size = new System.Drawing.Size(122, 21);
            this.cboPv.TabIndex = 40;
            // 
            // txtNomCliente
            // 
            this.txtNomCliente.Location = new System.Drawing.Point(376, 43);
            this.txtNomCliente.Name = "txtNomCliente";
            this.txtNomCliente.Size = new System.Drawing.Size(210, 20);
            this.txtNomCliente.TabIndex = 44;
            // 
            // clmNomCliente
            // 
            this.clmNomCliente.Text = "Cliente";
            this.clmNomCliente.Width = 150;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(18, 19);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(110, 16);
            this.labelQuimadh1.TabIndex = 45;
            this.labelQuimadh1.Text = "Codigo Planta:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(14, 46);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(117, 16);
            this.labelQuimadh2.TabIndex = 46;
            this.labelQuimadh2.Text = "Punto de Venta:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(4, 72);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(125, 16);
            this.labelQuimadh3.TabIndex = 47;
            this.labelQuimadh3.Text = "N° Comprobante:";
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(261, 45);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(119, 16);
            this.labelQuimadh5.TabIndex = 49;
            this.labelQuimadh5.Text = "Nombre Cliente:";
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(265, 18);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(115, 16);
            this.labelQuimadh6.TabIndex = 50;
            this.labelQuimadh6.Text = "Nombre Planta:";
            // 
            // clmMiPyme
            // 
            this.clmMiPyme.Text = "MiPyme";
            // 
            // frmBusquedaComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 580);
            this.Name = "frmBusquedaComp";
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxQuimadh txtNomPlanta;
        private Controles.TextBoxNumerico txtNroComp;
        private Controles.TextBoxQuimadh txtCodPlanta;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ColumnHeader clmFecha;
        private System.Windows.Forms.ColumnHeader clmNumero;
        private System.Windows.Forms.ColumnHeader clmImporte;
        private System.Windows.Forms.ColumnHeader clmTipo;
        private System.Windows.Forms.ColumnHeader clmEstado;
        private Controles.CustomComboBox cboPv;
        private Controles.TextBoxQuimadh txtNomCliente;
        private System.Windows.Forms.ColumnHeader clmNomCliente;
        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh1;
        private System.Windows.Forms.ColumnHeader clmMiPyme;
    }
}