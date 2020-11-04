using Controles;
using Entidades;
using System;
using System.Data;
using System.Linq;

namespace Desktop.Vistas.Ventas
{
    public partial class frmRelPagosFacturas : FormBaseSinToolbar
    {
        private Cliente _cliente;

        public frmRelPagosFacturas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvRecibos.Rows.Clear();
            var recibos = Global.Servicio.BuscarRecibos(_cliente?.id, dtpFechaDesde.Value, dtpFechaHasta.Value);

            foreach (var recibo in recibos)
            {
                var rowIndex = dgvRecibos.Rows.Add();
                dgvRecibos.Rows[rowIndex].Cells["clmFecha"].Value = recibo.fechaIngreso.ToString("dd/MM/yyyy");
                dgvRecibos.Rows[rowIndex].Cells["clmCliente"].Value = recibo.Planta.Cliente.razonSocial;
                dgvRecibos.Rows[rowIndex].Cells["clmNroRecibo"].Value = recibo.numero;
                var facturas = recibo.Comprobante_Factura.Select(x => x.pv.ToString("0000") + x.numero.ToString("00000000") + "-" + x.tipo + "-" + (x.CE_MiPyme ? "FCE" : ""));
                dgvRecibos.Rows[rowIndex].Cells["clmFact"].Value = string.Join(" | ", facturas);
                dgvRecibos.Rows[rowIndex].Cells["clmImpEf"].Value = recibo.InstrumentoPago.Where(x => x.Efectivo).Sum(x => x.Importe).ToString("0.00");
                dgvRecibos.Rows[rowIndex].Cells["clmImpTransf"].Value = recibo.InstrumentoPago.OfType<Pago_Transferencia>().Sum(x => x.Importe).ToString("0.00");
                dgvRecibos.Rows[rowIndex].Cells["clmImpTC"].Value = recibo.InstrumentoPago.OfType<Pago_Tarjeta>().Where(x => x.IdTipoTarjeta == 2).Sum(x => x.Importe).ToString("0.00");
                dgvRecibos.Rows[rowIndex].Cells["clmImpTD"].Value = recibo.InstrumentoPago.OfType<Pago_Tarjeta>().Where(x => x.IdTipoTarjeta == 1).Sum(x => x.Importe).ToString("0.00");                
                dgvRecibos.Rows[rowIndex].Cells["clmImpChe"].Value = recibo.InstrumentoPago.OfType<Pago_Cheque>().Sum(x => x.Importe).ToString("0.00");
            }
        }
    }
}
