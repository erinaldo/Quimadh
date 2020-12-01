namespace Desktop.Vistas.Ventas
{
    partial class frmRecibos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
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
            this.labelQuimadh13 = new Controles.LabelQuimadh(this.components);
            this.txtTotal1 = new Controles.TextBoxNumerico();
            this.labelQuimadh10 = new Controles.LabelQuimadh(this.components);
            this.btnReimprimir = new Controles.ButtonQuimadh(this.components);
            this.txtFormaPago = new Controles.TextBoxQuimadh();
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.clmFechaIzq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescIzq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImporteIzq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaDer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescDer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImporteDer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal2 = new Controles.TextBoxNumerico();
            this.labelQuimadh9 = new Controles.LabelQuimadh(this.components);
            this.txtNroRecibo = new Controles.TextBoxNumerico();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh11 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh14 = new Controles.LabelQuimadh(this.components);
            this.txtCotiz = new Controles.TextBoxQuimadh();
            this.gpbDatosRec = new System.Windows.Forms.GroupBox();
            this.gpbTotales = new System.Windows.Forms.GroupBox();
            this.btnPago = new Controles.ButtonQuimadh(this.components);
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.gpbDatosRec.SuspendLayout();
            this.gpbTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(59, 79);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Size = new System.Drawing.Size(159, 54);
            this.lblTitulo.Text = "Recibos";
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
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
            this.gpbDatos.Location = new System.Drawing.Point(4, 198);
            this.gpbDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gpbDatos.Size = new System.Drawing.Size(1064, 122);
            this.gpbDatos.TabIndex = 5;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // btnPlanta
            // 
            this.btnPlanta.Location = new System.Drawing.Point(899, 22);
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
            this.labelQuimadh17.Location = new System.Drawing.Point(557, 26);
            this.labelQuimadh17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh17.Name = "labelQuimadh17";
            this.labelQuimadh17.Size = new System.Drawing.Size(68, 20);
            this.labelQuimadh17.TabIndex = 27;
            this.labelQuimadh17.Text = "Planta:";
            // 
            // txtPlanta
            // 
            this.txtPlanta.Location = new System.Drawing.Point(679, 25);
            this.txtPlanta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.ReadOnly = true;
            this.txtPlanta.Size = new System.Drawing.Size(211, 22);
            this.txtPlanta.TabIndex = 26;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(407, 22);
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
            this.labelQuimadh8.Location = new System.Drawing.Point(41, 26);
            this.labelQuimadh8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh8.Name = "labelQuimadh8";
            this.labelQuimadh8.Size = new System.Drawing.Size(57, 20);
            this.labelQuimadh8.TabIndex = 24;
            this.labelQuimadh8.Text = "CUIT:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(187, 57);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(211, 22);
            this.txtRazonSocial.TabIndex = 2;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            this.txtRazonSocial.Leave += new System.EventHandler(this.txtRazonSocial_Leave);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(187, 89);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(211, 22);
            this.txtDomicilio.TabIndex = 3;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(679, 89);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(211, 22);
            this.txtLocalidad.TabIndex = 4;
            // 
            // txtSitIva
            // 
            this.txtSitIva.Location = new System.Drawing.Point(679, 57);
            this.txtSitIva.Margin = new System.Windows.Forms.Padding(4);
            this.txtSitIva.Name = "txtSitIva";
            this.txtSitIva.ReadOnly = true;
            this.txtSitIva.Size = new System.Drawing.Size(211, 22);
            this.txtSitIva.TabIndex = 5;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(41, 58);
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
            this.labelQuimadh2.Location = new System.Drawing.Point(63, 118);
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
            this.labelQuimadh3.Location = new System.Drawing.Point(41, 90);
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
            this.labelQuimadh4.Location = new System.Drawing.Point(557, 90);
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
            this.txtCUIT.Location = new System.Drawing.Point(187, 25);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(211, 22);
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
            this.labelQuimadh6.Location = new System.Drawing.Point(557, 58);
            this.labelQuimadh6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(84, 20);
            this.labelQuimadh6.TabIndex = 13;
            this.labelQuimadh6.Text = "Sit. IVA: ";
            // 
            // labelQuimadh13
            // 
            this.labelQuimadh13.AutoSize = true;
            this.labelQuimadh13.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh13.Location = new System.Drawing.Point(61, 21);
            this.labelQuimadh13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh13.Name = "labelQuimadh13";
            this.labelQuimadh13.Size = new System.Drawing.Size(109, 20);
            this.labelQuimadh13.TabIndex = 29;
            this.labelQuimadh13.Text = "Nro Recibo:";
            // 
            // txtTotal1
            // 
            this.txtTotal1.Decimales = 2;
            this.txtTotal1.Enteros = 12;
            this.txtTotal1.EnterTabulacion = true;
            this.txtTotal1.Location = new System.Drawing.Point(384, 17);
            this.txtTotal1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.ReadOnly = true;
            this.txtTotal1.Size = new System.Drawing.Size(171, 22);
            this.txtTotal1.TabIndex = 50;
            this.txtTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh10
            // 
            this.labelQuimadh10.AutoSize = true;
            this.labelQuimadh10.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh10.Location = new System.Drawing.Point(307, 18);
            this.labelQuimadh10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh10.Name = "labelQuimadh10";
            this.labelQuimadh10.Size = new System.Drawing.Size(63, 20);
            this.labelQuimadh10.TabIndex = 51;
            this.labelQuimadh10.Text = "Total: ";
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.Location = new System.Drawing.Point(880, 593);
            this.btnReimprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(188, 33);
            this.btnReimprimir.TabIndex = 52;
            this.btnReimprimir.Text = "Reimprimir";
            this.btnReimprimir.UseVisualStyleBackColor = true;
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // txtFormaPago
            // 
            this.txtFormaPago.Location = new System.Drawing.Point(425, 593);
            this.txtFormaPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtFormaPago.MaxLength = 255;
            this.txtFormaPago.Name = "txtFormaPago";
            this.txtFormaPago.Size = new System.Drawing.Size(209, 22);
            this.txtFormaPago.TabIndex = 53;
            this.txtFormaPago.Visible = false;
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(293, 594);
            this.labelQuimadh7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(120, 20);
            this.labelQuimadh7.TabIndex = 54;
            this.labelQuimadh7.Text = "Forma pago: ";
            this.labelQuimadh7.Visible = false;
            // 
            // dgvItems
            // 
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFechaIzq,
            this.clmDescIzq,
            this.clmImporteIzq,
            this.clmFechaDer,
            this.clmDescDer,
            this.clmImporteDer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.Enabled = false;
            this.dgvItems.GridColor = System.Drawing.Color.Black;
            this.dgvItems.Location = new System.Drawing.Point(4, 327);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.Name = "dgvItems";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.Size = new System.Drawing.Size(1064, 208);
            this.dgvItems.TabIndex = 55;
            this.dgvItems.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellLeave);
            this.dgvItems.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvItems_UserDeletedRow);
            // 
            // clmFechaIzq
            // 
            this.clmFechaIzq.HeaderText = "Fecha";
            this.clmFechaIzq.Name = "clmFechaIzq";
            // 
            // clmDescIzq
            // 
            this.clmDescIzq.HeaderText = "Descripción";
            this.clmDescIzq.MaxInputLength = 30;
            this.clmDescIzq.Name = "clmDescIzq";
            this.clmDescIzq.Width = 150;
            // 
            // clmImporteIzq
            // 
            this.clmImporteIzq.HeaderText = "Importe";
            this.clmImporteIzq.MaxInputLength = 12;
            this.clmImporteIzq.Name = "clmImporteIzq";
            this.clmImporteIzq.Width = 125;
            // 
            // clmFechaDer
            // 
            this.clmFechaDer.HeaderText = "Fecha";
            this.clmFechaDer.Name = "clmFechaDer";
            // 
            // clmDescDer
            // 
            this.clmDescDer.HeaderText = "Descripción";
            this.clmDescDer.MaxInputLength = 30;
            this.clmDescDer.Name = "clmDescDer";
            this.clmDescDer.Width = 150;
            // 
            // clmImporteDer
            // 
            this.clmImporteDer.HeaderText = "Importe";
            this.clmImporteDer.MaxInputLength = 12;
            this.clmImporteDer.Name = "clmImporteDer";
            this.clmImporteDer.Width = 125;
            // 
            // txtTotal2
            // 
            this.txtTotal2.Decimales = 2;
            this.txtTotal2.Enteros = 12;
            this.txtTotal2.EnterTabulacion = true;
            this.txtTotal2.Location = new System.Drawing.Point(887, 17);
            this.txtTotal2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.ReadOnly = true;
            this.txtTotal2.Size = new System.Drawing.Size(167, 22);
            this.txtTotal2.TabIndex = 56;
            this.txtTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh9
            // 
            this.labelQuimadh9.AutoSize = true;
            this.labelQuimadh9.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh9.Location = new System.Drawing.Point(809, 18);
            this.labelQuimadh9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh9.Name = "labelQuimadh9";
            this.labelQuimadh9.Size = new System.Drawing.Size(63, 20);
            this.labelQuimadh9.TabIndex = 57;
            this.labelQuimadh9.Text = "Total: ";
            // 
            // txtNroRecibo
            // 
            this.txtNroRecibo.Decimales = 0;
            this.txtNroRecibo.Enteros = 11;
            this.txtNroRecibo.EnterTabulacion = true;
            this.txtNroRecibo.Location = new System.Drawing.Point(208, 20);
            this.txtNroRecibo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroRecibo.Name = "txtNroRecibo";
            this.txtNroRecibo.Size = new System.Drawing.Size(211, 22);
            this.txtNroRecibo.TabIndex = 29;
            this.txtNroRecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(776, 18);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(205, 22);
            this.dtpFecha.TabIndex = 59;
            // 
            // labelQuimadh11
            // 
            this.labelQuimadh11.AutoSize = true;
            this.labelQuimadh11.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh11.Location = new System.Drawing.Point(695, 20);
            this.labelQuimadh11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh11.Name = "labelQuimadh11";
            this.labelQuimadh11.Size = new System.Drawing.Size(66, 20);
            this.labelQuimadh11.TabIndex = 58;
            this.labelQuimadh11.Text = "Fecha:";
            // 
            // labelQuimadh14
            // 
            this.labelQuimadh14.AutoSize = true;
            this.labelQuimadh14.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh14.Location = new System.Drawing.Point(456, 20);
            this.labelQuimadh14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh14.Name = "labelQuimadh14";
            this.labelQuimadh14.Size = new System.Drawing.Size(100, 20);
            this.labelQuimadh14.TabIndex = 61;
            this.labelQuimadh14.Text = "Cotiz. u$s:";
            // 
            // txtCotiz
            // 
            this.txtCotiz.Location = new System.Drawing.Point(568, 18);
            this.txtCotiz.Margin = new System.Windows.Forms.Padding(4);
            this.txtCotiz.Name = "txtCotiz";
            this.txtCotiz.ReadOnly = true;
            this.txtCotiz.Size = new System.Drawing.Size(83, 22);
            this.txtCotiz.TabIndex = 60;
            // 
            // gpbDatosRec
            // 
            this.gpbDatosRec.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatosRec.Controls.Add(this.labelQuimadh13);
            this.gpbDatosRec.Controls.Add(this.labelQuimadh14);
            this.gpbDatosRec.Controls.Add(this.txtNroRecibo);
            this.gpbDatosRec.Controls.Add(this.txtCotiz);
            this.gpbDatosRec.Controls.Add(this.labelQuimadh11);
            this.gpbDatosRec.Controls.Add(this.dtpFecha);
            this.gpbDatosRec.Location = new System.Drawing.Point(4, 138);
            this.gpbDatosRec.Margin = new System.Windows.Forms.Padding(4);
            this.gpbDatosRec.Name = "gpbDatosRec";
            this.gpbDatosRec.Padding = new System.Windows.Forms.Padding(4);
            this.gpbDatosRec.Size = new System.Drawing.Size(1064, 53);
            this.gpbDatosRec.TabIndex = 62;
            this.gpbDatosRec.TabStop = false;
            // 
            // gpbTotales
            // 
            this.gpbTotales.BackColor = System.Drawing.Color.Transparent;
            this.gpbTotales.Controls.Add(this.labelQuimadh10);
            this.gpbTotales.Controls.Add(this.txtTotal1);
            this.gpbTotales.Controls.Add(this.txtTotal2);
            this.gpbTotales.Controls.Add(this.labelQuimadh9);
            this.gpbTotales.Location = new System.Drawing.Point(4, 539);
            this.gpbTotales.Margin = new System.Windows.Forms.Padding(4);
            this.gpbTotales.Name = "gpbTotales";
            this.gpbTotales.Padding = new System.Windows.Forms.Padding(4);
            this.gpbTotales.Size = new System.Drawing.Size(1064, 48);
            this.gpbTotales.TabIndex = 63;
            this.gpbTotales.TabStop = false;
            this.gpbTotales.Text = "Totales";
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(688, 593);
            this.btnPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(188, 33);
            this.btnPago.TabIndex = 64;
            this.btnPago.Text = "Cargar / Ver Pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // frmRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 630);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.gpbTotales);
            this.Controls.Add(this.gpbDatosRec);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.txtFormaPago);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.labelQuimadh7);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecibos";
            this.Text = "";
            this.Controls.SetChildIndex(this.labelQuimadh7, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.Controls.SetChildIndex(this.btnReimprimir, 0);
            this.Controls.SetChildIndex(this.txtFormaPago, 0);
            this.Controls.SetChildIndex(this.dgvItems, 0);
            this.Controls.SetChildIndex(this.gpbDatosRec, 0);
            this.Controls.SetChildIndex(this.gpbTotales, 0);
            this.Controls.SetChildIndex(this.btnPago, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.gpbDatosRec.ResumeLayout(false);
            this.gpbDatosRec.PerformLayout();
            this.gpbTotales.ResumeLayout(false);
            this.gpbTotales.PerformLayout();
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
        private Controles.LabelQuimadh labelQuimadh13;
        private Controles.TextBoxNumerico txtTotal1;
        private Controles.LabelQuimadh labelQuimadh10;
        private Controles.ButtonQuimadh btnReimprimir;
        private Controles.TextBoxQuimadh txtFormaPago;
        private Controles.LabelQuimadh labelQuimadh7;
        private System.Windows.Forms.DataGridView dgvItems;
        private Controles.TextBoxNumerico txtTotal2;
        private Controles.LabelQuimadh labelQuimadh9;
        private Controles.TextBoxNumerico txtNroRecibo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private Controles.LabelQuimadh labelQuimadh11;
        private Controles.LabelQuimadh labelQuimadh14;
        private Controles.TextBoxQuimadh txtCotiz;
        private System.Windows.Forms.GroupBox gpbDatosRec;
        private System.Windows.Forms.GroupBox gpbTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaIzq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescIzq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImporteIzq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaDer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescDer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImporteDer;
        private Controles.ButtonQuimadh btnPago;
    }
}