namespace Desktop.Vistas.Ventas
{
    partial class frmPagosCheques
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
            this.cboBanco = new Controles.CustomComboBox(this.components);
            this.txtCuitLib = new Controles.TextBoxNumerico();
            this.txtDescLib = new Controles.TextBoxQuimadh();
            this.cboTipo = new Controles.CustomComboBox(this.components);
            this.labelQuimadh19 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaVto = new System.Windows.Forms.DateTimePicker();
            this.chkECheq = new System.Windows.Forms.CheckBox();
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(174, 54);
            this.lblTitulo.Text = "Cheques";
            // 
            // txtImporte
            // 
            this.txtImporte.Decimales = 2;
            this.txtImporte.Enteros = 16;
            this.txtImporte.EnterTabulacion = true;
            this.txtImporte.Location = new System.Drawing.Point(191, 127);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(211, 23);
            this.txtImporte.TabIndex = 26;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumero
            // 
            this.txtNumero.Decimales = 0;
            this.txtNumero.Enteros = 8;
            this.txtNumero.EnterTabulacion = true;
            this.txtNumero.Location = new System.Drawing.Point(191, 158);
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
            this.labelQuimadh12.Location = new System.Drawing.Point(107, 128);
            this.labelQuimadh12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh12.Name = "labelQuimadh12";
            this.labelQuimadh12.Size = new System.Drawing.Size(78, 20);
            this.labelQuimadh12.TabIndex = 66;
            this.labelQuimadh12.Text = "Importe:";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(103, 159);
            this.labelQuimadh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(80, 20);
            this.labelQuimadh1.TabIndex = 67;
            this.labelQuimadh1.Text = "Numero:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(191, 398);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 35);
            this.btnAgregar.TabIndex = 75;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboBanco
            // 
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(191, 189);
            this.cboBanco.Margin = new System.Windows.Forms.Padding(4);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(211, 25);
            this.cboBanco.TabIndex = 76;
            // 
            // txtCuitLib
            // 
            this.txtCuitLib.Decimales = 0;
            this.txtCuitLib.Enteros = 11;
            this.txtCuitLib.EnterTabulacion = true;
            this.txtCuitLib.Location = new System.Drawing.Point(191, 222);
            this.txtCuitLib.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuitLib.Name = "txtCuitLib";
            this.txtCuitLib.Size = new System.Drawing.Size(211, 23);
            this.txtCuitLib.TabIndex = 77;
            this.txtCuitLib.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescLib
            // 
            this.txtDescLib.Location = new System.Drawing.Point(191, 252);
            this.txtDescLib.MaxLength = 100;
            this.txtDescLib.Name = "txtDescLib";
            this.txtDescLib.Size = new System.Drawing.Size(211, 23);
            this.txtDescLib.TabIndex = 78;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Propio",
            "Terceros"});
            this.cboTipo.Location = new System.Drawing.Point(191, 313);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(211, 25);
            this.cboTipo.TabIndex = 79;
            // 
            // labelQuimadh19
            // 
            this.labelQuimadh19.AutoSize = true;
            this.labelQuimadh19.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh19.Location = new System.Drawing.Point(80, 285);
            this.labelQuimadh19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh19.Name = "labelQuimadh19";
            this.labelQuimadh19.Size = new System.Drawing.Size(105, 20);
            this.labelQuimadh19.TabIndex = 81;
            this.labelQuimadh19.Text = "Fecha Vto.:";
            // 
            // dtpFechaVto
            // 
            this.dtpFechaVto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVto.Location = new System.Drawing.Point(193, 282);
            this.dtpFechaVto.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaVto.Name = "dtpFechaVto";
            this.dtpFechaVto.Size = new System.Drawing.Size(209, 23);
            this.dtpFechaVto.TabIndex = 80;
            // 
            // chkECheq
            // 
            this.chkECheq.AutoSize = true;
            this.chkECheq.BackColor = System.Drawing.SystemColors.Info;
            this.chkECheq.Location = new System.Drawing.Point(191, 346);
            this.chkECheq.Margin = new System.Windows.Forms.Padding(4);
            this.chkECheq.Name = "chkECheq";
            this.chkECheq.Size = new System.Drawing.Size(156, 21);
            this.chkECheq.TabIndex = 82;
            this.chkECheq.Text = "Electrónico (ECheq)";
            this.chkECheq.UseVisualStyleBackColor = false;
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(115, 190);
            this.labelQuimadh2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(68, 20);
            this.labelQuimadh2.TabIndex = 83;
            this.labelQuimadh2.Text = "Banco:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(90, 223);
            this.labelQuimadh3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(93, 20);
            this.labelQuimadh3.TabIndex = 84;
            this.labelQuimadh3.Text = "Cuit Libr.:";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(61, 253);
            this.labelQuimadh4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(124, 20);
            this.labelQuimadh4.TabIndex = 85;
            this.labelQuimadh4.Text = "Nombre Libr.:";
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(132, 314);
            this.labelQuimadh5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(51, 20);
            this.labelQuimadh5.TabIndex = 86;
            this.labelQuimadh5.Text = "Tipo:";
            // 
            // frmPagosCheques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 445);
            this.Controls.Add(this.labelQuimadh5);
            this.Controls.Add(this.labelQuimadh4);
            this.Controls.Add(this.labelQuimadh3);
            this.Controls.Add(this.labelQuimadh2);
            this.Controls.Add(this.chkECheq);
            this.Controls.Add(this.labelQuimadh19);
            this.Controls.Add(this.dtpFechaVto);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtDescLib);
            this.Controls.Add(this.txtCuitLib);
            this.Controls.Add(this.cboBanco);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelQuimadh1);
            this.Controls.Add(this.labelQuimadh12);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtImporte);
            this.Name = "frmPagosCheques";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtImporte, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.labelQuimadh12, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.cboBanco, 0);
            this.Controls.SetChildIndex(this.txtCuitLib, 0);
            this.Controls.SetChildIndex(this.txtDescLib, 0);
            this.Controls.SetChildIndex(this.cboTipo, 0);
            this.Controls.SetChildIndex(this.dtpFechaVto, 0);
            this.Controls.SetChildIndex(this.labelQuimadh19, 0);
            this.Controls.SetChildIndex(this.chkECheq, 0);
            this.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.Controls.SetChildIndex(this.labelQuimadh5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxNumerico txtImporte;
        private Controles.TextBoxNumerico txtNumero;
        private Controles.LabelQuimadh labelQuimadh12;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.ButtonQuimadh btnAgregar;
        private Controles.CustomComboBox cboBanco;
        private Controles.TextBoxNumerico txtCuitLib;
        private Controles.TextBoxQuimadh txtDescLib;
        private Controles.CustomComboBox cboTipo;
        private Controles.LabelQuimadh labelQuimadh19;
        private System.Windows.Forms.DateTimePicker dtpFechaVto;
        private System.Windows.Forms.CheckBox chkECheq;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh5;
    }
}