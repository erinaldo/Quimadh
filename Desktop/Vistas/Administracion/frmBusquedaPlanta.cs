using Base;
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
    public partial class frmBusquedaPlanta : FormBusqueda
    {
        public Planta plantaSeleccionada;
        public Cliente cliente;

        public frmBusquedaPlanta()
        {
            InitializeComponent();
        }

        protected override bool buscar(int numeroRegistros, bool esBusquedaInicial)
        {
            // Obtenemos los datos de búsqueda
            string codigo = txtCodigo.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            
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
                List<Planta> resultado = Global.Servicio.buscarPlantas(codigo, nombre, cliente, numeroRegistros);

                // Listamos los clientes
                foreach (Planta pla in resultado)
                {
                    string[] datos = new string[] { pla.id.ToString(), pla.codigo, pla.nombre };
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = pla;
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
                List<Planta> resultado = Global.Servicio.obtenerTodosPlanta();

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
                    plantaSeleccionada = (Planta)tag;

                    this.DialogResult = DialogResult.OK;

                    this.Close();

                    return true;
                }
            }

            Mensaje mensaje = new Mensaje("Debe seleccionar una Planta.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
            mensaje.ShowDialog();

            return false;
        }

        protected override void limpiar()
        {
            base.limpiar();
        }
    }
}
