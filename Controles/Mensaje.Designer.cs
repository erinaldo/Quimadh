namespace Controles
{
    partial class Mensaje
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
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.rtbMotivoBaja = new System.Windows.Forms.RichTextBox();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagen
            // 
            this.picImagen.InitialImage = null;
            this.picImagen.Location = new System.Drawing.Point(30, 31);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(61, 61);
            this.picImagen.TabIndex = 5;
            this.picImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(270, 119);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(189, 119);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 7;
            this.btnNo.Text = "&No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(108, 119);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&Si";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rtbMotivoBaja
            // 
            this.rtbMotivoBaja.Location = new System.Drawing.Point(120, 31);
            this.rtbMotivoBaja.Name = "rtbMotivoBaja";
            this.rtbMotivoBaja.Size = new System.Drawing.Size(253, 67);
            this.rtbMotivoBaja.TabIndex = 9;
            this.rtbMotivoBaja.Text = "";
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbMensaje.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rtbMensaje.Location = new System.Drawing.Point(120, 31);
            this.rtbMensaje.MaxLength = 0;
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.ReadOnly = true;
            this.rtbMensaje.Size = new System.Drawing.Size(261, 64);
            this.rtbMensaje.TabIndex = 10;
            this.rtbMensaje.Text = "";
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 153);
            this.Controls.Add(this.rtbMotivoBaja);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.rtbMensaje);
            this.Name = "Mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RichTextBox rtbMotivoBaja;
        private System.Windows.Forms.RichTextBox rtbMensaje;
    }
}