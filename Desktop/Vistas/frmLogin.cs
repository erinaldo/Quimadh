using Controles;
using Entidades;
using Frontend.Controles;
using ModuloServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Base;
using Desktop.Vistas;
using System.Threading;
using System.Data.Entity.Validation;

namespace Desktop
{
    public partial class frmLogin : FormBaseSinToolbar
    {
        public bool m_bLayoutCalled = false;
        public DateTime m_dt = DateTime.Now;

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(string mostrarAdvertencia)
        {
            InitializeComponent();

            if (mostrarAdvertencia != "")
            {
                if (MessageBox.Show(mostrarAdvertencia, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    Global.Servicio.almacenaArchivosLocales();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }

        private void cerrarFormularioFade()
        {
            int loopctr = 0;

            for (loopctr = 100; loopctr >= 5; loopctr -= 10)
            {
                this.Opacity = loopctr / 95.0;
                this.Refresh();
                Thread.Sleep(100);
            }

            this.Hide();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            SplashScreen.CloseForm();  
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //btnIngresar_Click(null, null);
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuarioAutenticado = Global.Servicio.autenticarUsuario(txtUsuario.Text, Utiles.obtenerHash(txtUsuario.Text + txtClave.Text));

                if (usuarioAutenticado != null)
                {
                    Global.DatosSesion = new Metadata { idUsuario = usuarioAutenticado.id, IP = "" };

                    List<FormularioUsuario> formulariosUsuario = Global.Servicio.obtenerPermisosPorUsuario(usuarioAutenticado.id);

                    Global.Formularios = (from formUsuario in formulariosUsuario
                                          select formUsuario.Formulario).ToList();

                    cerrarFormularioFade();
                    (new frmInicio()).Show();
                    Hide();
                }
                else
                {
                    Thread.Sleep(3000);
                    Mensaje unMensaje = new Mensaje("Nombre de usuario y/o clave incorrectas", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                    unMensaje.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pictureBox1.BackgroundImage = Resources.sign_check_selected;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pictureBox1.BackgroundImage = Resources.sign_check;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            pictureBox2.BackgroundImage = Resources.sign_error_selected;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            pictureBox2.BackgroundImage = Resources.sign_error;
        }

        private void txtClave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pictureBox1_Click(sender, e);
        }

        private void frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIngresar_Click(sender, e);
        }

    }
}
