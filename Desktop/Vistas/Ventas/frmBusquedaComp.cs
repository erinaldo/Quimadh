using Controles;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Desktop.Vistas.Ventas
{
    public partial class frmBusquedaComp : FormBusqueda
    {
        public Comprobante comprobanteSeleccionado;
        public string Tipo { get; set; }
        public Cliente Cliente { get; set; }

        public frmBusquedaComp()
        {
            InitializeComponent();
        }

        protected override bool buscar(int numeroRegistros, bool esBusquedaInicial)
        {
            if (cboPv.Items.Count == 0)
            {
                Cargador.cargarPuntosVta(cboPv, Tipo);
                if (Tipo == "factura" || Tipo.Substring(0,4) == "nota")
                    cboPv.SelectedIndex = cboPv.FindStringExact("3"); 
            }
            
            if (Cliente != null)
            {
                txtNomCliente.Text = Cliente.razonSocial;
            }

            // Obtenemos los datos de búsqueda
            string codPlanta = txtCodPlanta.Text.Trim();
            string nomPlanta = txtNomPlanta.Text.Trim();
            string nomCliente = txtNomCliente.Text.Trim();
            long numComp=0; 
            if (txtNroComp.Text != "")
                numComp = long.Parse(txtNroComp.Text);

            //Si en la apertura del frm no existen entidades para mostrar,
            //no debe mostrarse el frm.
            if (esBusquedaInicial && !existenEntidades())
            {
                Mensaje mensaje = new Mensaje("No existen datos cargados para la entidad.", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                return false;
            }

            try
            {
                // Obtenemos el resultado                
                List<Comprobante> resultado = Global.Servicio.buscarComprobantes(codPlanta, nomPlanta, numComp, Tipo, int.Parse(cboPv.Text), nomCliente, numeroRegistros);

                // Listamos los clientes
                foreach (Comprobante comp in resultado)
                {
                    long numero;
                    string tipoF;
                    switch (Tipo)
                    {
                        case "factura":
                            numero = ((Comprobante_Factura)comp).numero;
                            tipoF = ((Comprobante_Factura)comp).tipo;
                            break;
                        case "remito":
                            numero = ((Comprobante_Remito)comp).numero;
                            tipoF = "R";
                            break;
                        case "recibo":
                            numero = ((Comprobante_Recibo)comp).numero;
                            tipoF = "X";
                            break;
                        case "notaCredito":
                            numero = ((Comprobante_Devolucion)comp).numero;
                            tipoF = ((Comprobante_Devolucion)comp).tipo;
                            break;
                        default:
                            numero = ((Comprobante_Recargo)comp).numero;
                            tipoF = ((Comprobante_Recargo)comp).tipo;
                            break;
                    }
                    string[] datos = new string[] { comp.fechaIngreso.ToString("dd/MM/yyyy"), numero.ToString(), comp.Planta.Cliente.razonSocial, comp.importe.ToString("0.00"), tipoF, comp.CE_MiPyme ? "SI" : "NO", ((bool)comp.anulado) ? "Anulado" : "Vigente" };
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = comp;
                    ltvBusqueda.Items.Add(item);
                }

                if (resultado.Count <= 0 && !esBusquedaInicial)
                {
                    Mensaje mensaje = new Mensaje("Sin resultados.", Mensaje.TipoMensaje.Informacion, Mensaje.Botones.OK);
                    mensaje.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return true;
        }

        private bool existenEntidades()
        {
            try
            {
                int cant;
                switch (Tipo)
                {
                    case "factura":
                        cant=  Global.Servicio.obtenerTodosComprobantesFact(1).Count();
                        break;
                    case "remito":
                        cant = Global.Servicio.obtenerTodosComprobantesRem(1).Count();
                        break;
                    case "recibo":
                        cant = Global.Servicio.ObtenerTodosComprobantesRec(1).Count();
                        break;
                    case "notaCredito":
                        cant = Global.Servicio.obtenerTodosComprobantesNC(1).Count();
                        break;
                    default:
                        cant = Global.Servicio.obtenerTodosComprobantesND(1).Count();
                        break;
                }
                
                return (cant > 0);
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override bool aceptar()
        {
            // Si seleccionó al menos un cliente
            if (ltvBusqueda.SelectedItems.Count > 0)
            {
                object tag = ltvBusqueda.SelectedItems[0].Tag;

                if (tag != null)
                {
                    comprobanteSeleccionado = (Comprobante)tag;

                    this.DialogResult = DialogResult.OK;

                    this.Close();

                    return true;
                }
            }

            Mensaje mensaje = new Mensaje("Debe seleccionar un Cliente.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
            mensaje.ShowDialog();

            return false;
        }
    }
}
