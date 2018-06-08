namespace Desktop.Vistas.Administracion
{
    partial class frmCotizacion
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
            this.gpbCotizacion = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new Controles.ButtonQuimadh(this.components);
            this.btnConfirmar = new Controles.ButtonQuimadh(this.components);
            this.txtCotizacionNueva = new Controles.TextBoxNumerico();
            this.txtCotizacionPrevia = new Controles.TextBoxNumerico();
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.cboMoneda = new Controles.CustomComboBox(this.components);
            this.labelQuimadh21 = new Controles.LabelQuimadh(this.components);
            this.gpbCotizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(99, 20);
            this.lblTitulo.Size = new System.Drawing.Size(171, 45);
            this.lblTitulo.Text = "Cotización";
            // 
            // gpbCotizacion
            // 
            this.gpbCotizacion.BackColor = System.Drawing.Color.Transparent;
            this.gpbCotizacion.Controls.Add(this.labelQuimadh21);
            this.gpbCotizacion.Controls.Add(this.cboMoneda);
            this.gpbCotizacion.Controls.Add(this.btnCancelar);
            this.gpbCotizacion.Controls.Add(this.btnConfirmar);
            this.gpbCotizacion.Controls.Add(this.txtCotizacionNueva);
            this.gpbCotizacion.Controls.Add(this.txtCotizacionPrevia);
            this.gpbCotizacion.Controls.Add(this.labelQuimadh2);
            this.gpbCotizacion.Controls.Add(this.labelQuimadh1);
            this.gpbCotizacion.Location = new System.Drawing.Point(21, 98);
            this.gpbCotizacion.Name = "gpbCotizacion";
            this.gpbCotizacion.Size = new System.Drawing.Size(331, 151);
            this.gpbCotizacion.TabIndex = 0;
            this.gpbCotizacion.TabStop = false;
            this.gpbCotizacion.Text = "Cotización";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(174, 113);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(93, 113);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCotizacionNueva
            // 
            this.txtCotizacionNueva.Decimales = 4;
            this.txtCotizacionNueva.Enteros = 8;
            this.txtCotizacionNueva.EnterTabulacion = true;
            this.txtCotizacionNueva.Location = new System.Drawing.Point(164, 72);
            this.txtCotizacionNueva.Name = "txtCotizacionNueva";
            this.txtCotizacionNueva.Size = new System.Drawing.Size(131, 20);
            this.txtCotizacionNueva.TabIndex = 3;
            this.txtCotizacionNueva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCotizacionPrevia
            // 
            this.txtCotizacionPrevia.Decimales = 4;
            this.txtCotizacionPrevia.Enteros = 8;
            this.txtCotizacionPrevia.EnterTabulacion = true;
            this.txtCotizacionPrevia.Location = new System.Drawing.Point(164, 46);
            this.txtCotizacionPrevia.Name = "txtCotizacionPrevia";
            this.txtCotizacionPrevia.ReadOnly = true;
            this.txtCotizacionPrevia.Size = new System.Drawing.Size(131, 20);
            this.txtCotizacionPrevia.TabIndex = 2;
            this.txtCotizacionPrevia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(25, 73);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(133, 16);
            this.labelQuimadh2.TabIndex = 1;
            this.labelQuimadh2.Text = "Cotización Nueva:";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(27, 47);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(131, 16);
            this.labelQuimadh1.TabIndex = 0;
            this.labelQuimadh1.Text = "Cotización Actual:";
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(164, 19);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(131, 21);
            this.cboMoneda.TabIndex = 71;
            this.cboMoneda.SelectedIndexChanged += new System.EventHandler(this.cboMoneda_SelectedIndexChanged);
            // 
            // labelQuimadh21
            // 
            this.labelQuimadh21.AutoSize = true;
            this.labelQuimadh21.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh21.Location = new System.Drawing.Point(94, 20);
            this.labelQuimadh21.Name = "labelQuimadh21";
            this.labelQuimadh21.Size = new System.Drawing.Size(64, 16);
            this.labelQuimadh21.TabIndex = 72;
            this.labelQuimadh21.Text = "Moneda";
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 260);
            this.Controls.Add(this.gpbCotizacion);
            this.Name = "frmCotizacion";
            this.Controls.SetChildIndex(this.gpbCotizacion, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.gpbCotizacion.ResumeLayout(false);
            this.gpbCotizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCotizacion;
        private Controles.ButtonQuimadh btnCancelar;
        private Controles.ButtonQuimadh btnConfirmar;
        private Controles.TextBoxNumerico txtCotizacionNueva;
        private Controles.TextBoxNumerico txtCotizacionPrevia;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh21;
        private Controles.CustomComboBox cboMoneda;
    }
}