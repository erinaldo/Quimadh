namespace Desktop.Vistas.Administracion
{
    partial class frmLotes
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
            this.txtNroLote = new Controles.TextBoxQuimadh();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.cboUnidad = new Controles.CustomComboBox(this.components);
            this.lalbel = new Controles.LabelQuimadh(this.components);
            this.dtpFechaVto = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaElab = new System.Windows.Forms.DateTimePicker();
            this.cboArticulo = new Controles.CustomComboBox(this.components);
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFecCierre = new Controles.LabelQuimadh(this.components);
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.cboEstado = new Controles.CustomComboBox(this.components);
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(51, 84);
            this.lblTitulo.Size = new System.Drawing.Size(94, 45);
            this.lblTitulo.Text = "Lotes";
            // 
            // txtNroLote
            // 
            this.txtNroLote.Location = new System.Drawing.Point(125, 51);
            this.txtNroLote.Name = "txtNroLote";
            this.txtNroLote.Size = new System.Drawing.Size(216, 20);
            this.txtNroLote.TabIndex = 4;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(50, 26);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(69, 15);
            this.labelQuimadh1.TabIndex = 6;
            this.labelQuimadh1.Text = "Tipo Art.:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(44, 53);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(75, 15);
            this.labelQuimadh2.TabIndex = 7;
            this.labelQuimadh2.Text = "Nro. Lote.:";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.labelQuimadh6);
            this.gpbDatos.Controls.Add(this.cboUnidad);
            this.gpbDatos.Controls.Add(this.lalbel);
            this.gpbDatos.Controls.Add(this.dtpFechaVto);
            this.gpbDatos.Controls.Add(this.labelQuimadh4);
            this.gpbDatos.Controls.Add(this.dtpFechaElab);
            this.gpbDatos.Controls.Add(this.cboArticulo);
            this.gpbDatos.Controls.Add(this.labelQuimadh5);
            this.gpbDatos.Controls.Add(this.dtpFechaInicio);
            this.gpbDatos.Controls.Add(this.lblFecCierre);
            this.gpbDatos.Controls.Add(this.dtpFechaCierre);
            this.gpbDatos.Controls.Add(this.labelQuimadh3);
            this.gpbDatos.Controls.Add(this.cboEstado);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.txtNroLote);
            this.gpbDatos.Location = new System.Drawing.Point(37, 149);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(378, 219);
            this.gpbDatos.TabIndex = 8;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(61, 210);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(58, 15);
            this.labelQuimadh6.TabIndex = 20;
            this.labelQuimadh6.Text = "Unidad:";
            this.labelQuimadh6.Visible = false;
            // 
            // cboUnidad
            // 
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(125, 208);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(216, 21);
            this.cboUnidad.TabIndex = 19;
            this.cboUnidad.Visible = false;
            // 
            // lalbel
            // 
            this.lalbel.AutoSize = true;
            this.lalbel.BackColor = System.Drawing.Color.Transparent;
            this.lalbel.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalbel.Location = new System.Drawing.Point(40, 129);
            this.lalbel.Name = "lalbel";
            this.lalbel.Size = new System.Drawing.Size(79, 15);
            this.lalbel.TabIndex = 18;
            this.lalbel.Text = "Fecha Vto.:";
            // 
            // dtpFechaVto
            // 
            this.dtpFechaVto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVto.Location = new System.Drawing.Point(125, 129);
            this.dtpFechaVto.Name = "dtpFechaVto";
            this.dtpFechaVto.Size = new System.Drawing.Size(216, 20);
            this.dtpFechaVto.TabIndex = 17;
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(18, 103);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(101, 15);
            this.labelQuimadh4.TabIndex = 16;
            this.labelQuimadh4.Text = "Fecha Elabor.:";
            // 
            // dtpFechaElab
            // 
            this.dtpFechaElab.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaElab.Location = new System.Drawing.Point(125, 103);
            this.dtpFechaElab.Name = "dtpFechaElab";
            this.dtpFechaElab.Size = new System.Drawing.Size(216, 20);
            this.dtpFechaElab.TabIndex = 15;
            // 
            // cboArticulo
            // 
            this.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(125, 24);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(216, 21);
            this.cboArticulo.TabIndex = 14;
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(25, 78);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(90, 15);
            this.labelQuimadh5.TabIndex = 13;
            this.labelQuimadh5.Text = "Fecha Inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(125, 77);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(216, 20);
            this.dtpFechaInicio.TabIndex = 12;
            // 
            // lblFecCierre
            // 
            this.lblFecCierre.AutoSize = true;
            this.lblFecCierre.BackColor = System.Drawing.Color.Transparent;
            this.lblFecCierre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecCierre.Location = new System.Drawing.Point(25, 183);
            this.lblFecCierre.Name = "lblFecCierre";
            this.lblFecCierre.Size = new System.Drawing.Size(94, 15);
            this.lblFecCierre.TabIndex = 11;
            this.lblFecCierre.Text = "Fecha Cierre:";
            this.lblFecCierre.Visible = false;
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Enabled = false;
            this.dtpFechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCierre.Location = new System.Drawing.Point(125, 182);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(216, 20);
            this.dtpFechaCierre.TabIndex = 10;
            this.dtpFechaCierre.Visible = false;
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(63, 157);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(56, 15);
            this.labelQuimadh3.TabIndex = 9;
            this.labelQuimadh3.Text = "Estado:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(125, 155);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(216, 21);
            this.cboEstado.TabIndex = 8;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // frmLotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.ClientSize = new System.Drawing.Size(481, 399);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmLotes";
            this.Text = "";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxQuimadh txtNroLote;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.LabelQuimadh lblFecCierre;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.CustomComboBox cboEstado;
        private Controles.LabelQuimadh labelQuimadh5;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private Controles.CustomComboBox cboArticulo;
        private Controles.LabelQuimadh lalbel;
        private System.Windows.Forms.DateTimePicker dtpFechaVto;
        private Controles.LabelQuimadh labelQuimadh4;
        private System.Windows.Forms.DateTimePicker dtpFechaElab;
        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.CustomComboBox cboUnidad;
    }
}