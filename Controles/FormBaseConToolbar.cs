using Controles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Frontend.Controles
{
    public partial class FormBaseConToolbar : Form
    {
        public ToolStrip tlbHerramientas;
        public ToolStripButton btnAgregar;
        public ToolStripButton btnBuscar;
        public ToolStripSeparator toolStripSeparator2;
        public ToolStripButton btnModificar;
        public ToolStripButton btnGuardar;
        public ToolStripButton btnCancelar;
        public ToolStripSeparator toolStripSeparator1;
        public ToolStripButton btnEliminar;
        public ToolStripButton btnImprimir;
        public Label lblTitulo;
        public ToolStripButton btnPrimero;
        public ToolStripButton btnAnterior;
        public ToolStripButton btnSiguiente;
        public ToolStripButton btnUltimo;
        public ToolStripSeparator toolStripSeparator3;
        public ToolStripButton btnRutinasPendientes;
        public ToolStripButton btnGraficar;
        private ToolStripSeparator toolStripButton8;
        // Estos serán los estados de un formulario
        public enum Estados { Esperar, Agregar, Modificar, Consultar };
        // Estado actual del formulario
        protected Estados Estado { get; set; }
        // Binding Source asociado al formulario
        protected BindingSource BindingSourceLocal { get; set; }

        public FormBaseConToolbar()
        {
            usuarioAutorizado();
            InitializeComponent();
            Text = lblTitulo.Text;
            cambiarEstado(Estados.Esperar);            
        }

        /// <summary>
        /// Controla el acceso al formulario
        /// </summary>
        public virtual void usuarioAutorizado()
        {
            // Consultar en los datos de la sesión, si el usuario tiene permisos sobre esta pantalla
            // En caso de que no tenga permisos, lanza una excepción.
        }

        public void cambiarEstado(Estados estadoNuevo)
        {
            Estado = estadoNuevo;

            switch (estadoNuevo)
            {
                // En el estado agregar, sólo se deben habilitar los botones
                // grabar y cancelar
                case Estados.Agregar:
                    estadosBotonesToolbar(false, false, false, true, true, false, false);
                    break;

                // En el estado consultar, sólo se deben habilitar los botones
                // agregar, modificar, buscar, eliminar, imprimir
                case Estados.Consultar:
                    estadosBotonesToolbar(true, true, true, false, false, true, true);
                    break;

                // En el estado esperar, sólo se deben habilitar los botones
                // agregar, modificar, buscar, eliminar, imprimir
                case Estados.Esperar:
                    estadosBotonesToolbar(true, true, false, false, false, false, false);
                    break;

                // En el estado modificar, sólo se deben habilitar los botones
                // grabar y cancelar
                case Estados.Modificar:
                    estadosBotonesToolbar(false, false, false, true, true, false, false);
                    break;
            }
        }

        /// <summary>
        /// Setea los botones de la toolbar, según el estado del formulario,
        /// en habilitados/deshabilitados.
        /// </summary>
        /// <param name="agregar"></param>
        /// <param name="buscar"></param>
        /// <param name="modificar"></param>
        /// <param name="guardar"></param>
        /// <param name="cancelar"></param>
        /// <param name="eliminar"></param>
        /// <param name="imprimir"></param>
        protected void estadosBotonesToolbar(bool agregar, bool buscar, bool modificar, bool guardar, bool cancelar, bool eliminar, bool imprimir)
        {
            btnAgregar.Enabled = agregar;
            btnBuscar.Enabled = buscar;
            btnCancelar.Enabled = cancelar;
            btnEliminar.Enabled = eliminar;
            btnGuardar.Enabled = guardar;
            btnImprimir.Enabled = imprimir;
            //btnGraficar.Enabled = imprimir;
            btnModificar.Enabled = modificar;
        }


        /// <summary>
        /// Prepara los campos del formulario. Se utiliza al momento de
        /// mostrar el formulario por primera vez. Este método se 
        /// sobreescribe a nivel de formulario.
        /// </summary>
        protected virtual void cargar() { }

        /// <summary>
        /// Prepara los campos del formulario para permitir
        /// dar de alta una entidad. Este método se sobreescribe a
        /// nivel de formulario.
        /// </summary>
        protected virtual void agregar() { }

        /// <summary>
        /// Prepara los campos del formulario para mostrar los datos de
        /// la entidad a modificar. Este método se sobreescribe a
        /// nivel de formulario.
        /// </summary>
        protected virtual void modificar() { }

        /// <summary>
        /// Lleva a cabo las acciones iniciales para guardar los
        /// cambios realizados a una entidad. Este método se 
        /// sobreescribe a nivel de formulario.
        /// </summary>
        protected virtual bool guardar() { return false; }

        /// <summary>
        /// Elimina una entidad del sistema. Este método se
        /// sobreescribe a nivel de formulario.
        /// </summary>
        protected virtual bool eliminar() { return false; }

        /// <summary>
        /// Limpia el contenido del formulario, estableciendo
        /// los controles a su estado inicial.
        /// </summary>
        protected virtual void limpiar() { }

        /// <summary>
        /// Lleva a cabo las acciones para cargar el formulario
        /// de búsqueda de entidades. Este método se sobreescribe
        /// a nivel de formulario.
        /// </summary>
        protected virtual bool cargarBusqueda() { return false; }

        /// <summary>
        /// Ejecuta la funcionalidad de imprimir. El reporte
        /// a generar se debe implementar de manera local
        /// al área del formulario.
        /// </summary>
        protected virtual void imprimir() { }

        /// <summary>
        /// Ejecuta la funcionalidad de graficar. El reporte
        /// a generar se debe implementar de manera local
        /// al área del formulario.
        /// </summary>
        protected virtual void Graficar() { }

        /// <summary>
        /// Prepara el formulario para la consulta de una entidad
        /// en particular. 
        /// </summary>
        protected virtual void consultar() { }

        /// <summary>
        /// Ejecuta acciones previo a cancelar. 
        /// </summary>
        protected virtual void cancelar() { }

        protected virtual void Primero() { }

        protected virtual void Anterior() { }

        protected virtual void Siguiente() { }

        protected virtual void Ultimo() { }

        protected virtual void GuardarRutinasPendientes() { }

        #region "Eventos"

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cambiarEstado(Estados.Agregar);
            agregar();
            BindingSourceLocal.ResumeBinding();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cambiarEstado(Estados.Modificar);
            BindingSourceLocal.ResumeBinding();
            modificar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmBaseGrande_Load(object sender, EventArgs e)
        {
            setearControles();
            cargar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void frmBaseGrande_KeyDown(object sender, KeyEventArgs e)
        {
            Control nextControl;

            //Si el Parent es un textBoxNumerico y ademas posee EnterTabulacion = False no entrará.
            if (ActiveControl != null && (!(ActiveControl.Parent is TextBoxNumerico) || ((TextBoxNumerico)ActiveControl.Parent).EnterTabulacion))
                // Si presionó la tecla ENTER
                if (e.KeyCode == Keys.Enter)
                {
                    // Obtiene el siguiente control y aplica el foco sobre el mismo
                    nextControl = GetNextControl(ActiveControl, !e.Shift);

                    while (nextControl == null || !(nextControl is TextBox || nextControl is MaskedTextBox || nextControl is RichTextBox || nextControl is ComboBox || nextControl is CheckBox || nextControl is RadioButton) || !nextControl.Enabled)
                        nextControl = GetNextControl(nextControl, true);

                    nextControl.Focus();

                    // Suprime el evento de la tecla ENTER
                    e.SuppressKeyPress = true;
                }
        }

        #endregion

        #region "Métodos Auxiliares"

        /// <summary>
        /// Obtiene el miembro asociado al control que se especifica,
        /// correspondiente al primer data binding.
        /// </summary>
        /// <param name="control">Control del cual se obtendrá el miembro.</param>
        /// <returns>Nombre del miembro.</returns>
        protected string obtenerMiembro(Control control)
        {
            if (control.DataBindings.Count > 0)
                return control.DataBindings[0].BindingMemberInfo.BindingMember;
            else
                return null;
        }

        /// <summary>
        /// Deshabilita todos los controles
        /// de un formulario (los gpb que encuentre en él)
        /// </summary>
        /// <param name="contenedor"></param>
        protected void deshabilitar(Control contenedor)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is GroupBox)
                        (control as GroupBox).Enabled = false;
                    else if (control is Panel)
                        func(control.Controls);
                    else if (control is DataGridView)
                        (control as DataGridView).Enabled = false;
            };

            if (contenedor != null)
            {
                func(contenedor.Controls);
            }
        }

        /// <summary>
        /// Limpia el contenido de los controles contenidos en el
        /// control que se pasa como parámetro.
        /// </summary>
        protected void limpiarControles(Control contenedor)
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
                    else if (control is RichTextBox)
                        (control as RichTextBox).Clear();
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Today;
                    else if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    else if (control is DataGridView)
                        (control as DataGridView).Rows.Clear();
                    else
                        func(control.Controls);
            };

            if (contenedor != null)
            {
                func(contenedor.Controls);
            }
        }

        /// <summary>
        /// Quita los espacios en blanco al comienzo y al final del texto
        /// de cada una de las cajas de texto contenidas en el formulario.
        /// </summary>
        protected void trimControles()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                        ((TextBox)control).Text = ((TextBox)control).Text.Trim();
                    else if (control is MaskedTextBox)
                        ((MaskedTextBox)control).Text = ((MaskedTextBox)control).Text.Trim();

                    if (control is GroupBox || control is Panel)
                        func(control.Controls);
                }
            };

            func(this.Controls);
        }

        /// <summary>
        /// Establece los valores por defecto para los controles del formulario.
        /// </summary>
        protected void setearControles()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is DateTimePicker)
                    {
                        //(control as DateTimePicker).ValueNullable = null;
                        (control as DateTimePicker).CustomFormat = " ";
                        //(control as DateTimePicker).CustomNullText = " ";
                    }

                    if (control is GroupBox || control is Panel)
                        func(control.Controls);
                }
            };

            func(this.Controls);
        }

        /// <summary>
        /// Agregamos un botón en la toolbar,
        /// cuyo evento se maneja en el hijo
        /// </summary>
        public ToolStripButton agregarBotonAToolbar(Image imagen, String nombre)
        {
            ToolStripButton item = new ToolStripButton(imagen);
            item.Name = nombre;            
            item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            item.BackgroundImageLayout = ImageLayout.Stretch;
            item.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            item.ImageTransparentColor = System.Drawing.Color.Magenta;
            item.Size = new System.Drawing.Size(34, 55);
            tlbHerramientas.Items.Add(item);
            return item;
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseConToolbar));
            this.tlbHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnGraficar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrimero = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnSiguiente = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRutinasPendientes = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tlbHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlbHerramientas
            // 
            this.tlbHerramientas.AutoSize = false;
            this.tlbHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.tlbHerramientas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tlbHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnBuscar,
            this.toolStripSeparator2,
            this.btnModificar,
            this.btnGuardar,
            this.btnCancelar,
            this.toolStripSeparator1,
            this.btnEliminar,
            this.btnImprimir,
            this.btnGraficar,
            this.toolStripButton8,
            this.btnPrimero,
            this.btnAnterior,
            this.btnSiguiente,
            this.btnUltimo,
            this.toolStripSeparator3,
            this.btnRutinasPendientes});
            this.tlbHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tlbHerramientas.Name = "tlbHerramientas";
            this.tlbHerramientas.Size = new System.Drawing.Size(822, 58);
            this.tlbHerramientas.TabIndex = 1;
            this.tlbHerramientas.Text = "toolStrip";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 55);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(46, 55);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 55);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(53, 55);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 55);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 55);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(57, 55);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click_1);
            // 
            // btnGraficar
            // 
            this.btnGraficar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGraficar.Image = ((System.Drawing.Image)(resources.GetObject("btnGraficar.Image")));
            this.btnGraficar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(52, 55);
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.Visible = false;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(6, 58);
            // 
            // btnPrimero
            // 
            this.btnPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrimero.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(27, 55);
            this.btnPrimero.Text = "<<";
            this.btnPrimero.ToolTipText = "Primero";
            this.btnPrimero.Visible = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(23, 55);
            this.btnAnterior.Text = "<";
            this.btnAnterior.ToolTipText = "Anterior";
            this.btnAnterior.Visible = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(23, 55);
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.ToolTipText = "Siguiente";
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(27, 55);
            this.btnUltimo.Text = ">>";
            this.btnUltimo.ToolTipText = "Último";
            this.btnUltimo.Visible = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 58);
            this.toolStripSeparator3.Visible = false;
            // 
            // btnRutinasPendientes
            // 
            this.btnRutinasPendientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRutinasPendientes.Image = ((System.Drawing.Image)(resources.GetObject("btnRutinasPendientes.Image")));
            this.btnRutinasPendientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRutinasPendientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRutinasPendientes.Name = "btnRutinasPendientes";
            this.btnRutinasPendientes.Size = new System.Drawing.Size(156, 55);
            this.btnRutinasPendientes.Text = "Guardar Rutinas Pendientes";
            this.btnRutinasPendientes.Visible = false;
            this.btnRutinasPendientes.Click += new System.EventHandler(this.btnRutinasPendientes_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(42, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(104, 45);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título";
            // 
            // FormBaseConToolbar
            // 
            this.BackgroundImage = global::Controles.Resources.FondoFormBase2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 556);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tlbHerramientas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBaseConToolbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormBaseConToolbar_Load);
            this.tlbHerramientas.ResumeLayout(false);
            this.tlbHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            cambiarEstado(Estados.Agregar);
            agregar();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (cargarBusqueda())
                cambiarEstado(Estados.Consultar);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            cambiarEstado(Estados.Modificar);
            modificar();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {            
            trimControles();
            if (guardar())
            {
                //Deshabilitamos todos los controles
                //Por convención TODOS los controles están dentro de un gpb
                //así que procedo a deshabilitar todos los gpb
                deshabilitar(this);
                cambiarEstado(Estados.Consultar);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            cancelar();
            limpiar();

            if (Estado == Estados.Modificar)
                cambiarEstado(Estados.Consultar);
            else
                cambiarEstado(Estados.Esperar);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (eliminar())
            {
                limpiar();
                cambiarEstado(Estados.Esperar);
            }
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            imprimir();
        }

        private void FormBaseConToolbar_Load(object sender, EventArgs e)
        {
            setearControles();
            cargar();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {            
            cambiarEstado(Estados.Modificar);
            btnCancelar_Click_1(sender, e);
            Primero();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {            
            cambiarEstado(Estados.Modificar);
            btnCancelar_Click_1(sender, e);
            Anterior();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {                        
            cambiarEstado(Estados.Modificar);
            btnCancelar_Click_1(sender, e);
            Siguiente();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {            
            cambiarEstado(Estados.Modificar);
            btnCancelar_Click_1(sender, e);
            Ultimo();
        }

        private void btnRutinasPendientes_Click(object sender, EventArgs e)
        {
            GuardarRutinasPendientes();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            Graficar();
        }
    }
}
