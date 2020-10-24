using Controles;
using Entidades;
using System;
using System.Data.Entity.Core.Objects;
using System.Windows.Forms;

namespace Desktop.Vistas.Ventas
{
    public partial class frmPagos : FormBaseSinToolbar
    {
        private Comprobante_Recibo _recibo;
        private InstrumentoPago _pagoEfectivo;

        public frmPagos(Comprobante_Recibo recibo)
        {
            InitializeComponent();

            _recibo = recibo;
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            txtTotal.Text = "0.00";
            CargarPagos();
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
            var grilla = ObtenerDataGridView(ObjectContext.GetObjectType(pago.GetType()));
            var rowIndex = grilla.Rows.Add();
            grilla.Rows[rowIndex].Tag = pago;
            CargarFilaEnGrilla(grilla, rowIndex);

            ActualizarTotal(pago, true);
        }

        private void EliminarPago(DataGridView dataGridView)
        {
            var row = EliminarFilaSeleccionada(dataGridView);
            ActualizarTotal((InstrumentoPago)row.Tag, false);
        }

        private void ActualizarTotal(InstrumentoPago pago, bool positivo)
        {
            var importe = decimal.Parse(txtTotal.Text);
            importe += pago.Importe * (positivo ? 1 : -1);
            txtTotal.Text = importe.ToString("0.00");
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
                case nameof(dgvFacturas):
                    var factura = (Comprobante_Factura)grilla.Rows[rowIndex].Tag;
                    grilla.Rows[rowIndex].Cells["clmFactPvNro"].Value = $"{factura.pv:0000}-{factura.numero:00000000}";
                    grilla.Rows[rowIndex].Cells["clmFactTipo"].Value = factura.tipo;                    
                    grilla.Rows[rowIndex].Cells["clmFactFCE"].Value = factura.CE_MiPyme ? "SI" : "NO";
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _recibo.InstrumentoPago.Clear();

            if (_pagoEfectivo != null)
            {
                _recibo.InstrumentoPago.Add(_pagoEfectivo);
            }

            RecorrerGrillaPago(dgvTransf);
            RecorrerGrillaPago(dgvTarj);
            RecorrerGrillaPago(dgvCheques);

            foreach (DataGridViewRow fila in dgvFacturas.Rows)
            {
                var factura = (Comprobante_Factura)fila.Tag;
                _recibo.Comprobante_Factura.Add(factura);
            }

            Close();
        }

        private void RecorrerGrillaPago(DataGridView grilla)
        {
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                var pago = (InstrumentoPago)fila.Tag;
                _recibo.InstrumentoPago.Add(pago);
            }
        }        

        private void CargarPagos()
        {
            foreach (var pago in _recibo.InstrumentoPago)
            {
                if (pago.Efectivo)
                {
                    _pagoEfectivo = pago;
                    txtEfectivo.Text = pago.Importe.ToString("0.00");
                    ActualizarTotal(pago, true);
                }
                else
                {
                    AgregarPago(pago);
                }
            }
        }

        private void txtEfectivo_Leave(object sender, EventArgs e)
        {
            if (_pagoEfectivo == null)
            {
                _pagoEfectivo = new InstrumentoPago();
                _pagoEfectivo.Efectivo = true;
            }
            else
            {
                ActualizarTotal(_pagoEfectivo, false);
            }

            _pagoEfectivo.Importe = decimal.Parse(txtEfectivo.Text);
            ActualizarTotal(_pagoEfectivo, true);
        }

        private void btnMasFact_Click(object sender, EventArgs e)
        {
            var busq = new frmBusquedaComp();
            busq.tipo = "factura";
            busq.ShowDialog();

            var rowIndex = dgvFacturas.Rows.Add();
            dgvFacturas.Rows[rowIndex].Tag = busq.comprobanteSeleccionado;
            CargarFilaEnGrilla(dgvFacturas, rowIndex);            
        }

        private void btnMenosFact_Click(object sender, EventArgs e)
        {
            EliminarFilaSeleccionada(dgvFacturas);
        }

        private DataGridViewRow EliminarFilaSeleccionada(DataGridView grilla)
        {
            var row = grilla.SelectedRows[0];
            grilla.Rows.Remove(row);

            return row;
        }
    }
}
