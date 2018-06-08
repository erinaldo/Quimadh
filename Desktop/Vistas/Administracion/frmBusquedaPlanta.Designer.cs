namespace Desktop.Vistas.Administracion
{
    partial class frmBusquedaPlanta
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
            this.txtCodigo = new Controles.TextBoxQuimadh();
            this.txtNombre = new Controles.TextBoxQuimadh();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.labelQuimadh2);
            this.gpbFiltros.Controls.Add(this.labelQuimadh1);
            this.gpbFiltros.Controls.Add(this.txtNombre);
            this.gpbFiltros.Controls.Add(this.txtCodigo);
            this.gpbFiltros.Controls.SetChildIndex(this.txtCodigo, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtNombre, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.labelQuimadh2, 0);
            // 
            // ltvBusqueda
            // 
            this.ltvBusqueda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmCodigo,
            this.clmNombre});
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(140, 21);
            this.lblTitulo.Size = new System.Drawing.Size(320, 45);
            this.lblTitulo.Text = "Búsqueda de Plantas";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(125, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(183, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(57, 22);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(62, 16);
            this.labelQuimadh1.TabIndex = 4;
            this.labelQuimadh1.Text = "Codigo:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(57, 57);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(67, 16);
            this.labelQuimadh2.TabIndex = 5;
            this.labelQuimadh2.Text = "Nombre:";
            // 
            // clmId
            // 
            this.clmId.Text = "Id";
            // 
            // clmCodigo
            // 
            this.clmCodigo.Text = "Codigo";
            this.clmCodigo.Width = 150;
            // 
            // clmNombre
            // 
            this.clmNombre.Text = "Nombre";
            this.clmNombre.Width = 350;
            // 
            // frmBusquedaPlanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 580);
            this.Name = "frmBusquedaPlanta";
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxQuimadh txtCodigo;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.TextBoxQuimadh txtNombre;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmCodigo;
        private System.Windows.Forms.ColumnHeader clmNombre;

    }
}