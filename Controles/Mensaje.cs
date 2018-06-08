using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class Mensaje : Form
    {
        public Mensaje()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este enum define el tipo de mensaje. Utilizaremos:
        /// - Información: para indicar al usuario cuestiones que debe tener en cuenta para seguir.
        /// - Error: para excepciones graves o fallas en base de datos no esperadas.
        /// - Alerta: para indicar que hay errores en las entradas.
        /// - Éxito: para indicar que un proceso finalizó exitosamente.
        /// </summary>
        public enum TipoMensaje { Informacion, Error, Alerta, Exito, Baja, Seguridad };
        public enum Botones { OK, SiNo, SiNoCancelar };
        public String motivoBaja;
        /// <summary>
        /// Los posibles resultados son = { OK, NO, CANCEL }
        /// </summary>
        public DialogResult resultado;

        /// <summary>
        /// Crea el mensaje, del tipo que se necesite y con los botones que se necesiten.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tipoMensaje"></param>
        /// <param name="botones"></param>
        public Mensaje(String texto, TipoMensaje tipoMensaje, Botones botones)
        {
            InitializeComponent();
            rtbMotivoBaja.Visible = false;
            setearTexto(texto);
            habilitarBotones(botones);
            mostrarImagen(tipoMensaje);
        }

        /// <summary>
        /// Este método setea el texto del mensaje, con el que se pasa al constructor como parámetro.
        /// Luego, alinea el texto, con la premisa de contener 4 líneas de 42 caracteres cada una.
        /// El texto debe estar centrado horizontal y verticalmente. Para eso se analiza cómo mostrarlo.
        /// Si el mensaje supera los 4*42 (aprox.) caracteres, aparecerá el scroll.
        /// </summary>
        /// <param name="texto"></param>
        private void setearTexto(String texto)
        {
            int tamanioTexto = texto.Length;
            rtbMensaje.SelectionAlignment = HorizontalAlignment.Left;

            //texto muy corto
            //if (tamanioTexto <= 21)
            //TODO ver achicar cartel
            //else
            //texto corto
            if (tamanioTexto <= 42)
                texto = "\v\v" + texto;
            //texto 2 o 3 líneas
            else if (tamanioTexto > 42 && tamanioTexto <= 126)
                texto = "\v" + texto;
            //texto 4 líneas o más - no hay que modificar nada

            rtbMensaje.Text = texto;
        }

        /// <summary>
        /// Se coloca una imagen descriptiva, según tipo de mensaje.
        /// Además, se coloca el título al Form.
        /// </summary>
        /// <param name="tipoMensaje"></param>
        private void mostrarImagen(TipoMensaje tipoMensaje)
        {
            switch (tipoMensaje)
            {
                case TipoMensaje.Alerta:
                    picImagen.Image = Resources.alerta;
                    this.Text = "Alerta";
                    break;
                case TipoMensaje.Error:
                    picImagen.Image = Resources.error;
                    this.Text = "Error";
                    break;
                case TipoMensaje.Exito:
                    picImagen.Image = Resources.exito;
                    this.Text = "Éxito";
                    break;
                case TipoMensaje.Informacion:
                    picImagen.Image = Resources.informacion;
                    this.Text = "Información";
                    break;
                case TipoMensaje.Baja:
                    picImagen.Image = Resources.alerta;
                    this.Text = "Baja";
                    reacomodarMensajeBaja();
                    break;
                case TipoMensaje.Seguridad:
                    picImagen.Image = Resources.seguridad;
                    this.Text = "Seguridad";
                    break;

            }
        }

        /// <summary>
        /// Cuando se trata de un mensaje de baja, debemos mostrar
        /// el cuadro para ingresar un motivo (opcional)
        /// </summary>
        private void reacomodarMensajeBaja()
        {
            rtbMotivoBaja.Visible = true;
            //ubicación de este cartel 
            rtbMotivoBaja.Location = new Point(89, 68);
            this.Size = new Size(368, 199);
            picImagen.Location = new Point(12, 57);
            btnOk.Location = new Point(104, 136);
            btnNo.Location = new Point(185, 136);
            btnCancelar.Location = new Point(266, 136);
            //la baja debe contener estos dos botones
            btnOk.Location = btnNo.Location;
            btnNo.Location = btnCancelar.Location;
        }

        /// <summary>
        /// Obtener el texto que el usuario ingresa en MotivoBaja
        /// </summary>
        /// <returns></returns>
        public String getMotivoBaja()
        {
            if (motivoBaja != "<<Si lo desea, ingrese un motivo de baja aquí>>")
                return motivoBaja;
            else
                return "";
        }

        /// <summary>
        /// Se habilitan los botones que se reciben como parámetro al
        /// iniciar el Mensaje.
        /// </summary>
        /// <param name="botones"></param>
        private void habilitarBotones(Botones botones)
        {
            switch (botones)
            {
                case Botones.OK:
                    btnOk.Text = "Aceptar";
                    btnOk.Visible = true;
                    btnCancelar.Visible = false;
                    btnNo.Visible = false;
                    //Lo ubico en el centro
                    btnOk.Location = btnNo.Location;
                    break;
                case Botones.SiNo:
                    btnOk.Visible = true;
                    btnCancelar.Visible = false;
                    btnCancelar.Enabled = false;
                    btnNo.Visible = true;
                    //Los ubico
                    btnOk.Location = btnNo.Location;
                    btnNo.Location = btnCancelar.Location;
                    break;
                default:
                    btnOk.Visible = true;
                    btnCancelar.Visible = true;
                    btnNo.Visible = true;
                    break;
            }
        }

        #region Eventos
        /// <summary>
        /// Respuestas a mensajes.
        /// btnOk -> OK
        /// btnNo -> No
        /// btnCancelar -> Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resultado = DialogResult.Cancel;
            this.Dispose();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            resultado = DialogResult.OK;
            motivoBaja = rtbMotivoBaja.Text;
            this.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            resultado = DialogResult.No;
            this.Dispose();
        }

        private void rtbMotivoBaja_Enter(object sender, System.EventArgs e)
        {
            if (rtbMotivoBaja.Text == "<<Si lo desea, ingrese un motivo de baja aquí>>")
                rtbMotivoBaja.Text = string.Empty;
            rtbMotivoBaja.ForeColor = System.Drawing.Color.Black;
        }

        #endregion
    }
}
