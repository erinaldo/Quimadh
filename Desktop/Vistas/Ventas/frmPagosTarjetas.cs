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
    public partial class frmPagosTarjetas : FormBaseSinToolbar
    {
        public Pago_Tarjeta PagoTarjeta { get; set; }

        public frmPagosTarjetas()
        {
            InitializeComponent();
        }

        private void frmPagosTarjetas_Load(object sender, EventArgs e)
        {
            Cargador.CargarTiposTarjeta(cboTipo, "", -1);
            Cargador.CargarMarcasTarjeta(cboMarca, "", -1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PagoTarjeta = new Pago_Tarjeta();
            PagoTarjeta.Efectivo = false;
            PagoTarjeta.Importe = decimal.Parse(txtImporte.Text);
            PagoTarjeta.TipoTarjeta = (TipoTarjeta)((ComboBoxItem)cboTipo.SelectedItem).Value;
            PagoTarjeta.MarcaTarjeta = (MarcaTarjeta)((ComboBoxItem)cboMarca.SelectedItem).Value;

            ObjetoRetorno = PagoTarjeta;
            Close();
        }        
    }
}
