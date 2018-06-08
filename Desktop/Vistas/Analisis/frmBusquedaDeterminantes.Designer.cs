namespace Desktop.Vistas.Analisis
{
    partial class frmBusquedaDeterminantes
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
            this.txtUnidad = new Controles.TextBoxQuimadh();
            this.txtNombre = new Controles.TextBoxQuimadh();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNombre = new Controles.LabelQuimadh(this.components);
            this.lblUnidad = new Controles.LabelQuimadh(this.components);
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.lblUnidad);
            this.gpbFiltros.Controls.Add(this.lblNombre);
            this.gpbFiltros.Controls.Add(this.txtUnidad);
            this.gpbFiltros.Controls.Add(this.txtNombre);
            this.gpbFiltros.Controls.SetChildIndex(this.txtNombre, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtUnidad, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblNombre, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblUnidad, 0);
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
            this.lblTitulo.Location = new System.Drawing.Point(97, 20);
            this.lblTitulo.Size = new System.Drawing.Size(424, 45);
            this.lblTitulo.Text = "Búsqueda de Determinantes";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(107, 50);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(226, 20);
            this.txtUnidad.TabIndex = 31;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 30;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 283;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unidad";
            this.columnHeader3.Width = 218;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 15);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.BackColor = System.Drawing.Color.Transparent;
            this.lblUnidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(16, 52);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(58, 15);
            this.lblUnidad.TabIndex = 33;
            this.lblUnidad.Text = "Unidad:";
            // 
            // frmBusquedaDeterminantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 583);
            this.Name = "frmBusquedaDeterminantes";
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxQuimadh txtUnidad;
        private Controles.TextBoxQuimadh txtNombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Controles.LabelQuimadh lblUnidad;
        private Controles.LabelQuimadh lblNombre;
    }
}