namespace Desktop
{
    partial class frmLogin
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
            this.textBoxNumerico1 = new Controles.TextBoxNumerico();
            this.textBoxNumerico2 = new Controles.TextBoxNumerico();
            this.labelQuimadh1 = new Controles.LabelQuimadh(this.components);
            this.txtUsuario = new Controles.TextBoxQuimadh();
            this.txtClave = new Controles.TextBoxQuimadh();
            this.labelQuimadh2 = new Controles.LabelQuimadh(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(70, 21);
            this.lblTitulo.Size = new System.Drawing.Size(282, 45);
            this.lblTitulo.Text = "Ingreso al Sistema";
            // 
            // textBoxNumerico1
            // 
            this.textBoxNumerico1.Decimales = 0;
            this.textBoxNumerico1.Enteros = 0;
            this.textBoxNumerico1.EnterTabulacion = true;
            this.textBoxNumerico1.Location = new System.Drawing.Point(0, 0);
            this.textBoxNumerico1.Name = "textBoxNumerico1";
            this.textBoxNumerico1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumerico1.TabIndex = 0;
            this.textBoxNumerico1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNumerico2
            // 
            this.textBoxNumerico2.Decimales = 0;
            this.textBoxNumerico2.Enteros = 0;
            this.textBoxNumerico2.EnterTabulacion = true;
            this.textBoxNumerico2.Location = new System.Drawing.Point(0, 0);
            this.textBoxNumerico2.Name = "textBoxNumerico2";
            this.textBoxNumerico2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumerico2.TabIndex = 0;
            this.textBoxNumerico2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelQuimadh1
            // 
            this.labelQuimadh1.AutoSize = true;
            this.labelQuimadh1.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh1.Location = new System.Drawing.Point(44, 100);
            this.labelQuimadh1.Name = "labelQuimadh1";
            this.labelQuimadh1.Size = new System.Drawing.Size(62, 15);
            this.labelQuimadh1.TabIndex = 1;
            this.labelQuimadh1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(130, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(222, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(130, 140);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '#';
            this.txtClave.Size = new System.Drawing.Size(222, 20);
            this.txtClave.TabIndex = 4;
            this.txtClave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyUp);
            // 
            // labelQuimadh2
            // 
            this.labelQuimadh2.AutoSize = true;
            this.labelQuimadh2.BackColor = System.Drawing.Color.Transparent;
            this.labelQuimadh2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuimadh2.Location = new System.Drawing.Point(44, 143);
            this.labelQuimadh2.Name = "labelQuimadh2";
            this.labelQuimadh2.Size = new System.Drawing.Size(86, 15);
            this.labelQuimadh2.TabIndex = 3;
            this.labelQuimadh2.Text = "Contraseña:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Desktop.Resources.sign_check;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(145, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Desktop.Resources.sign_error;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(244, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 253);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.labelQuimadh2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelQuimadh1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLogin";
            this.Text = "Ingreso al Sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyUp);
            this.Controls.SetChildIndex(this.labelQuimadh1, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.labelQuimadh2, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxNumerico textBoxNumerico1;
        private Controles.TextBoxNumerico textBoxNumerico2;
        private Controles.LabelQuimadh labelQuimadh1;
        private Controles.TextBoxQuimadh txtUsuario;
        private Controles.TextBoxQuimadh txtClave;
        private Controles.LabelQuimadh labelQuimadh2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}

