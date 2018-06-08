namespace Desktop.Vistas.Analisis
{
    partial class frmRutinas
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
            this.cboPlanta = new Controles.CustomComboBox(this.components);
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.btnEliminarMuestra = new Controles.ButtonQuimadh(this.components);
            this.btnAgregarMuestra = new Controles.ButtonQuimadh(this.components);
            this.btnEliminarDeterminante = new Controles.ButtonQuimadh(this.components);
            this.btnAgregarDeterminante = new Controles.ButtonQuimadh(this.components);
            this.ltvMuestras = new Controles.CustomListView(this.components);
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ltvDeterminantes = new Controles.CustomListView(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.btnCargarRutina = new Controles.ButtonQuimadh(this.components);
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.cboRutina = new Controles.CustomComboBox(this.components);
            this.txtCliente = new Controles.TextBoxQuimadh();
            this.lblCliente = new Controles.LabelQuimadh(this.components);
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(174, 74);
            this.lblTitulo.Size = new System.Drawing.Size(415, 37);
            this.lblTitulo.Text = "Administración de Rutinas";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.Location = new System.Drawing.Point(20, 38);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(40, 13);
            this.labelQuimadh1.TabIndex = 26;
            this.labelQuimadh1.Text = "Planta:";
            // 
            // cboPlanta
            // 
            this.cboPlanta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPlanta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboPlanta.FormattingEnabled = true;
            this.cboPlanta.Location = new System.Drawing.Point(79, 35);
            this.cboPlanta.Name = "cboPlanta";
            this.cboPlanta.Size = new System.Drawing.Size(221, 21);
            this.cboPlanta.TabIndex = 25;
            this.cboPlanta.SelectedIndexChanged += new System.EventHandler(this.cboPlanta_SelectedIndexChanged);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.btnEliminarMuestra);
            this.gpbDatos.Controls.Add(this.btnAgregarMuestra);
            this.gpbDatos.Controls.Add(this.btnEliminarDeterminante);
            this.gpbDatos.Controls.Add(this.btnAgregarDeterminante);
            this.gpbDatos.Controls.Add(this.ltvMuestras);
            this.gpbDatos.Controls.Add(this.ltvDeterminantes);
            this.gpbDatos.Controls.Add(this.labelQuimadh4);
            this.gpbDatos.Controls.Add(this.labelQuimadh3);
            this.gpbDatos.Controls.Add(this.btnCargarRutina);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.cboRutina);
            this.gpbDatos.Controls.Add(this.txtCliente);
            this.gpbDatos.Controls.Add(this.lblCliente);
            this.gpbDatos.Controls.Add(this.cboPlanta);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Location = new System.Drawing.Point(21, 114);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(674, 490);
            this.gpbDatos.TabIndex = 27;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Rutina";
            // 
            // btnEliminarMuestra
            // 
            this.btnEliminarMuestra.Location = new System.Drawing.Point(513, 111);
            this.btnEliminarMuestra.Name = "btnEliminarMuestra";
            this.btnEliminarMuestra.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMuestra.TabIndex = 39;
            this.btnEliminarMuestra.Text = "Eliminar";
            this.btnEliminarMuestra.UseVisualStyleBackColor = true;
            this.btnEliminarMuestra.Click += new System.EventHandler(this.btnEliminarMuestra_Click);
            // 
            // btnAgregarMuestra
            // 
            this.btnAgregarMuestra.Location = new System.Drawing.Point(432, 111);
            this.btnAgregarMuestra.Name = "btnAgregarMuestra";
            this.btnAgregarMuestra.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMuestra.TabIndex = 38;
            this.btnAgregarMuestra.Text = "Agregar";
            this.btnAgregarMuestra.UseVisualStyleBackColor = true;
            this.btnAgregarMuestra.Click += new System.EventHandler(this.btnAgregarMuestra_Click);
            // 
            // btnEliminarDeterminante
            // 
            this.btnEliminarDeterminante.Location = new System.Drawing.Point(185, 111);
            this.btnEliminarDeterminante.Name = "btnEliminarDeterminante";
            this.btnEliminarDeterminante.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDeterminante.TabIndex = 37;
            this.btnEliminarDeterminante.Text = "Eliminar";
            this.btnEliminarDeterminante.UseVisualStyleBackColor = true;
            this.btnEliminarDeterminante.Click += new System.EventHandler(this.btnEliminarDeterminante_Click);
            // 
            // btnAgregarDeterminante
            // 
            this.btnAgregarDeterminante.Location = new System.Drawing.Point(104, 111);
            this.btnAgregarDeterminante.Name = "btnAgregarDeterminante";
            this.btnAgregarDeterminante.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDeterminante.TabIndex = 36;
            this.btnAgregarDeterminante.Text = "Agregar";
            this.btnAgregarDeterminante.UseVisualStyleBackColor = true;
            this.btnAgregarDeterminante.Click += new System.EventHandler(this.btnAgregarDeterminante_Click);
            // 
            // ltvMuestras
            // 
            this.ltvMuestras.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ltvMuestras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.ltvMuestras.FullRowSelect = true;
            this.ltvMuestras.Location = new System.Drawing.Point(376, 140);
            this.ltvMuestras.MultiSelect = false;
            this.ltvMuestras.Name = "ltvMuestras";
            this.ltvMuestras.Size = new System.Drawing.Size(277, 344);
            this.ltvMuestras.TabIndex = 35;
            this.ltvMuestras.UseCompatibleStateImageBehavior = false;
            this.ltvMuestras.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Muestra";
            this.columnHeader3.Width = 96;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descripción";
            this.columnHeader4.Width = 175;
            // 
            // ltvDeterminantes
            // 
            this.ltvDeterminantes.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ltvDeterminantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ltvDeterminantes.FullRowSelect = true;
            this.ltvDeterminantes.Location = new System.Drawing.Point(23, 140);
            this.ltvDeterminantes.MultiSelect = false;
            this.ltvDeterminantes.Name = "ltvDeterminantes";
            this.ltvDeterminantes.Size = new System.Drawing.Size(277, 344);
            this.ltvDeterminantes.TabIndex = 34;
            this.ltvDeterminantes.UseCompatibleStateImageBehavior = false;
            this.ltvDeterminantes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 189;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unidad";
            this.columnHeader2.Width = 83;
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.Location = new System.Drawing.Point(373, 116);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(53, 13);
            this.labelQuimadh4.TabIndex = 33;
            this.labelQuimadh4.Text = "Muestras:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.Location = new System.Drawing.Point(20, 116);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(78, 13);
            this.labelQuimadh3.TabIndex = 32;
            this.labelQuimadh3.Text = "Determinantes:";
            // 
            // btnCargarRutina
            // 
            this.btnCargarRutina.Location = new System.Drawing.Point(313, 69);
            this.btnCargarRutina.Name = "btnCargarRutina";
            this.btnCargarRutina.Size = new System.Drawing.Size(75, 23);
            this.btnCargarRutina.TabIndex = 31;
            this.btnCargarRutina.Text = "Cargar";
            this.btnCargarRutina.UseVisualStyleBackColor = true;
            this.btnCargarRutina.Click += new System.EventHandler(this.btnCargarRutina_Click);
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.Location = new System.Drawing.Point(20, 74);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(41, 13);
            this.labelQuimadh2.TabIndex = 30;
            this.labelQuimadh2.Text = "Rutina:";
            // 
            // cboRutina
            // 
            this.cboRutina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRutina.FormattingEnabled = true;
            this.cboRutina.Items.AddRange(new object[] {
            "Efluente",
            "Agua Potable",
            "Bacteriológica"});
            this.cboRutina.Location = new System.Drawing.Point(79, 71);
            this.cboRutina.Name = "cboRutina";
            this.cboRutina.Size = new System.Drawing.Size(221, 21);
            this.cboRutina.TabIndex = 29;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(381, 35);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(272, 20);
            this.txtCliente.TabIndex = 28;
            this.txtCliente.TabStop = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(333, 38);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 27;
            this.lblCliente.Text = "Cliente:";
            // 
            // frmRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 616);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmRutinas";
            this.Text = "Cliente:";
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.CustomComboBox cboPlanta;
        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.TextBoxQuimadh txtCliente;
        private Controles.LabelQuimadh lblCliente;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.CustomComboBox cboRutina;
        private Controles.ButtonQuimadh btnCargarRutina;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.CustomListView ltvMuestras;
        private Controles.ButtonQuimadh btnEliminarMuestra;
        private Controles.ButtonQuimadh btnAgregarMuestra;
        private Controles.ButtonQuimadh btnEliminarDeterminante;
        private Controles.ButtonQuimadh btnAgregarDeterminante;
        private Controles.CustomListView ltvDeterminantes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}