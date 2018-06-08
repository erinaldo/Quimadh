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

namespace Desktop.Vistas.Administracion
{
    public partial class frmBusquedaEntrada : FormBusqueda
    {
        public Entrada entradaSeleccionada;
        private Boolean cargaRealizada;
        
        public frmBusquedaEntrada()
        {
            InitializeComponent();
            cargaRealizada = false;
        }

        protected override void cargar()
        {
            if (!cargaRealizada)
            {
                Cargador.cargarArticulos(cboArticulo, "Sin seleccionar");
                cargaRealizada = true;
            }            
        }

        protected override bool buscar(int numeroRegistros, bool esBusquedaInicial)
        {
            // Obtenemos los datos de búsqueda
            TipoArticulo tipoArticulo = cboArticulo.SelectedItem != null && !cboArticulo.SelectedItem.ToString().Equals("Sin especificar") ? ((TipoArticulo)((ComboBoxItem)cboArticulo.SelectedItem).Value) : null;
            
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
                List<Entrada> resultado = Global.Servicio.buscarEntradas(tipoArticulo, dtpFechaD.Value, dtpFechaH.Value, numeroRegistros);
                ltvBusqueda.Items.Clear();
                // Listamos los clientes
                foreach (Entrada ent in resultado)
                {
                    string[] datos = new string[] { ent.Lote.TipoArticulo.nombre, ent.cantidad.ToString(), "x " + ent.Presentacion.litrosEnvase.ToString(), ent.nroLote, ent.fecha.ToString("dd/MM/yyyy") };
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = ent;
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
                List<Entrada> resultado = Global.Servicio.obtenerTodosEntradas(1);

                return (resultado.Count > 0);
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
                    entradaSeleccionada = (Entrada)tag;

                    this.DialogResult = DialogResult.OK;

                    this.Hide();

                    return true;
                }
            }

            Mensaje mensaje = new Mensaje("Debe seleccionar una Entrada.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
            mensaje.ShowDialog();

            return false;
        }

        protected override void limpiar()
        {
            base.limpiar();
        }
    }
}
