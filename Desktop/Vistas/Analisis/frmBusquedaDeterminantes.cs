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

namespace Desktop.Vistas.Analisis
{
    public partial class frmBusquedaDeterminantes : FormBusqueda
    {
        public Determinante Determinante { get; set; }

        public frmBusquedaDeterminantes()
        {
            InitializeComponent();
        }

        protected override void cargar()
        {
            txtNombre.Focus();
        }

        protected override bool buscar(int numeroRegistros, bool esBusquedaInicial)
        {
            // Obtenemos los datos de búsqueda
            string nombre = txtNombre.Text.Trim();
            string unidad = txtUnidad.Text.Trim();

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
                List<Determinante> resultado = Global.Servicio.buscarDeterminantes(nombre, unidad, numeroRegistros);

                // Listamos los clientes
                foreach (Determinante det in resultado)
                {
                    string[] datos = new string[] { det.id.ToString(), det.nombre, det.unidad };
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = det;
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

        ///// <summary>
        ///// Cuando iniciamos el frm, comprueba que existan entidades cargadas para mostrar.
        ///// Para eso, se utiliza este método.
        ///// </summary>
        ///// <returns></returns>
        private bool existenEntidades()
        {
            try
            {
                List<Determinante> resultado = Global.Servicio.obtenerTodosDeterminante(1);

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
                    Determinante = (Determinante)tag;

                    this.DialogResult = DialogResult.OK;

                    this.Close();

                    return true;
                }
            }

            Mensaje mensaje = new Mensaje("Debe seleccionar un Determinante.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
            mensaje.ShowDialog();

            return false;
        }

        protected override void limpiar()
        {
            base.limpiar();
        }
    }
}
