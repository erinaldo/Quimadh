namespace Desktop.Vistas.Ventas
{
    partial class frmPagosTarjetas
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
            this.labelQuimadh12 = new Controles.LabelQuimadh(this.components);
            this.btnAgregar = new Controles.ButtonQuimadh(this.components);
            this.cboTipo = new Controles.CustomComboBox(this.components);
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(167, 54);
            this.lblTitulo.Text = "Tarjetas";
            // 
            // txtImporte
            // 
            this.txtImporte.Decimales = 0;
            this.txtImporte.Enteros = 11;
            this.txtImporte.EnterTabulacion = true;
            this.txtImporte.Location = new System.Drawing.Point(191, 143);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(211, 23);
            this.txtImporte.TabIndex = 1;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh12
            // 
            this.labelQuimadh12.AutoSize = true;
            this.labelQuimadh12.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh12.Location = new System.Drawing.Point(107, 144);
            this.labelQuimadh12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh12.Name = "labelQuimadh12";
            this.labelQuimadh12.Size = new System.Drawing.Size(78, 20);
            this.labelQuimadh12.TabIndex = 66;
            this.labelQuimadh12.Text = "Importe:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(191, 196);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 35);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(191, 110);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(211, 25);
            this.cboTipo.TabIndex = 0;
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(132, 111);
            this.labelQuimadh5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(51, 20);
            this.labelQuimadh5.TabIndex = 86;
            this.labelQuimadh5.Text = "Tipo:";
            // 
            // frmPagosTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.labelQuimadh5);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelQuimadh12);
            this.Controls.Add(this.txtImporte);
            this.Name = "frmPagosTarjetas";
            this.Load += new System.EventHandler(this.frmPagosTarjetas_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtImporte, 0);
            this.Controls.SetChildIndex(this.labelQuimadh12, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.cboTipo, 0);
            this.Controls.SetChildIndex(this.labelQuimadh5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxNumerico txtImporte;
        private Controles.LabelQuimadh labelQuimadh12;
        private Controles.ButtonQuimadh btnAgregar;
        private Controles.CustomComboBox cboTipo;
        private Controles.LabelQuimadh labelQuimadh5;
    }
}