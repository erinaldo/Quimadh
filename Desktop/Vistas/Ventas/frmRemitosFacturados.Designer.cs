namespace Desktop.Vistas.Ventas
{
    partial class frmRemitosFacturados
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
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.txtCliente = new Controles.TextBoxQuimadh();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dgvRemitos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new Controles.ButtonQuimadh(this.components);
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNroRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPvFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(301, 45);
            this.lblTitulo.Text = "Remitos Facturados";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(445, 93);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(56, 16);
            this.labelQuimadh1.TabIndex = 63;
            this.labelQuimadh1.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(507, 91);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(165, 20);
            this.txtCliente.TabIndex = 62;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(319, 91);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaHasta.TabIndex = 61;
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(222, 93);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(100, 16);
            this.labelQuimadh4.TabIndex = 60;
            this.labelQuimadh4.Text = "Fecha Hasta:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(12, 93);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(105, 16);
            this.labelQuimadh3.TabIndex = 59;
            this.labelQuimadh3.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(123, 91);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaDesde.TabIndex = 58;
            // 
            // dgvRemitos
            // 
            this.dgvRemitos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemitos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRemitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCliente,
            this.clmNroRemito,
            this.clmPvFact,
            this.clmNroFactura,
            this.clmTipoFact,
            this.clmEstado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRemitos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRemitos.GridColor = System.Drawing.Color.Black;
            this.dgvRemitos.Location = new System.Drawing.Point(12, 154);
            this.dgvRemitos.Name = "dgvRemitos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRemitos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRemitos.Size = new System.Drawing.Size(661, 238);
            this.dgvRemitos.TabIndex = 64;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(591, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 23);
            this.btnBuscar.TabIndex = 65;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.ReadOnly = true;
            // 
            // clmNroRemito
            // 
            this.clmNroRemito.HeaderText = "Nro Remito";
            this.clmNroRemito.Name = "clmNroRemito";
            this.clmNroRemito.ReadOnly = true;
            // 
            // clmPvFact
            // 
            this.clmPvFact.HeaderText = "Pv Factura";
            this.clmPvFact.Name = "clmPvFact";
            this.clmPvFact.ReadOnly = true;
            // 
            // clmNroFactura
            // 
            this.clmNroFactura.HeaderText = "Nro Factura";
            this.clmNroFactura.Name = "clmNroFactura";
            this.clmNroFactura.ReadOnly = true;
            // 
            // clmTipoFact
            // 
            this.clmTipoFact.HeaderText = "Tipo Factura";
            this.clmTipoFact.Name = "clmTipoFact";
            this.clmTipoFact.ReadOnly = true;
            // 
            // clmEstado
            // 
            this.clmEstado.HeaderText = "Estado ";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            // 
            // frmRemitosFacturados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 422);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvRemitos);
            this.Controls.Add(this.labelQuimadh1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.labelQuimadh4);
            this.Controls.Add(this.labelQuimadh3);
            this.Controls.Add(this.dtpFechaDesde);
            this.Name = "frmRemitosFacturados";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.dtpFechaDesde, 0);
            this.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.Controls.SetChildIndex(this.dtpFechaHasta, 0);
            this.Controls.SetChildIndex(this.txtCliente, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.dgvRemitos, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.TextBoxQuimadh txtCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh3;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DataGridView dgvRemitos;
        private Controles.ButtonQuimadh btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNroRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPvFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
    }
}