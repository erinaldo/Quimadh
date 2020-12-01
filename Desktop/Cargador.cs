using Controles;
using Desktop.Vistas;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Desktop
{
    public static class Cargador
    {
        /// <summary>
        /// Carga todas las situaciones frente al IVA en el ComboBox especificado, creando
        /// el primer elemento con el texto por defecto.
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="textoPrimerItem"></param>
        /// <param name="?"></param>
        /// <param name="idUnidadPorDefecto"></param>
        public static void cargarUnidades(ComboBox combo, string textoPrimerItem = "", int idUnidadPorDefecto = 0)
        {
            try
            {
                ComboBoxItem item;
                // Obtiene las situaciones frente al IVA
                List<Unidad> unidades = Global.Servicio.obtenerUnidades();

                // Limpia el contenido del combobox
                combo.Items.Clear();

                if (textoPrimerItem != "")
                    combo.Items.Add(textoPrimerItem);

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombreUnidades = new AutoCompleteStringCollection();

                int indice = 0;

                // Carga las unidades obtenidas
                foreach (Unidad unidad in unidades)
                {
                    item = new ComboBoxItem(unidad.nombre, unidad);
                    combo.Items.Add(item);
                    nombreUnidades.Add(unidad.nombre);

                    if (idUnidadPorDefecto == unidad.id)
                        indice = combo.Items.Count - 1;
                }

                combo.AutoCompleteCustomSource = nombreUnidades;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        /// <summary>
        /// Carga todas las localidades en el ComboBox especificado, creando
        /// el primer elemento con el texto por defecto.
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="textoPrimerItem"></param>
        /// <param name="idLocalidadPorDefecto"></param>
        public static void cargarLocalidad(ComboBox combo, string textoPrimerItem="",int idLocalidadPorDefecto=0)
        {
            try
            {
                ComboBoxItem item;
                // Obtiene las localidades
                List<Localidad> localidades = Global.Servicio.obtenerTodosLocalidad();

                // Limpia el contenido del combobox
                combo.Items.Clear();

                if (textoPrimerItem != "")
                    combo.Items.Add(textoPrimerItem);

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombreLocalidades = new AutoCompleteStringCollection();

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (Localidad localidad in localidades)
                {
                    item = new ComboBoxItem(localidad.nombre, localidad);
                    combo.Items.Add(item);
                    nombreLocalidades.Add(localidad.nombre);

                    if (idLocalidadPorDefecto == localidad.id)
                        indice = combo.Items.Count - 1;
                }

                combo.AutoCompleteCustomSource = nombreLocalidades;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarLocalidad(TextBox celda, string textoPrimerItem = "", int idLocalidadPorDefecto = 0)
        {
            try
            {
                List<Localidad> localidades = Global.Servicio.obtenerTodosLocalidad();

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombreLocalidades = new AutoCompleteStringCollection();

                // Carga las localidades obtenidas
                foreach (Localidad localidad in localidades)
                {
                    nombreLocalidades.Add(localidad.nombre);
                }

                celda.AutoCompleteCustomSource = nombreLocalidades;
                celda.AutoCompleteSource = AutoCompleteSource.CustomSource;
                celda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void anularAutoCompletar(TextBox celda)
        {
            celda.AutoCompleteCustomSource = null;
            celda.AutoCompleteSource = AutoCompleteSource.None;
            celda.AutoCompleteMode = AutoCompleteMode.None;
        }

        public static void cargarSitIva(CustomComboBox combo, string textoPrimerItem = "",int idSitPorDefecto=0)
        {
            try
            {
                ComboBoxItem item;
                // Obtiene las localidades
                List<SituacionFrenteIva> sitIva = Global.Servicio.obtenerTodosSitIva();

                // Limpia el contenido del combobox
                combo.Items.Clear();

                // Agrega el primer elemento con el texto especificado
                if (textoPrimerItem != "")
                {
                    item = new ComboBoxItem(textoPrimerItem, null);
                    combo.Items.Add(item);
                }

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombreSituacionesIVA = new AutoCompleteStringCollection();

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (SituacionFrenteIva si in sitIva)
                {
                    item = new ComboBoxItem(si.nombre, si);
                    combo.Items.Add(item);
                    nombreSituacionesIVA.Add(si.nombre);

                    if (idSitPorDefecto == si.id)
                        indice = combo.Items.Count - 1;
                }

                combo.AutoCompleteCustomSource = nombreSituacionesIVA;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }        

        public static void cargarPresentaciones(ComboBox combo, string textoPrimerItem = "")
        {
            try
            {
                ComboBoxItem item;
                List<Presentacion> presentaciones = Global.Servicio.obtenerTodosPresentaciones(int.MaxValue);

                // Limpia el contenido del combobox
                combo.Items.Clear();

                // Agrega el primer elemento con el texto especificado
                if (textoPrimerItem != "")
                {
                    item = new ComboBoxItem(textoPrimerItem, null);
                    combo.Items.Add(item);
                }

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombrePresentaciones = new AutoCompleteStringCollection();

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (Presentacion presentacion in presentaciones)
                {
                    item = new ComboBoxItem("x " + presentacion.litrosEnvase.ToString(), presentacion);
                    combo.Items.Add(item);
                    nombrePresentaciones.Add("x " + presentacion.litrosEnvase.ToString());
                }

                combo.AutoCompleteCustomSource = nombrePresentaciones;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarPresentaciones(TextBox celda)
        {
            try
            {
                List<Presentacion> presentaciones = Global.Servicio.obtenerTodosPresentaciones(int.MaxValue);

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombrePresentaciones = new AutoCompleteStringCollection();


                // Carga las localidades obtenidas
                foreach (Presentacion presentacion in presentaciones)
                {
                    nombrePresentaciones.Add("x " + presentacion.litrosEnvase.ToString());
                }

                celda.AutoCompleteCustomSource = nombrePresentaciones;
                celda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                celda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarClientes(ComboBox combo, string textoPrimerItem = "")
        {
            List<Cliente> clientes = Global.Servicio.obtenerTodosClientes(int.MaxValue);

            cargarClientes(combo, textoPrimerItem, clientes);
        }

        public static void cargarClientes(ComboBox combo, string textoPrimerItem = "", List<Cliente> clientes = null)
        {
            try
            {
                ComboBoxItem item;

                // Limpia el contenido del combobox
                combo.Items.Clear();

                // Agrega el primer elemento con el texto especificado
                if (textoPrimerItem != "")
                {
                    item = new ComboBoxItem(textoPrimerItem, null);
                    combo.Items.Add(item);
                }

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombreClientes = new AutoCompleteStringCollection();

                int indice = 0;

                foreach (Cliente cliente in clientes)
                {
                    item = new ComboBoxItem(cliente.razonSocial, cliente);
                    combo.Items.Add(item);
                    nombreClientes.Add(cliente.razonSocial);
                }

                combo.AutoCompleteCustomSource = nombreClientes;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarVendedores(ComboBox combo, string textoPrimerItem = "", List<string> vendedores = null)
        {
            try
            {
                ComboBoxItem item;

                // Limpia el contenido del combobox
                combo.Items.Clear();

                // Agrega el primer elemento con el texto especificado
                if (textoPrimerItem != "" && !vendedores.Contains(textoPrimerItem))
                {
                    item = new ComboBoxItem(textoPrimerItem, null);
                    combo.Items.Add(item);
                }

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombreVendedores = new AutoCompleteStringCollection();

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (string nombreVendedor in vendedores)
                {
                    item = new ComboBoxItem(nombreVendedor, nombreVendedor);
                    combo.Items.Add(item);
                    nombreVendedores.Add(nombreVendedor);
                }

                combo.AutoCompleteCustomSource = nombreVendedores;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                if (vendedores.Count > 0)
                    combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarVendedores(TextBox input, string textoPrimerItem = "")
        {
            try
            {
                List<String> vendedores = Global.Servicio.ObtenerNombresVendedores();

                AutoCompleteStringCollection nomVendedores = new AutoCompleteStringCollection();
                nomVendedores.AddRange(vendedores.ToArray());

                input.AutoCompleteCustomSource = nomVendedores;
                input.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                input.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarLista(TextBox input, List<string> lista = null)
        {
            try
            {                
                AutoCompleteStringCollection nombres = new AutoCompleteStringCollection();
                nombres.AddRange(lista.ToArray());

                input.AutoCompleteCustomSource = nombres;
                input.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                input.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarPlantas(ComboBox combo, string textoPrimerItem = "")
        {
            List<Planta> plantas = Global.Servicio.obtenerTodosPlanta();

            cargarPlantas(combo, textoPrimerItem, plantas);
        }

        public static void cargarPlantas(ComboBox combo, Cliente cli, string textoPrimerItem = "")
        {
            List<Planta> plantas = Global.Servicio.buscarPlantas("", "", cli, 1000);

            cargarPlantas(combo, textoPrimerItem, plantas);
        }

        public static void cargarPlantas(ComboBox combo, string textoPrimerItem = "", List<Planta> plantas = null)
        {
            try
            {
                ComboBoxItem item;

                // Limpia el contenido del combobox
                combo.Items.Clear();

                // Agrega el primer elemento con el texto especificado
                if (textoPrimerItem != "")
                {
                    item = new ComboBoxItem(textoPrimerItem, null);
                    combo.Items.Add(item);
                }

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombrePlantas = new AutoCompleteStringCollection();

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (Planta planta in plantas)
                {
                    item = new ComboBoxItem(planta.nombre, planta);
                    combo.Items.Add(item);
                    nombrePlantas.Add(planta.nombre);
                }

                combo.AutoCompleteCustomSource = nombrePlantas;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarPlantasConCliente(ComboBox combo, string textoPrimerItem = "")
        {
            List<Planta> plantas = Global.Servicio.obtenerPlantasConClientes();

            cargarPlantas(combo, textoPrimerItem, plantas);
        }
       
        public static void cargarMonedas(ComboBox combo, string textoPrimerItem = "")
        {
            try
            {
                ComboBoxItem item;
                // Obtiene las localidades
                List<Moneda> monedas = Global.Servicio.obtenerTodosMoneda();

                // Limpia el contenido del combobox
                combo.Items.Clear();

                // Agrega el primer elemento con el texto especificado
                if (textoPrimerItem != "")
                {
                    item = new ComboBoxItem(textoPrimerItem, null);
                    combo.Items.Add(item);
                }

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (Moneda moneda in monedas)
                {
                    item = new ComboBoxItem(moneda.nombre, moneda);
                    combo.Items.Add(item);
                }

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarArticuloPlanta(TextBox celda,Planta planta, string textoPrimerItem = "")
        {
            IEnumerable<ArticuloPlanta> plantas = new List<ArticuloPlanta>();
            AutoCompleteStringCollection codArticulos = new AutoCompleteStringCollection();

            plantas = planta.ArticuloPlanta.Where(x => x.eliminado == null);

            foreach (ArticuloPlanta artPla in plantas)
            {
                codArticulos.Add(artPla.Planta.codigo + artPla.contador.ToString());
            }
            celda.AutoCompleteCustomSource = codArticulos;
            celda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            celda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public static void cargarArticulosDePlanta(TextBox celda, Planta planta, string textoPrimerItem = "")
        {
            IEnumerable<ArticuloPlanta> plantas = new List<ArticuloPlanta>();
            AutoCompleteStringCollection descArticulos = new AutoCompleteStringCollection();

            plantas = planta.ArticuloPlanta.Where(x => x.eliminado == null);

            foreach (ArticuloPlanta artPla in plantas)
            {
                descArticulos.Add(artPla.TipoArticulo.nombre);
            }
            celda.AutoCompleteCustomSource = descArticulos;
            celda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            celda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public static void cargarPrecios(TextBox celda, ArticuloPlanta artPla, string textoPrimerItem = "")
        {
            List<PreciosAdicionales> precios = new List<PreciosAdicionales>();
            AutoCompleteStringCollection descPrecios = new AutoCompleteStringCollection();
            precios.Add(new PreciosAdicionales { precio = artPla.precio });
            precios.AddRange(artPla.PreciosAdicionales);
            descPrecios.AddRange(precios.Select(p => p.precio.ToString("0.00")).ToArray());
            //precios.ForEach(p => descPrecios.Add)
            //foreach (PreciosAdicionales precio in precios)
            //{
            //    descPrecios.Add(precio.precio.ToString("0.00"));
            //}
            celda.AutoCompleteCustomSource = descPrecios;
            celda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            celda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        /// <summary>
        /// Carga todos los artículos en el ComboBox especificado, creando
        /// el primer elemento con el texto por defecto.
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="textoPrimerItem"></param>
        /// <param name="idLocalidadPorDefecto"></param>
        public static void cargarArticulos(ComboBox combo, string textoPrimerItem = "")
        {
            try
            {
                ComboBoxItem item;
                // Obtiene las localidades
                List<TipoArticulo> articulos = Global.Servicio.obtenerTodosArticulos(int.MaxValue);

                // Limpia el contenido del combobox
                combo.Items.Clear();

                // Agrega el primer elemento con el texto especificado
                if (textoPrimerItem != "")
                {
                    item = new ComboBoxItem(textoPrimerItem, null);
                    combo.Items.Add(item);
                }

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombreArticulos = new AutoCompleteStringCollection();

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (TipoArticulo articulo in articulos)
                {
                    item = new ComboBoxItem(articulo.nombre, articulo);
                    combo.Items.Add(item);
                    nombreArticulos.Add(articulo.nombre);
                }

                combo.AutoCompleteCustomSource = nombreArticulos;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarArticulos(TextBox celda, string textoPrimerItem = "")
        {
            try
            {
                ComboBoxItem item;
                // Obtiene las localidades
                List<TipoArticulo> articulos = Global.Servicio.obtenerTodosArticulos(int.MaxValue);

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombreArticulos = new AutoCompleteStringCollection();

                // Carga las localidades obtenidas
                foreach (TipoArticulo articulo in articulos)
                {
                    item = new ComboBoxItem(articulo.nombre, articulo);
                    nombreArticulos.Add(articulo.nombre);
                }

                celda.AutoCompleteCustomSource = nombreArticulos;
                celda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                celda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarNombresClientes(TextBox input, string textoPrimerItem = "")
        {
            IEnumerable<Cliente> clientes = new List<Cliente>();

            AutoCompleteStringCollection nomClientes = new AutoCompleteStringCollection();

            clientes = Global.Servicio.obtenerTodosClientes(1000);

            foreach (Cliente cli in clientes)
            {
                nomClientes.Add(cli.razonSocial);
            }
            input.AutoCompleteCustomSource = nomClientes;
            input.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            input.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public static void cargarPuntosVta(ComboBox combo, string tipo, string textoPrimerItem = "")
        {
            try
            {
                ComboBoxItem item;
                List<Rel_Pv_Comprobante> puntosVta = Global.Servicio.ObtenerPuntosVenta(tipo);

                // Limpia el contenido del combobox
                combo.Items.Clear();

                // Agrega el primer elemento con el texto especificado
                if (textoPrimerItem != "")
                {
                    item = new ComboBoxItem(textoPrimerItem, null);
                    combo.Items.Add(item);
                }

                int indice = 0;

                foreach (Rel_Pv_Comprobante pv in puntosVta)
                {
                    item = new ComboBoxItem(pv.PuntoVenta.ToString(), pv);
                    combo.Items.Add(item);
                }

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarLotes(CustomComboBox combo, TipoArticulo tipoArt, short estado, string textoPrimerItem = "")
        {
            try
            {
                ComboBoxItem item;
                List<Lote> lotes = Global.Servicio.obtenerLotes(tipoArt, estado);

                // Limpia el contenido del combobox
                combo.Items.Clear();

                // Agrega el primer elemento con el texto especificado
                if (textoPrimerItem != "")
                {
                    item = new ComboBoxItem(textoPrimerItem, null);
                    combo.Items.Add(item);
                }

                int indice = 0;

                foreach (Lote lote in lotes)
                {
                    item = new ComboBoxItem(lote.numero, lote);
                    combo.Items.Add(item);
                }

                if (combo.Items.Count>0)
                    combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void cargarLotes(TextBox celda, TipoArticulo tipoArt, short estado)
        {
            try
            {
                List<Lote> lotes = Global.Servicio.obtenerLotes(tipoArt, estado);
                AutoCompleteStringCollection numerosLotes = new AutoCompleteStringCollection();

                foreach (Lote lote in lotes)
                {
                    numerosLotes.Add(lote.numero);
                }

                celda.AutoCompleteCustomSource = numerosLotes;
                celda.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                celda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void CargarBancos(ComboBox combo, string textoPrimerItem = "", int idBancoPorDefecto = 0)
        {
            try
            {
                ComboBoxItem item;
                // Obtiene las localidades
                var bancos = Global.Servicio.ObtenerTodosBancos();

                // Limpia el contenido del combobox
                combo.Items.Clear();

                if (textoPrimerItem != "")
                    combo.Items.Add(textoPrimerItem);

                // Origen de datos para Autocompletado
                AutoCompleteStringCollection nombreBancos = new AutoCompleteStringCollection();

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (var banco in bancos)
                {
                    item = new ComboBoxItem(banco.Nombre, banco);
                    combo.Items.Add(item);
                    nombreBancos.Add(banco.Nombre);

                    if (idBancoPorDefecto == banco.Id)
                        indice = combo.Items.Count - 1;
                }

                combo.AutoCompleteCustomSource = nombreBancos;
                combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void CargarTiposTarjeta(ComboBox combo, string textoPrimerItem = "", int idTipoPorDefecto = 0)
        {
            try
            {
                ComboBoxItem item;
                // Obtiene las localidades
                var tiposTarjetas = Global.Servicio.ObtenerTodosTipoTarjetas();

                // Limpia el contenido del combobox
                combo.Items.Clear();

                if (textoPrimerItem != "")
                    combo.Items.Add(textoPrimerItem);

                // Origen de datos para Autocompletado
                //AutoCompleteStringCollection nombreBancos = new AutoCompleteStringCollection();

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (var tipoTarjeta in tiposTarjetas)
                {
                    item = new ComboBoxItem(tipoTarjeta.Descripcion, tipoTarjeta);
                    combo.Items.Add(item);
                    //nombreBancos.Add(banco.Nombre);

                    if (idTipoPorDefecto == tipoTarjeta.Id)
                        indice = combo.Items.Count - 1;
                }

                //combo.AutoCompleteCustomSource = nombreBancos;
                //combo.AutoCompleteSource = AutoCompleteSource.CustomSource;

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }

        public static void CargarMarcasTarjeta(ComboBox combo, string textoPrimerItem = "", int idTipoPorDefecto = 0)
        {
            try
            {
                ComboBoxItem item;
                // Obtiene las localidades
                var marcasTarjetas = Global.Servicio.ObtenerTodosMarcaTarjetas();

                // Limpia el contenido del combobox
                combo.Items.Clear();

                if (textoPrimerItem != "")
                    combo.Items.Add(textoPrimerItem);

                int indice = 0;

                // Carga las localidades obtenidas
                foreach (var marca in marcasTarjetas)
                {
                    item = new ComboBoxItem(marca.Descripcion, marca);
                    combo.Items.Add(item);

                    if (idTipoPorDefecto == marca.Id)
                        indice = combo.Items.Count - 1;
                }

                combo.SelectedIndex = indice;
            }
            catch (Exception ex)
            {
                Mensaje unMensaje = new Mensaje(ex.Message, Mensaje.TipoMensaje.Error, Mensaje.Botones.OK);
                unMensaje.ShowDialog();
            }
        }
    }
}
