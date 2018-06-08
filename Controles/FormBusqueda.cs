using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class FormBusqueda : Form
    {
        // Se utiliza para controlar el ordenamiento ascendente o descendente 
        // por columna del litView
        private int ordenColumna = -1;
        // Por defecto se buscan 10 registros
        private int numeroRegistros = Constantes.NUMERO_REGISTROS_POR_DEFECTO;

        public FormBusqueda()
        {
            usuarioAutorizado();
            InitializeComponent();
            // Por defecto busca 10 items
            cboNumeroRegistros.SelectedItem = "10";// Constantes.NUMERO_REGISTROS_POR_DEFECTO.ToString();
        }

        /// <summary>
        /// Controla el acceso al formulario
        /// </summary>
        public virtual void usuarioAutorizado()
        {
            // Consultar en los datos de la sesión, si el usuario tiene permisos sobre esta pantalla
            // En caso de que no tenga permisos, lanza una excepción.
        }

        /// <summary>
        /// Prepara los campos del formulario. Se utiliza al momento de
        /// mostrar el formulario de búsqueda por primera vez. Este método
        /// se sobreescribe a nivel de formulario.
        /// </summary>
        protected virtual void cargar() { }

        /// <summary>
        /// Lleva a cabo una búsqueda con los valores especificados para cada
        /// uno de los filtros de la pantalla. Se debe implementar a nivel de
        /// formulario heredado.
        /// </summary>
        protected virtual bool buscar(int numeroRegistros, bool esBusquedaInicial = false) { return true; }

        /// <summary>
        /// En caso de que se haya seleccionado, devuelve la entidad
        /// al formulario padre. Se debe implementar a nivel de
        /// formulario heredado.
        /// </summary>
        /// <returns>Verdadero si se seleccionó un registro, falso en caso contrario.</returns>
        protected virtual bool aceptar() { return false; }

        /// <summary>
        /// Realiza un conjunto de acciones correspondientes
        /// al botón cancelar. Por defecto cierra el formulario.
        /// Se puede modificar su comportamiento si se implementa
        /// a nivel de formulario heredado.
        /// </summary>
        protected virtual void cancelar()
        {
            this.Close();
        }

        #region "Métodos Generales"

        /// <summary>
        /// Limpia el contenido de los controles contenidos en el
        /// formulario y limpia la grilla de resultados.
        /// </summary>
        protected virtual void limpiar()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                    {
                        List<object> itemsCollection = new List<object>();

                        foreach (Object obj in (control as ComboBox).Items)
                            itemsCollection.Add(obj);

                        (control as ComboBox).Items.Clear();

                        foreach (Object obj in itemsCollection)
                            (control as ComboBox).Items.Add(obj);
                    }
                    else if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(this.Controls);

            ltvBusqueda.Items.Clear();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Limpiamos la grilla
            ltvBusqueda.Items.Clear();
            // Realizamos la búsqueda
            buscar(this.numeroRegistros);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool esCorrecto = aceptar();

            if (esCorrecto)
                this.DialogResult = DialogResult.OK;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();

            this.DialogResult = DialogResult.Cancel;
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            cargar();
            if (!buscar(this.numeroRegistros, true))
                this.Dispose();
        }

        private void cboNumeroRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nroRegistrosSeleccionado = int.Parse((string)cboNumeroRegistros.SelectedItem);
            if (nroRegistrosSeleccionado != this.numeroRegistros)
            {
                this.numeroRegistros = nroRegistrosSeleccionado;
                ltvBusqueda.Items.Clear();
                buscar(this.numeroRegistros);
            }
        }

        private void ltvBusqueda_ItemActivate(object sender, EventArgs e)
        {
            bool esCorrecto = aceptar();

            if (esCorrecto)
                this.DialogResult = DialogResult.OK;
        }

        private void ltvBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            // Si presionó la tecla ENTER
            if (e.KeyCode == Keys.Enter)
            {
                ltvBusqueda_ItemActivate(sender, e);
                // Suprime el evento de la tecla ENTER
                e.SuppressKeyPress = true;
            }
        }

    }
}
