namespace Desktop.Vistas.Administracion
{
    partial class frmProveedores
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
            this.labelQuimadh3 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh4 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh5 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh6 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh7 = new Controles.LabelQuimadh(this.components);
            this.labelQuimadh8 = new Controles.LabelQuimadh(this.components);
            this.txtRazonSocial = new Controles.TextBoxQuimadh();
            this.txtDireccion = new Controles.TextBoxQuimadh();
            this.txtCUIT = new Controles.TextBoxNumerico();
            this.txtEmail = new Controles.TextBoxQuimadh();
            this.txtTelefono = new Controles.TextBoxQuimadh();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.cboLocalidad = new Controles.CustomComboBox(this.components);
            this.cboSitIva = new Controles.CustomComboBox(this.components);
            this.gpbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(16, 71);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Size = new System.Drawing.Size(582, 54);
            this.lblTitulo.Text = "Administración de Proveedores";
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(97, 20);
            this.labelQuimadh1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(126, 20);
            this.labelQuimadh1.TabIndex = 3;
            this.labelQuimadh1.Text = "Razón Social:";
            // 
            // labelQuimadh3
            // 
            this.labelQuimadh3.AutoSize = true;
            this.labelQuimadh3.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh3.Location = new System.Drawing.Point(97, 50);
            this.labelQuimadh3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh3.Name = "labelQuimadh3";
            this.labelQuimadh3.Size = new System.Drawing.Size(105, 20);
            this.labelQuimadh3.TabIndex = 5;
            this.labelQuimadh3.Text = "CUIL/CUIT:";
            // 
            // labelQuimadh4
            // 
            this.labelQuimadh4.AutoSize = true;
            this.labelQuimadh4.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh4.Location = new System.Drawing.Point(97, 80);
            this.labelQuimadh4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh4.Name = "labelQuimadh4";
            this.labelQuimadh4.Size = new System.Drawing.Size(128, 20);
            this.labelQuimadh4.TabIndex = 6;
            this.labelQuimadh4.Text = "Situación IVA:";
            // 
            // labelQuimadh5
            // 
            this.labelQuimadh5.AutoSize = true;
            this.labelQuimadh5.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh5.Location = new System.Drawing.Point(97, 113);
            this.labelQuimadh5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh5.Name = "labelQuimadh5";
            this.labelQuimadh5.Size = new System.Drawing.Size(96, 20);
            this.labelQuimadh5.TabIndex = 7;
            this.labelQuimadh5.Text = "Dirección:";
            // 
            // labelQuimadh6
            // 
            this.labelQuimadh6.AutoSize = true;
            this.labelQuimadh6.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh6.Location = new System.Drawing.Point(97, 146);
            this.labelQuimadh6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh6.Name = "labelQuimadh6";
            this.labelQuimadh6.Size = new System.Drawing.Size(96, 20);
            this.labelQuimadh6.TabIndex = 8;
            this.labelQuimadh6.Text = "Localidad:";
            // 
            // labelQuimadh7
            // 
            this.labelQuimadh7.AutoSize = true;
            this.labelQuimadh7.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh7.Location = new System.Drawing.Point(97, 208);
            this.labelQuimadh7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh7.Name = "labelQuimadh7";
            this.labelQuimadh7.Size = new System.Drawing.Size(87, 20);
            this.labelQuimadh7.TabIndex = 9;
            this.labelQuimadh7.Text = "Teléfono:";
            // 
            // labelQuimadh8
            // 
            this.labelQuimadh8.AutoSize = true;
            this.labelQuimadh8.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh8.Location = new System.Drawing.Point(97, 176);
            this.labelQuimadh8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuimadh8.Name = "labelQuimadh8";
            this.labelQuimadh8.Size = new System.Drawing.Size(62, 20);
            this.labelQuimadh8.TabIndex = 10;
            this.labelQuimadh8.Text = "Email:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(281, 18);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(215, 22);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(281, 112);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(215, 22);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Decimales = 0;
            this.txtCUIT.Enteros = 11;
            this.txtCUIT.EnterTabulacion = true;
            this.txtCUIT.Location = new System.Drawing.Point(281, 48);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(215, 22);
            this.txtCUIT.TabIndex = 4;
            this.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(281, 174);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(215, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(281, 206);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(215, 22);
            this.txtTelefono.TabIndex = 9;
            // 
            // gpbDatos
            // 
            this.gpbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gpbDatos.Controls.Add(this.cboLocalidad);
            this.gpbDatos.Controls.Add(this.cboSitIva);
            this.gpbDatos.Controls.Add(this.labelQuimadh1);
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
            this.gpbDatos.Location = new System.Drawing.Point(143, 167);
            this.gpbDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDatos.Size = new System.Drawing.Size(642, 287);
            this.gpbDatos.TabIndex = 0;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // cboLocalidad
            // 
            this.cboLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboLocalidad.FormattingEnabled = true;
            this.cboLocalidad.Location = new System.Drawing.Point(281, 142);
            this.cboLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboLocalidad.Name = "cboLocalidad";
            this.cboLocalidad.Size = new System.Drawing.Size(215, 24);
            this.cboLocalidad.TabIndex = 7;
            // 
            // cboSitIva
            // 
            this.cboSitIva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cboSitIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSitIva.FormattingEnabled = true;
            this.cboSitIva.Location = new System.Drawing.Point(281, 78);
            this.cboSitIva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboSitIva.Name = "cboSitIva";
            this.cboSitIva.Size = new System.Drawing.Size(215, 24);
            this.cboSitIva.TabIndex = 5;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 577);
            this.Controls.Add(this.gpbDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProveedores";
            this.Text = "";
            this.Controls.SetChildIndex(this.gpbDatos, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.LabelQuimadh labelQuimadh3;
        private Controles.LabelQuimadh labelQuimadh4;
        private Controles.LabelQuimadh labelQuimadh5;
        private Controles.LabelQuimadh labelQuimadh6;
        private Controles.LabelQuimadh labelQuimadh7;
        private Controles.LabelQuimadh labelQuimadh8;
        private Controles.TextBoxQuimadh txtRazonSocial;
        private Controles.TextBoxQuimadh txtDireccion;
        private Controles.TextBoxNumerico txtCUIT;
        private Controles.TextBoxQuimadh txtEmail;
        private Controles.TextBoxQuimadh txtTelefono;
        private System.Windows.Forms.GroupBox gpbDatos;
        private Controles.CustomComboBox cboSitIva;
        private Controles.CustomComboBox cboLocalidad;
    }
}