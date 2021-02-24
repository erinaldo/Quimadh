using Controles;
using Entidades;
using System;

namespace Desktop.Vistas.Ventas
{
    public partial class frmPagosCheques : FormBaseSinToolbar
    {
        public Pago_Cheque PagoCheque { get; set; }

        public frmPagosCheques()
        {
            InitializeComponent();
            Cargador.CargarBancos(cboBanco, " ");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas())
                return;

            PagoCheque = new Pago_Cheque();
            PagoCheque.Importe = decimal.Parse(txtImporte.Text);
            PagoCheque.Numero = int.Parse(txtNumero.Text);
            PagoCheque.CuitLibrador = long.Parse(txtCuitLib.Text);
            PagoCheque.NombreLibrador = txtDescLib.Text;
            PagoCheque.FechaVto = dtpFechaVto.Value;
            PagoCheque.Efectivo = false;
            PagoCheque.Propio = cboTipo.Text == "Propio";
            PagoCheque.Electronico = chkECheq.Checked;
            PagoCheque.Banco = (Banco)((ComboBoxItem)cboBanco.SelectedItem).Value;

            ObjetoRetorno = PagoCheque;
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

            if (txtNumero.Text.Length < 1 || txtNumero.Text.Length > 8)
            {
                var msjErr = new Mensaje("El número de cheque debe ser de entre 1 y 8 dígitos", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            if (cboBanco.SelectedIndex == 0)
            {
                var msjErr = new Mensaje("Debe seleccionar un banco", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            if (txtCuitLib.Text.Length != 11)
            {
                var msjErr = new Mensaje("el Cuit del librador debe ser de 11 dígitos", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            if (string.IsNullOrEmpty(txtDescLib.Text))
            {
                var msjErr = new Mensaje("Debe completar el nombre del librador", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            if (cboTipo.SelectedIndex == -1)
            {
                var msjErr = new Mensaje("Debe seleccionar un tipo", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return false;
            }

            return true;
        }
    }
}
