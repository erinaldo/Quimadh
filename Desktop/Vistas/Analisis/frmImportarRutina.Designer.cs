namespace Desktop.Vistas.Analisis
{
    partial class frmImportarRutina
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
            this.txtNroInterno = new Controles.TextBoxNumerico();
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.chkIncluirFirma = new System.Windows.Forms.CheckBox();
            this.cboTipoRutina = new Controles.CustomComboBox(this.components);
            this.txtObservaciones = new Controles.TextBoxQuimadh();
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.dtpAnalisis = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.dtpMuestreo = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroRutina = new Controles.TextBoxNumerico();
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.dgvRutina = new System.Windows.Forms.DataGridView();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnArchivo = new Controles.ButtonQuimadh(this.components);
            this.txtCliente = new Controles.TextBoxQuimadh();
            this.lblCliente = new Controles.LabelQuimadh(this.components);
            this.cboPlanta = new Controles.CustomComboBox(this.components);
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.ofdRutina = new System.Windows.Forms.OpenFileDialog();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(14, 94);
            this.lblTitulo.Size = new System.Drawing.Size(251, 45);
            this.lblTitulo.Text = "Importar Rutina";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.txtNroInterno);
            this.gpbDatos.Controls.Add(this.labelQuimadh6);
            this.gpbDatos.Controls.Add(this.chkIncluirFirma);
            this.gpbDatos.Controls.Add(this.cboTipoRutina);
            this.gpbDatos.Controls.Add(this.txtObservaciones);
            this.gpbDatos.Controls.Add(this.labelQuimadh5);
            this.gpbDatos.Controls.Add(this.dtpAnalisis);
            this.gpbDatos.Controls.Add(this.labelQuimadh4);
            this.gpbDatos.Controls.Add(this.dtpMuestreo);
            this.gpbDatos.Controls.Add(this.txtNumeroRutina);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.dgvRutina);
            this.gpbDatos.Controls.Add(this.btnArchivo);
            this.gpbDatos.Controls.Add(this.txtCliente);
            this.gpbDatos.Controls.Add(this.lblCliente);
            this.gpbDatos.Controls.Add(this.cboPlanta);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.labelQuimadh3);
            this.gpbDatos.Location = new System.Drawing.Point(12, 175);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(937, 539);
            this.gpbDatos.TabIndex = 3;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // txtNroInterno
            // 
            this.txtNroInterno.Decimales = 0;
            this.txtNroInterno.Enteros = 18;
            this.txtNroInterno.EnterTabulacion = true;
            this.txtNroInterno.Location = new System.Drawing.Point(99, 56);
            this.txtNroInterno.Name = "txtNroInterno";
            this.txtNroInterno.Size = new System.Drawing.Size(93, 20);
            this.txtNroInterno.TabIndex = 46;
            this.txtNroInterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(13, 58);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(80, 16);
            this.labelQuimadh6.TabIndex = 45;
            this.labelQuimadh6.Text = "Nº Interno:";
            // 
            // chkIncluirFirma
            // 
            this.chkIncluirFirma.AutoSize = true;
            this.chkIncluirFirma.Location = new System.Drawing.Point(201, 105);
            this.chkIncluirFirma.Name = "chkIncluirFirma";
            this.chkIncluirFirma.Size = new System.Drawing.Size(184, 17);
            this.chkIncluirFirma.TabIndex = 44;
            this.chkIncluirFirma.Text = "Incluir firma electrónica en planilla";
            this.chkIncluirFirma.UseVisualStyleBackColor = true;
            this.chkIncluirFirma.CheckedChanged += new System.EventHandler(this.chkIncluirFirma_CheckedChanged);
            // 
            // cboTipoRutina
            // 
            this.cboTipoRutina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoRutina.FormattingEnabled = true;
            this.cboTipoRutina.Items.AddRange(new object[] {
            "ANÁLISIS DE AGUA",
            "ANÁLISIS BACTERIOLÓGICO",
            "ANÁLISIS DE EFLUENTE"});
            this.cboTipoRutina.Location = new System.Drawing.Point(10, 82);
            this.cboTipoRutina.Name = "cboTipoRutina";
            this.cboTipoRutina.Size = new System.Drawing.Size(182, 21);
            this.cboTipoRutina.TabIndex = 43;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(552, 56);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(379, 65);
            this.txtObservaciones.TabIndex = 42;
            this.txtObservaciones.Text = "\r\n";
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(490, 61);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(44, 16);
            this.labelQuimadh5.TabIndex = 41;
            this.labelQuimadh5.Text = "Obs.:";
            // 
            // dtpAnalisis
            // 
            this.dtpAnalisis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAnalisis.Location = new System.Drawing.Point(277, 58);
            this.dtpAnalisis.Name = "dtpAnalisis";
            this.dtpAnalisis.Size = new System.Drawing.Size(93, 20);
            this.dtpAnalisis.TabIndex = 40;
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(198, 58);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(67, 16);
            this.labelQuimadh4.TabIndex = 39;
            this.labelQuimadh4.Text = "Análisis:";
            // 
            // dtpMuestreo
            // 
            this.dtpMuestreo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMuestreo.Location = new System.Drawing.Point(277, 82);
            this.dtpMuestreo.Name = "dtpMuestreo";
            this.dtpMuestreo.Size = new System.Drawing.Size(93, 20);
            this.dtpMuestreo.TabIndex = 37;
            // 
            // txtNumeroRutina
            // 
            this.txtNumeroRutina.Decimales = 0;
            this.txtNumeroRutina.Enteros = 18;
            this.txtNumeroRutina.EnterTabulacion = true;
            this.txtNumeroRutina.Location = new System.Drawing.Point(99, 27);
            this.txtNumeroRutina.Name = "txtNumeroRutina";
            this.txtNumeroRutina.ReadOnly = true;
            this.txtNumeroRutina.Size = new System.Drawing.Size(93, 20);
            this.txtNumeroRutina.TabIndex = 36;
            this.txtNumeroRutina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(13, 28);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(73, 16);
            this.labelQuimadh2.TabIndex = 35;
            this.labelQuimadh2.Text = "Id Rutina:";
            // 
            // dgvRutina
            // 
            this.dgvRutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c0});
            this.dgvRutina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRutina.Location = new System.Drawing.Point(3, 128);
            this.dgvRutina.Name = "dgvRutina";
            this.dgvRutina.Size = new System.Drawing.Size(931, 408);
            this.dgvRutina.TabIndex = 34;
            this.dgvRutina.Click += new System.EventHandler(this.dgvRutina_Click);
            // 
            // c0
            // 
            this.c0.Frozen = true;
            this.c0.HeaderText = "Analisis";
            this.c0.Name = "c0";
            this.c0.Width = 200;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(797, 28);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(134, 23);
            this.btnArchivo.TabIndex = 33;
            this.btnArchivo.Text = "Cargar Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(277, 29);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(207, 20);
            this.txtCliente.TabIndex = 32;
            this.txtCliente.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(198, 31);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 16);
            this.lblCliente.TabIndex = 31;
            this.lblCliente.Text = "Cliente:";
            // 
            // cboPlanta
            // 
            this.cboPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPlanta.FormattingEnabled = true;
            this.cboPlanta.Location = new System.Drawing.Point(552, 29);
            this.cboPlanta.Name = "cboPlanta";
            this.cboPlanta.Size = new System.Drawing.Size(233, 21);
            this.cboPlanta.TabIndex = 29;
            this.cboPlanta.SelectedIndexChanged += new System.EventHandler(this.cboPlanta_SelectedIndexChanged);
            this.cboPlanta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboPlanta_KeyDown);
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(490, 31);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(56, 16);
            this.labelQuimadh1.TabIndex = 30;
            this.labelQuimadh1.Text = "Planta:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(198, 82);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(76, 16);
            this.labelQuimadh3.TabIndex = 38;
            this.labelQuimadh3.Text = "Muestreo:";
            // 
            // ofdRutina
            // 
            this.ofdRutina.FileName = "Rutina";
            this.ofdRutina.Filter = "Archivos Excel (*.xls)|*.xls|Archivos Excel (*.xlsx)|*.xlsx";
            // 
            // frmImportarRutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 733);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmImportarRutina";
            this.Text = "";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.TextBoxQuimadh txtCliente;
        private Controles.LabelQuimadh lblCliente;
        private Controles.CustomComboBox cboPlanta;
        private Controles.LabelQuimadh labelQuimadh1;
        private System.Windows.Forms.OpenFileDialog ofdRutina;
        private Controles.ButtonQuimadh btnArchivo;
        private System.Windows.Forms.DataGridView dgvRutina;
        private System.Windows.Forms.DataGridViewTextBoxColumn c0;
        private Controles.TextBoxNumerico txtNumeroRutina;
        private Controles.LabelQuimadh labelQuimadh2;
        private System.Windows.Forms.DateTimePicker dtpAnalisis;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh3;
        private System.Windows.Forms.DateTimePicker dtpMuestreo;
        private Controles.TextBoxQuimadh txtObservaciones;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.CustomComboBox cboTipoRutina;
        private System.Windows.Forms.CheckBox chkIncluirFirma;
        private Controles.TextBoxNumerico txtNroInterno;
        private Controles.LabelQuimadh labelQuimadh6;
    }
}