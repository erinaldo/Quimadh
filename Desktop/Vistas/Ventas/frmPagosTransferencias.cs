using Controles;
using Entidades;
using System;

namespace Desktop.Vistas.Ventas
{
    public partial class frmPagosTransferencias : FormBaseSinToolbar
    {
        public Pago_Transferencia PagoTransferencia { get; set; }

        public frmPagosTransferencias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas())
                return;

            PagoTransferencia = new Pago_Transferencia();
            PagoTransferencia.Efectivo = false;
            PagoTransferencia.Importe = decimal.Parse(txtImporte.Text);
            PagoTransferencia.NumeroComprobante = txtNumero.Text;

            ObjetoRetorno = PagoTransferencia;
            Close();
        }

        private bool ValidarEntradas()
        {
            if (string.IsNullOrEmpty(txtImporte.Text))
            {
                var msjErr = new Mensaje("Debe completar el importe", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                var msjErr = new Mensaje("Debe completar el número de comprobante", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            return true;
        }
    }
}
