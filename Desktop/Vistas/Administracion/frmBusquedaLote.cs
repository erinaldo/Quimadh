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
    public partial class frmBusquedaLote : FormBusqueda
    {
        public Lote loteSeleccionado;

        public frmBusquedaLote()
        {
            InitializeComponent();
        }

        protected override void cargar()
        {
            Cargador.cargarArticulos(cboArticulo, "Sin seleccionar");
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
                List<Lote> resultado = Global.Servicio.buscarLotes(tipoArticulo,txtNroLote.Text, numeroRegistros);

                // Listamos los clientes
                foreach (Lote lote in resultado)
                {
                    DateTime fecCierre = new DateTime();
                    if (lote.fechaCierre != null)
                        fecCierre = (DateTime)lote.fechaCierre;

                    string[] datos = new string[] { lote.numero, lote.TipoArticulo.nombre, lote.fechaInicio.ToString("dd/MM/yyyy"), lote.fechaCierre == null ? "" : fecCierre.ToString("dd/MM/yyyy") };
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = lote;
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
                List<Lote> resultado = Global.Servicio.obtenerTodosLotes(1);

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
                    loteSeleccionado = (Lote)tag;

                    this.DialogResult = DialogResult.OK;

                    this.Close();

                    return true;
                }
            }

            Mensaje mensaje = new Mensaje("Debe seleccionar un Lote.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
            mensaje.ShowDialog();

            return false;
        }

        protected override void limpiar()
        {
            base.limpiar();
        }
    }
}
