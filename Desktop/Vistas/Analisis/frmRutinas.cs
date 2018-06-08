using Controles;
using Entidades;
using Frontend.Controles;
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
    public partial class frmRutinas : FormBaseConToolbar
    {
        private Planta Planta;

        public frmRutinas()
        {
            InitializeComponent();

            ltvDeterminantes.MultiSelect = true;
            ltvMuestras.MultiSelect = true;

            btnBuscar.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
        }

        public override void usuarioAutorizado()
        {
            //Seguridad.tienePermisos(this.GetType().Name, Global.Formularios);
        }

        protected override void cargar()
        {
            Cargador.cargarPlantas(cboPlanta, "");
            
            gpbDatos.Enabled = false;
        }

        protected override void agregar()
        {
            Planta = new Planta();
            limpiarControles(gpbDatos);
            gpbDatos.Enabled = true;
            cboPlanta.Focus();
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            cboPlanta.Focus();
        }

        protected override bool guardar()
        {
            List<DeterminantesPlanta> dp = new List<DeterminantesPlanta>(); 
            List<MuestraPlanta> mp = new List<MuestraPlanta>();
            Planta = cboPlanta.SelectedItem != null ? ((Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value) : null;

            foreach (ListViewItem lvi in ltvMuestras.Items)
            {
                MuestraPlanta muestraPlanta = new MuestraPlanta();
                muestraPlanta.idPlanta = Planta.id;
                muestraPlanta.idMuestra = ((Muestra)lvi.Tag).Id;
                mp.Add(muestraPlanta);
            }

            foreach (ListViewItem lvi in ltvDeterminantes.Items)
            {
                DeterminantesPlanta detPlanta = new DeterminantesPlanta();
                detPlanta.idPlanta = Planta.id;
                detPlanta.idDeterminante = ((Determinante)lvi.Tag).id;
                dp.Add(detPlanta);
            }

            try
            {
                string cadenaMensaje = "";

                // Guardamos los datos del Determinante
                if (Estado == Estados.Agregar)
                {
                    Global.Servicio.agregarRutina(Planta, dp, mp, Global.DatosSesion);
                    cadenaMensaje = "Rutina dada de Alta exitosamente.";
                }
                else
                {
                    //Global.Servicio.actualizarRutina(Planta, dp, mp, Global.DatosSesion);
                    cadenaMensaje = "Rutina Modificada con éxito.";
                }

                // Mostramos mensaje de éxito
                Mensaje mensaje = new Mensaje(cadenaMensaje, Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                // Indica que el Determinante se guardó correctamente
                return true;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje;

                unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();

            }

            return false;
        }

        protected override bool eliminar()
        {
            if (Planta != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("La rutina de la planta '" + Planta.nombre + "' será eliminada ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    try
                    {
                        Mensaje mensajeExito;
                        //se pudo eliminar Determinante físicamente
                        Global.Servicio.eliminarRutina(Planta, Global.DatosSesion);
                        mensajeExito = new Mensaje("El Determinante ha sido eliminado con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                        mensajeExito.ShowDialog();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();
                    }
                }
            }
            else
            {
                Mensaje unMensaje = new Mensaje("Debe seleccionar un determinante.", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            return false;
        }

        protected override void limpiar()
        {
            if (Estado != Estados.Modificar)
            {
                // Limpia los datos del formulario
                limpiarControles(gpbDatos);
            }
            // Limpia los mensajes de error
            //errProvider.Clear();
            // Fija los campos para consulta
            gpbDatos.Enabled = false;
        }

        protected override bool cargarBusqueda()
        {
            return false;
        }

        private bool validar()
        {
            return false;
        }

        private void btnCargarRutina_Click(object sender, EventArgs e)
        {
            List<String> nombresAnalisis = new List<string>();
            List<String> nombresDeterminantes = new List<string>();
            string rutinaSeleccionada = cboRutina.SelectedItem == null ? "Ninguna" : cboRutina.SelectedItem.ToString();

            switch(rutinaSeleccionada)
            { 

                case "Efluente":
                    nombresDeterminantes = new List<string>() { "pH",
                                                            "Alcalinidad Fenolftaleina",
                                                            "Alcalinidad Total",
                                                            "Alcalinidad Hidróxidos",
                                                            "Olor",
                                                            "Aspecto",
                                                            "Sulfitos",
                                                            "Sulfuros Totales",
                                                            "Color",
                                                            "Turbiedad",
                                                            "Sólidos Totales",
                                                            "Sólidos Disueltos",
                                                            "Sólidos Susp. Fijos",
                                                            "Sólidos Sedim. 10 min.",
                                                            "Sólidos Sedim. 120 min.",
                                                            "Cloruros",
                                                            "Conductancia Específica",
                                                            "Temperarura Muestra",
                                                            "Oxígeno Disuelto",
                                                            "D.B.O. (5)",
                                                            "D.Q.O.",
                                                            "Materia Grasa",
                                                            "Coliformes Totales" };


                    nombresAnalisis = new List<string>() { "Efluente Crudo", "Efluente Refinería Crudo", "Volcamiento Final" };
                    break;

                case "Agua Potable":
                    nombresDeterminantes = new List<string>() { "pH",
                                                                "Alcalinidad Fenolftaleina",
                                                                "Alcalinidad Total",
                                                                "Alcalinidad Hidróxidos",
                                                                "Dureza Total",
                                                                "Dureza Cálcica",
                                                                "Dureza Magnésica",
                                                                "Fosfatos Totales",
                                                                "Fosfatos Líbres",
                                                                "Sulfitos",
                                                                "Hidracina",
                                                                "Relación de Incrustación",
                                                                "Cloruros",
                                                                "Sulfatos",
                                                                "Sílice",
                                                                "Hierro Total",
                                                                "Conductancia Específica",
                                                                "Ciclos de Concentración",
                                                                "Recuperación de Condensados" 
                    };

                    nombresAnalisis = new List<string>() { "Salida Placas" , "Salida Filtros" , "CISTERNA" , "Bajada TK" };

                    break;

                case "Bacteriológica":

                    nombresDeterminantes = new List<string>() { "pH",
                                                                "Alcalinidad Fenolftaleina",
                                                                "Alcalinidad Total",
                                                                "Alcalinidad Hidróxidos",
                                                                "Dureza Total",
                                                                "Dureza Cálcica",
                                                                "Dureza Magnésica",
                                                                "Fosfatos Totales",
                                                                "Fosfatos Líbres",
                                                                "Sulfitos",
                                                                "Hidracina",
                                                                "Relación de Incrustación",
                                                                "Cloruros",
                                                                "Sulfatos",
                                                                "Sílice",
                                                                "Hierro Total",
                                                                "Conductancia Específica",
                                                                "Ciclos de Concentración",
                                                                "Recuperación de Condensados" 
                    };

                    nombresAnalisis = new List<string>() { "Alimentación Caldera" , "Caldera Chica" , "Caldera Grande" , "Cond. Evap. Nº1.", "Cond. Evap. Nº2.", "Cond. Evap. Nº3.", "Cond. Evap. Nº4.",
                        "Reposición Torre", "Torre", "Banco de Frio" };

                    break;
            }

            foreach (Determinante det in Global.Servicio.obtenerTodosDeterminante(int.MaxValue))
            {
                if (nombresDeterminantes.Contains(det.nombre))
                {
                    string[] datos = new string[] { det.nombre, det.unidad };
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = det;
                    ltvDeterminantes.Items.Add(item);
                }
            }

            foreach (Muestra m in Global.Servicio.obtenerTodosMuestra(int.MaxValue))
            {
                if (nombresAnalisis.Contains(m.Descripcion))
                {
                    string[] datos = new string[] { m.Codigo, m.Descripcion };
                    ListViewItem item = new ListViewItem(datos);
                    item.Tag = m;
                    ltvMuestras.Items.Add(item);
                }
            }

        }

        private void btnAgregarDeterminante_Click(object sender, EventArgs e)
        {
            frmBusquedaDeterminantes frmBusquedaArticulo = new frmBusquedaDeterminantes();
            DialogResult res = frmBusquedaArticulo.ShowDialog();
            Determinante det;
            Mensaje unMensaje;

            if (res == DialogResult.OK)
            {
                det = frmBusquedaArticulo.Determinante;

                foreach (ListViewItem lvi in ltvDeterminantes.Items)
                {
                    if (((Determinante)lvi.Tag).Equals(det))
                    {
                        unMensaje = new Mensaje("El determinante seleccionado ya se encuentra agregado a la lista.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();
                        return;
                    }
                }

                string[] datos = new string[] { det.nombre, det.unidad };
                ListViewItem item = new ListViewItem(datos);
                item.Tag = det;
                ltvDeterminantes.Items.Add(item);

                unMensaje = new Mensaje("Determinante añadido exitosamente.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        private void btnAgregarMuestra_Click(object sender, EventArgs e)
        {
            frmBusquedaMuestras frmBusquedaMuestras = new frmBusquedaMuestras();
            DialogResult res = frmBusquedaMuestras.ShowDialog();
            Muestra m;
            Mensaje unMensaje;

            if (res == DialogResult.OK)
            {
                m = frmBusquedaMuestras.Muestra;

                foreach (ListViewItem lvi in ltvMuestras.Items)
                {
                    if (((Muestra)lvi.Tag).Equals(m))
                    {
                        unMensaje = new Mensaje("La muestra seleccionada ya se encuentra agregada a la lista.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                        unMensaje.ShowDialog();
                        return;
                    }
                }

                string[] datos = new string[] { m.Codigo, m.Descripcion };
                ListViewItem item = new ListViewItem(datos);
                item.Tag = m;
                ltvMuestras.Items.Add(item);

                unMensaje = new Mensaje("Muestra añadida exitosamente.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        private void btnEliminarDeterminante_Click(object sender, EventArgs e)
        {
            Mensaje unMensaje;
            if (ltvDeterminantes.SelectedItems.Count == 0)
            {
                unMensaje = new Mensaje("Debe seleccionar al menos un determinante de la lista.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
                return;
            }

            foreach(ListViewItem lvi in ltvDeterminantes.SelectedItems)
            {
                ltvDeterminantes.Items.Remove(lvi);
            }
            unMensaje = new Mensaje("Determinantes seleccionados borrados con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
            unMensaje.ShowDialog();
            
        }

        private void btnEliminarMuestra_Click(object sender, EventArgs e)
        {
            Mensaje unMensaje;
            if (ltvMuestras.SelectedItems.Count == 0)
            {
                unMensaje = new Mensaje("Debe seleccionar al menos una muestra de la lista.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
                return;
            }

            foreach (ListViewItem lvi in ltvMuestras.SelectedItems)
            {
                ltvMuestras.Items.Remove(lvi);
            }
            unMensaje = new Mensaje("Muestras seleccionadas borradas con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
            unMensaje.ShowDialog();
        }

        private void cboPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Planta planta = cboPlanta.SelectedItem == null ? null : (Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value;

            txtCliente.Text = planta.Cliente != null ? planta.Cliente.razonSocial : "SIN ESPECIFICAR";
            ltvDeterminantes.Items.Clear();
            ltvMuestras.Items.Clear();

            foreach (Determinante det in Global.Servicio.obtenerDeterminantesPlanta(planta))
            {
                string[] datos = new string[] { det.nombre, det.unidad };
                ListViewItem item = new ListViewItem(datos);
                item.Tag = det;
                ltvDeterminantes.Items.Add(item);
            }

            foreach (Muestra m in Global.Servicio.obtenerMuestrasPlanta(planta))
            {
                string[] datos = new string[] { m.Codigo, m.Descripcion };
                ListViewItem item = new ListViewItem(datos);
                item.Tag = m;
                ltvMuestras.Items.Add(item);
            }
        }
    }
}
