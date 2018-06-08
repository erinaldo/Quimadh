using Controles;
using Entidades;
using Frontend.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Vistas.Analisis
{
    public partial class frmFirmas : FormBaseConToolbar
    {
        private CabeceraRutinaFirmantes Firmante;

        public frmFirmas()
        {
            InitializeComponent();
        }

        public override void usuarioAutorizado()
        {
            //Seguridad.tienePermisos(this.GetType().Name, Global.Formularios);
        }

        protected override void cargar()
        {
            gpbDatos.Enabled = false;
            txtCodigo.Focus();
        }

        protected override void agregar()
        {
            Firmante = new CabeceraRutinaFirmantes();
            limpiarControles(gpbDatos);
            gpbDatos.Enabled = true;
            txtCodigo.Focus();
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            txtCodigo.Focus();
        }

        protected override bool guardar()
        {
            Firmante.nombre = txtCodigo.Text;
            Firmante.iniciales = txtIniciales.Text;
            Firmante.firma = imageToByteArray(pictureBox1.Image);            

            try
            {
                string cadenaMensaje = "";

                // Guardamos los datos del Muestra
                if (Estado == Estados.Agregar)
                {
                    Firmante = Global.Servicio.agregarFirma(Firmante, Global.DatosSesion);
                    cadenaMensaje = "Firma dada de Alta exitosamente.";
                }
                else
                {
                    Global.Servicio.actualizarFirma(Firmante, Global.DatosSesion);
                    cadenaMensaje = "Firma Modificada con éxito.";
                }

                // Mostramos mensaje de éxito
                Mensaje mensaje = new Mensaje(cadenaMensaje, Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                // Indica que el Muestra se guardó correctamente
                return true;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje;

                unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override bool eliminar()
        {
            if (Firmante != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("La firma de '" + Firmante.nombre + "' será eliminada ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        //se pudo eliminar Muestra físicamente
                        Global.Servicio.eliminarFirma(Firmante, Global.DatosSesion);
                        mensajeExito = new Mensaje("La firma ha sido eliminada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                        mensajeExito.ShowDialog();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();
                    }
                }
            }
            else
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar una Firma.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override void limpiar()
        {
            if (Estado != Estados.Modificar)
            {
                // Limpia los datos del formulario
                limpiarControles(gpbDatos);
            }
            // Limpia los mensajes de error
            //errProvider.Clear();
            // Fija los campos para consulta
            gpbDatos.Enabled = false;
        }

        protected override bool cargarBusqueda()
        {
            frmBusquedaFirmas frmBusquedaFirmas = new frmBusquedaFirmas();
            DialogResult res = frmBusquedaFirmas.ShowDialog();

            if (res == DialogResult.OK)
            {
                Firmante = frmBusquedaFirmas.Firma;
                txtCodigo.Text = Firmante.nombre;
                txtIniciales.Text = Firmante.iniciales;
                pictureBox1.Image = Firmante.firma == null ? null : byteArrayToImage(Firmante.firma);

                return true;
            }

            return false;
        }

        private bool validar()
        {
            return false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
            return null;
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void btnCargaFirma_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imágenes PNG (.png)|*.png|Imágenes JPG (.jpg)|*.jpg|Todos los archivos (*.*)|*.*";
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;    
            }
        }

        private void frmFirmas_Load(object sender, EventArgs e)
        {

        }
    }
}
