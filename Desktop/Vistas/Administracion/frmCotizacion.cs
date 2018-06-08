using Controles;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Vistas.Administracion
{
    public partial class frmCotizacion : FormBaseSinToolbar
    {
        public frmCotizacion()
        {
            InitializeComponent();

            Cargador.cargarMonedas(cboMoneda);
            cboMoneda.SelectedIndex = 0;            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Moneda mon = (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value;
            if (mon.id == 0)
            {
                (new Mensaje("No se puede editar la cotización de la moneda local", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK)).ShowDialog();
                return;
            }

            Global.Servicio.actualizarCotizacionMoneda(mon.id, decimal.Parse(txtCotizacionNueva.Text));
            (new Mensaje("Cotizacion modificada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK)).ShowDialog();
            this.Close();
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Moneda mon = (Moneda)((ComboBoxItem)cboMoneda.SelectedItem).Value;
            txtCotizacionPrevia.Text = "" + Global.Servicio.obtenerCotizacionMoneda(mon.id);
        }
    }
}
