namespace Desktop.Vistas.Analisis
{
    partial class frmMuestras
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
            this.txtDescripcion = new Controles.TextBoxQuimadh();
            this.txtCodigo = new Controles.TextBoxQuimadh();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(19, 85);
            this.lblTitulo.Size = new System.Drawing.Size(419, 45);
            this.lblTitulo.Text = "Administración de Muestras";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.txtDescripcion);
            this.gpbDatos.Controls.Add(this.txtCodigo);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Location = new System.Drawing.Point(50, 156);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(360, 91);
            this.gpbDatos.TabIndex = 27;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(93, 49);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(244, 20);
            this.txtDescripcion.TabIndex = 27;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(93, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(244, 20);
            this.txtCodigo.TabIndex = 26;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(7, 23);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(57, 15);
            this.labelQuimadh1.TabIndex = 28;
            this.labelQuimadh1.Text = "Código:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(7, 51);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(89, 15);
            this.labelQuimadh2.TabIndex = 29;
            this.labelQuimadh2.Text = "Descripción:";
            // 
            // frmMuestras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.ClientSize = new System.Drawing.Size(455, 268);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmMuestras";
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
        private Controles.TextBoxQuimadh txtDescripcion;
        private Controles.TextBoxQuimadh txtCodigo;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
    }
}