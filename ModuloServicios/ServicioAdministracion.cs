using Base;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Transactions;

namespace ModuloServicios
{
    public partial class Servicios
    {

        #region "Usuario"

        public Usuario obtenerAdministrador()
        {
            Usuario user = (from e in _contexto.Usuario
                            select e).First();
            return user;
        }

        public List<TipoUsuario> obtenerTodosTipoUsuario() {
            return _contexto.TipoUsuario.ToList();
        }

        public Usuario obtenerUsuarioPorId(int idUsuario)
        {
            return _contexto.Usuario.Include("TipoUsuario").Where(u => u.id == idUsuario).FirstOrDefault();
        }

        public Usuario obtenerUsuarioAdministrador()
        {
            return _contexto.Usuario.Include("TipoUsuario").Where(u => u.nombreUsuario.ToUpper().Equals("ADMINISTRADOR")).FirstOrDefault();
        }

        public List<Usuario> buscarUsuarios(string nombre, EstadoEntidad estado, int numeroRegistros)
        {
            IQueryable<Usuario> query = _contexto.Usuario.Include("TipoUsuario").Include("Cliente").Include("Vendedor");

            if (!string.IsNullOrEmpty(nombre))
                query = query.Where(u => u.nombreUsuario.Contains(nombre));

            if (estado.idEstado == (int)EstadosEntidad.Activo)
                query = query.Where(u => !u.inactivo);
            else if (estado.idEstado == (int)EstadosEntidad.Inactivo)
                query = query.Where(u => u.inactivo);

            query = query.OrderBy(u => u.nombreUsuario);

            return query.Take(numeroRegistros).ToList();
        }

        public void eliminarUsuario(Usuario usuario, Metadata metadata)
        {
            // ----- VALIDACIONES ----- //            

            if (usuario.nombreUsuario.Equals("administrador"))
            {
                GenerarLogMensaje("Se ha intentado borrar el administrador del sistema.", Acciones.Log.BAJA, metadata);
                throw new Exception("No es posible borrar al usuario Administrador. Este suceso sera informado.");
            }

            // Valida que el usuario no haya sido eliminado anteriormente
            Usuario temp = _contexto.Usuario.Where(u => u.id == usuario.id && !u.inactivo).FirstOrDefault();

            if (temp == null)
                throw new Exception("Usuario ya eliminado.");

            // Valida que el usuario que se está eliminando no corresponda al usuario de la sesión
            if (metadata.idUsuario.Equals(usuario.id))
                throw new Exception("No es posible borrar al usuario de la sesion actual.");

            // ------------------------ //

            using (TransactionScope scope = new TransactionScope())
            {
                Usuario delUsuario = _contexto.Usuario.Where(u => u.id == usuario.id).FirstOrDefault();
                delUsuario.inactivo = true;

                _contexto.SaveChanges();
                GenerarLog<Usuario>(delUsuario, Acciones.Log.BAJA, metadata);

                scope.Complete();
            }
        }

        public Usuario agregarUsuario(Usuario usuario, List<Formulario> permisos, Metadata metadata)
        {
            // ----- VALIDACIONES ----- //
            //Validar USUARIO

            // Valida que no exista un usuario con el mismo nombre
            Usuario temp = _contexto.Usuario.Where(u => u.nombreUsuario.Equals(usuario.nombreUsuario)).FirstOrDefault();

            if (temp != null)
                throw new Exception("El nombre de usuario escogido ya existe.");

            // ------------------------ //

            using (TransactionScope scope = new TransactionScope())
            {
                usuario.inactivo = false;
                usuario.TipoUsuario = null;

                _contexto.Usuario.Add(usuario);

                _contexto.SaveChanges();
                GenerarLog<Usuario>(usuario, Acciones.Log.ALTA, metadata);

                actualizarPermisos(permisos, usuario.id);

                scope.Complete();
            }

            return usuario;
        }

        public void actualizarUsuario(Usuario usuario, List<Formulario> permisos, Metadata metadata)
        {
            // ----- VALIDACIONES ----- //
            // Validaciones de Metadata
            //Validar USUARIO

            // Valida que no exista un usuario con el mismo nombre
            Usuario temp = _contexto.Usuario.Where(u => u.nombreUsuario.Equals(usuario.nombreUsuario) && u.id != usuario.id).FirstOrDefault();

            if (temp != null)
                throw new Exception("El nombre de usuario escogido ya existe.");

            // ------------------------ //

            using (TransactionScope scope = new TransactionScope())
            {
                Usuario updUsuario = _contexto.Usuario.Where(c => c.id == usuario.id).FirstOrDefault();

                if (!updUsuario.nombreUsuario.Equals(usuario.nombreUsuario))
                    throw new Exception("No es posible modificar al usuario Administrador");

                if (!updUsuario.nombreUsuario.Equals("administrador"))
                {
                    updUsuario.nombreUsuario = usuario.nombreUsuario;
                    updUsuario.inactivo = usuario.inactivo;
                    updUsuario.idTipoUsuario = usuario.idTipoUsuario;
                }

                updUsuario.clave = usuario.clave;
                
                _contexto.SaveChanges();
                GenerarLog<Usuario>(updUsuario, Acciones.Log.MODIFICACION, metadata);

                if (!usuario.nombreUsuario.Equals("administrador"))
                    actualizarPermisos(permisos, usuario.id);

                scope.Complete();
            }
        }

        #endregion

        #region "FormularioUsuario"

        /// <summary>
        /// Obtiene todos los formularios y en cuáles tiene permisos el usuario pasado como argumento.
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public List<FormularioUsuario> obtenerPermisosPorUsuario(int idUsuario)
        {
            return _contexto.FormularioUsuario.Include("Formulario").Where(form => form.idUsuario == idUsuario).ToList();
        }

        /// <summary>
        /// Recibe la lista de formularios que se desean habilitar para el usuario con el id pasado como argumento.
        /// </summary>
        /// <param name="formulariosHabilitados"></param>
        /// <param name="idUsuario"></param>
        public void actualizarPermisos(List<Formulario> formulariosHabilitados, int idUsuario)
        {
            List<FormularioUsuario> formulariosRelaciones = new List<FormularioUsuario>();
            FormularioUsuario unFormulario;
            foreach (Formulario form in formulariosHabilitados)
            {
                unFormulario = new FormularioUsuario();
                unFormulario.idUsuario = idUsuario;
                unFormulario.idFormulario = form.id;
                formulariosRelaciones.Add(unFormulario);
            }

            using (TransactionScope scope = new TransactionScope())
            {
                //Para ver que registros debo eliminar
                List<FormularioUsuario> formulariosUsuarioTotal = _contexto.FormularioUsuario.Where(f => f.idUsuario == idUsuario).ToList();

                //Foreach para ver que registros me faltan insertar
                foreach (FormularioUsuario unaRelacion in formulariosRelaciones)
                {
                    FormularioUsuario updForm = _contexto.FormularioUsuario.Where(f => f.idFormulario == unaRelacion.idFormulario && f.idUsuario == idUsuario).FirstOrDefault();
                    //Si no se encuentra la relación la agrego
                    if (updForm == null)
                    {
                        _contexto.FormularioUsuario.Add(unaRelacion);
                    }
                }

                //Si no se encuentra la relación en las tildadas por el usuario, la elimino
                foreach (FormularioUsuario fu in formulariosUsuarioTotal)
                {
                    if (!formulariosRelaciones.Exists(f => f.idFormulario == fu.idFormulario))
                    {
                        _contexto.FormularioUsuario.Remove(fu);
                    }
                }

                _contexto.SaveChanges();

                scope.Complete();
            }
        }

        #endregion

        #region "TipoArticulo"

        public TipoArticulo obtenerArticulo(long id)
        {
            return _contexto.TipoArticulo.Include("Unidad").Where(ta => ta.id == id).First();
        }

        public TipoArticulo obtenerArticulo(string nombre)
        {
            return _contexto.TipoArticulo.Where(ta => ta.nombre == nombre).FirstOrDefault();
        }

        public List<TipoArticulo> obtenerTodosArticulos(int numeroRegistros)
        {
            return _contexto.TipoArticulo.Include("Unidad").Take(numeroRegistros).ToList();
        }        

        public List<TipoArticulo> buscarArticulos(string nombre, Unidad unidad, int numeroRegistros)
        {
            IQueryable<TipoArticulo> query = _contexto.TipoArticulo.Include("Unidad");

            query = query.Where(a => a.nombre.Contains(nombre));

            if(unidad != null)
                query = query.Where(a => a.idUnidad == unidad.id);

            return query.Take(numeroRegistros).ToList();
        }        

        public TipoArticulo agregarArticulo(TipoArticulo tipoArticulo, Metadata metadata)
        {
            TipoArticulo articuloGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarTipoArticulo(tipoArticulo);                

                articuloGuardado = _contexto.TipoArticulo.Add(tipoArticulo);
                _contexto.SaveChanges();

                GenerarLog<TipoArticulo>(tipoArticulo, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return articuloGuardado;
        }

        public TipoArticulo actualizarArticulo(TipoArticulo tipoArticulo, Metadata metadata)
        {
            TipoArticulo articuloGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarTipoArticulo(tipoArticulo, Acciones.Log.MODIFICACION);

                //------------------------------>si hay hijos en la base que se quitaron los borra
                List<ComposicionArticulos> compHijosEnBase;
                IEnumerable<ComposicionArticulos> hijosAEliminar;
                compHijosEnBase = _contexto.ComposicionArticulos.Where(h => h.idArticuloPadre == tipoArticulo.id).ToList();
                hijosAEliminar = compHijosEnBase.Where(h => !tipoArticulo.ComposicionArticulos.Contains(h));
                _contexto.ComposicionArticulos.RemoveRange(hijosAEliminar);
                //------------------------------->
                _contexto.SaveChanges();

                GenerarLog<TipoArticulo>(tipoArticulo, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return articuloGuardado;
        }

        public TipoArticulo eliminarArticulo(TipoArticulo tipoArticulo, Metadata metadata)
        {
            TipoArticulo articuloGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarTipoArticulo(tipoArticulo, Acciones.Log.BAJA);                
                _contexto.ComposicionArticulos.RemoveRange(tipoArticulo.ComposicionArticulos);
                _contexto.TipoArticulo.Remove(tipoArticulo);
                _contexto.SaveChanges();

                GenerarLog<TipoArticulo>(tipoArticulo, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return articuloGuardado;
        }

        private void ValidarTipoArticulo(TipoArticulo tipoArticulo, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";
            int lonNombre = tipoArticulo.nombre.Length;

            if (lonNombre < 0 || lonNombre > 255)
                mensaje += "La longitud del nombre debe estar entre 1 y 255 caracteres." + Environment.NewLine;

            if (tipoArticulo.idUnidad == null)
                mensaje += "La unidad es obligatoria." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);

            bool existe = (from a in _contexto.TipoArticulo
                           where a.nombre.Equals(tipoArticulo.nombre)
                           select a).Any();

            if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
                mensaje = "El artículo con nombre " + tipoArticulo.nombre + " ya se encuentra cargado." + Environment.NewLine;
            if (!existe && accion == Acciones.Log.BAJA)
                mensaje = "El artículo con nombre " + tipoArticulo.nombre + " no existe." + Environment.NewLine;

            if (accion == Acciones.Log.BAJA)
            {
                mensaje += _contexto.ArticuloPlanta.Where(ap => ap.idArticulo == tipoArticulo.id).Any() ? mensaje + "No es posible eliminar el artículo. El mismo posee plantas asociadas." + Environment.NewLine : mensaje;
            }

            existe = (from u in _contexto.Unidad
                      where u.id == tipoArticulo.idUnidad
                      select u).Any();

            if (!existe)
                mensaje += "El artículo posee una unidad incorrecta." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        #endregion

        #region "Unidad"

        public List<Unidad> obtenerUnidades()
        {
            return _contexto.Unidad.ToList();
        }

        #endregion

        #region "Localidad"

        public List<Localidad> obtenerTodosLocalidad()
        {
            return _contexto.Localidad.ToList();
        }

        public Localidad getLocalidadCliente(long idCliente)
        {
            return _contexto.Cliente.Include("Localidad").Where(c => c.id == idCliente).First().Localidad;
        }

        public Localidad actualizarLocalidad(Localidad l, Metadata metadata)
        {
            Localidad localidad = _contexto.Localidad.Where(loc => loc.id == l.id).First();

            using (TransactionScope scope = new TransactionScope())
            {
                localidad.nombre = l.nombre;
                localidad.codigoPostal = l.codigoPostal;

                _contexto.SaveChanges();

                GenerarLog<Localidad>(localidad, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return localidad;
        }

        public Localidad buscaUnaLocalidad(String nombre)
        {
            Localidad localidad = _contexto.Localidad.Where(loc => loc.nombre == nombre).FirstOrDefault();
            return localidad;
        }

        #endregion

        #region "SitIva"

        public List<SituacionFrenteIva> obtenerTodosSitIva()
        {
            return _contexto.SituacionFrenteIva.ToList();
        }

        #endregion

        #region "Cliente"

        public List<Cliente> obtenerTodosClientes(int numeroRegistros)
        {
            List<Cliente> clientes = _contexto.Cliente.ToList();
            if (numeroRegistros > 0)
                clientes = clientes.Take(numeroRegistros).ToList();

            return clientes;
        }

        public List<Cliente> buscarClientes(string razonSoc, string cuit, int numeroRegistros)
        {
            //_contexto.Configuration.LazyLoadingEnabled = false;
            IQueryable<Cliente> query = _contexto.Cliente.Include("Planta.ArticuloPlanta");//.Include("Localidad").Include("SituacionFrenteIva");

            if (razonSoc != "")
                query = query.Where(a => a.razonSocial.Contains(razonSoc));

            if (cuit != "")
                query = query.Where(a => a.cuit == cuit);

            return query.Take(numeroRegistros).ToList();
        }

        public Cliente buscarUnCliente(long? idPlanta)
        {
            IQueryable<Planta> query = _contexto.Planta.Include("Cliente");//.Include("Localidad").Include("SituacionFrenteIva");

            query = query.Where(a => a.id == idPlanta);

            return query.Any() ? query.First().Cliente : null;
        }

        public Cliente buscarUnCliente(string razonSoc, string cuit)
        {
            IQueryable<Cliente> query = _contexto.Cliente.Include("Planta.ArticuloPlanta");//.Include("Localidad").Include("SituacionFrenteIva");

            if (razonSoc != "")
                query = query.Where(a => a.razonSocial == razonSoc);

            if (cuit != "")
                query = query.Where(a => a.cuit == cuit);

            return query.Any() ? query.First() : null;
        }

        public Cliente agregarCliente(Cliente cliente, Metadata metadata)
        {
            Cliente clienteGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarCliente(cliente);

                clienteGuardado = _contexto.Cliente.Add(cliente);
                _contexto.SaveChanges();

                GenerarLog<Cliente>(cliente, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return clienteGuardado;
        }

        public Cliente actualizarCliente(Cliente cliente, Metadata metadata)
        {
            Cliente articuloGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarCliente(cliente, Acciones.Log.MODIFICACION);

                _contexto.SaveChanges();

                if (metadata != null)
                {
                    GenerarLog<Cliente>(cliente, Acciones.Log.MODIFICACION, metadata);
                }                

                scope.Complete();
            }

            return articuloGuardado;
        }

        public Cliente eliminarCliente(Cliente cliente, Metadata metadata)
        {
            Cliente clienteGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                //ValidarCliente(tipoArticulo, Acciones.Log.BAJA);

                _contexto.Cliente.Remove(cliente);
                _contexto.SaveChanges();

                GenerarLog<Cliente>(cliente, Acciones.Log.BAJA, metadata);

                scope.Complete();
            }

            return clienteGuardado;
        }

        private void ValidarCliente(Cliente cliente, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";
            int lonRazonSoc = cliente.razonSocial.Length;
            int lonNomContac = cliente.nombreContacto.Length;
            int lonCargoContac = cliente.cargoContacto.Length;
            int lonCUIT = cliente.cuit.Length;
            int lonDir = cliente.direccion.Length;
            int lonTel = cliente.telefono.Length;
            int lonTel2 = cliente.telefono2.Length;
            int lonFax = cliente.fax.Length;
            int lonMail = cliente.email.Length;

            if (lonRazonSoc < 1 || lonRazonSoc > 255)
                mensaje = "La longitud de la razón social debe estar entre 1 y 255 caracteres." + Environment.NewLine;

            if (lonNomContac > 255)
                mensaje = "La longitud del nombre de contacto no puede superar 255 caracteres." + Environment.NewLine;

            //if (lonCUIT != 11)
            //    mensaje = "La CUIT debe estar compuesta por 11 dígitos" + Environment.NewLine;

            if (cliente.idSituacionFrenteIva == -1)
                mensaje = "La situación frente al IVA es obligatoria." + Environment.NewLine;

            if (lonDir < 1 || lonDir > 255)
                mensaje = "La longitud de la dirección debe estar entre 1 y 255 caracteres." + Environment.NewLine;

            if (cliente.idLocalidad == -1)
                mensaje = "La localidad es obligatoria." + Environment.NewLine;

            if (lonMail > 60)
                mensaje = "La longitud del mail no puede superar los 60 caracteres." + Environment.NewLine;

            if (lonTel > 50)
                mensaje = "La longitud del teléfono no puede superar 50 caracteres." + Environment.NewLine;

            if (lonTel2 > 50)
                mensaje = "La longitud del teléfono 2 no puede superar los 50 caracteres." + Environment.NewLine;

            if (lonFax > 50)
                mensaje = "La longitud del fax no puede superar los 50 caracteres." + Environment.NewLine;

            foreach(Planta planta in cliente.Planta)
            {
                ValidarPlanta(planta, accion);
            }

            bool existe = (from a in _contexto.Cliente
                           where a.cuit.Equals(cliente.cuit) && !a.cuit.Equals("")
                           select a).Any();

            if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
                mensaje = "El cliente con CUIT " + cliente.cuit + " ya se encuentra cargado." + Environment.NewLine;
            if (!existe && accion == Acciones.Log.BAJA)
                mensaje = "El cliete con cuit " + cliente.cuit + " no existe." + Environment.NewLine;

            existe = (from c in _contexto.Cliente
                      where c.razonSocial == cliente.razonSocial
                      select c).Any();

            if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
                mensaje = "El cliente con razón social " + cliente.razonSocial + " ya se encuentra cargado." + Environment.NewLine;
            if (!existe && accion == Acciones.Log.BAJA)
                mensaje = "El cliete con razón social " + cliente.razonSocial + " no existe." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        #endregion

        #region "Moneda"

        public Moneda obtenerMoneda(long id)
        {
            return _contexto.Moneda.Where(m => m.id == id).First();
        }

        public Moneda obtenerMoneda(string simbologia)
        {
            return _contexto.Moneda.Where(m => m.simbologia == simbologia).First();
        }

        public List<Moneda> obtenerTodosMoneda()
        {
            return _contexto.Moneda.ToList();
        }

        //public bool actualizarCotizacionDolar(decimal nuevoValor)
        //{
        //    Moneda dolar = _contexto.Moneda.Where(m => m.id == 1).First();
        //    dolar.cotizacion = nuevoValor;
        //    _contexto.SaveChanges();

        //    return true;
        //}

        public bool actualizarCotizacionMoneda(int idMoneda, decimal nuevoValor)
        {
            Moneda mon = _contexto.Moneda.Find(idMoneda); //.Where(m => m.id == idMoneda).Single();
            mon.cotizacion = nuevoValor;
            _contexto.SaveChanges();

            return true;
        }

        //public decimal obtenerCotizacionDolar()
        //{
        //    return _contexto.Moneda.Where(m => m.id == 1).First().cotizacion;
        //}

        public decimal obtenerCotizacionMoneda(int idMoneda)
        {
            return _contexto.Moneda.Where(m => m.id == idMoneda).Single().cotizacion;
        }

        #endregion

        #region "Precios - Articulo Planta"         

        public List<ArticuloPlantaHistorico> buscarArticulosPlantaHistorico(TipoArticulo tipoArticulo, Planta planta, decimal precio, string codigo, int numeroRegistros)
        {
            IQueryable<ArticuloPlantaHistorico> query = _contexto.ArticuloPlantaHistorico.Include("ArticuloPlanta").Include("ArticuloPlanta.Planta").Include("ArticuloPlanta.TipoArticulo").Include("ArticuloPlanta.Moneda");

            if (tipoArticulo != null)
                query = query.Where(a => a.ArticuloPlanta.idArticulo == tipoArticulo.id);

            if (planta != null)
                query = query.Where(a => a.ArticuloPlanta.idPlanta == planta.id);

            if (precio != 0)
                query = query.Where(a => a.precio == precio);

            if (!String.IsNullOrWhiteSpace(codigo))
                query = query.Where(a => (a.ArticuloPlanta.Planta.codigo + a.ArticuloPlanta.contador.ToString()).Contains(codigo));

            return query.Take(numeroRegistros).ToList();
        }

        public int obtenerProximoNumero(long idPlanta)
        {
            return _contexto.ArticuloPlanta.Where(ap => ap.idPlanta == idPlanta).Any() ?  _contexto.ArticuloPlanta.Where(ap => ap.idPlanta == idPlanta).Max(ap => ap.contador)+ 1: 1;
        }

        public List<ArticuloPlanta> obtenerTodosArticulosPlanta(int numeroRegistros)
        {
            return _contexto.ArticuloPlanta.Include("TipoArticulo").Include("Planta").Take(numeroRegistros).ToList();
        }

        public List<ArticuloPlanta> buscarArticulosPlanta(TipoArticulo tipoArticulo, Cliente cliente, Planta planta, decimal precio, string codigo, int numeroRegistros)
        {
            IQueryable<ArticuloPlanta> query = _contexto.ArticuloPlanta.Include("TipoArticulo").Include("Planta");

            if(tipoArticulo != null)
                query = query.Where(a => a.idArticulo == tipoArticulo.id);

            if (planta != null)
                query = query.Where(a => a.idPlanta == planta.id);
            else
                if (cliente != null)
                    query = query.Where(a => a.Planta.idCliente == cliente.id);

            if (precio != 0)
                query = query.Where(a => a.precio == precio);

            if(!String.IsNullOrWhiteSpace(codigo))
                query = query.Where(a => (a.Planta.codigo + a.contador.ToString()).Contains(codigo));

            return query.Take(numeroRegistros).ToList();
        }

        public ArticuloPlanta agregarArticuloPlanta(ArticuloPlanta articuloPlanta, Metadata metadata)
        {
            ArticuloPlanta articuloGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarArticuloPlanta(articuloPlanta);

                articuloPlanta.contador = obtenerProximoNumero(articuloPlanta.idPlanta);

                articuloGuardado = _contexto.ArticuloPlanta.Add(articuloPlanta);
                _contexto.SaveChanges();

                GenerarLog<ArticuloPlanta>(articuloPlanta, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return articuloGuardado;
        }

        public ArticuloPlanta actualizarArticuloPlanta(ArticuloPlanta articuloPlanta, ArticuloPlantaHistorico aph, Metadata metadata)
        {
            ArticuloPlanta articuloGuardado = null;
            ArticuloPlanta articuloBase = null;
            //ArticuloPlantaHistorico aph = new ArticuloPlantaHistorico();
            //QuimadhEntities newContext = new QuimadhEntities();

            using (TransactionScope scope = new TransactionScope())
            {                
                ValidarArticuloPlanta(articuloPlanta, Acciones.Log.MODIFICACION);

                //articuloBase = newContext.ArticuloPlanta.Where(ap => ap.idArticulo == articuloPlanta.idArticulo && ap.idPlanta == articuloPlanta.idPlanta).First();                

                //aph.ArticuloPlanta = articuloBase;
                //aph.idMoneda = articuloBase.idMoneda;
                //aph.precio = articuloBase.precio;
                //aph.fechaCambio = articuloBase.fechaCambio;

                _contexto.ArticuloPlantaHistorico.Add(aph);

                //borra los anteriores para cargar la actualización del la rel artículo-planta
                IQueryable<PreciosAdicionales> precios;
                precios = _contexto.PreciosAdicionales.Where(p => p.idArticulo == articuloPlanta.idArticulo && p.idPlanta == articuloPlanta.idPlanta);
                _contexto.PreciosAdicionales.RemoveRange(precios);

                _contexto.SaveChanges();

                GenerarLog<ArticuloPlanta>(articuloPlanta, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return articuloGuardado;
        }

        public ArticuloPlanta eliminarArticuloPlanta(ArticuloPlanta articuloPlanta, Metadata metadata)
        {
            ArticuloPlanta articuloGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarArticuloPlanta(articuloPlanta, Acciones.Log.BAJA);

                _contexto.ArticuloPlanta.Remove(articuloPlanta);
                _contexto.SaveChanges();

                GenerarLog<ArticuloPlanta>(articuloPlanta, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return articuloGuardado;
        }

        private void ValidarArticuloPlanta(ArticuloPlanta articuloPlanta, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";
            bool existe;

            if(articuloPlanta.idPlanta == null)
                mensaje += "La planta es obligatoria." + Environment.NewLine;

            if(articuloPlanta.idArticulo == null)
                mensaje += "El artículo es obligatorio." + Environment.NewLine;
                
            if(articuloPlanta.precio == 0)
                mensaje += "El precio debe ser distinto de cero." + Environment.NewLine;

            if(articuloPlanta.idMoneda == null)
                mensaje += "La moneda es obligatoria." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);

            existe = (from a in _contexto.ArticuloPlanta
                           where a.idArticulo == articuloPlanta.idArticulo && a.idPlanta == articuloPlanta.idPlanta
                           select a).Any();

            if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
                mensaje += "El precio del artículo para la planta ya se encuentra cargado." + Environment.NewLine;
            if (!existe && accion == Acciones.Log.BAJA)
                mensaje += "El precio del artículo para la planta no existe." + Environment.NewLine;

            if (accion == Acciones.Log.BAJA)
            {
                mensaje += _contexto.ArticuloPlanta.Where(ap => ap.idArticulo == articuloPlanta.idArticulo && ap.idPlanta == articuloPlanta.idPlanta).Any() ? mensaje + "No es posible eliminar el artículo. El mismo posee plantas asociadas." + Environment.NewLine : mensaje;
            }

            existe = (from u in _contexto.Moneda
                      where u.id == articuloPlanta.idMoneda
                      select u).Any();

            if (!existe)
                mensaje += "El artículo posee una moneda incorrecta." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        public ArticuloPlanta buscarUnArticuloPlanta(string nombre)
        {
            IQueryable<ArticuloPlanta> query = _contexto.ArticuloPlanta.Where(ap => ap.Planta.codigo.Trim() + ap.contador.ToString().Trim() == nombre);
            if (query.Count() == 0)
                return null;
            return query.First();
        }

        public ArticuloPlanta buscarUnArticuloPlantaXDesc(Planta planta,string descrip)
        {
            IQueryable<ArticuloPlanta> query = _contexto.ArticuloPlanta.Where(ap => ap.TipoArticulo.nombre == descrip);
            query = query.Where(ap => ap.Planta.id == planta.id);
            if (query.Count() == 0)
                return null;
            return query.First();
        }

        #endregion

        #region "Planta"

        public Planta obtenerPlanta(long id)
        {
            return _contexto.Planta.Include("Cliente").Where(p => p.id == id).First();
        }

        public List<Planta> obtenerTodosPlanta()
        {
            return _contexto.Planta.Include("Cliente").Include("ArticuloPlanta").ToList();
        }

        public List<Planta> obtenerPlantasConClientes()
        {
            return _contexto.Planta.Include("Cliente").Include("ArticuloPlanta").Where(p => p.Cliente != null).ToList();
        }

        public Planta buscarUnaPlanta(string codPlanta,string nomPlanta)
        {
            IQueryable<Planta> query = _contexto.Planta;
            if (codPlanta != "")
                query = query.Where(p => p.codigo == codPlanta);
            if (nomPlanta != "")
                query = query.Where(p => p.nombre == nomPlanta);
            return query.Any() ? query.First() : null;
        }

        public List<Planta> buscarPlantas(string codPlanta, string nomPlanta,Cliente cliente, int numeroRegistros)
        {
            IQueryable<Planta> query = _contexto.Planta;//.Include("Cliente");
            if(codPlanta != null)
                query = query.Where(p => p.codigo.Contains(codPlanta));
            if(nomPlanta != null)
                query = query.Where(p => p.nombre.Contains(nomPlanta));
            if (cliente != null)
                query = query.Where(p => p.idCliente == cliente.id);

            return query.Take(numeroRegistros).ToList();
        }

        private void ValidarPlanta(Planta  planta, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";
            int lonCodigo = planta.codigo.Length;
            int lonNom = planta.nombre.Length;
            int lonDir = planta.direccion.Length;

            if (lonCodigo < 1 || lonCodigo > 5)
                mensaje = "La longitud del código de planta debe estar entre 1 y 5 caracteres." + Environment.NewLine;
            if (lonNom < 1 || lonNom > 255)
                mensaje = "La longitud del nombre de planta debe estar entre 1 y 255 caracteres." + Environment.NewLine;
            if (lonDir > 255)
                mensaje = "La longitud de la dirección de la planta no puede superar los 255 caracteres." + Environment.NewLine;

            bool existe = (from p in _contexto.Planta
                           where p.codigo.Equals(planta.codigo)
                           select p).Any();

            if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
                mensaje = "La planta con código " + planta.codigo + " ya se encuentra cargada." + Environment.NewLine;
            if (!existe && accion == Acciones.Log.BAJA)
                mensaje = "La planta " + planta.codigo + " no existe." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        public Planta agregarPlanta(Planta planta, Metadata metadata)
        {
            Planta plantaGuardada;
            using (TransactionScope scope = new TransactionScope())
            {
                plantaGuardada = _contexto.Planta.Add(planta);

                GenerarLog<Planta>(planta, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return plantaGuardada;
        }

        public void actualizarPlanta(Planta planta)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                _contexto.SaveChanges();

                scope.Complete();
            }
        }

        #endregion

        #region "Muestra"

        public List<Muestra> obtenerTodosMuestra(int numeroRegistros)
        {
            return _contexto.Muestra.Take(numeroRegistros).ToList();
        }

        public Muestra obtenerMuestra(long id)
        {
            return _contexto.Muestra.Where(m => m.Id == id).First();
        }

        public Muestra  obtenerMuestra(string descripcion)
        {
            return _contexto.Muestra.Where(m => m.Descripcion.Equals(descripcion)).First();
        }

        public List<Muestra> buscarMuestras(string codigo, string descripcion, int numeroRegistros)
        {
            IQueryable<Muestra> query = _contexto.Muestra;

            query = query.Where(a => a.Codigo.Contains(codigo));

            query = query.Where(a => a.Descripcion.Contains(descripcion));

            return query.Take(numeroRegistros).ToList();
        }

        public Muestra agregarMuestra(Muestra muestra, Metadata metadata)
        {
            Muestra muestraGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarMuestra(muestra);

                muestraGuardada = _contexto.Muestra.Add(muestra);
                _contexto.SaveChanges();

                GenerarLog<Muestra>(muestra, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return muestraGuardada;
        }

        public Muestra actualizarMuestra(Muestra muestra, Metadata metadata)
        {
            Muestra muestraGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarMuestra(muestra, Acciones.Log.MODIFICACION);

                _contexto.SaveChanges();

                GenerarLog<Muestra>(muestra, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return muestraGuardada;
        }

        public Muestra eliminarMuestra(Muestra muestra, Metadata metadata)
        {
            Muestra muestraGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarMuestra(muestra, Acciones.Log.BAJA);

                _contexto.Muestra.Remove(muestra);
                _contexto.SaveChanges();

                GenerarLog<Muestra>(muestra, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return muestraGuardada;
        }

        private void ValidarMuestra(Muestra muestra, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";
            int lonCodigo = muestra.Codigo.Length;
            int lonDescripcion = muestra.Descripcion.Length;

            if (lonCodigo < 0 || lonCodigo > 50)
                mensaje += "La longitud del código debe estar entre 1 y 50 caracteres." + Environment.NewLine;

            if (lonDescripcion < 0 || lonDescripcion > 255)
                mensaje += "La longitud de la descripción debe estar entre 1 y 255 caracteres." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);

            bool existe = (from a in _contexto.Muestra
                           where a.Codigo.Equals(muestra.Codigo) || a.Descripcion.Equals(muestra.Descripcion)
                           select a).Any();

            if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
                mensaje = "La muestra con código " + muestra.Codigo + " ya se encuentra cargada." + Environment.NewLine;
            if (!existe && accion == Acciones.Log.BAJA)
                mensaje = "La muestra con código " + muestra.Codigo + " no existe." + Environment.NewLine;

            if (accion == Acciones.Log.BAJA)
            {
                //mensaje += _contexto.ArticuloPlanta.Where(ap => ap.idArticulo == muestra.id).Any() ? mensaje + "No es posible eliminar la muestra. La misma posee relaciones asociadas." + Environment.NewLine : mensaje;
            }

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        #endregion

        #region "Firmas"

        public List<CabeceraRutinaFirmantes> obtenerTodosFirmas(int numeroRegistros)
        {
            return _contexto.CabeceraRutinaFirmantes.Take(numeroRegistros).ToList();
        }

        public CabeceraRutinaFirmantes obtenerFirma(string nombre)
        {
            return _contexto.CabeceraRutinaFirmantes.Where(m => m.nombre.Equals(nombre)).First();
        }

        public List<CabeceraRutinaFirmantes> buscarFirmas(string nombre, int numeroRegistros)
        {
            IQueryable<CabeceraRutinaFirmantes> query = _contexto.CabeceraRutinaFirmantes;

            query = query.Where(a => a.nombre.Contains(nombre));

            return query.Take(numeroRegistros).ToList();
        }

        public CabeceraRutinaFirmantes agregarFirma(CabeceraRutinaFirmantes firma, Metadata metadata)
        {
            CabeceraRutinaFirmantes muestraGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarFirma(firma);

                muestraGuardada = _contexto.CabeceraRutinaFirmantes.Add(firma);
                _contexto.SaveChanges();

                GenerarLog<CabeceraRutinaFirmantes>(firma, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return muestraGuardada;
        }

        public CabeceraRutinaFirmantes actualizarFirma(CabeceraRutinaFirmantes firma, Metadata metadata)
        {
            CabeceraRutinaFirmantes muestraGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarFirma(firma, Acciones.Log.MODIFICACION);

                _contexto.SaveChanges();

                GenerarLog<CabeceraRutinaFirmantes>(firma, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return muestraGuardada;
        }

        public CabeceraRutinaFirmantes eliminarFirma(CabeceraRutinaFirmantes firma, Metadata metadata)
        {
            CabeceraRutinaFirmantes muestraGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarFirma(firma, Acciones.Log.BAJA);

                _contexto.CabeceraRutinaFirmantes.Remove(firma);
                _contexto.SaveChanges();

                GenerarLog<CabeceraRutinaFirmantes>(firma, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return muestraGuardada;
        }

        private void ValidarFirma(CabeceraRutinaFirmantes firma, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";
            int lonNombre = firma.nombre.Length;

            if (lonNombre < 0 || lonNombre > 50)
                mensaje += "La longitud del nombre debe estar entre 1 y 50 caracteres." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);

            bool existe = (from a in _contexto.CabeceraRutinaFirmantes
                           where a.nombre.Equals(firma.nombre)
                           select a).Any();

            if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
                mensaje = "La firma " + firma.nombre + " ya se encuentra cargada." + Environment.NewLine;
            if (!existe && accion == Acciones.Log.BAJA)
                mensaje = "La firma " + firma.nombre + " no existe." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        #endregion

        #region "DatosRutina"

        public List<CabeceraRutina> buscarRutinas(Cliente cliente, Planta planta, string tipoRutina, DateTime desde, DateTime hasta, int numeroRegistros)
        {
            IQueryable<CabeceraRutina> query = _contexto.CabeceraRutina.Include("Planta");

            if(planta != null)
                query = query.Where(a => a.idPlanta == planta.id);
            if (cliente != null && planta == null)
                query = query.Where(a => a.Planta.idCliente == cliente.id);
            if (tipoRutina != "")
                query = query.Where(a => a.tipoRutina == tipoRutina);

            query = query.Where(a => a.fechaMuestreo <= hasta && a.fechaMuestreo >= desde);

            //query = query.Where(a => a.fechaAnalisis <= hasta && a.fechaAnalisis >= desde);

            return query.OrderByDescending(r => r.id).Take(numeroRegistros).ToList();
        }

        public List<DatosRutina> getDatosRutina(CabeceraRutina rutina)
        {
            return _contexto.DatosRutina.Include("CabeceraRutina").Include("Determinante").Include("Muestra").Where(p => p.CabeceraRutina.id == rutina.id).ToList();
        }

        public CabeceraRutina agregarDatosRutina(CabeceraRutina rutina, List<DatosRutina> dr, Metadata metadata)
        {           
            using (TransactionScope scope = new TransactionScope())
            {
                //ValidarRutina(plantaGuardada, dr, mp);

                _contexto.CabeceraRutina.Add(rutina);

                _contexto.SaveChanges();

                foreach (DatosRutina d in dr)
                {
                    d.idCabeceraRutina = rutina.id;
                    _contexto.DatosRutina.Add(d);
                }

                _contexto.SaveChanges();

                GenerarLogMensaje("Se ha dado de alta una rutina para la planta " + rutina.idPlanta, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return rutina;
        }

        public bool ExisteNroInternoRutina(CabeceraRutina rutina)
        {
            return _contexto.CabeceraRutina.Where(r => r.id != rutina.id && r.numeroInterno == rutina.numeroInterno).Any();
        }

        public CabeceraRutina actualizarDatosRutina(CabeceraRutina rutina, List<DatosRutina> datosRutina, Metadata metadata)
        {
            CabeceraRutina rutinaLocal;

            using (TransactionScope scope = new TransactionScope())
            {
                //ValidarRutina(planta, datosRutina, Acciones.Log.MODIFICACION);

                rutinaLocal = _contexto.CabeceraRutina.Where(r => r.id == rutina.id).First();
                rutinaLocal.fechaMuestreo = rutina.fechaMuestreo;
                rutinaLocal.fechaAnalisis = rutina.fechaAnalisis;
                rutinaLocal.idPlanta = rutina.idPlanta;

                _contexto.SaveChanges();

                _contexto.DatosRutina.RemoveRange(_contexto.DatosRutina.Where(d => d.idCabeceraRutina == rutina.id));                

                foreach (DatosRutina d in datosRutina)
                {
                    d.idCabeceraRutina = rutina.id;
                    _contexto.DatosRutina.Add(d);
                }
                _contexto.SaveChanges();

                

                GenerarLogMensaje("Se ha modificado la rutina de la planta " + rutina.idPlanta, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return rutina;
        }

        public CabeceraRutina eliminarDatosRutina(CabeceraRutina rutina, Metadata metadata)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                //ValidarRutina(planta, datosRutina, Acciones.Log.MODIFICACION);

                _contexto.DatosRutina.RemoveRange(_contexto.DatosRutina.Where(d => d.idCabeceraRutina == rutina.id));
                _contexto.CabeceraRutina.Remove(rutina);

                _contexto.SaveChanges();

                GenerarLogMensaje("Se ha elimninado la rutina de la planta " + rutina.idPlanta, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return null;
        }

        #endregion

        #region "Rutina"

        public CabeceraRutina obtenerDatosResultadoAnalisis(long idCabeceraRutina)
        {
            return _contexto.CabeceraRutina.Include("DatosRutina").Include("DatosRutina.Muestra").Include("Planta").Include("Planta.Cliente").Include("Planta.Cliente.Localidad").Include("CabeceraRutinaFirmantes").Where(c => c.id == idCabeceraRutina).First();
        }

        public List<Determinante> obtenerDeterminantesPlanta(Planta planta)
        {
            return _contexto.Determinante.Where(d => _contexto.DeterminantesPlanta.Where(dp => dp.idPlanta == planta.id && dp.idDeterminante == d.id).Any()).ToList();
        }

        public List<Muestra> obtenerMuestrasPlanta(Planta planta)
        {
            return _contexto.Muestra.Where(d => _contexto.MuestraPlanta.Where(dp => dp.idPlanta == planta.id && dp.idMuestra == d.Id).Any()).ToList();
        }

        public List<Planta> obtenerPlantasSinRutina()
        {
            return _contexto.Planta.Where(p => !_contexto.DeterminantesPlanta.Where(dp => p.id == dp.idPlanta).Any() &&
                                               !_contexto.MuestraPlanta.Where(mp => p.id == mp.idPlanta).Any()).ToList();
        }

        public Planta agregarRutina(Planta planta, List<DeterminantesPlanta> dp, List<MuestraPlanta> mp, Metadata metadata)
        {
            Planta plantaGuardada = _contexto.Planta.Where(p => p.id == planta.id).First();

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarRutina(plantaGuardada, dp, mp);

                foreach (DeterminantesPlanta d in dp)
                {
                    _contexto.DeterminantesPlanta.Add(d);
                }

                foreach (MuestraPlanta m in mp)
                {
                    _contexto.MuestraPlanta.Add(m);
                }

                _contexto.SaveChanges();

                GenerarLogMensaje("Se ha dado de alta una rutina para la planta " + planta.nombre, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return plantaGuardada;
        }

        public Planta actualizarRutina(Planta planta, List<DeterminantesPlanta> dp, List<MuestraPlanta> mp, Metadata metadata)
        {
            Planta plantaGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarRutina(planta, dp, mp, Acciones.Log.MODIFICACION);

                _contexto.DeterminantesPlanta.RemoveRange(_contexto.DeterminantesPlanta.Where(d => d.idPlanta == planta.id));
                _contexto.MuestraPlanta.RemoveRange(_contexto.MuestraPlanta.Where(m => m.idPlanta == planta.id));                

                _contexto.SaveChanges();

                foreach (DeterminantesPlanta d in dp)
                {
                    _contexto.DeterminantesPlanta.Add(d);
                }

                foreach (MuestraPlanta m in mp)
                {
                    _contexto.MuestraPlanta.Add(m);
                }
                _contexto.SaveChanges();

                GenerarLogMensaje("Se ha modificado la rutina de la planta " + planta.nombre, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return plantaGuardada;
        }

        public Planta eliminarRutina(Planta planta, Metadata metadata)
        {
            Planta plantaGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarRutina(planta, null, null, Acciones.Log.BAJA);

                _contexto.DeterminantesPlanta.RemoveRange(_contexto.DeterminantesPlanta.Where(d => d.idPlanta == planta.id));
                _contexto.MuestraPlanta.RemoveRange(_contexto.MuestraPlanta.Where(m => m.idPlanta == planta.id));                

                _contexto.SaveChanges();

                GenerarLogMensaje("Se ha dado de baja la rutina de la planta " + planta.nombre, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return plantaGuardada;
        }

        private void ValidarRutina(Planta planta, List<DeterminantesPlanta> dp, List<MuestraPlanta> mp, Acciones.Log accion = Acciones.Log.ALTA)
        {
            //string mensaje = "";
            //int lonCodigo = muestra.Codigo.Length;
            //int lonDescripcion = muestra.Descripcion.Length;

            //if (lonCodigo < 0 || lonCodigo > 50)
            //    mensaje += "La longitud del código debe estar entre 1 y 50 caracteres." + Environment.NewLine;

            //if (lonDescripcion < 0 || lonDescripcion > 255)
            //    mensaje += "La longitud de la descripción debe estar entre 1 y 255 caracteres." + Environment.NewLine;

            //if (mensaje != "")
            //    throw new ExcepcionValidacion(mensaje);

            //bool existe = (from a in _contexto.Muestra
            //               where a.Codigo.Equals(muestra.Codigo) || a.Descripcion.Equals(muestra.Descripcion)
            //               select a).Any();

            //if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
            //    mensaje = "La muestra con código " + muestra.Codigo + " ya se encuentra cargada." + Environment.NewLine;
            //if (!existe && accion == Acciones.Log.BAJA)
            //    mensaje = "La muestra con código " + muestra.Codigo + " no existe." + Environment.NewLine;

            //if (accion == Acciones.Log.BAJA)
            //{
            //    //mensaje += _contexto.ArticuloPlanta.Where(ap => ap.idArticulo == muestra.id).Any() ? mensaje + "No es posible eliminar la muestra. La misma posee relaciones asociadas." + Environment.NewLine : mensaje;
            //}

            //if (mensaje != "")
            //    throw new ExcepcionValidacion(mensaje);
        }

        #endregion

        #region "Determinante"

        public List<Determinante> obtenerTodosDeterminante(int numeroRegistros)
        {
            return _contexto.Determinante.Take(numeroRegistros).ToList();
        }

        public Determinante obtenerDeterminante(long id)
        {
            return _contexto.Determinante.Where(m => m.id == id).First();
        }

        public Determinante obtenerDeterminante(string nombre)
        {
            return _contexto.Determinante.Where(m => m.nombre.Equals(nombre)).First();
        }

        public List<Determinante> buscarDeterminantes(string nombre, string unidad, int numeroRegistros)
        {
            IQueryable<Determinante> query = _contexto.Determinante;

            query = query.Where(a => a.nombre.Contains(nombre));

            query = query.Where(a => a.unidad.Contains(unidad));

            return query.Take(numeroRegistros).ToList();
        }

        public Determinante agregarDeterminante(Determinante determinante, Metadata metadata)
        {
            Determinante determinanteGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarDeterminante(determinante);

                determinanteGuardado = _contexto.Determinante.Add(determinante);
                _contexto.SaveChanges();

                GenerarLog<Determinante>(determinante, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return determinanteGuardado;
        }

        public Determinante actualizarDeterminante(Determinante muestra, Metadata metadata)
        {
            Determinante determinanteGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarDeterminante(muestra, Acciones.Log.MODIFICACION);

                _contexto.SaveChanges();

                GenerarLog<Determinante>(muestra, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return determinanteGuardado;
        }

        public Determinante eliminarDeterminante(Determinante determinante, Metadata metadata)
        {
            Determinante determinanteGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarDeterminante(determinante, Acciones.Log.BAJA);

                _contexto.Determinante.Remove(determinante);
                _contexto.SaveChanges();

                GenerarLog<Determinante>(determinante, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return determinanteGuardado;
        }

        private void ValidarDeterminante(Determinante determinante, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";
            int lonNombre = determinante.nombre.Length;
            int lonUnidad = determinante.unidad.Length;

            if (lonNombre < 0 || lonNombre > 50)
                mensaje += "La longitud del nombre debe estar entre 1 y 50 caracteres." + Environment.NewLine;

            if (lonUnidad < 0 || lonUnidad > 255)
                mensaje += "La longitud de la unidad debe estar entre 1 y 255 caracteres." + Environment.NewLine;

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);

            bool existe = (from a in _contexto.Determinante
                           where a.nombre.Equals(determinante.nombre)
                           select a).Any();

            if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
                mensaje = "El determinante con nombre " + determinante.nombre + " ya se encuentra cargado." + Environment.NewLine;
            if (!existe && accion == Acciones.Log.BAJA)
                mensaje = "El determinante con nombre " + determinante.nombre + " no existe." + Environment.NewLine;

            if (accion == Acciones.Log.BAJA)
            {
                //mensaje += _contexto.ArticuloPlanta.Where(ap => ap.idArticulo == muestra.id).Any() ? mensaje + "No es posible eliminar la muestra. La misma posee relaciones asociadas." + Environment.NewLine : mensaje;
            }

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        #endregion

        #region "Presentacion"

        public List<Presentacion> obtenerTodosPresentaciones(int numeroRegistros)
        {
            return _contexto.Presentacion.Take(numeroRegistros).ToList();
        }

        public Presentacion obtenerPresentacionPorLitros(int litros)
        {
            return _contexto.Presentacion.Where(p => p.litrosEnvase == litros).FirstOrDefault();
        }

        public Presentacion obtenerPresentacion(int id)
        {
            return _contexto.Presentacion.Where(p => p.id == id).FirstOrDefault();
        }

        #endregion

        #region "Entdada"

        public Entrada agregarEntrada(Entrada entrada, Metadata metadata)
        {
            Entrada entradaGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarEntrada(entrada);

                entradaGuardada = _contexto.Entrada.Add(entrada);   
                             
                _contexto.SaveChanges();

                GenerarLog<Entrada>(entrada, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return entradaGuardada;
        }

        private void ValidarEntrada(Entrada entrada, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";

            if (entrada.cantidad == 0)
            {
                mensaje = "Debe seleccionar una cantidad";
            }

            if (entrada.Lote == null)
            {
                mensaje = "Debe seleccionar un lote";
            }

            if (entrada.idPresentacion == -1)
            {
                mensaje = "Debe seleccionar una presentación";
            }

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        public Entrada actualizarEntrada(Entrada entrada, Metadata metadata)
        {
            Entrada entradaGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                _contexto.SaveChanges();

                GenerarLog<Entrada>(entrada, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return entradaGuardada;
        }

        public Entrada eliminarEntrada(Entrada entrada, Metadata metadata)
        {
            Entrada entradaGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {                
                _contexto.Entrada.Remove(entrada);
                _contexto.SaveChanges();

                GenerarLog<Entrada>(entrada, Acciones.Log.BAJA, metadata);

                scope.Complete();
            }

            return entradaGuardada;
        }

        public List<Entrada> buscarEntradas(TipoArticulo tipoArticulo, DateTime fd, DateTime fh, int numeroRegistros)
        {
            IQueryable<Entrada> query = _contexto.Entrada.Include("Lote.TipoArticulo"); 

            if (tipoArticulo != null)
                query = query.Where(a => a.Lote.idTipoArticulo == tipoArticulo.id);
            
            query = query.Where(a => a.fecha >= fd.Date);
            query = query.Where(a => a.fecha <= fh.Date);
            return query.Take(numeroRegistros).OrderByDescending(e => e.id).ToList();
        }

        public List<Entrada> obtenerTodosEntradas(int numeroRegistros)
        {
            return _contexto.Entrada.Take(numeroRegistros).ToList();
        }

        #endregion "Entrada"

        #region "Salida"

        private void ValidarSalida(Salida salida, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";

            if (salida.cantidad == 0)
            {
                mensaje = "Debe seleccionar una cantidad";
            }
            if (string.IsNullOrEmpty(salida.nombreVendedor) && salida.idCliente == (long?)null)
            {
                mensaje = "Debe ingresar un vendedor o seleccionar un cliente";
            }
            if (salida.Lote == null)
            {
                mensaje = "Debe seleccionar un lote";
            }

            //if (salida.idPresentacion == -1)
            //{
            //    mensaje = "Debe seleccionar una presentación";
            //}

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        public List<Salida> buscarSalidas(TipoArticulo tipoArticulo, DateTime fd, DateTime fh, int numeroRegistros)
        {
            IQueryable<Salida> query = _contexto.Salida.Include("Lote.TipoArticulo");

            if (tipoArticulo != null)
                query = query.Where(a => a.Lote.idTipoArticulo == tipoArticulo.id);

            query = query.Where(a => a.fecha >= fd.Date);
            query = query.Where(a => a.fecha <= fh.Date);
            return query.Take(numeroRegistros).OrderByDescending(s => s.id).ToList();
        }

        public List<string> ObtenerNombresVendedores()
        {
            List<string> query = _contexto.Salida.Where(v => !string.IsNullOrEmpty(v.nombreVendedor)).Select(v => v.nombreVendedor).Distinct().ToList();

            return query;
        }

        public Salida eliminarSalida(Salida salida, Metadata metadata)
        {
            Salida salidaGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                _contexto.Salida.RemoveRange(salida.Salida1);
                _contexto.Salida.Remove(salida);
                _contexto.SaveChanges();

                GenerarLog<Salida>(salida, Acciones.Log.BAJA, metadata);

                scope.Complete();
            }

            return salidaGuardada;
        }

        public Salida actualizarSalida(Salida salida, Metadata metadata)
        {
            Salida salidaGuardada = null;

            ValidarSalida(salida);

            using (TransactionScope scope = new TransactionScope())
            {
                ObtenerSalidasMateriasPrimas(salida, metadata);

                //borra las salidas inferidas por composicion antes de cargar la modificacion (para que cargue las nuevas)
                IQueryable<Salida> salidasInferidas = _contexto.Salida.Where(s => s.idSalidaPadre == salida.id);
                _contexto.Salida.RemoveRange(salidasInferidas);                
                _contexto.SaveChanges();

                GenerarLog<Salida>(salida, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return salidaGuardada;
        }

        public Salida agregarSalida(Salida salida, Metadata metadata)
        {
            Salida salidaGuardada = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarSalida(salida);

                ObtenerSalidasMateriasPrimas(salida, metadata);

                salidaGuardada = _contexto.Salida.Add(salida);
                _contexto.SaveChanges();

                GenerarLog<Salida>(salida, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return salidaGuardada;
        }

        public void ObtenerSalidasMateriasPrimas(Salida salidaPadre, Metadata metadata)
        {
            //calcula las salidas aca para que se pueda llamar desde remitos
            ICollection<ComposicionArticulos> salidasCalculadas = salidaPadre.Lote.TipoArticulo.ComposicionArticulos;
            salidaPadre.Salida1.Clear();
            foreach (ComposicionArticulos comp in salidasCalculadas)
            {
                Salida salCalc = new Salida();
                salCalc.Lote = obtenerLoteMateriaPrima(comp.TipoArticulo1, metadata);
                if (salidaPadre.idPresentacion.HasValue)
                    salCalc.idPresentacion = salidaPadre.idPresentacion;
                salCalc.cantidad = Math.Round(salidaPadre.cantidad * comp.cantComposicion * comp.factorConversion, 2);
                salCalc.nombreVendedor = salidaPadre.nombreVendedor;
                salCalc.idCliente = salidaPadre.idCliente;
                salCalc.fecha = salidaPadre.fecha;
                salCalc.VentaArticuloPlanta = salidaPadre.VentaArticuloPlanta;
                //agrega las salidas derivadas
                salidaPadre.Salida1.Add(salCalc);
            }
        }

        #endregion "Salida"

        #region "Lote"

        public Lote eliminarLote(Lote lote, Metadata metadata)
        {
            Lote loteGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarLote(lote, Acciones.Log.BAJA);
                _contexto.Lote.Remove(lote);
                _contexto.SaveChanges();

                GenerarLog<Lote>(lote, Acciones.Log.BAJA, metadata);

                scope.Complete();
            }

            return loteGuardado;
        }

        public List<Lote> obtenerTodosLotes(int numeroRegistros)
        {
            return _contexto.Lote.Where(l => l.numero.Substring(0,3) != "MP-").Take(numeroRegistros).ToList();
        }

        public List<Lote> buscarLotes(TipoArticulo tipoArticulo, string nroLote, int numeroRegistros)
        {
            IQueryable<Lote> query = _contexto.Lote.Where(l => l.numero.Substring(0,3) != "MP-");

            if (tipoArticulo != null)
                query = query.Where(a => a.idTipoArticulo == tipoArticulo.id);

            if (nroLote != "")
                query = query.Where(l => l.numero == nroLote);

            return query.Take(numeroRegistros).ToList();
        }

        public List<Lote> obtenerLotes(TipoArticulo tipoArt, short estado)
        {
            if (estado == 0)//busca lotes abiertos
                return _contexto.Lote.Where(l => l.TipoArticulo.id == tipoArt.id && l.fechaCierre == null && l.numero.Substring(0, 3) != "MP-" && l.numero.Substring(0, 3) != "PF-").ToList();
            else if (estado == 1) //busca lotes cerrados
                return _contexto.Lote.Where(l => l.TipoArticulo.id == tipoArt.id && l.fechaCierre != null && l.numero.Substring(0, 3) != "MP-" && l.numero.Substring(0, 3) != "PF-").ToList();
            else if (estado == 2) //busca todos los lotes
                return _contexto.Lote.Where(l => l.TipoArticulo.id == tipoArt.id && l.numero.Substring(0, 3) != "MP-" && l.numero.Substring(0, 3) != "PF-").ToList();
            else if (estado == 3)
            {
                //busca todos los lotes pero de los cerrados solo los últimos 2 años para que no se llenen los combos
                DateTime fecha = DateTime.Now.AddYears(-2);
                return _contexto.Lote.Where(l => l.TipoArticulo.id == tipoArt.id && l.numero.Substring(0, 3) != "MP-" && (l.fechaCierre == null || l.fechaInicio >= fecha)).ToList();
            }
            else
                return null;
        }

        public Lote obtenerLote(String nroLote)
        {
            return _contexto.Lote.Where(l => l.numero == nroLote).FirstOrDefault();
        }

        public Lote obtenerLoteMateriaPrima(TipoArticulo art, Metadata metadata)
        {
            Lote loteMp;
            loteMp = _contexto.Lote.Where(l => l.TipoArticulo.id == art.id && l.numero.Substring(0, 3) == "MP-").FirstOrDefault();
            if (loteMp == null)
            {
                loteMp = new Lote();
                loteMp.numero = "MP-" + art.id.ToString();
                loteMp.fechaInicio = DateTime.Now;
                loteMp.idTipoArticulo = art.id;

                agregarLote(loteMp, metadata);
            }
            
            return loteMp;
        }

        public Lote obtenerLoteProductoFinal(TipoArticulo art, Metadata metadata)
        {
            Lote loteMp;
            loteMp = _contexto.Lote.Where(l => l.TipoArticulo.id == art.id && l.numero.Substring(0, 3) == "PF-").FirstOrDefault();
            if (loteMp == null)
            {
                loteMp = new Lote();
                loteMp.numero = "PF-" + art.id.ToString();
                loteMp.fechaInicio = DateTime.Now;
                loteMp.idTipoArticulo = art.id;

                agregarLote(loteMp, metadata);
            }

            return loteMp;
        }

        public Lote agregarLote(Lote lote, Metadata metadata)
        {
            Lote loteGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarLote(lote);

                loteGuardado = _contexto.Lote.Add(lote);
                _contexto.SaveChanges();

                GenerarLog<Lote>(lote, Acciones.Log.ALTA, metadata);

                scope.Complete();
            }

            return loteGuardado;
        }

        private void ValidarLote(Lote lote, Acciones.Log accion = Acciones.Log.ALTA)
        {
            string mensaje = "";

            if (lote.numero.Trim() == "")
                mensaje = "Debe ingresar un Nro. de Lote";

            if (lote.idTipoArticulo == -1)
                mensaje = "Debe seleccionar un artículo";

            bool existe = (from l in _contexto.Lote
                           where l.numero.Equals(lote.numero)
                           select l).Any();

            if (existe && accion != Acciones.Log.BAJA && accion != Acciones.Log.MODIFICACION)
                mensaje = "El lote " + lote.numero + " ya se encuentra cargado." + Environment.NewLine;
            if (!existe && accion == Acciones.Log.BAJA)
                mensaje = "El lote " + lote.numero + " no existe." + Environment.NewLine;

            if (accion == Acciones.Log.BAJA)
            {
                mensaje = _contexto.Entrada.Where(e => e.nroLote == lote.numero).Any() ? mensaje + "No es posible eliminar el lote. El mismo posee entradas asociadas." + Environment.NewLine : mensaje;
            }

            if (mensaje != "")
                throw new ExcepcionValidacion(mensaje);
        }

        public Lote actualizarLote(Lote lote, Metadata metadata)
        {
            Lote loteGuardado = null;

            using (TransactionScope scope = new TransactionScope())
            {
                ValidarLote(lote,Acciones.Log.MODIFICACION);

                _contexto.SaveChanges();

                GenerarLog<Lote>(lote, Acciones.Log.MODIFICACION, metadata);

                scope.Complete();
            }

            return loteGuardado;
        }

        #endregion "Lote"

        #region "Stock"

        public decimal calcularStock(TipoArticulo tipoArt, Lote lote, Presentacion present)
        {
            decimal cantEnt;
            decimal cantSal;

            IQueryable<Entrada> entradas =  _contexto.Entrada.Include("Lote").Include("Presentacion").Where(e => e.Lote.idTipoArticulo == tipoArt.id);
            IQueryable<Salida> salidas = _contexto.Salida.Include("Lote").Include("Presentacion").Where(s => s.Lote.idTipoArticulo == tipoArt.id);

            if (lote != null)
            {
                entradas = entradas.Where(e => e.nroLote == lote.numero);
                salidas = salidas.Where(s => s.nroLote == lote.numero);
            }

            if (present != null)
            {
                entradas = entradas.Where(e => e.idPresentacion == present.id);
                salidas = salidas.Where(s => s.idPresentacion == present.id);
            }

            cantEnt = entradas.Count() > 0 ? entradas.Sum(e => e.cantidad) : 0;//entradas.Sum(e => (e.cantidad * e.Presentacion.litrosEnvase)) : 0;
            cantSal = salidas.Count() > 0 ? salidas.Sum(s => s.cantidad) : 0;//salidas.Sum(s => (s.cantidad * s.Presentacion.litrosEnvase)) : 0;

            return (cantEnt - cantSal);
        }

        #endregion
    }
}
