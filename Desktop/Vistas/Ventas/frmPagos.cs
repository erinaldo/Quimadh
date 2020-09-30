using Controles;
using Desktop.Vistas.Administracion;
using Entidades;
using Frontend.Controles;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Desktop.Vistas.Ventas
{
    public partial class frmPagos : FormBaseSinToolbar
    {
        private Comprobante_Recibo recibo;
        private Cliente cliente;

        public frmPagos()
        {
            InitializeComponent();
        }

        private void btnMasTarj_Click(object sender, EventArgs e)
        {
            var form = new frmPagosTarjetas();
            form.ShowDialog();

            //
        }

        private void btnMenosTarj_Click(object sender, EventArgs e)
        {

        }        

        private void btnMasChq_Click(object sender, EventArgs e)
        {
            var form = new frmPagosCheques();
            form.ShowDialog();

            var pagoCheque = form.Pago_Cheque;
            if (pagoCheque != null)
            {
                var rowIndex = dgvCheques.Rows.Add();
                dgvCheques.Rows[rowIndex].Tag = pagoCheque;
                dgvCheques.Rows[rowIndex].Cells["clmChqImporte"].Value = pagoCheque.Importe.ToString("0.00");
                dgvCheques.Rows[rowIndex].Cells["clmChqNumero"].Value = pagoCheque.Numero;
                dgvCheques.Rows[rowIndex].Cells["clmChqCuitLib"].Value = pagoCheque.CuitLibrador;
                dgvCheques.Rows[rowIndex].Cells["clmChqNombreLib"].Value = pagoCheque.NombreLibrador;
                dgvCheques.Rows[rowIndex].Cells["clmChqFechaVto"].Value = pagoCheque.FechaVto.ToString("dd/MM/yyyy");
                dgvCheques.Rows[rowIndex].Cells["clmChqTipo"].Value = pagoCheque.Propio ? "Propio" : "Terceros";
                dgvCheques.Rows[rowIndex].Cells["clmChqEcheq"].Value = pagoCheque.Electronico ? "SI" : "NO";
                recibo.InstrumentoPago.Add(pagoCheque);
            }
        }

        private void btnMenosChq_Click(object sender, EventArgs e)
        {
            var row = dgvCheques.SelectedRows[0];
            var cheque = (Pago_Cheque)row.Tag;
            recibo.InstrumentoPago.Remove(cheque);
            dgvCheques.Rows.Remove(row);
        }

        private void btnMasTransf_Click(object sender, EventArgs e)
        {
            var form = new frmPagosTransferencias();
            form.ShowDialog();
        }

        private void btnMenosTransf_Click(object sender, EventArgs e)
        {

        }
    }
}
