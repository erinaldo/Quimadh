namespace Controles
{
    partial class FormBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusqueda));
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new Controles.ButtonQuimadh(this.components);
            this.btnBuscar = new Controles.ButtonQuimadh(this.components);
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cboNumeroRegistros = new System.Windows.Forms.ComboBox();
            this.lblNumeroRegistros = new System.Windows.Forms.Label();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltvBusqueda = new Controles.CustomListView(this.components);
            this.btnAceptar = new Controles.ButtonQuimadh(this.components);
            this.btnCancelar = new Controles.ButtonQuimadh(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpbFiltros.BackColor = System.Drawing.Color.Transparent;
            this.gpbFiltros.Controls.Add(this.btnLimpiar);
            this.gpbFiltros.Controls.Add(this.btnBuscar);
            this.gpbFiltros.Location = new System.Drawing.Point(12, 84);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(569, 113);
            this.gpbFiltros.TabIndex = 5;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Datos de Búsqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(488, 84);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(407, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 206);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(399, 13);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Haga doble clic sobre el objeto a consultar, o bien selecciónelo y presione Acept" +
    "ar.";
            // 
            // cboNumeroRegistros
            // 
            this.cboNumeroRegistros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumeroRegistros.FormattingEnabled = true;
            this.cboNumeroRegistros.Items.AddRange(new object[] {
            "10",
            "100",
            "500"});
            this.cboNumeroRegistros.Location = new System.Drawing.Point(533, 203);
            this.cboNumeroRegistros.Name = "cboNumeroRegistros";
            this.cboNumeroRegistros.Size = new System.Drawing.Size(48, 21);
            this.cboNumeroRegistros.TabIndex = 20;
            this.cboNumeroRegistros.SelectedIndexChanged += new System.EventHandler(this.cboNumeroRegistros_SelectedIndexChanged);
            // 
            // lblNumeroRegistros
            // 
            this.lblNumeroRegistros.AutoSize = true;
            this.lblNumeroRegistros.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroRegistros.Location = new System.Drawing.Point(486, 206);
            this.lblNumeroRegistros.Name = "lblNumeroRegistros";
            this.lblNumeroRegistros.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroRegistros.TabIndex = 21;
            this.lblNumeroRegistros.Text = "Filtrar:";
            // 
            // col1
            // 
            this.col1.Width = 139;
            // 
            // col2
            // 
            this.col2.Width = 137;
            // 
            // ltvBusqueda
            // 
            this.ltvBusqueda.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ltvBusqueda.FullRowSelect = true;
            this.ltvBusqueda.Location = new System.Drawing.Point(15, 229);
            this.ltvBusqueda.MultiSelect = false;
            this.ltvBusqueda.Name = "ltvBusqueda";
            this.ltvBusqueda.Size = new System.Drawing.Size(565, 317);
            this.ltvBusqueda.TabIndex = 22;
            this.ltvBusqueda.UseCompatibleStateImageBehavior = false;
            this.ltvBusqueda.View = System.Windows.Forms.View.Details;
            this.ltvBusqueda.ItemActivate += new System.EventHandler(this.ltvBusqueda_ItemActivate);
            this.ltvBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltvBusqueda_KeyDown);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(425, 552);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(506, 552);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(230, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 45);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Búsqueda";
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Controles.Resources.FondoFormBase3;
            this.ClientSize = new System.Drawing.Size(592, 587);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.ltvBusqueda);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.cboNumeroRegistros);
            this.Controls.Add(this.lblNumeroRegistros);
            this.Controls.Add(this.gpbFiltros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBusqueda_Load);
            this.gpbFiltros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.GroupBox gpbFiltros;
        protected System.Windows.Forms.Label lblDescripcion;
        protected System.Windows.Forms.ComboBox cboNumeroRegistros;
        protected System.Windows.Forms.Label lblNumeroRegistros;
        protected System.Windows.Forms.ColumnHeader col1;
        protected System.Windows.Forms.ColumnHeader col2;
        private ButtonQuimadh btnLimpiar;
        private ButtonQuimadh btnBuscar;
        private ButtonQuimadh btnAceptar;
        private ButtonQuimadh btnCancelar;
        public CustomListView ltvBusqueda;
        public System.Windows.Forms.Label lblTitulo;
    }
}