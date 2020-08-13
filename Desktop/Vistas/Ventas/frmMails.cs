using Controles;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Desktop.Vistas.Ventas
{
    public partial class frmMails : FormBaseSinToolbar
    {
        private Comprobante_Factura _factura;

        public frmMails(Comprobante_Factura factura)
        {
            _factura = factura;
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDest.Text))
            {
                var mensaje = new Mensaje("El destinatario no puede ser vacío", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                return;
            }

            try
            {
                Global.Servicio.EnviarMailFactura(_factura, txtDest.Text, txtCC.Text);
                var mensajeExito = new Mensaje("Factura enviada con éxito", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                mensajeExito.ShowDialog();
            }
            catch(Exception ex)
            {
                var mensajeError = new Mensaje($"Error inesperado al enviar el mail:{ex.Message}", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                mensajeError.ShowDialog();
            }
        }

        private void frmMails_Load(object sender, EventArgs e)
        {
            txtDest.Text = _factura?.Planta.Cliente.email;
            var mails = new List<string>();
            mails.Add(_factura.Planta.emailContac1);
            mails.Add(_factura.Planta.emailContac2);

            txtCC.Text = string.Join(";", mails.Where(x => !string.IsNullOrWhiteSpace(x)));
        }
    }
}
