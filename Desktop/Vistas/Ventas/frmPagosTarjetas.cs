using Controles;
using Entidades;
using System;

namespace Desktop.Vistas.Ventas
{
    public partial class frmPagosTarjetas : FormBaseSinToolbar
    {
        public Pago_Tarjeta PagoTarjeta { get; set; }

        public frmPagosTarjetas()
        {
            InitializeComponent();
        }

        private void frmPagosTarjetas_Load(object sender, EventArgs e)
        {
            Cargador.CargarTiposTarjeta(cboTipo, " ");
            Cargador.CargarMarcasTarjeta(cboMarca, " ");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas())
                return;

            PagoTarjeta = new Pago_Tarjeta();
            PagoTarjeta.Efectivo = false;
            PagoTarjeta.Importe = decimal.Parse(txtImporte.Text);
            PagoTarjeta.TipoTarjeta = (TipoTarjeta)((ComboBoxItem)cboTipo.SelectedItem).Value;
            PagoTarjeta.MarcaTarjeta = (MarcaTarjeta)((ComboBoxItem)cboMarca.SelectedItem).Value;

            ObjetoRetorno = PagoTarjeta;
            Close();
        }

        private bool ValidarEntradas()
        {
            if (cboTipo.SelectedIndex == 0)
            {
                var msjErr = new Mensaje("Debe seleccionar un tipo", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            if (cboMarca.SelectedIndex == 0)
            {
                var msjErr = new Mensaje("Debe seleccionar una marca", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txtImporte.Text))
            {
                var msjErr = new Mensaje("Debe completar el importe", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            return true;
        }
    }
}
