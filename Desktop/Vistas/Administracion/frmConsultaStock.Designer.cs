namespace Desktop.Vistas.Administracion
{
    partial class frmConsultaStock
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
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.btnConsultar = new Controles.ButtonQuimadh(this.components);
            this.cboArticulo = new Controles.CustomComboBox(this.components);
            this.cboLote = new Controles.CustomComboBox(this.components);
            this.cboPresentacion = new Controles.CustomComboBox(this.components);
            this.lblUnidad = new Controles.LabelQuimadh(this.components);
            this.txtStock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(245, 45);
            this.lblTitulo.Text = "Consultar Stock";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(73, 114);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(64, 15);
            this.labelQuimadh1.TabIndex = 7;
            this.labelQuimadh1.Text = "Artículo:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(98, 141);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(39, 15);
            this.labelQuimadh2.TabIndex = 8;
            this.labelQuimadh2.Text = "Lote:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(41, 168);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(96, 15);
            this.labelQuimadh3.TabIndex = 9;
            this.labelQuimadh3.Text = "Presentación:";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(21, 237);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(116, 15);
            this.labelQuimadh4.TabIndex = 11;
            this.labelQuimadh4.Text = "STOCK ACTUAL:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(208, 193);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(97, 26);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar Stock";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboArticulo
            // 
            this.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(138, 112);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(167, 21);
            this.cboArticulo.TabIndex = 1;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            // 
            // cboLote
            // 
            this.cboLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLote.FormattingEnabled = true;
            this.cboLote.Location = new System.Drawing.Point(138, 139);
            this.cboLote.Name = "cboLote";
            this.cboLote.Size = new System.Drawing.Size(167, 21);
            this.cboLote.TabIndex = 2;
            // 
            // cboPresentacion
            // 
            this.cboPresentacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresentacion.FormattingEnabled = true;
            this.cboPresentacion.Location = new System.Drawing.Point(138, 166);
            this.cboPresentacion.Name = "cboPresentacion";
            this.cboPresentacion.Size = new System.Drawing.Size(167, 21);
            this.cboPresentacion.TabIndex = 3;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.BackColor = System.Drawing.Color.Transparent;
            this.lblUnidad.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(312, 239);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(0, 15);
            this.lblUnidad.TabIndex = 41;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(138, 235);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(167, 20);
            this.txtStock.TabIndex = 42;
            // 
            // frmConsultaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 310);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.cboLote);
            this.Controls.Add(this.cboPresentacion);
            this.Controls.Add(this.cboArticulo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.labelQuimadh4);
            this.Controls.Add(this.labelQuimadh3);
            this.Controls.Add(this.labelQuimadh2);
            this.Controls.Add(this.labelQuimadh1);
            this.Name = "frmConsultaStock";
            this.Load += new System.EventHandler(this.frmConsultaStock_Load);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.Controls.SetChildIndex(this.labelQuimadh3, 0);
            this.Controls.SetChildIndex(this.labelQuimadh4, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.cboArticulo, 0);
            this.Controls.SetChildIndex(this.cboPresentacion, 0);
            this.Controls.SetChildIndex(this.cboLote, 0);
            this.Controls.SetChildIndex(this.lblUnidad, 0);
            this.Controls.SetChildIndex(this.txtStock, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.ButtonQuimadh btnConsultar;
        private Controles.CustomComboBox cboArticulo;
        private Controles.CustomComboBox cboLote;
        private Controles.CustomComboBox cboPresentacion;
        private Controles.LabelQuimadh lblUnidad;
        private System.Windows.Forms.TextBox txtStock;
    }
}