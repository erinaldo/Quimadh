namespace Desktop.Vistas.Analisis
{
    partial class frmFirmas
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
            this.btnCargaFirma = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.txtCodigo = new Controles.TextBoxQuimadh();
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.txtIniciales = new Controles.TextBoxQuimadh();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(19, 85);
            this.lblTitulo.Size = new System.Drawing.Size(386, 45);
            this.lblTitulo.Text = "Administración de Firmas";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.labelQuimadh3);
            this.gpbDatos.Controls.Add(this.txtIniciales);
            this.gpbDatos.Controls.Add(this.btnCargaFirma);
            this.gpbDatos.Controls.Add(this.pictureBox1);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.txtCodigo);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Location = new System.Drawing.Point(50, 156);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(355, 251);
            this.gpbDatos.TabIndex = 27;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // btnCargaFirma
            // 
            this.btnCargaFirma.Location = new System.Drawing.Point(259, 217);
            this.btnCargaFirma.Name = "btnCargaFirma";
            this.btnCargaFirma.Size = new System.Drawing.Size(78, 23);
            this.btnCargaFirma.TabIndex = 31;
            this.btnCargaFirma.Text = "Cargar";
            this.btnCargaFirma.UseVisualStyleBackColor = true;
            this.btnCargaFirma.Click += new System.EventHandler(this.btnCargaFirma_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
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
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(93, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(244, 20);
            this.txtCodigo.TabIndex = 26;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(7, 73);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(52, 15);
            this.labelQuimadh2.TabIndex = 29;
            this.labelQuimadh2.Text = "Firma:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(7, 49);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(69, 15);
            this.labelQuimadh3.TabIndex = 33;
            this.labelQuimadh3.Text = "Iniciales:";
            // 
            // txtIniciales
            // 
            this.txtIniciales.Location = new System.Drawing.Point(93, 47);
            this.txtIniciales.Name = "txtIniciales";
            this.txtIniciales.Size = new System.Drawing.Size(244, 20);
            this.txtIniciales.TabIndex = 32;
            // 
            // frmFirmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.ClientSize = new System.Drawing.Size(458, 419);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmFirmas";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmFirmas_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.TextBoxQuimadh txtCodigo;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
        private System.Windows.Forms.Button btnCargaFirma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.TextBoxQuimadh txtIniciales;
    }
}