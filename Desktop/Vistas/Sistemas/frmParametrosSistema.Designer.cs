namespace Desktop.Vistas.Sistemas
{
    partial class frmParametrosSistema
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
            this.ltvParametrosSistema = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDirPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ltvParametrosSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Size = new System.Drawing.Size(358, 45);
            this.lblTitulo.Text = "Parámetros del Sistema";
            // 
            // ltvParametrosSistema
            // 
            this.ltvParametrosSistema.BackgroundColor = System.Drawing.Color.White;
            this.ltvParametrosSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ltvParametrosSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmCodigo,
            this.clmDescrip,
            this.clmDirPlanta});
            this.ltvParametrosSistema.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ltvParametrosSistema.Location = new System.Drawing.Point(12, 157);
            this.ltvParametrosSistema.Name = "ltvParametrosSistema";
            this.ltvParametrosSistema.Size = new System.Drawing.Size(798, 370);
            this.ltvParametrosSistema.TabIndex = 13;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Nombre";
            this.clmId.MaxInputLength = 22767;
            this.clmId.Name = "clmId";
            this.clmId.Width = 175;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Descripcion";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.Width = 270;
            // 
            // clmDescrip
            // 
            this.clmDescrip.HeaderText = "Tipo de Dato";
            this.clmDescrip.Name = "clmDescrip";
            this.clmDescrip.Width = 150;
            // 
            // clmDirPlanta
            // 
            this.clmDirPlanta.HeaderText = "Valor";
            this.clmDirPlanta.Name = "clmDirPlanta";
            this.clmDirPlanta.Width = 150;
            // 
            // frmParametrosSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 557);
            this.Controls.Add(this.ltvParametrosSistema);
            this.Name = "frmParametrosSistema";
            this.Text = "";
            this.Shown += new System.EventHandler(this.frmParametrosSistema_Shown);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.ltvParametrosSistema, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ltvParametrosSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ltvParametrosSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDirPlanta;
    }
}