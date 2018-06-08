namespace Desktop.Vistas.Administracion
{
    partial class frmArticulos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.cboUnidadStock = new Controles.CustomComboBox(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.cboUnidad = new Controles.CustomComboBox(this.components);
            this.txtNombre = new Controles.TextBoxQuimadh();
            this.dgvComposicion = new System.Windows.Forms.DataGridView();
            this.clmArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(50, 83);
            this.lblTitulo.Size = new System.Drawing.Size(416, 45);
            this.lblTitulo.Text = "Administración de Artículos";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.labelQuimadh3);
            this.gpbDatos.Controls.Add(this.cboUnidadStock);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.cboUnidad);
            this.gpbDatos.Controls.Add(this.txtNombre);
            this.gpbDatos.Location = new System.Drawing.Point(69, 157);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(360, 107);
            this.gpbDatos.TabIndex = 25;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(7, 75);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(78, 16);
            this.labelQuimadh3.TabIndex = 29;
            this.labelQuimadh3.Text = "Un. Stock:";
            // 
            // cboUnidadStock
            // 
            this.cboUnidadStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadStock.FormattingEnabled = true;
            this.cboUnidadStock.Location = new System.Drawing.Point(100, 74);
            this.cboUnidadStock.Name = "cboUnidadStock";
            this.cboUnidadStock.Size = new System.Drawing.Size(226, 21);
            this.cboUnidadStock.TabIndex = 30;
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(7, 49);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(62, 16);
            this.labelQuimadh2.TabIndex = 26;
            this.labelQuimadh2.Text = "Unidad:";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(7, 23);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(67, 16);
            this.labelQuimadh1.TabIndex = 28;
            this.labelQuimadh1.Text = "Nombre:";
            // 
            // cboUnidad
            // 
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(100, 47);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(226, 21);
            this.cboUnidad.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // dgvComposicion
            // 
            this.dgvComposicion.BackgroundColor = System.Drawing.Color.White;
            this.dgvComposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComposicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmArt,
            this.clmCant,
            this.clmFactor});
            this.dgvComposicion.Location = new System.Drawing.Point(12, 290);
            this.dgvComposicion.Name = "dgvComposicion";
            this.dgvComposicion.Size = new System.Drawing.Size(482, 150);
            this.dgvComposicion.TabIndex = 26;
            this.dgvComposicion.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComposicion_CellLeave);
            this.dgvComposicion.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvComposicion_EditingControlShowing);
            // 
            // clmArt
            // 
            this.clmArt.HeaderText = "Artículo";
            this.clmArt.Name = "clmArt";
            this.clmArt.Width = 230;
            // 
            // clmCant
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.clmCant.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCant.HeaderText = "Proporción";
            this.clmCant.Name = "clmCant";
            // 
            // clmFactor
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "1";
            this.clmFactor.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmFactor.HeaderText = "Factor Conversión";
            this.clmFactor.Name = "clmFactor";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.ClientSize = new System.Drawing.Size(506, 452);
            this.Controls.Add(this.dgvComposicion);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmArticulos";
            this.Text = "";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.Controls.SetChildIndex(this.dgvComposicion, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComposicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.TextBoxQuimadh txtNombre;
        private Controles.CustomComboBox cboUnidad;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.CustomComboBox cboUnidadStock;
        private System.Windows.Forms.DataGridView dgvComposicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFactor;
    }
}