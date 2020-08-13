namespace Desktop.Vistas.Ventas
{
    partial class frmMails
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
            this.txtDest = new Controles.TextBoxQuimadh();
            this.txtCC = new Controles.TextBoxQuimadh();
            this.labelQuimadh8 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.btnEnviar = new Controles.ButtonQuimadh(this.components);
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(251, 54);
            this.lblTitulo.Text = "Mail Factura";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(157, 119);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(519, 23);
            this.txtDest.TabIndex = 4;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(157, 157);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(519, 23);
            this.txtCC.TabIndex = 5;
            // 
            // labelQuimadh8
            // 
            this.labelQuimadh8.AutoSize = true;
            this.labelQuimadh8.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh8.Location = new System.Drawing.Point(38, 119);
            this.labelQuimadh8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh8.Name = "labelQuimadh8";
            this.labelQuimadh8.Size = new System.Drawing.Size(112, 20);
            this.labelQuimadh8.TabIndex = 23;
            this.labelQuimadh8.Text = "Destinatario";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(84, 158);
            this.labelQuimadh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(57, 20);
            this.labelQuimadh1.TabIndex = 24;
            this.labelQuimadh1.Text = "Copia";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(312, 211);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(125, 40);
            this.btnEnviar.TabIndex = 25;
            this.btnEnviar.Text = "Enviar Mail";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmMails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 276);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.labelQuimadh1);
            this.Controls.Add(this.labelQuimadh8);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtDest);
            this.Name = "frmMails";
            this.Text = "frmMailscs";
            this.Load += new System.EventHandler(this.frmMails_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtDest, 0);
            this.Controls.SetChildIndex(this.txtCC, 0);
            this.Controls.SetChildIndex(this.labelQuimadh8, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.btnEnviar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxQuimadh txtDest;
        private Controles.TextBoxQuimadh txtCC;
        private Controles.LabelQuimadh labelQuimadh8;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.ButtonQuimadh btnEnviar;
    }
}