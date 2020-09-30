namespace Desktop.Vistas.Ventas
{
    partial class frmPagosTransferencias
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
            this.txtImporte = new Controles.TextBoxNumerico();
            this.txtNumero = new Controles.TextBoxNumerico();
            this.labelQuimadh12 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.btnAgregar = new Controles.ButtonQuimadh(this.components);
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(284, 54);
            this.lblTitulo.Text = "Transferencias";
            // 
            // txtImporte
            // 
            this.txtImporte.Decimales = 0;
            this.txtImporte.Enteros = 11;
            this.txtImporte.EnterTabulacion = true;
            this.txtImporte.Location = new System.Drawing.Point(191, 133);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(211, 23);
            this.txtImporte.TabIndex = 26;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumero
            // 
            this.txtNumero.Decimales = 0;
            this.txtNumero.Enteros = 11;
            this.txtNumero.EnterTabulacion = true;
            this.txtNumero.Location = new System.Drawing.Point(191, 180);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(211, 23);
            this.txtNumero.TabIndex = 27;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh12
            // 
            this.labelQuimadh12.AutoSize = true;
            this.labelQuimadh12.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh12.Location = new System.Drawing.Point(111, 134);
            this.labelQuimadh12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh12.Name = "labelQuimadh12";
            this.labelQuimadh12.Size = new System.Drawing.Size(72, 20);
            this.labelQuimadh12.TabIndex = 66;
            this.labelQuimadh12.Text = "Importe";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(27, 180);
            this.labelQuimadh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(156, 20);
            this.labelQuimadh1.TabIndex = 67;
            this.labelQuimadh1.Text = "Nro/Comprobante";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(191, 247);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 35);
            this.btnAgregar.TabIndex = 75;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmPagosTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 321);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelQuimadh1);
            this.Controls.Add(this.labelQuimadh12);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtImporte);
            this.Name = "frmPagosTransferencias";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtImporte, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.labelQuimadh12, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxNumerico txtImporte;
        private Controles.TextBoxNumerico txtNumero;
        private Controles.LabelQuimadh labelQuimadh12;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.ButtonQuimadh btnAgregar;
    }
}