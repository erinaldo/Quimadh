using Controles;
using Entidades;
using System;
using System.Windows.Forms;

namespace Desktop.Vistas.Ventas
{
    public partial class frmPagos : FormBaseSinToolbar
    {
        private Comprobante_Recibo recibo;        

        public frmPagos(Comprobante_Recibo recibo)
        {
            InitializeComponent();

            this.recibo = recibo;
        }

        private void btnMasTarj_Click(object sender, EventArgs e)
        {
            MostrarFormularioPago(new frmPagosTarjetas());
        }

        private void btnMenosTarj_Click(object sender, EventArgs e)
        {
            EliminarPago(dgvTarj);
        }        

        private void btnMasChq_Click(object sender, EventArgs e)
        {
            MostrarFormularioPago(new frmPagosCheques());
        }

        private void btnMenosChq_Click(object sender, EventArgs e)
        {
            EliminarPago(dgvCheques);
        }

        private void btnMasTransf_Click(object sender, EventArgs e)
        {
            MostrarFormularioPago(new frmPagosTransferencias());
        }

        private void btnMenosTransf_Click(object sender, EventArgs e)
        {
            EliminarPago(dgvTransf);
        }        

        private void MostrarFormularioPago(FormBaseSinToolbar formPago)
        {
            formPago.ShowDialog();

            var pago = (InstrumentoPago)formPago.ObjetoRetorno;
            if (pago != null)
            {
                AgregarPago(pago);
            }
        }

        private void AgregarPago(InstrumentoPago pago)
        {
            var grilla = ObtenerDataGridView(pago.GetType());
            var rowIndex = grilla.Rows.Add();
            grilla.Rows[rowIndex].Tag = pago;

            CargarFilaEnGrilla(grilla, rowIndex);
            recibo.InstrumentoPago.Add(pago);
        }

        private void EliminarPago(DataGridView dataGridView)
        {
            var row = dataGridView.SelectedRows[0];
            var pago = (InstrumentoPago)row.Tag;
            recibo.InstrumentoPago.Remove(pago);
            dataGridView.Rows.Remove(row);
        }

        private DataGridView ObtenerDataGridView(Type type)
        {
            switch (type.Name)
            {
                case nameof(Pago_Cheque):
                    return dgvCheques;
                case nameof(Pago_Transferencia):
                    return dgvTransf;
                case nameof(Pago_Tarjeta):
                    return dgvTarj;
                default:
                    throw new NotSupportedException($"El tipo {type.Name} no está soportado");
            }
        }

        private void CargarFilaEnGrilla(DataGridView grilla, int rowIndex)
        {
            switch (grilla.Name)
            {
                case nameof(dgvCheques):
                    var pagoCheque = (Pago_Cheque)grilla.Rows[rowIndex].Tag;
                    grilla.Rows[rowIndex].Cells["clmChqImporte"].Value = pagoCheque.Importe.ToString("0.00");
                    grilla.Rows[rowIndex].Cells["clmChqNumero"].Value = pagoCheque.Numero;
                    grilla.Rows[rowIndex].Cells["clmChqBanco"].Value = pagoCheque.Banco.Nombre;
                    grilla.Rows[rowIndex].Cells["clmChqCuitLib"].Value = pagoCheque.CuitLibrador;
                    grilla.Rows[rowIndex].Cells["clmChqNombreLib"].Value = pagoCheque.NombreLibrador;
                    grilla.Rows[rowIndex].Cells["clmChqFechaVto"].Value = pagoCheque.FechaVto.ToString("dd/MM/yyyy");
                    grilla.Rows[rowIndex].Cells["clmChqTipo"].Value = pagoCheque.Propio ? "Propio" : "Terceros";
                    grilla.Rows[rowIndex].Cells["clmChqEcheq"].Value = pagoCheque.Electronico ? "SI" : "NO";
                    break;
                case nameof(dgvTransf):
                    var pagoTransf = (Pago_Transferencia)grilla.Rows[rowIndex].Tag;
                    grilla.Rows[rowIndex].Cells["clmTransfImporte"].Value = pagoTransf.Importe.ToString("0.00");
                    grilla.Rows[rowIndex].Cells["clmTransfNro"].Value = pagoTransf.NumeroComprobante;
                    break;
                case nameof(dgvTarj):
                    var pagoTarj = (Pago_Tarjeta)grilla.Rows[rowIndex].Tag;
                    grilla.Rows[rowIndex].Cells["clmTarjImporte"].Value = pagoTarj.Importe.ToString("0.00");
                    grilla.Rows[rowIndex].Cells["clmTarjTipo"].Value = pagoTarj.TipoTarjeta.Descripcion;
                    break;
            }
        }        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
