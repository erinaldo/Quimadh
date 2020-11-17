using Controles;
using Entidades;
using System;
using System.Data.Entity.Core.Objects;
using System.Windows.Forms;

namespace Desktop.Vistas.Ventas
{
    public partial class frmPagos : FormBaseSinToolbar
    {
        private readonly Comprobante_Recibo _recibo;
        private readonly Cliente _cliente;
        private InstrumentoPago _pagoEfectivo;

        public frmPagos(Comprobante_Recibo recibo, Cliente cliente)
        {
            InitializeComponent();

            _recibo = recibo;
            _cliente = cliente;
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            txtTotal.Text = "0.00";
            txtTotalFact.Text = "0.00";
            lblTituloRecibo.Text += $" {_recibo.numero.ToString("00000000")} - {_cliente.razonSocial}";
            txtRetenciones.Text = _recibo.Retenciones?.ToString() ?? "0.00";
            CargarDatos();

            var totalPagos = decimal.Parse(txtTotal.Text) + _recibo.Retenciones;
            var totalFact = decimal.Parse(txtTotalFact.Text);

            if (totalFact == 0)
                txtTipoRecibo.Text = "A cuenta";
            else if (totalFact > totalPagos)
                txtTipoRecibo.Text = "Parcial";
            else
                txtTipoRecibo.Text = "Total";
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

        private void ActualizarTotalFactura(Comprobante_Factura factura, bool positivo)
        {
            var importe = decimal.Parse(txtTotalFact.Text);
            importe += factura.importe * (positivo ? 1 : -1);
            txtTotalFact.Text = importe.ToString("0.00");
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
            if (decimal.Parse(txtTotal.Text) != _recibo.importe)
            {
                var msjErr = new Mensaje("El importe total debe coincidir con el importe del recibo", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                msjErr.ShowDialog();
                return;
            }

            _recibo.InstrumentoPago.Clear();
            _recibo.Retenciones = decimal.Parse(string.IsNullOrEmpty(txtRetenciones.Text) ? "0" : txtRetenciones.Text);

            if (_pagoEfectivo != null && _pagoEfectivo.Importe > 0)
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

        private void CargarDatos()
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

            foreach (var factura in _recibo.Comprobante_Factura)
            {
                AgregarFactura(factura);
            }
        }

        private void txtEfectivo_Leave(object sender, EventArgs e)
        {
            var importe = string.IsNullOrEmpty(txtEfectivo.Text) ? 0 : decimal.Parse(txtEfectivo.Text);

            if (_pagoEfectivo == null)
            {
                _pagoEfectivo = new InstrumentoPago();
                _pagoEfectivo.Efectivo = true;
            }
            else
            {
                //resto el total
                ActualizarTotal(_pagoEfectivo, false);
            }

            _pagoEfectivo.Importe = importe;
            //sumo el nuevo total
            ActualizarTotal(_pagoEfectivo, true);
        }

        private void btnMasFact_Click(object sender, EventArgs e)
        {
            var busq = new frmBusquedaComp();
            busq.Tipo = "factura";
            busq.Cliente = _cliente;
            busq.ShowDialog();
            if (busq.comprobanteSeleccionado != null)
            {
                AgregarFactura((Comprobante_Factura)busq.comprobanteSeleccionado);
            }
        }

        private void btnMenosFact_Click(object sender, EventArgs e)
        {
            var row = EliminarFilaSeleccionada(dgvFacturas);
            ActualizarTotalFactura((Comprobante_Factura)row.Tag, false);
        }

        private void AgregarFactura(Comprobante_Factura factura)
        {
            var rowIndex = dgvFacturas.Rows.Add();
            dgvFacturas.Rows[rowIndex].Tag = factura;
            CargarFilaEnGrilla(dgvFacturas, rowIndex);

            ActualizarTotalFactura(factura, true);
        }

        private DataGridViewRow EliminarFilaSeleccionada(DataGridView grilla)
        {
            var row = grilla.SelectedRows[0];
            grilla.Rows.Remove(row);

            return row;
        }
    }
}
