namespace Desktop.Vistas.Analisis
{
    partial class frmDeterminantes
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
            this.cboGrupo = new Controles.CustomComboBox(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.txtUnidad = new Controles.TextBoxQuimadh();
            this.txtNombre = new Controles.TextBoxQuimadh();
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(23, 84);
            this.lblTitulo.Size = new System.Drawing.Size(531, 45);
            this.lblTitulo.Text = "Administración de Determinaciones";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.cboGrupo);
            this.gpbDatos.Controls.Add(this.labelQuimadh3);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.txtUnidad);
            this.gpbDatos.Controls.Add(this.txtNombre);
            this.gpbDatos.Location = new System.Drawing.Point(97, 157);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(360, 112);
            this.gpbDatos.TabIndex = 26;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "7"});
            this.cboGrupo.Location = new System.Drawing.Point(91, 75);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(121, 21);
            this.cboGrupo.TabIndex = 31;
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(7, 77);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(52, 15);
            this.labelQuimadh3.TabIndex = 30;
            this.labelQuimadh3.Text = "Grupo:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(7, 51);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(58, 15);
            this.labelQuimadh2.TabIndex = 29;
            this.labelQuimadh2.Text = "Unidad:";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(7, 23);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(63, 15);
            this.labelQuimadh1.TabIndex = 28;
            this.labelQuimadh1.Text = "Nombre:";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(91, 49);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(226, 20);
            this.txtUnidad.TabIndex = 27;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(91, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // frmDeterminantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.ClientSize = new System.Drawing.Size(560, 281);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmDeterminantes";
            this.Text = "";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.TextBoxQuimadh txtNombre;
        private Controles.TextBoxQuimadh txtUnidad;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.CustomComboBox cboGrupo;
        private Controles.LabelQuimadh labelQuimadh3;
    }
}