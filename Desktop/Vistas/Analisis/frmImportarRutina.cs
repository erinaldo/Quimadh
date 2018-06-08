using Controles;
using Desktop.Vistas.Administracion;
using Desktop.Vistas.Reportes;
using Entidades;
using Frontend.Controles;
using Microsoft.Office.Interop.Excel;
using ModuloServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Vistas.Analisis
{
    public partial class frmImportarRutina : FormBaseConToolbar
    {
        private CabeceraRutinaFirmantes firmante = null;
        private List<CabeceraRutina> rutina;
        private int indice = -1;

        frmBusquedaRutinas frmBusquedaArticulo;

        public frmImportarRutina()
        {
            InitializeComponent();

            chkIncluirFirma.Checked = Global.Servicio.obtenerParametroSistemaPorNombre("IncluirFirma").valor == "1" ? true : false;

            btnImprimir.Visible = true;
            btnPrimero.Visible = true;
            btnAnterior.Visible = true;
            btnSiguiente.Visible = true;
            btnUltimo.Visible = true;
            toolStripSeparator3.Visible = true;
            btnRutinasPendientes.Visible = true;
            btnGraficar.Visible = true;
        }

        protected override void GuardarRutinasPendientes()
        {
            int cont = Global.Servicio.almacenaArchivosLocales();

            MessageBox.Show(String.Format("Se han almacenado correctamente {0} rutinas. ", cont), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public override void usuarioAutorizado()
        {
            //Seguridad.tienePermisos(this.GetType().Name, Global.Formularios);
        }

        protected override void cargar()
        {
            Cargador.cargarPlantasConCliente(cboPlanta, "");

            gpbDatos.Enabled = false;
            cboTipoRutina.SelectedIndex = 0;
            btnImprimir.Enabled = false;
            btnPrimero.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
        }

        protected override void cancelar()
        {
        }

        protected override void agregar()
        {
            rutina = new List<CabeceraRutina>();
            rutina.Add(new CabeceraRutina());
            limpiarControles(gpbDatos);
            gpbDatos.Enabled = true;
            cboPlanta.Focus();

            btnPrimero.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;

            //txtObservaciones.Text = Environment.NewLine + "[f]Héctor O. Crespi" + Environment.NewLine + "QUIMADH SRL";
        }

        protected override void modificar()
        {
            gpbDatos.Enabled = true;
            cboPlanta.Focus();
        }

        protected override bool guardar()
        {
            List<DatosRutina> datosRutina = new List<DatosRutina>();
            List<Muestra> muestrasUtilizadas = new List<Muestra>();
            Muestra m;
            Determinante d;
            Planta plantaSeleccionada = cboPlanta.SelectedItem != null ? ((Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value) : null;
            CabeceraRutina rutinaActual = getRutinaActual();

            //Modificamos el parámetro de impresión
            ParametroSistema ps = Global.Servicio.obtenerParametroSistemaPorNombre("IncluirFirma");
            ps.valor = chkIncluirFirma.Checked ? "1" : "0";
            Global.Servicio.modificarParametrosSistema(new List<ParametroSistema>() { ps }, Global.DatosSesion);

            rutinaActual.idPlanta = plantaSeleccionada.id;

            rutinaActual.tipoRutina = cboTipoRutina.Text;
            rutinaActual.observaciones = txtObservaciones.Text;
            rutinaActual.fechaAnalisis = dtpAnalisis.Value;
            rutinaActual.fechaMuestreo = dtpMuestreo.Value;
            rutinaActual.idCabeceraRutinaFirmante = firmante == null ? 1 : firmante.id;

            string aux = "";
            try
            {
                for (int i = 1; i < dgvRutina.Columns.Count; i++)
                {
                    aux = dgvRutina.Columns[i].HeaderCell.Value.ToString();
                    m = Global.Servicio.obtenerMuestra(dgvRutina.Columns[i].HeaderCell.Value.ToString());
                    muestrasUtilizadas.Add(m);
                }
            }
            catch (Exception ex)
            {
                Mensaje mensaje = new Mensaje("Existen incoherencias en las muestras importadas. Verifique muestra '" + aux + "'.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                return false;
            }

            try
            {
                for (int j = 0; j < dgvRutina.Rows.Count - 1; j++)
                {
                    aux = dgvRutina.Rows[j].Cells[0].Value.ToString();
                    d = Global.Servicio.obtenerDeterminante(dgvRutina.Rows[j].Cells[0].Value.ToString());

                    for (int i = 1; i < dgvRutina.Columns.Count; i++)
                    {
                        DatosRutina dr = new DatosRutina();
                        dr.idMuestra = muestrasUtilizadas.ElementAt(i - 1).Id;
                        dr.idDeterminante = d.id;
                        dr.CabeceraRutina = rutinaActual;
                        dr.valor = dgvRutina.Rows[j].Cells[i].Value.ToString();

                        datosRutina.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje mensaje = new Mensaje("Existen incoherencias en los determinantes importados. Verifique determinante '" + aux + "'.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                mensaje.ShowDialog();
                return false;
            }

            try
            {
                string cadenaMensaje = "";

                // Guardamos los datos del Determinante
                if (Estado == Estados.Agregar)
                {
                    rutinaActual = Global.Servicio.agregarDatosRutina(rutinaActual, datosRutina, Global.DatosSesion);
                    txtNumeroRutina.Text = rutinaActual.id.ToString();
                    cadenaMensaje = "Rutina dada de Alta exitosamente.";
                }
                else
                {
                    rutinaActual = Global.Servicio.actualizarDatosRutina(rutinaActual, datosRutina, Global.DatosSesion);
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

        private CabeceraRutina getRutinaActual()
        {
            long numRutina = 0;
            CabeceraRutina rutinaActual;
            if (long.TryParse(txtNumeroRutina.Text, out numRutina) && numRutina != 0)
                rutinaActual = rutina.Where(r => r.id == numRutina).First();
            else
                rutinaActual = rutina.First();


            return rutinaActual;
        }

        protected override bool eliminar()
        {
            CabeceraRutina rutinaActual = getRutinaActual();
            if (rutina != null)
            {
                Mensaje mensajeConfirmacion = new Mensaje("La rutina Nº '" + rutinaActual.id + "' será eliminada ¿Está seguro?", Mensaje.TipoMensaje.Alerta, Mensaje.Botones.SiNo);
                mensajeConfirmacion.ShowDialog();

                if (mensajeConfirmacion.resultado == DialogResult.OK)
                {
                    btnPrimero.Enabled = false;
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    btnUltimo.Enabled = false;
                    try
                    {
                        Mensaje mensajeExito;
                        //se pudo eliminar Determinante físicamente
                        Global.Servicio.eliminarDatosRutina(rutinaActual, Global.DatosSesion);
                        mensajeExito = new Mensaje("La rutina ha sido eliminada con éxito.", Mensaje.TipoMensaje.Exito, Mensaje.Botones.OK);
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

                for (int i = dgvRutina.Columns.Count - 1; i > 0; i--)
                    dgvRutina.Columns.RemoveAt(i);

                dgvRutina.Rows.Clear();
            }
            cboTipoRutina.SelectedIndex = 0;
            // Limpia los mensajes de error
            //errProvider.Clear();
            // Fija los campos para consulta
            gpbDatos.Enabled = false;
        }

        protected override bool cargarBusqueda()
        {
            if (frmBusquedaArticulo == null)
                frmBusquedaArticulo = new frmBusquedaRutinas();

            DialogResult res = frmBusquedaArticulo.ShowDialog();
            CabeceraRutina rutinaActual;
            indice = -1;

            if (res == DialogResult.OK)
            {
                rutina = frmBusquedaArticulo.rutina;
                txtNumeroRutina.Text = rutina.First().id.ToString();
                rutinaActual = getRutinaActual();
                cargarRutina(rutinaActual);

                indice = 0;
                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;

                if (rutina != null && rutina.Count == 1)
                {
                    btnSiguiente.Enabled = false;
                    btnUltimo.Enabled = false;
                }
                else
                {
                    btnSiguiente.Enabled = true;
                    btnUltimo.Enabled = true;
                }

                return true;
            }

            return false;
        }

        protected override void Primero()
        {
            if (rutina != null && rutina.Count > 0)
            {
                CabeceraRutina cr = rutina.First();

                btnPrimero.Enabled = false;
                btnAnterior.Enabled = false;

                txtNumeroRutina.Text = cr.id.ToString();
                cargarRutina(cr);
                //cboPlanta.SelectedIndex = cboPlanta.FindStringExact(cr.Planta.nombre);
                //txtObservaciones.Text = cr.observaciones;

                indice = 0;

                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
        }

        protected override void Anterior()
        {
            if (rutina != null && rutina.Count > 0)
            {
                indice--;

                CabeceraRutina cr = rutina.ElementAt(indice);

                txtNumeroRutina.Text = cr.id.ToString();
                cargarRutina(cr);
                //cboPlanta.SelectedIndex = cboPlanta.FindStringExact(cr.Planta.nombre);
                //txtObservaciones.Text = cr.observaciones;

                if (indice == 0)
                {
                    btnPrimero.Enabled = false;
                    btnAnterior.Enabled = false;
                }

                btnSiguiente.Enabled = true;
                btnUltimo.Enabled = true;
            }
        }

        protected override void Siguiente()
        {
            if (rutina != null && rutina.Count > 0)
            {
                indice++;

                CabeceraRutina cr = rutina.ElementAt(indice);

                txtNumeroRutina.Text = cr.id.ToString();
                cargarRutina(cr);

                if (indice == rutina.Count - 1)
                {
                    btnUltimo.Enabled = false;
                    btnSiguiente.Enabled = false;
                }
                btnAnterior.Enabled = true;
                btnPrimero.Enabled = true;
            }
        }

        protected override void Ultimo()
        {
            if (rutina != null && rutina.Count > 0)
            {
                CabeceraRutina cr = rutina.Last();

                btnSiguiente.Enabled = false;
                btnUltimo.Enabled = false;

                txtNumeroRutina.Text = cr.id.ToString();
                cargarRutina(cr);
                //cboPlanta.SelectedIndex = cboPlanta.FindStringExact(cr.Planta.nombre);
                //txtObservaciones.Text = cr.observaciones;

                indice = rutina.Count - 1;

                btnAnterior.Enabled = true;
                btnPrimero.Enabled = true;
            }

        }

        private bool validar()
        {
            return false;
        }

        protected override void imprimir()
        {
            long numRutina = long.Parse(txtNumeroRutina.Text);
            CabeceraRutina rutinaActual = rutina.Where(r => r.id == numRutina).First();
            List<Muestra> muestras = (from d in rutinaActual.DatosRutina
                                      select d.Muestra).Distinct().ToList();
            Planta plantaSeleccionada = cboPlanta.SelectedItem != null ? ((Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value) : null;

            if (plantaSeleccionada.Cliente != null)
            {
                Localidad l = Global.Servicio.getLocalidadCliente((long)plantaSeleccionada.idCliente);
                if (l != null && l.codigoPostal == null)
                {
                    string response = Microsoft.VisualBasic.Interaction.InputBox(String.Format("Ingrese código postal para la localidad {0}", l.nombre), "Ingreso de código postal", "0", 0, 0);
                    l.codigoPostal = int.Parse(response);
                    Global.Servicio.actualizarLocalidad(l, Global.DatosSesion);
                }
            }

            frmReporteAnalisis frmRep = new frmReporteAnalisis(long.Parse(txtNumeroRutina.Text), frmReporteAnalisis.orientacionDef.Vertical); //muestras.Count > 8 ? frmReporteAnalisis.orientacionDef.Horizontal :
            frmRep.Show();

            cargarWord();

        }

        protected override void Graficar()
        {
            try
            {

                Planta plantaSeleccionada = cboPlanta.SelectedItem != null ? ((Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value) : null;
                DateTime fechaDesde = rutina.Min(r => r.fechaAnalisis).Value;
                DateTime fechaHasta = rutina.Max(r => r.fechaAnalisis).Value;

                int i = dgvRutina.SelectedCells[0].RowIndex;
                int j = dgvRutina.SelectedCells[0].ColumnIndex;

                Determinante determinante = Global.Servicio.obtenerDeterminante(dgvRutina.Rows[i].Cells[0].Value.ToString());
                Muestra muestra = Global.Servicio.obtenerMuestra(dgvRutina.Columns[j].HeaderText);

                try
                {
                    frmGraficoQuimadh frmRep = new frmGraficoQuimadh(plantaSeleccionada.id, muestra.Id, determinante.id, fechaDesde, fechaHasta);
                    frmRep.Show();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje("Seleccione un valor de Muestra/Determinación.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                m.ShowDialog();
            }            

        }

        /// <summary>
        /// Lógica encargada de abrir los archivos de Word encontrados.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="idRutina"></param>
        /// <returns></returns>
        private bool aperturaArchivo(string fileName, long idRutina, bool copiaLocalValida = false)
        {
            try
            {
                Process wordProcess;

                if (!Directory.Exists(@"C:\Quimadh\Reportes"))
                    Directory.CreateDirectory(@"C:\Quimadh\Reportes");

                if (!copiaLocalValida)
                {
                    //byte[] rutinaArchivo = Global.Servicio.recuperarArchivo(idRutina);

                    //if (rutinaArchivo == null)
                    //    return false;

                    ////---------zip
                    //string zipPath = @"C:\Quimadh\Reportes\Comprimidos\" + idRutina.ToString() + ".zip";
                    //using (Stream zipFile = File.OpenWrite(zipPath))
                    //{
                    //    zipFile.Write(rutinaArchivo, 0, rutinaArchivo.Length);
                    //}

                    //ZipFile.ExtractToDirectory(zipPath, fileName.Replace(".doc",""));
                    ////------------

                    //using (Stream file = File.OpenWrite(fileName))
                    //{
                    //    file.Write(rutinaArchivo, 0, rutinaArchivo.Length);
                    //}

                    bool existeArchivo = Global.Servicio.existeArchivo(idRutina);
                    if (!existeArchivo)
                        return false;

                    ParametroSistema paramCarpeta = Global.Servicio.obtenerParametroSistemaPorNombre("CarpetaReportes");

                    if (!File.Exists(fileName))
                        File.Copy(String.Format(@"{0}\{1}.doc", paramCarpeta.valor, idRutina), fileName);
                    
                }

                if (File.Exists(fileName))
                {
                    //MessageBox.Show(String.Format("Se está abriendo un archivo almacenado localmente en {0}. ", fileName), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    wordProcess = Process.Start(fileName);

                    return true;
                }


            }
            catch (Exception ex)
            {
                Mensaje m = new Mensaje(String.Format("Error al editar archivo. Descripción: {0}.", ex.Message), Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                m.ShowDialog();
                return false;
            }
            return false;
        }

        private void cargarWord()
        {
            DateTime ahora = Global.Servicio.obtenerFechaHora();
            // set the file name from the open file dialog
            object fileName = String.Format(@"C:\Quimadh\Reportes\{0}.doc", long.Parse(txtNumeroRutina.Text));
            object readOnly = false;
            object isVisible = true;
            // Here is the way to handle parameters you don't care about in .NET
            object missing = System.Reflection.Missing.Value;


            if (aperturaArchivo(fileName.ToString(), long.Parse(txtNumeroRutina.Text)))
                return;

            File.Copy(@"C:\Quimadh\ResultadosAnalisis.doc", fileName.ToString());

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            app.Visible = false;

            Microsoft.Office.Interop.Word.Document d = app.Documents.Open(ref fileName, ref missing, ref readOnly, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref isVisible);

            CabeceraRutina cr = Global.Servicio.obtenerDatosResultadoAnalisis(long.Parse(txtNumeroRutina.Text));

            string finalAux = "";
            Dictionary<string, bool> ingresosCampos = new Dictionary<string, bool>();
            ingresosCampos.Add("fecha", false);
            ingresosCampos.Add("nombre", false);
            ingresosCampos.Add("direccion", false);
            ingresosCampos.Add("localidad", false);
            ingresosCampos.Add("contacto", false);
            ingresosCampos.Add("nombrePlanta", false);
            ingresosCampos.Add("numeroAnalisis", false);
            ingresosCampos.Add("Analisis", false);
            ingresosCampos.Add("FIRMAPERSONAQUIMADH", false);
            for (int i = 1; i <= d.Words.Count; i++)
            {
                switch (d.Words[i].Text.Trim())
                {
                    case "fecha":
                        if (!ingresosCampos["fecha"])
                        {
                            ingresosCampos["fecha"] = true;
                            d.Words[i].Text = ahora.Day + " de " + ahora.ToString("MMMM", CultureInfo.CurrentCulture) + " de " + ahora.Year;
                        }
                        break;
                    case "nombre":
                        if (!ingresosCampos["nombre"])
                        {
                            ingresosCampos["nombre"] = true;
                            d.Words[i].Text = cr.Planta.Cliente == null ? "Complete razón social" : cr.Planta.Cliente.razonSocial;
                        }
                        break;
                    case "direccion":
                        if (!ingresosCampos["direccion"])
                        {
                            ingresosCampos["direccion"] = true;
                            d.Words[i].Text = cr.Planta.Cliente == null ? "Complete dirección" : cr.Planta.Cliente.direccion;
                        }
                        break;
                    case "localidad":
                        if (!ingresosCampos["localidad"])
                        {
                            ingresosCampos["localidad"] = true;
                            string lFinal = "";
                            d.Words[i].Text = "";
                            if (cr.Planta.Cliente == null)
                            {
                                lFinal = "Complete Loc.";
                            }
                            else
                            {
                                lFinal = cr.Planta.Cliente.Localidad.codigoPostal == null ? "" : ("(" + cr.Planta.Cliente.Localidad.codigoPostal + ") - ");
                                lFinal += cr.Planta.Cliente.Localidad.nombre.Trim();
                            }
                            d.Words[i].Text = lFinal;
                        }
                        break;
                    case "contacto":
                        if (!ingresosCampos["contacto"])
                        {
                            ingresosCampos["contacto"] = true;
                            d.Words[i].Text = cr.Planta.nombreContacto1 == null ? "Complete Contact." : cr.Planta.nombreContacto1.Trim();
                        }
                        break;
                    case "nombrePlanta":
                        if (!ingresosCampos["nombrePlanta"])
                        {
                            ingresosCampos["nombrePlanta"] = true;
                            d.Words[i].Text = cr.Planta.nombre.Trim() + (String.IsNullOrWhiteSpace(cr.Planta.nombreContacto2) ? "" : " - " + cr.Planta.nombreContacto2.Trim());
                        }
                        break;
                    case "numeroAnalisis":
                        if (!ingresosCampos["numeroAnalisis"])
                        {
                            ingresosCampos["numeroAnalisis"] = true;
                            d.Words[i].Text = cr.id.ToString("000000000");
                        }
                        break;
                    case "Analisis":
                        if (!ingresosCampos["Analisis"])
                        {
                            ingresosCampos["Analisis"] = true;
                            foreach (Muestra m in cr.DatosRutina.ToList().Select(mu => mu.Muestra).Distinct())
                                finalAux += "(" + m.Codigo.Trim() + ") - " + m.Descripcion.Trim() + ": " + Environment.NewLine;
                            d.Words[i].Text = finalAux;
                        }
                        break;
                    case "FIRMAPERSONAQUIMADH":
                        if (!ingresosCampos["FIRMAPERSONAQUIMADH"])
                        {
                            ingresosCampos["FIRMAPERSONAQUIMADH"] = true;
                            d.Words[i].Text = cr.CabeceraRutinaFirmantes.nombre;
                        }
                        break;
                    default:
                        break;

                }
            }

            //d.Activate();

            d.Save();
            d.Close();

            aperturaArchivo(fileName.ToString(), long.Parse(txtNumeroRutina.Text), true);
        }

        private void altaReducida(string razonSocial, string nombrePlanta)
        {
            if (MessageBox.Show("Cliente no encontrado ¿Desea realizar el alta reducida?", "Alta reducida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                frmClientes fc = new frmClientes();
                string response = Microsoft.VisualBasic.Interaction.InputBox("Ingrese dirección.", "Ingreso de dirección", "0", 0, 0);
                fc.automatizarClienteReducido(razonSocial, response, nombrePlanta);
                Cargador.cargarPlantasConCliente(cboPlanta, "");
            }
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] PROCPREVIOUS = Process.GetProcessesByName("EXCEL");
            DialogResult result = ofdRutina.ShowDialog(); // Show the dialog.

            if (result == System.Windows.Forms.DialogResult.Cancel)
                return;

            dgvRutina.Columns.Clear();
            dgvRutina.Rows.Clear();
            dgvRutina.Columns.Add("c0", "Análisis");

            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application(); // the Excel application.
            // the reference to the workbook,
            // which is the xls document to read from.
            Workbook book = null;
            // the reference to the worksheet,
            // we'll assume the first sheet in the book.
            Worksheet sheet = null;
            Range range = null;
            // the range object is used to hold the data
            // we'll be reading from and to find the range of data.
            app.Visible = false;
            app.ScreenUpdating = false;
            app.DisplayAlerts = false;

            string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

            if (ofdRutina.FileName.ToUpper().Contains("AGUA"))
                cboTipoRutina.SelectedIndex = cboTipoRutina.FindStringExact("ANÁLISIS DE AGUA");
            if (ofdRutina.FileName.ToUpper().Contains("BACTERIOL"))
                cboTipoRutina.SelectedIndex = cboTipoRutina.FindStringExact("ANÁLISIS BACTERIOLÓGICO");
            if (ofdRutina.FileName.ToUpper().Contains("EFLUENTE"))
                cboTipoRutina.SelectedIndex = cboTipoRutina.FindStringExact("ANÁLISIS DE EFLUENTE");

            book = app.Workbooks.Open(ofdRutina.FileName,
                   Missing.Value, Missing.Value, Missing.Value,
                   Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                   Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                   Missing.Value, Missing.Value, Missing.Value);
            sheet = (Worksheet)book.Worksheets[1];

            cboPlanta.SelectedIndex = cboPlanta.FindString((string)sheet.get_Range("A6", "A6").Value2);

            if (cboPlanta.SelectedIndex == -1)
            {
                altaReducida((string)sheet.get_Range("A4", "A4").Value2, (string)sheet.get_Range("A6", "A6").Value2);
                cboPlanta.SelectedIndex = cboPlanta.FindString((string)sheet.get_Range("A6", "A6").Value2);
            }

            try
            {
                dtpAnalisis.Value = DateTime.FromOADate((double)sheet.get_Range("A10", "A10").Value2);
                dtpMuestreo.Value = DateTime.FromOADate((double)sheet.get_Range("A8", "A8").Value2);
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje("Verifique fecha de muestreo/análisis.", Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }

            range = sheet.get_Range("A10", "FA150");

            object[,] values = (object[,])range.Value2;
            int columnas = 0;
            int filas = 0;
            int columnaLocal = 1;

            for (int j = 2; j <= values.GetLength(1); j++)
            {
                if (values[1, j] != null)
                {
                    dgvRutina.Columns.Add("c" + j, (string)values[1, j]);
                    columnas = j;
                }
            }
            for (int j = 3; j <= values.GetLength(0); j++)
            {
                if (values[j, 1] != null)
                {
                    dgvRutina.Rows.Add((string)values[j, 1]);
                    filas = j;
                }
            }

            for (int i = 3; i <= values.GetLength(0); i++)
            { //Filas
                for (int j = 2; j <= values.GetLength(1); j++)
                { //Columnas
                    if ((j - 1) % 3 == 0)
                    {
                        if (columnaLocal < dgvRutina.Columns.Count && (i - 3) < dgvRutina.Rows.Count - 1)
                            dgvRutina.Rows[i - 3].Cells[columnaLocal].Value = "";

                        if (values[i, j] != null)
                            /*if (double.TryParse(values[i, j].ToString(), out valor))
                                dgvRutina.Rows[i - 3].Cells[columnaLocal].Value = Math.Round(valor, 2);
                            else*/
                            dgvRutina.Rows[i - 3].Cells[columnaLocal].Value = ((Microsoft.Office.Interop.Excel.Range)sheet.Cells[i + 9, j]).Text;//values[i, j];

                        columnaLocal++;
                    }
                }
                columnaLocal = 1;
            }

            dgvRutina.Columns[0].Frozen = true;
            dgvRutina.Columns[0].ReadOnly = true;
            dgvRutina.Columns[0].Width = 200;

            book.Close();

            Marshal.ReleaseComObject(book);
            Marshal.ReleaseComObject(sheet);

            app.Quit();
            Marshal.FinalReleaseComObject(app);

            System.Diagnostics.Process[] PROC = Process.GetProcessesByName("EXCEL");
            foreach (System.Diagnostics.Process PK in PROC)
            {//Si no encuentro el proceso significa que fue generado en este punto.
                if (PROCPREVIOUS.Where(p => p.Id == PK.Id).FirstOrDefault() == null)
                    PK.Kill();
            }
        }

        private void cboPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Planta planta = cboPlanta.SelectedItem == null ? null : (Planta)((ComboBoxItem)cboPlanta.SelectedItem).Value;

            txtCliente.Text = planta != null && planta.Cliente != null ? planta.Cliente.razonSocial : "SIN ESPECIFICAR";
        }

        private void cargarRutina(CabeceraRutina carga = null)
        {
            CabeceraRutina rutinaActual = getRutinaActual();
            if (rutina != null)
            {
                List<DatosRutina> dr = Global.Servicio.getDatosRutina(rutinaActual);

                if (dr.Count > 0)
                {
                    int i = 1;
                    List<Determinante> determinantes = (from d in dr
                                                        select d.Determinante).Distinct().ToList();
                    List<Muestra> muestras = (from d in dr
                                              select d.Muestra).Distinct().ToList();
                    List<DatosRutina> datosPorDeterminante;

                    dgvRutina.Columns.Clear();
                    dgvRutina.Rows.Clear();

                    dgvRutina.Columns.Add("c0", "Análisis");
                    foreach (Muestra m in muestras)
                    {
                        dgvRutina.Columns.Add("c" + i, m.Descripcion);
                        i++;
                    }
                    i = 0;
                    foreach (Determinante d in determinantes)
                    {
                        dgvRutina.Rows.Add(d.nombre);
                        datosPorDeterminante = dr.Where(dat => dat.idDeterminante == d.id).ToList();

                        for (int j = 1; j <= muestras.Count; j++)
                        {
                            dgvRutina.Rows[i].Cells[j].Value = datosPorDeterminante.ElementAt(j - 1).valor;

                            dgvRutina.Rows[i].Cells[j].ReadOnly = false;
                        }

                        i++;
                    }

                    dgvRutina.Columns[0].Frozen = true;
                    dgvRutina.Columns[0].ReadOnly = true;
                    dgvRutina.Columns[0].Width = 200;
                }

                dtpAnalisis.Value = rutinaActual.fechaAnalisis.Value;
                dtpMuestreo.Value = rutinaActual.fechaMuestreo.Value;

                if (carga != null)
                {
                    cboPlanta.SelectedIndex = cboPlanta.FindStringExact(carga.Planta.nombre);
                    cboTipoRutina.SelectedIndex = cboTipoRutina.FindStringExact(carga.tipoRutina);
                    txtNumeroRutina.Text = carga.id.ToString();
                    txtObservaciones.Text = carga.observaciones;
                }
            }
        }

        private void cboPlanta_KeyDown(object sender, KeyEventArgs e)
        {
            cboPlanta.DroppedDown = false;
        }

        private void chkIncluirFirma_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIncluirFirma.Checked && btnImprimir.Visible)
            {
                frmBusquedaFirmas frmBusquedaFirmas = new frmBusquedaFirmas();
                DialogResult res = frmBusquedaFirmas.ShowDialog();

                if (res == DialogResult.OK)
                {
                    firmante = frmBusquedaFirmas.Firma;
                }
                else
                {
                    firmante = null;
                }
            }
            else
            {
                firmante = null;
            }
        }

        private void dgvRutina_Click(object sender, EventArgs e)
        {
        }

    }
}
