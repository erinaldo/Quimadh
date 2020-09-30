using Controles;
using Entidades;
using System;

namespace Desktop.Vistas.Ventas
{
    public partial class frmPagosCheques : FormBaseSinToolbar
    {
        public Pago_Cheque Pago_Cheque { get; set; }

        public frmPagosCheques()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pago_Cheque = new Pago_Cheque();
            Pago_Cheque.Importe = decimal.Parse(txtImporte.Text);
            Pago_Cheque.CuitLibrador = long.Parse(txtCuitLib.Text);
            Pago_Cheque.NombreLibrador = txtDescLib.Text;
            Pago_Cheque.FechaVto = dtpFechaVto.Value;
            Pago_Cheque.Efectivo = false;
            Pago_Cheque.Propio = cboTipo.Text == "Propio";
            Pago_Cheque.Electronico = chkECheq.Checked;
        }
    }
}
