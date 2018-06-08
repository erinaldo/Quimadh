namespace Desktop.Vistas.Ventas
{
    partial class frmErroresAfip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvObserv = new System.Windows.Forms.DataGridView();
            this.clmObsCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObsDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.clmErrCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmErrDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.clmEvCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEvDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObserv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(193, 45);
            this.lblTitulo.Text = "Errores AFIP";
            // 
            // dgvObserv
            // 
            this.dgvObserv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObserv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObserv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmObsCod,
            this.clmObsDesc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObserv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvObserv.Location = new System.Drawing.Point(12, 110);
            this.dgvObserv.Name = "dgvObserv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObserv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObserv.Size = new System.Drawing.Size(498, 89);
            this.dgvObserv.TabIndex = 4;
            // 
            // clmObsCod
            // 
            this.clmObsCod.HeaderText = "Código";
            this.clmObsCod.Name = "clmObsCod";
            this.clmObsCod.ReadOnly = true;
            // 
            // clmObsDesc
            // 
            this.clmObsDesc.HeaderText = "Descripción";
            this.clmObsDesc.Name = "clmObsDesc";
            this.clmObsDesc.ReadOnly = true;
            this.clmObsDesc.Width = 350;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(12, 91);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(113, 16);
            this.labelQuimadh1.TabIndex = 7;
            this.labelQuimadh1.Text = "Observaciones";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(12, 207);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(59, 16);
            this.labelQuimadh2.TabIndex = 8;
            this.labelQuimadh2.Text = "Errores";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(12, 323);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(64, 16);
            this.labelQuimadh3.TabIndex = 9;
            this.labelQuimadh3.Text = "Eventos";
            // 
            // dgvErrores
            // 
            this.dgvErrores.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvErrores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmErrCod,
            this.clmErrDesc});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvErrores.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvErrores.Location = new System.Drawing.Point(12, 226);
            this.dgvErrores.Name = "dgvErrores";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvErrores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvErrores.Size = new System.Drawing.Size(498, 89);
            this.dgvErrores.TabIndex = 10;
            // 
            // clmErrCod
            // 
            this.clmErrCod.HeaderText = "Código";
            this.clmErrCod.Name = "clmErrCod";
            this.clmErrCod.ReadOnly = true;
            // 
            // clmErrDesc
            // 
            this.clmErrDesc.HeaderText = "Descripción";
            this.clmErrDesc.Name = "clmErrDesc";
            this.clmErrDesc.ReadOnly = true;
            this.clmErrDesc.Width = 350;
            // 
            // dgvEventos
            // 
            this.dgvEventos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEvCod,
            this.clmEvDesc});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEventos.Location = new System.Drawing.Point(12, 342);
            this.dgvEventos.Name = "dgvEventos";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEventos.Size = new System.Drawing.Size(498, 89);
            this.dgvEventos.TabIndex = 11;
            // 
            // clmEvCod
            // 
            this.clmEvCod.HeaderText = "Código";
            this.clmEvCod.Name = "clmEvCod";
            this.clmEvCod.ReadOnly = true;
            // 
            // clmEvDesc
            // 
            this.clmEvDesc.HeaderText = "Descripción";
            this.clmEvDesc.Name = "clmEvDesc";
            this.clmEvDesc.ReadOnly = true;
            this.clmEvDesc.Width = 350;
            // 
            // frmErroresAfip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 440);
            this.Controls.Add(this.dgvEventos);
            this.Controls.Add(this.dgvErrores);
            this.Controls.Add(this.labelQuimadh3);
            this.Controls.Add(this.labelQuimadh2);
            this.Controls.Add(this.dgvObserv);
            this.Controls.Add(this.labelQuimadh1);
            this.Name = "frmErroresAfip";
            this.Load += new System.EventHandler(this.frmErroresAfip_Load);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.dgvObserv, 0);
            this.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.Controls.SetChildIndex(this.dgvErrores, 0);
            this.Controls.SetChildIndex(this.dgvEventos, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObserv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObserv;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh3;
        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObsCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObsDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmErrCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmErrDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEvCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEvDesc;
    }
}