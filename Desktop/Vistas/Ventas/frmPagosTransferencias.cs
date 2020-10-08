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
            PagoTransferencia = new Pago_Transferencia();
            PagoTransferencia.Efectivo = false;
            PagoTransferencia.Importe = decimal.Parse(txtImporte.Text);
            PagoTransferencia.NumeroComprobante = txtNumero.Text;

            ObjetoRetorno = PagoTransferencia;
            Close();
        }
    }
}
