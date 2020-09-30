namespace Desktop.Vistas.Ventas
{
    partial class frmRemitos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.labelQuimadh19 = new Controles.LabelQuimadh(this.components);
            this.cboTipoRem = new Controles.CustomComboBox(this.components);
            this.txtOrdenCompra = new Controles.TextBoxQuimadh();
            this.labelQuimadh9 = new Controles.LabelQuimadh(this.components);
            this.btnPlanta = new Controles.ButtonQuimadh(this.components);
            this.labelQuimadh17 = new Controles.LabelQuimadh(this.components);
            this.txtPlanta = new Controles.TextBoxQuimadh();
            this.btnBuscarCliente = new Controles.ButtonQuimadh(this.components);
            this.labelQuimadh8 = new Controles.LabelQuimadh(this.components);
            this.txtRazonSocial = new Controles.TextBoxQuimadh();
            this.txtDomicilio = new Controles.TextBoxQuimadh();
            this.txtLocalidad = new Controles.TextBoxQuimadh();
            this.txtSitIva = new Controles.TextBoxQuimadh();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.txtCUIT = new Controles.TextBoxNumerico();
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.txtObs = new Controles.TextBoxQuimadh();
            this.txtEnviarA = new Controles.TextBoxQuimadh();
            this.labelQuimadh12 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh11 = new Controles.LabelQuimadh(this.components);
            this.chkImprimirPrecios = new System.Windows.Forms.CheckBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.clmArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReimprimir = new Controles.ButtonQuimadh(this.components);
            this.txtNroRemito = new Controles.TextBoxNumerico();
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh14 = new Controles.LabelQuimadh(this.components);
            this.txtCotiz = new Controles.TextBoxQuimadh();
            this.labelQuimadh18 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh16 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh15 = new Controles.LabelQuimadh(this.components);
            this.txtTotal = new Controles.TextBoxNumerico();
            this.txtPeso = new Controles.TextBoxNumerico();
            this.txtCantBultos = new Controles.TextBoxNumerico();
            this.cboUnidad = new Controles.CustomComboBox(this.components);
            this.labelQuimadh10 = new Controles.LabelQuimadh(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh13 = new Controles.LabelQuimadh(this.components);
            this.gpbDatosRem = new System.Windows.Forms.GroupBox();
            this.cboMoneda = new Controles.CustomComboBox(this.components);
            this.labelQuimadh21 = new Controles.LabelQuimadh(this.components);
            this.gpbTotales = new System.Windows.Forms.GroupBox();
            this.chkNF = new System.Windows.Forms.CheckBox();
            this.gpbOtros = new System.Windows.Forms.GroupBox();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.gpbDatosRem.SuspendLayout();
            this.gpbTotales.SuspendLayout();
            this.gpbOtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(87, 97);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Size = new System.Drawing.Size(167, 54);
            this.lblTitulo.Text = "Remitos";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gpbDatos.Controls.Add(this.labelQuimadh19);
            this.gpbDatos.Controls.Add(this.cboTipoRem);
            this.gpbDatos.Controls.Add(this.txtOrdenCompra);
            this.gpbDatos.Controls.Add(this.labelQuimadh9);
            this.gpbDatos.Controls.Add(this.btnPlanta);
            this.gpbDatos.Controls.Add(this.labelQuimadh17);
            this.gpbDatos.Controls.Add(this.txtPlanta);
            this.gpbDatos.Controls.Add(this.btnBuscarCliente);
            this.gpbDatos.Controls.Add(this.labelQuimadh8);
            this.gpbDatos.Controls.Add(this.txtRazonSocial);
            this.gpbDatos.Controls.Add(this.txtDomicilio);
            this.gpbDatos.Controls.Add(this.txtLocalidad);
            this.gpbDatos.Controls.Add(this.txtSitIva);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.labelQuimadh3);
            this.gpbDatos.Controls.Add(this.labelQuimadh4);
            this.gpbDatos.Controls.Add(this.txtCUIT);
            this.gpbDatos.Controls.Add(this.labelQuimadh5);
            this.gpbDatos.Controls.Add(this.labelQuimadh6);
            this.gpbDatos.Controls.Add(this.txtObs);
            this.gpbDatos.Controls.Add(this.txtEnviarA);
            this.gpbDatos.Controls.Add(this.labelQuimadh12);
            this.gpbDatos.Controls.Add(this.labelQuimadh11);
            this.gpbDatos.Location = new System.Drawing.Point(11, 223);
            this.gpbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gpbDatos.Size = new System.Drawing.Size(1163, 213);
            this.gpbDatos.TabIndex = 4;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // labelQuimadh19
            // 
            this.labelQuimadh19.AutoSize = true;
            this.labelQuimadh19.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh19.Location = new System.Drawing.Point(575, 182);
            this.labelQuimadh19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh19.Name = "labelQuimadh19";
            this.labelQuimadh19.Size = new System.Drawing.Size(116, 20);
            this.labelQuimadh19.TabIndex = 69;
            this.labelQuimadh19.Text = "Tipo Remito:";
            // 
            // cboTipoRem
            // 
            this.cboTipoRem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoRem.FormattingEnabled = true;
            this.cboTipoRem.Location = new System.Drawing.Point(735, 181);
            this.cboTipoRem.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoRem.Name = "cboTipoRem";
            this.cboTipoRem.Size = new System.Drawing.Size(209, 24);
            this.cboTipoRem.TabIndex = 68;
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(189, 178);
            this.txtOrdenCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtOrdenCompra.MaxLength = 50;
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(209, 22);
            this.txtOrdenCompra.TabIndex = 30;
            // 
            // labelQuimadh9
            // 
            this.labelQuimadh9.AutoSize = true;
            this.labelQuimadh9.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh9.Location = new System.Drawing.Point(32, 180);
            this.labelQuimadh9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh9.Name = "labelQuimadh9";
            this.labelQuimadh9.Size = new System.Drawing.Size(137, 20);
            this.labelQuimadh9.TabIndex = 29;
            this.labelQuimadh9.Text = "Orden Compra:";
            // 
            // btnPlanta
            // 
            this.btnPlanta.Location = new System.Drawing.Point(953, 146);
            this.btnPlanta.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlanta.Name = "btnPlanta";
            this.btnPlanta.Size = new System.Drawing.Size(64, 28);
            this.btnPlanta.TabIndex = 28;
            this.btnPlanta.Text = "...";
            this.btnPlanta.UseVisualStyleBackColor = true;
            this.btnPlanta.Click += new System.EventHandler(this.btnPlanta_Click);
            // 
            // labelQuimadh17
            // 
            this.labelQuimadh17.AutoSize = true;
            this.labelQuimadh17.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh17.Location = new System.Drawing.Point(575, 150);
            this.labelQuimadh17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh17.Name = "labelQuimadh17";
            this.labelQuimadh17.Size = new System.Drawing.Size(68, 20);
            this.labelQuimadh17.TabIndex = 27;
            this.labelQuimadh17.Text = "Planta:";
            // 
            // txtPlanta
            // 
            this.txtPlanta.Location = new System.Drawing.Point(735, 149);
            this.txtPlanta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.ReadOnly = true;
            this.txtPlanta.Size = new System.Drawing.Size(209, 22);
            this.txtPlanta.TabIndex = 26;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(408, 16);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(64, 28);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // labelQuimadh8
            // 
            this.labelQuimadh8.AutoSize = true;
            this.labelQuimadh8.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh8.Location = new System.Drawing.Point(32, 20);
            this.labelQuimadh8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh8.Name = "labelQuimadh8";
            this.labelQuimadh8.Size = new System.Drawing.Size(57, 20);
            this.labelQuimadh8.TabIndex = 24;
            this.labelQuimadh8.Text = "CUIT:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(189, 50);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(209, 22);
            this.txtRazonSocial.TabIndex = 2;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            this.txtRazonSocial.Leave += new System.EventHandler(this.txtRazonSocial_Leave);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(189, 82);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(209, 22);
            this.txtDomicilio.TabIndex = 3;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(189, 114);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(209, 22);
            this.txtLocalidad.TabIndex = 4;
            // 
            // txtSitIva
            // 
            this.txtSitIva.Location = new System.Drawing.Point(189, 146);
            this.txtSitIva.Margin = new System.Windows.Forms.Padding(4);
            this.txtSitIva.Name = "txtSitIva";
            this.txtSitIva.ReadOnly = true;
            this.txtSitIva.Size = new System.Drawing.Size(209, 22);
            this.txtSitIva.TabIndex = 5;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(32, 53);
            this.labelQuimadh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(132, 20);
            this.labelQuimadh1.TabIndex = 8;
            this.labelQuimadh1.Text = "Razón Social: ";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(61, 105);
            this.labelQuimadh2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(0, 20);
            this.labelQuimadh2.TabIndex = 9;
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(32, 85);
            this.labelQuimadh3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(100, 20);
            this.labelQuimadh3.TabIndex = 10;
            this.labelQuimadh3.Text = "Domicilio: ";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(32, 116);
            this.labelQuimadh4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(102, 20);
            this.labelQuimadh4.TabIndex = 11;
            this.labelQuimadh4.Text = "Localidad: ";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Decimales = 0;
            this.txtCUIT.Enteros = 11;
            this.txtCUIT.EnterTabulacion = true;
            this.txtCUIT.Location = new System.Drawing.Point(189, 18);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(209, 22);
            this.txtCUIT.TabIndex = 1;
            this.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
            this.txtCUIT.Leave += new System.EventHandler(this.txtCUIT_Leave);
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(63, 213);
            this.labelQuimadh5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(0, 20);
            this.labelQuimadh5.TabIndex = 12;
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(32, 148);
            this.labelQuimadh6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(84, 20);
            this.labelQuimadh6.TabIndex = 13;
            this.labelQuimadh6.Text = "Sit. IVA: ";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(735, 20);
            this.txtObs.Margin = new System.Windows.Forms.Padding(4);
            this.txtObs.MaxLength = 350;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(332, 84);
            this.txtObs.TabIndex = 6;
            // 
            // txtEnviarA
            // 
            this.txtEnviarA.Location = new System.Drawing.Point(735, 114);
            this.txtEnviarA.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnviarA.MaxLength = 30;
            this.txtEnviarA.Name = "txtEnviarA";
            this.txtEnviarA.Size = new System.Drawing.Size(209, 22);
            this.txtEnviarA.TabIndex = 7;
            // 
            // labelQuimadh12
            // 
            this.labelQuimadh12.AutoSize = true;
            this.labelQuimadh12.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh12.Location = new System.Drawing.Point(575, 20);
            this.labelQuimadh12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh12.Name = "labelQuimadh12";
            this.labelQuimadh12.Size = new System.Drawing.Size(80, 20);
            this.labelQuimadh12.TabIndex = 20;
            this.labelQuimadh12.Text = "Observ.:";
            // 
            // labelQuimadh11
            // 
            this.labelQuimadh11.AutoSize = true;
            this.labelQuimadh11.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh11.Location = new System.Drawing.Point(575, 118);
            this.labelQuimadh11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh11.Name = "labelQuimadh11";
            this.labelQuimadh11.Size = new System.Drawing.Size(84, 20);
            this.labelQuimadh11.TabIndex = 21;
            this.labelQuimadh11.Text = "Enviar a:";
            // 
            // chkImprimirPrecios
            // 
            this.chkImprimirPrecios.AutoSize = true;
            this.chkImprimirPrecios.BackColor = System.Drawing.SystemColors.Info;
            this.chkImprimirPrecios.Checked = true;
            this.chkImprimirPrecios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImprimirPrecios.Location = new System.Drawing.Point(879, 763);
            this.chkImprimirPrecios.Margin = new System.Windows.Forms.Padding(4);
            this.chkImprimirPrecios.Name = "chkImprimirPrecios";
            this.chkImprimirPrecios.Size = new System.Drawing.Size(130, 21);
            this.chkImprimirPrecios.TabIndex = 70;
            this.chkImprimirPrecios.Text = "Imprimir Precios";
            this.chkImprimirPrecios.UseVisualStyleBackColor = false;
            // 
            // dgvItems
            // 
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmArt,
            this.clmCant,
            this.clmUnidad,
            this.clmDesc,
            this.clmLote,
            this.clmPresent,
            this.clmMon,
            this.clmPrecio,
            this.clmImp});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvItems.Enabled = false;
            this.dgvItems.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvItems.Location = new System.Drawing.Point(16, 443);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.Name = "dgvItems";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvItems.Size = new System.Drawing.Size(1157, 218);
            this.dgvItems.TabIndex = 12;
            this.dgvItems.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellLeave);
            this.dgvItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvItems_EditingControlShowing);
            this.dgvItems.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvItems_UserDeletedRow);
            // 
            // clmArt
            // 
            this.clmArt.HeaderText = "Artículo";
            this.clmArt.Name = "clmArt";
            // 
            // clmCant
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "0";
            this.clmCant.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmCant.HeaderText = "Cant.";
            this.clmCant.MaxInputLength = 9;
            this.clmCant.Name = "clmCant";
            this.clmCant.Width = 50;
            // 
            // clmUnidad
            // 
            this.clmUnidad.HeaderText = "Unidad";
            this.clmUnidad.Name = "clmUnidad";
            this.clmUnidad.ReadOnly = true;
            this.clmUnidad.Width = 50;
            // 
            // clmDesc
            // 
            this.clmDesc.HeaderText = "Descripción";
            this.clmDesc.Name = "clmDesc";
            this.clmDesc.Width = 220;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.MaxInputLength = 15;
            this.clmLote.Name = "clmLote";
            // 
            // clmPresent
            // 
            this.clmPresent.HeaderText = "Presentación";
            this.clmPresent.Name = "clmPresent";
            this.clmPresent.Width = 50;
            // 
            // clmMon
            // 
            this.clmMon.HeaderText = "Moneda";
            this.clmMon.Name = "clmMon";
            this.clmMon.ReadOnly = true;
            this.clmMon.Width = 50;
            // 
            // clmPrecio
            // 
            dataGridViewCellStyle9.Format = "N2";
            this.clmPrecio.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmPrecio.HeaderText = "Precio unid.";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clmImp
            // 
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            this.clmImp.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmImp.HeaderText = "Importe";
            this.clmImp.MaxInputLength = 9;
            this.clmImp.Name = "clmImp";
            this.clmImp.ReadOnly = true;
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Location = new System.Drawing.Point(1017, 756);
            this.btnReimprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(156, 33);
            this.btnReimprimir.TabIndex = 16;
            this.btnReimprimir.Text = "Reimprimir";
            this.btnReimprimir.UseVisualStyleBackColor = true;
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // txtNroRemito
            // 
            this.txtNroRemito.Decimales = 0;
            this.txtNroRemito.Enteros = 11;
            this.txtNroRemito.EnterTabulacion = true;
            this.txtNroRemito.Location = new System.Drawing.Point(172, 18);
            this.txtNroRemito.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroRemito.Name = "txtNroRemito";
            this.txtNroRemito.Size = new System.Drawing.Size(209, 22);
            this.txtNroRemito.TabIndex = 17;
            this.txtNroRemito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(32, 20);
            this.labelQuimadh7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(110, 20);
            this.labelQuimadh7.TabIndex = 18;
            this.labelQuimadh7.Text = "Remito Nro:";
            // 
            // labelQuimadh14
            // 
            this.labelQuimadh14.AutoSize = true;
            this.labelQuimadh14.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh14.Location = new System.Drawing.Point(411, 18);
            this.labelQuimadh14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh14.Name = "labelQuimadh14";
            this.labelQuimadh14.Size = new System.Drawing.Size(100, 20);
            this.labelQuimadh14.TabIndex = 30;
            this.labelQuimadh14.Text = "Cotiz. u$s:";
            // 
            // txtCotiz
            // 
            this.txtCotiz.Location = new System.Drawing.Point(527, 17);
            this.txtCotiz.Margin = new System.Windows.Forms.Padding(4);
            this.txtCotiz.Name = "txtCotiz";
            this.txtCotiz.ReadOnly = true;
            this.txtCotiz.Size = new System.Drawing.Size(83, 22);
            this.txtCotiz.TabIndex = 29;
            // 
            // labelQuimadh18
            // 
            this.labelQuimadh18.AutoSize = true;
            this.labelQuimadh18.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh18.Location = new System.Drawing.Point(811, 20);
            this.labelQuimadh18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh18.Name = "labelQuimadh18";
            this.labelQuimadh18.Size = new System.Drawing.Size(151, 20);
            this.labelQuimadh18.TabIndex = 43;
            this.labelQuimadh18.Text = "Valor Declarado:";
            // 
            // labelQuimadh16
            // 
            this.labelQuimadh16.AutoSize = true;
            this.labelQuimadh16.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh16.Location = new System.Drawing.Point(411, 17);
            this.labelQuimadh16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh16.Name = "labelQuimadh16";
            this.labelQuimadh16.Size = new System.Drawing.Size(123, 20);
            this.labelQuimadh16.TabIndex = 42;
            this.labelQuimadh16.Text = "Total medido:";
            // 
            // labelQuimadh15
            // 
            this.labelQuimadh15.AutoSize = true;
            this.labelQuimadh15.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh15.Location = new System.Drawing.Point(8, 20);
            this.labelQuimadh15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh15.Name = "labelQuimadh15";
            this.labelQuimadh15.Size = new System.Drawing.Size(119, 20);
            this.labelQuimadh15.TabIndex = 41;
            this.labelQuimadh15.Text = "Cant. Bultos:";
            // 
            // txtTotal
            // 
            this.txtTotal.Decimales = 2;
            this.txtTotal.Enteros = 12;
            this.txtTotal.EnterTabulacion = true;
            this.txtTotal.Location = new System.Drawing.Point(987, 16);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(165, 22);
            this.txtTotal.TabIndex = 40;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPeso
            // 
            this.txtPeso.Decimales = 2;
            this.txtPeso.Enteros = 12;
            this.txtPeso.EnterTabulacion = true;
            this.txtPeso.Location = new System.Drawing.Point(579, 14);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(164, 22);
            this.txtPeso.TabIndex = 39;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCantBultos
            // 
            this.txtCantBultos.Decimales = 0;
            this.txtCantBultos.Enteros = 8;
            this.txtCantBultos.EnterTabulacion = true;
            this.txtCantBultos.Location = new System.Drawing.Point(141, 16);
            this.txtCantBultos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantBultos.Name = "txtCantBultos";
            this.txtCantBultos.Size = new System.Drawing.Size(156, 22);
            this.txtCantBultos.TabIndex = 38;
            this.txtCantBultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboUnidad
            // 
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(507, 13);
            this.cboUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(164, 24);
            this.cboUnidad.TabIndex = 44;
            this.cboUnidad.SelectedIndexChanged += new System.EventHandler(this.cboUnidad_SelectedIndexChanged);
            // 
            // labelQuimadh10
            // 
            this.labelQuimadh10.AutoSize = true;
            this.labelQuimadh10.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh10.Location = new System.Drawing.Point(360, 15);
            this.labelQuimadh10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh10.Name = "labelQuimadh10";
            this.labelQuimadh10.Size = new System.Drawing.Size(139, 20);
            this.labelQuimadh10.TabIndex = 45;
            this.labelQuimadh10.Text = "Unidad medida:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(987, 17);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(167, 22);
            this.dtpFecha.TabIndex = 65;
            // 
            // labelQuimadh13
            // 
            this.labelQuimadh13.AutoSize = true;
            this.labelQuimadh13.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh13.Location = new System.Drawing.Point(905, 18);
            this.labelQuimadh13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh13.Name = "labelQuimadh13";
            this.labelQuimadh13.Size = new System.Drawing.Size(66, 20);
            this.labelQuimadh13.TabIndex = 64;
            this.labelQuimadh13.Text = "Fecha:";
            // 
            // gpbDatosRem
            // 
            this.gpbDatosRem.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatosRem.Controls.Add(this.cboMoneda);
            this.gpbDatosRem.Controls.Add(this.labelQuimadh7);
            this.gpbDatosRem.Controls.Add(this.labelQuimadh21);
            this.gpbDatosRem.Controls.Add(this.dtpFecha);
            this.gpbDatosRem.Controls.Add(this.txtNroRemito);
            this.gpbDatosRem.Controls.Add(this.labelQuimadh13);
            this.gpbDatosRem.Controls.Add(this.txtCotiz);
            this.gpbDatosRem.Controls.Add(this.labelQuimadh14);
            this.gpbDatosRem.Location = new System.Drawing.Point(11, 176);
            this.gpbDatosRem.Margin = new System.Windows.Forms.Padding(4);
            this.gpbDatosRem.Name = "gpbDatosRem";
            this.gpbDatosRem.Padding = new System.Windows.Forms.Padding(4);
            this.gpbDatosRem.Size = new System.Drawing.Size(1163, 48);
            this.gpbDatosRem.TabIndex = 66;
            this.gpbDatosRem.TabStop = false;
            // 
            // cboMoneda
            // 
            this.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.Location = new System.Drawing.Point(747, 15);
            this.cboMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(131, 24);
            this.cboMoneda.TabIndex = 69;
            this.cboMoneda.SelectedIndexChanged += new System.EventHandler(this.cboMoneda_SelectedIndexChanged);
            // 
            // labelQuimadh21
            // 
            this.labelQuimadh21.AutoSize = true;
            this.labelQuimadh21.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh21.Location = new System.Drawing.Point(651, 17);
            this.labelQuimadh21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh21.Name = "labelQuimadh21";
            this.labelQuimadh21.Size = new System.Drawing.Size(80, 20);
            this.labelQuimadh21.TabIndex = 68;
            this.labelQuimadh21.Text = "Moneda:";
            // 
            // gpbTotales
            // 
            this.gpbTotales.BackColor = System.Drawing.Color.Transparent;
            this.gpbTotales.Controls.Add(this.labelQuimadh15);
            this.gpbTotales.Controls.Add(this.txtCantBultos);
            this.gpbTotales.Controls.Add(this.txtPeso);
            this.gpbTotales.Controls.Add(this.txtTotal);
            this.gpbTotales.Controls.Add(this.labelQuimadh18);
            this.gpbTotales.Controls.Add(this.labelQuimadh16);
            this.gpbTotales.Location = new System.Drawing.Point(16, 704);
            this.gpbTotales.Margin = new System.Windows.Forms.Padding(4);
            this.gpbTotales.Name = "gpbTotales";
            this.gpbTotales.Padding = new System.Windows.Forms.Padding(4);
            this.gpbTotales.Size = new System.Drawing.Size(1158, 47);
            this.gpbTotales.TabIndex = 67;
            this.gpbTotales.TabStop = false;
            this.gpbTotales.Text = "Totales";
            // 
            // chkNF
            // 
            this.chkNF.AutoSize = true;
            this.chkNF.BackColor = System.Drawing.SystemColors.Info;
            this.chkNF.Location = new System.Drawing.Point(685, 15);
            this.chkNF.Margin = new System.Windows.Forms.Padding(4);
            this.chkNF.Name = "chkNF";
            this.chkNF.Size = new System.Drawing.Size(105, 21);
            this.chkNF.TabIndex = 71;
            this.chkNF.Text = "No Facturar";
            this.chkNF.UseVisualStyleBackColor = false;
            // 
            // gpbOtros
            // 
            this.gpbOtros.BackColor = System.Drawing.Color.Transparent;
            this.gpbOtros.Controls.Add(this.cboUnidad);
            this.gpbOtros.Controls.Add(this.chkNF);
            this.gpbOtros.Controls.Add(this.labelQuimadh10);
            this.gpbOtros.Location = new System.Drawing.Point(16, 661);
            this.gpbOtros.Margin = new System.Windows.Forms.Padding(4);
            this.gpbOtros.Name = "gpbOtros";
            this.gpbOtros.Padding = new System.Windows.Forms.Padding(4);
            this.gpbOtros.Size = new System.Drawing.Size(1158, 45);
            this.gpbOtros.TabIndex = 68;
            this.gpbOtros.TabStop = false;
            // 
            // frmRemitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 796);
            this.Controls.Add(this.gpbOtros);
            this.Controls.Add(this.chkImprimirPrecios);
            this.Controls.Add(this.gpbTotales);
            this.Controls.Add(this.gpbDatosRem);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.gpbDatos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRemitos";
            this.Text = "";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.Controls.SetChildIndex(this.dgvItems, 0);
            this.Controls.SetChildIndex(this.btnReimprimir, 0);
            this.Controls.SetChildIndex(this.gpbDatosRem, 0);
            this.Controls.SetChildIndex(this.gpbTotales, 0);
            this.Controls.SetChildIndex(this.chkImprimirPrecios, 0);
            this.Controls.SetChildIndex(this.gpbOtros, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.gpbDatosRem.ResumeLayout(false);
            this.gpbDatosRem.PerformLayout();
            this.gpbTotales.ResumeLayout(false);
            this.gpbTotales.PerformLayout();
            this.gpbOtros.ResumeLayout(false);
            this.gpbOtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.ButtonQuimadh btnPlanta;
        private Controles.LabelQuimadh labelQuimadh17;
        private Controles.TextBoxQuimadh txtPlanta;
        private Controles.ButtonQuimadh btnBuscarCliente;
        private Controles.LabelQuimadh labelQuimadh8;
        private Controles.TextBoxQuimadh txtRazonSocial;
        private Controles.TextBoxQuimadh txtDomicilio;
        private Controles.TextBoxQuimadh txtLocalidad;
        private Controles.TextBoxQuimadh txtSitIva;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.TextBoxNumerico txtCUIT;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.TextBoxQuimadh txtObs;
        private Controles.TextBoxQuimadh txtEnviarA;
        private Controles.LabelQuimadh labelQuimadh12;
        private Controles.LabelQuimadh labelQuimadh11;
        internal System.Windows.Forms.DataGridView dgvItems;
        private Controles.ButtonQuimadh btnReimprimir;
        private Controles.TextBoxNumerico txtNroRemito;
        private Controles.LabelQuimadh labelQuimadh7;
        private Controles.LabelQuimadh labelQuimadh14;
        private Controles.TextBoxQuimadh txtCotiz;
        private Controles.LabelQuimadh labelQuimadh18;
        private Controles.LabelQuimadh labelQuimadh16;
        private Controles.LabelQuimadh labelQuimadh15;
        private Controles.TextBoxNumerico txtTotal;
        private Controles.TextBoxNumerico txtPeso;
        private Controles.TextBoxNumerico txtCantBultos;
        private Controles.TextBoxQuimadh txtOrdenCompra;
        private Controles.LabelQuimadh labelQuimadh9;
        private Controles.CustomComboBox cboUnidad;
        private Controles.LabelQuimadh labelQuimadh10;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Controles.LabelQuimadh labelQuimadh13;
        private System.Windows.Forms.GroupBox gpbDatosRem;
        private System.Windows.Forms.GroupBox gpbTotales;
        private Controles.LabelQuimadh labelQuimadh19;
        private Controles.CustomComboBox cboTipoRem;
        private Controles.CustomComboBox cboMoneda;
        private Controles.LabelQuimadh labelQuimadh21;
        private System.Windows.Forms.CheckBox chkImprimirPrecios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImp;
        private System.Windows.Forms.CheckBox chkNF;
        private System.Windows.Forms.GroupBox gpbOtros;
    }
}