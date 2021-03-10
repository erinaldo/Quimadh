namespace Desktop.Vistas.Administracion
{
    partial class frmBusquedaProveedor
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
            this.txtRazonSoc = new Controles.TextBoxQuimadh();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCUIT = new Controles.TextBoxNumerico();
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.txtCUIT);
            this.gpbFiltros.Controls.Add(this.txtRazonSoc);
            this.gpbFiltros.Controls.Add(this.lblUnidad);
            this.gpbFiltros.Controls.Add(this.lblNombre);
            this.gpbFiltros.Controls.SetChildIndex(this.lblNombre, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblUnidad, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtRazonSoc, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtCUIT, 0);
            // 
            // ltvBusqueda
            // 
            this.ltvBusqueda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(133, 20);
            this.lblTitulo.Size = new System.Drawing.Size(326, 45);
            this.lblTitulo.Text = "Búsqueda de Clientes";
            // 
            // txtRazonSoc
            // 
            this.txtRazonSoc.Location = new System.Drawing.Point(95, 19);
            this.txtRazonSoc.Name = "txtRazonSoc";
            this.txtRazonSoc.Size = new System.Drawing.Size(226, 20);
            this.txtRazonSoc.TabIndex = 30;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(20, 50);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(64, 13);
            this.lblUnidad.TabIndex = 29;
            this.lblUnidad.Text = "CUIT/CUIL:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 13);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Razón Socal:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Razón Social";
            this.columnHeader2.Width = 275;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CUIT/CUIL";
            this.columnHeader3.Width = 96;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Decimales = 0;
            this.txtCUIT.Enteros = 11;
            this.txtCUIT.EnterTabulacion = true;
            this.txtCUIT.Location = new System.Drawing.Point(95, 47);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(226, 20);
            this.txtCUIT.TabIndex = 31;
            this.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 580);
            this.Name = "frmBusquedaCliente";
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxQuimadh txtRazonSoc;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Controles.TextBoxNumerico txtCUIT;

    }
}