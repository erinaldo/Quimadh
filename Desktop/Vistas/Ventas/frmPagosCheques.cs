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
            Cargador.CargarBancos(cboBanco);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
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
    }
}
