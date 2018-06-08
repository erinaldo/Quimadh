namespace Desktop.Vistas.Administracion
{
    partial class frmClientes
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
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh8 = new Controles.LabelQuimadh(this.components);
            this.txtRazonSocial = new Controles.TextBoxQuimadh();
            this.txtNomContacto = new Controles.TextBoxQuimadh();
            this.txtDireccion = new Controles.TextBoxQuimadh();
            this.txtCUIT = new Controles.TextBoxNumerico();
            this.txtEmail = new Controles.TextBoxQuimadh();
            this.txtTelefono = new Controles.TextBoxQuimadh();
            this.gpbPlantas = new System.Windows.Forms.GroupBox();
            this.btnNuevaPlanta = new Controles.ButtonQuimadh(this.components);
            this.dgvPlantas = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDirPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEditar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clmEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.cboLocalidad = new Controles.CustomComboBox(this.components);
            this.cboSitIva = new Controles.CustomComboBox(this.components);
            this.txtFax = new Controles.TextBoxQuimadh();
            this.labelQuimadh11 = new Controles.LabelQuimadh(this.components);
            this.txtTel2 = new Controles.TextBoxQuimadh();
            this.labelQuimadh10 = new Controles.LabelQuimadh(this.components);
            this.txtCargoContacto = new Controles.TextBoxQuimadh();
            this.labelQuimadh9 = new Controles.LabelQuimadh(this.components);
            this.gpbPlantas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).BeginInit();
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 58);
            this.lblTitulo.Size = new System.Drawing.Size(403, 45);
            this.lblTitulo.Text = "Administración de Clientes";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(73, 16);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(104, 16);
            this.labelQuimadh1.TabIndex = 3;
            this.labelQuimadh1.Text = "Razón Social:";
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(73, 42);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(132, 16);
            this.labelQuimadh2.TabIndex = 4;
            this.labelQuimadh2.Text = "Nombre Contacto:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(73, 94);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(85, 16);
            this.labelQuimadh3.TabIndex = 5;
            this.labelQuimadh3.Text = "CUIL/CUIT:";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(73, 120);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(104, 16);
            this.labelQuimadh4.TabIndex = 6;
            this.labelQuimadh4.Text = "Situación IVA:";
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(73, 147);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(78, 16);
            this.labelQuimadh5.TabIndex = 7;
            this.labelQuimadh5.Text = "Dirección:";
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(481, 19);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(81, 16);
            this.labelQuimadh6.TabIndex = 8;
            this.labelQuimadh6.Text = "Localidad:";
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(481, 72);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(74, 16);
            this.labelQuimadh7.TabIndex = 9;
            this.labelQuimadh7.Text = "Teléfono:";
            // 
            // labelQuimadh8
            // 
            this.labelQuimadh8.AutoSize = true;
            this.labelQuimadh8.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh8.Location = new System.Drawing.Point(481, 46);
            this.labelQuimadh8.Name = "labelQuimadh8";
            this.labelQuimadh8.Size = new System.Drawing.Size(51, 16);
            this.labelQuimadh8.TabIndex = 10;
            this.labelQuimadh8.Text = "Email:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(211, 15);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(162, 20);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtNomContacto
            // 
            this.txtNomContacto.Location = new System.Drawing.Point(211, 41);
            this.txtNomContacto.Name = "txtNomContacto";
            this.txtNomContacto.Size = new System.Drawing.Size(162, 20);
            this.txtNomContacto.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(211, 146);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(162, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Decimales = 0;
            this.txtCUIT.Enteros = 11;
            this.txtCUIT.EnterTabulacion = true;
            this.txtCUIT.Location = new System.Drawing.Point(211, 93);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(162, 20);
            this.txtCUIT.TabIndex = 4;
            this.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(619, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(619, 71);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(162, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // gpbPlantas
            // 
            this.gpbPlantas.Controls.Add(this.btnNuevaPlanta);
            this.gpbPlantas.Controls.Add(this.dgvPlantas);
            this.gpbPlantas.Location = new System.Drawing.Point(66, 185);
            this.gpbPlantas.Name = "gpbPlantas";
            this.gpbPlantas.Size = new System.Drawing.Size(768, 221);
            this.gpbPlantas.TabIndex = 21;
            this.gpbPlantas.TabStop = false;
            this.gpbPlantas.Text = "Plantas";
            // 
            // btnNuevaPlanta
            // 
            this.btnNuevaPlanta.Location = new System.Drawing.Point(640, 183);
            this.btnNuevaPlanta.Name = "btnNuevaPlanta";
            this.btnNuevaPlanta.Size = new System.Drawing.Size(122, 31);
            this.btnNuevaPlanta.TabIndex = 13;
            this.btnNuevaPlanta.Text = "Agregar Planta";
            this.btnNuevaPlanta.UseVisualStyleBackColor = true;
            this.btnNuevaPlanta.Click += new System.EventHandler(this.btnNuevaPlanta_Click);
            // 
            // dgvPlantas
            // 
            this.dgvPlantas.AllowUserToAddRows = false;
            this.dgvPlantas.AllowUserToDeleteRows = false;
            this.dgvPlantas.AllowUserToOrderColumns = true;
            this.dgvPlantas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmCodigo,
            this.clmDescrip,
            this.clmDirPlanta,
            this.clmLocalidad,
            this.clmEditar,
            this.clmEliminar});
            this.dgvPlantas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPlantas.Location = new System.Drawing.Point(6, 17);
            this.dgvPlantas.Name = "dgvPlantas";
            this.dgvPlantas.ReadOnly = true;
            this.dgvPlantas.Size = new System.Drawing.Size(756, 160);
            this.dgvPlantas.TabIndex = 12;
            this.dgvPlantas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlantas_CellClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.MaxInputLength = 22767;
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Width = 35;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 50;
            // 
            // clmDescrip
            // 
            this.clmDescrip.HeaderText = "Descripción";
            this.clmDescrip.Name = "clmDescrip";
            this.clmDescrip.ReadOnly = true;
            this.clmDescrip.Width = 190;
            // 
            // clmDirPlanta
            // 
            this.clmDirPlanta.HeaderText = "Dirección ";
            this.clmDirPlanta.Name = "clmDirPlanta";
            this.clmDirPlanta.ReadOnly = true;
            this.clmDirPlanta.Width = 175;
            // 
            // clmLocalidad
            // 
            this.clmLocalidad.HeaderText = "Localidad";
            this.clmLocalidad.Name = "clmLocalidad";
            this.clmLocalidad.ReadOnly = true;
            this.clmLocalidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clmEditar
            // 
            this.clmEditar.HeaderText = "";
            this.clmEditar.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.clmEditar.Name = "clmEditar";
            this.clmEditar.ReadOnly = true;
            this.clmEditar.Text = "Editar";
            this.clmEditar.UseColumnTextForLinkValue = true;
            this.clmEditar.Width = 75;
            // 
            // clmEliminar
            // 
            this.clmEliminar.HeaderText = "";
            this.clmEliminar.Name = "clmEliminar";
            this.clmEliminar.ReadOnly = true;
            this.clmEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEliminar.Text = "Eliminar";
            this.clmEliminar.UseColumnTextForLinkValue = true;
            this.clmEliminar.Width = 75;
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.cboLocalidad);
            this.gpbDatos.Controls.Add(this.cboSitIva);
            this.gpbDatos.Controls.Add(this.txtFax);
            this.gpbDatos.Controls.Add(this.labelQuimadh11);
            this.gpbDatos.Controls.Add(this.txtTel2);
            this.gpbDatos.Controls.Add(this.labelQuimadh10);
            this.gpbDatos.Controls.Add(this.txtCargoContacto);
            this.gpbDatos.Controls.Add(this.labelQuimadh9);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
            this.gpbDatos.Controls.Add(this.labelQuimadh2);
            this.gpbDatos.Controls.Add(this.gpbPlantas);
            this.gpbDatos.Controls.Add(this.labelQuimadh3);
            this.gpbDatos.Controls.Add(this.labelQuimadh4);
            this.gpbDatos.Controls.Add(this.txtTelefono);
            this.gpbDatos.Controls.Add(this.labelQuimadh5);
            this.gpbDatos.Controls.Add(this.txtEmail);
            this.gpbDatos.Controls.Add(this.labelQuimadh6);
            this.gpbDatos.Controls.Add(this.txtCUIT);
            this.gpbDatos.Controls.Add(this.labelQuimadh7);
            this.gpbDatos.Controls.Add(this.txtDireccion);
            this.gpbDatos.Controls.Add(this.labelQuimadh8);
            this.gpbDatos.Controls.Add(this.txtRazonSocial);
            this.gpbDatos.Controls.Add(this.txtNomContacto);
            this.gpbDatos.Location = new System.Drawing.Point(12, 134);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(901, 412);
            this.gpbDatos.TabIndex = 0;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(619, 18);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(162, 21);
            this.cboLocalidad.TabIndex = 7;
            // 
            // cboSitIva
            // 
            this.cboSitIva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboSitIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSitIva.FormattingEnabled = true;
            this.cboSitIva.Location = new System.Drawing.Point(211, 119);
            this.cboSitIva.Name = "cboSitIva";
            this.cboSitIva.Size = new System.Drawing.Size(162, 21);
            this.cboSitIva.TabIndex = 5;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(619, 123);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(162, 20);
            this.txtFax.TabIndex = 11;
            // 
            // labelQuimadh11
            // 
            this.labelQuimadh11.AutoSize = true;
            this.labelQuimadh11.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh11.Location = new System.Drawing.Point(481, 124);
            this.labelQuimadh11.Name = "labelQuimadh11";
            this.labelQuimadh11.Size = new System.Drawing.Size(41, 16);
            this.labelQuimadh11.TabIndex = 27;
            this.labelQuimadh11.Text = "Fax :";
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(619, 97);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(162, 20);
            this.txtTel2.TabIndex = 10;
            // 
            // labelQuimadh10
            // 
            this.labelQuimadh10.AutoSize = true;
            this.labelQuimadh10.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh10.Location = new System.Drawing.Point(481, 98);
            this.labelQuimadh10.Name = "labelQuimadh10";
            this.labelQuimadh10.Size = new System.Drawing.Size(86, 16);
            this.labelQuimadh10.TabIndex = 25;
            this.labelQuimadh10.Text = "Teléfono 2:";
            // 
            // txtCargoContacto
            // 
            this.txtCargoContacto.Location = new System.Drawing.Point(211, 67);
            this.txtCargoContacto.Name = "txtCargoContacto";
            this.txtCargoContacto.Size = new System.Drawing.Size(162, 20);
            this.txtCargoContacto.TabIndex = 3;
            // 
            // labelQuimadh9
            // 
            this.labelQuimadh9.AutoSize = true;
            this.labelQuimadh9.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh9.Location = new System.Drawing.Point(73, 68);
            this.labelQuimadh9.Name = "labelQuimadh9";
            this.labelQuimadh9.Size = new System.Drawing.Size(119, 16);
            this.labelQuimadh9.TabIndex = 23;
            this.labelQuimadh9.Text = "Cargo Contacto:";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 545);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmClientes";
            this.Text = "";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmClientes_FormClosed);
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.gpbPlantas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).EndInit();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh2;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.LabelQuimadh labelQuimadh7;
        private Controles.LabelQuimadh labelQuimadh8;
        private Controles.TextBoxQuimadh txtRazonSocial;
        private Controles.TextBoxQuimadh txtNomContacto;
        private Controles.TextBoxQuimadh txtDireccion;
        private Controles.TextBoxNumerico txtCUIT;
        private Controles.TextBoxQuimadh txtEmail;
        private Controles.TextBoxQuimadh txtTelefono;
        private System.Windows.Forms.GroupBox gpbPlantas;
        private System.Windows.Forms.DataGridView dgvPlantas;
        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.TextBoxQuimadh txtCargoContacto;
        private Controles.LabelQuimadh labelQuimadh9;
        private Controles.TextBoxQuimadh txtFax;
        private Controles.LabelQuimadh labelQuimadh11;
        private Controles.TextBoxQuimadh txtTel2;
        private Controles.LabelQuimadh labelQuimadh10;
        private Controles.CustomComboBox cboSitIva;
        private Controles.CustomComboBox cboLocalidad;
        private Controles.ButtonQuimadh btnNuevaPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDirPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocalidad;
        private System.Windows.Forms.DataGridViewLinkColumn clmEditar;
        private System.Windows.Forms.DataGridViewLinkColumn clmEliminar;
    }
}