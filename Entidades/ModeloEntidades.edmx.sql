
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/18/2016 21:19:16
-- Generated from EDMX file: C:\Users\Federico\Documents\Visual Studio 2013\Projects\Quimadh\4 - Desarrollo\Quimadh_nuevo\Entidades\ModeloEntidades.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Quimadh];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ArticuloPlanta_Moneda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArticuloPlanta] DROP CONSTRAINT [FK_ArticuloPlanta_Moneda];
GO
IF OBJECT_ID(N'[dbo].[FK_ArticuloPlanta_Planta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArticuloPlanta] DROP CONSTRAINT [FK_ArticuloPlanta_Planta];
GO
IF OBJECT_ID(N'[dbo].[FK_ArticuloPlanta_TipoArticulo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArticuloPlanta] DROP CONSTRAINT [FK_ArticuloPlanta_TipoArticulo];
GO
IF OBJECT_ID(N'[dbo].[FK_ArticuloPlantaHistorico_ArticuloPlanta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ArticuloPlantaHistorico] DROP CONSTRAINT [FK_ArticuloPlantaHistorico_ArticuloPlanta];
GO
IF OBJECT_ID(N'[dbo].[FK_CabeceraRutina_CabeceraRutinaFirmantes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CabeceraRutina] DROP CONSTRAINT [FK_CabeceraRutina_CabeceraRutinaFirmantes];
GO
IF OBJECT_ID(N'[dbo].[FK_CabeceraRutina_Planta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CabeceraRutina] DROP CONSTRAINT [FK_CabeceraRutina_Planta];
GO
IF OBJECT_ID(N'[dbo].[FK_cliente_fk_Cliente_Localidad1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [FK_cliente_fk_Cliente_Localidad1];
GO
IF OBJECT_ID(N'[dbo].[FK_cliente_fk_Cliente_SituacionFrenteIva1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cliente] DROP CONSTRAINT [FK_cliente_fk_Cliente_SituacionFrenteIva1];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Comprobante_Factura_Moneda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Factura] DROP CONSTRAINT [FK_Comprobante_Comprobante_Factura_Moneda];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Comprobante_Remito_Moneda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Remito] DROP CONSTRAINT [FK_Comprobante_Comprobante_Remito_Moneda];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Comprobante_Remito_Unidad1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Remito] DROP CONSTRAINT [FK_Comprobante_Comprobante_Remito_Unidad1];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Devolucion_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Devolucion] DROP CONSTRAINT [FK_Comprobante_Devolucion_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Devolucion_inherits_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Devolucion] DROP CONSTRAINT [FK_Comprobante_Devolucion_inherits_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Devolucion_Moneda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Devolucion] DROP CONSTRAINT [FK_Comprobante_Devolucion_Moneda];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_DevolucionItemNota]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemNota] DROP CONSTRAINT [FK_Comprobante_DevolucionItemNota];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_EstadoComprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante] DROP CONSTRAINT [FK_Comprobante_EstadoComprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Factura_inherits_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Factura] DROP CONSTRAINT [FK_Comprobante_Factura_inherits_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_FacturaComprobante_Remito]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Remito] DROP CONSTRAINT [FK_Comprobante_FacturaComprobante_Remito];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Recargo_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Recargo] DROP CONSTRAINT [FK_Comprobante_Recargo_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Recargo_inherits_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Recargo] DROP CONSTRAINT [FK_Comprobante_Recargo_inherits_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Recargo_Moneda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Recargo] DROP CONSTRAINT [FK_Comprobante_Recargo_Moneda];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_RecargoItemNota]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemNota] DROP CONSTRAINT [FK_Comprobante_RecargoItemNota];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Recibo_inherits_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Recibo] DROP CONSTRAINT [FK_Comprobante_Recibo_inherits_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_ReciboItemRecibo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemRecibo] DROP CONSTRAINT [FK_Comprobante_ReciboItemRecibo];
GO
IF OBJECT_ID(N'[dbo].[FK_Comprobante_Remito_inherits_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante_Comprobante_Remito] DROP CONSTRAINT [FK_Comprobante_Remito_inherits_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_DatosRutina_CabeceraRutina]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DatosRutina] DROP CONSTRAINT [FK_DatosRutina_CabeceraRutina];
GO
IF OBJECT_ID(N'[dbo].[FK_DatosRutina_Determinante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DatosRutina] DROP CONSTRAINT [FK_DatosRutina_Determinante];
GO
IF OBJECT_ID(N'[dbo].[FK_DatosRutina_Muestra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DatosRutina] DROP CONSTRAINT [FK_DatosRutina_Muestra];
GO
IF OBJECT_ID(N'[dbo].[FK_DeterminantesPlanta_Determinante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeterminantesPlanta] DROP CONSTRAINT [FK_DeterminantesPlanta_Determinante];
GO
IF OBJECT_ID(N'[dbo].[FK_DeterminantesPlanta_Planta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DeterminantesPlanta] DROP CONSTRAINT [FK_DeterminantesPlanta_Planta];
GO
IF OBJECT_ID(N'[dbo].[FK_Entrada_Lote]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entrada] DROP CONSTRAINT [FK_Entrada_Lote];
GO
IF OBJECT_ID(N'[dbo].[FK_Entrada_Presentacion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Entrada] DROP CONSTRAINT [FK_Entrada_Presentacion];
GO
IF OBJECT_ID(N'[dbo].[FK_formulariousuario_fk_Formulario_has_Usuario_Formulario1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormularioUsuario] DROP CONSTRAINT [FK_formulariousuario_fk_Formulario_has_Usuario_Formulario1];
GO
IF OBJECT_ID(N'[dbo].[FK_formulariousuario_fk_Formulario_has_Usuario_Usuario1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FormularioUsuario] DROP CONSTRAINT [FK_formulariousuario_fk_Formulario_has_Usuario_Usuario1];
GO
IF OBJECT_ID(N'[dbo].[FK_log_fk_Log_Usuario1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Log] DROP CONSTRAINT [FK_log_fk_Log_Usuario1];
GO
IF OBJECT_ID(N'[dbo].[FK_Lote_TipoArticulo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Lote] DROP CONSTRAINT [FK_Lote_TipoArticulo];
GO
IF OBJECT_ID(N'[dbo].[FK_MuestraPlanta_Muestra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MuestraPlanta] DROP CONSTRAINT [FK_MuestraPlanta_Muestra];
GO
IF OBJECT_ID(N'[dbo].[FK_MuestraPlanta_Planta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MuestraPlanta] DROP CONSTRAINT [FK_MuestraPlanta_Planta];
GO
IF OBJECT_ID(N'[dbo].[FK_parametros_fk_Parametros_SituacionFrenteIva1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Parametros] DROP CONSTRAINT [FK_parametros_fk_Parametros_SituacionFrenteIva1];
GO
IF OBJECT_ID(N'[dbo].[FK_Planta_Cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Planta] DROP CONSTRAINT [FK_Planta_Cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_Planta_Localidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Planta] DROP CONSTRAINT [FK_Planta_Localidad];
GO
IF OBJECT_ID(N'[dbo].[FK_PlantaComprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobante] DROP CONSTRAINT [FK_PlantaComprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Salida_Lote]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Salida] DROP CONSTRAINT [FK_Salida_Lote];
GO
IF OBJECT_ID(N'[dbo].[FK_Salida_Presentacion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Salida] DROP CONSTRAINT [FK_Salida_Presentacion];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoArticulo_Unidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TipoArticulo] DROP CONSTRAINT [FK_TipoArticulo_Unidad];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoArticulo_Unidad1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TipoArticulo] DROP CONSTRAINT [FK_TipoArticulo_Unidad1];
GO
IF OBJECT_ID(N'[dbo].[FK_Usuario_TipoUsuario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT [FK_Usuario_TipoUsuario];
GO
IF OBJECT_ID(N'[dbo].[FK_VentaArticuloPlanta_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VentaArticuloPlanta] DROP CONSTRAINT [FK_VentaArticuloPlanta_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_VentaArticuloPlanta_Moneda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VentaArticuloPlanta] DROP CONSTRAINT [FK_VentaArticuloPlanta_Moneda];
GO
IF OBJECT_ID(N'[dbo].[FK_VentaArticuloPlantaTipoArticulo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VentaArticuloPlanta] DROP CONSTRAINT [FK_VentaArticuloPlantaTipoArticulo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Archivos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Archivos];
GO
IF OBJECT_ID(N'[dbo].[ArticuloPlanta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArticuloPlanta];
GO
IF OBJECT_ID(N'[dbo].[ArticuloPlantaHistorico]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ArticuloPlantaHistorico];
GO
IF OBJECT_ID(N'[dbo].[CabeceraRutina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CabeceraRutina];
GO
IF OBJECT_ID(N'[dbo].[CabeceraRutinaFirmantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CabeceraRutinaFirmantes];
GO
IF OBJECT_ID(N'[dbo].[Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cliente];
GO
IF OBJECT_ID(N'[dbo].[Comprobante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobante];
GO
IF OBJECT_ID(N'[dbo].[Comprobante_Comprobante_Devolucion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobante_Comprobante_Devolucion];
GO
IF OBJECT_ID(N'[dbo].[Comprobante_Comprobante_Factura]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobante_Comprobante_Factura];
GO
IF OBJECT_ID(N'[dbo].[Comprobante_Comprobante_Recargo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobante_Comprobante_Recargo];
GO
IF OBJECT_ID(N'[dbo].[Comprobante_Comprobante_Recibo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobante_Comprobante_Recibo];
GO
IF OBJECT_ID(N'[dbo].[Comprobante_Comprobante_Remito]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobante_Comprobante_Remito];
GO
IF OBJECT_ID(N'[dbo].[DatosRutina]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DatosRutina];
GO
IF OBJECT_ID(N'[dbo].[Determinante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Determinante];
GO
IF OBJECT_ID(N'[dbo].[DeterminantesPlanta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeterminantesPlanta];
GO
IF OBJECT_ID(N'[dbo].[Entrada]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Entrada];
GO
IF OBJECT_ID(N'[dbo].[EstadoComprobante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoComprobante];
GO
IF OBJECT_ID(N'[dbo].[Formulario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formulario];
GO
IF OBJECT_ID(N'[dbo].[FormularioUsuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FormularioUsuario];
GO
IF OBJECT_ID(N'[dbo].[ItemNota]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemNota];
GO
IF OBJECT_ID(N'[dbo].[ItemRecibo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemRecibo];
GO
IF OBJECT_ID(N'[dbo].[Localidad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Localidad];
GO
IF OBJECT_ID(N'[dbo].[Log]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Log];
GO
IF OBJECT_ID(N'[dbo].[Lote]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Lote];
GO
IF OBJECT_ID(N'[dbo].[Moneda]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Moneda];
GO
IF OBJECT_ID(N'[dbo].[Muestra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Muestra];
GO
IF OBJECT_ID(N'[dbo].[MuestraPlanta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MuestraPlanta];
GO
IF OBJECT_ID(N'[dbo].[Parametros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parametros];
GO
IF OBJECT_ID(N'[dbo].[ParametroSistema]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ParametroSistema];
GO
IF OBJECT_ID(N'[dbo].[Planta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Planta];
GO
IF OBJECT_ID(N'[dbo].[Presentacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Presentacion];
GO
IF OBJECT_ID(N'[dbo].[Rel_Pv_Comprobante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rel_Pv_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[Salida]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Salida];
GO
IF OBJECT_ID(N'[dbo].[SituacionFrenteIva]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SituacionFrenteIva];
GO
IF OBJECT_ID(N'[dbo].[TipoArticulo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoArticulo];
GO
IF OBJECT_ID(N'[dbo].[TipoUsuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoUsuario];
GO
IF OBJECT_ID(N'[dbo].[Unidad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Unidad];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO
IF OBJECT_ID(N'[dbo].[VentaArticuloPlanta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VentaArticuloPlanta];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ArticuloPlanta'
CREATE TABLE [dbo].[ArticuloPlanta] (
    [idArticulo] bigint  NOT NULL,
    [idPlanta] bigint  NOT NULL,
    [contador] int  NOT NULL,
    [idMoneda] int  NOT NULL,
    [precio] decimal(18,2)  NOT NULL,
    [fechaCambio] datetime  NOT NULL
);
GO

-- Creating table 'CabeceraRutina'
CREATE TABLE [dbo].[CabeceraRutina] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [idPlanta] bigint  NULL,
    [fechaMuestreo] datetime  NULL,
    [fechaAnalisis] datetime  NULL,
    [observaciones] varchar(1024)  NULL,
    [tipoRutina] varchar(50)  NOT NULL,
    [idCabeceraRutinaFirmante] int  NOT NULL
);
GO

-- Creating table 'Cliente'
CREATE TABLE [dbo].[Cliente] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [fechaAlta] datetime  NOT NULL,
    [razonSocial] varchar(255)  NULL,
    [nombreContacto] nvarchar(max)  NOT NULL,
    [cargoContacto] nvarchar(max)  NOT NULL,
    [direccion] varchar(255)  NULL,
    [telefono] varchar(63)  NULL,
    [telefono2] nvarchar(max)  NOT NULL,
    [fax] nvarchar(max)  NOT NULL,
    [email] varchar(63)  NULL,
    [cuit] varchar(13)  NULL,
    [fechaBaja] datetime  NULL,
    [motivoBaja] varchar(63)  NULL,
    [idLocalidad] bigint  NULL,
    [idSituacionFrenteIva] int  NULL
);
GO

-- Creating table 'Comprobante'
CREATE TABLE [dbo].[Comprobante] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [importe] decimal(12,2)  NOT NULL,
    [fechaIngreso] datetime  NOT NULL,
    [debe] bit  NOT NULL,
    [idPlanta] bigint  NOT NULL,
    [subtotal] decimal(12,2)  NOT NULL,
    [totalIva] decimal(12,2)  NOT NULL,
    [anulado] bit  NULL,
    [estadoCarga] int  NOT NULL
);
GO

-- Creating table 'DatosRutina'
CREATE TABLE [dbo].[DatosRutina] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [idMuestra] bigint  NOT NULL,
    [idDeterminante] bigint  NOT NULL,
    [idCabeceraRutina] bigint  NOT NULL,
    [valor] varchar(20)  NOT NULL
);
GO

-- Creating table 'Determinante'
CREATE TABLE [dbo].[Determinante] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [nombre] varchar(50)  NOT NULL,
    [unidad] varchar(50)  NOT NULL,
    [grupo] smallint  NULL
);
GO

-- Creating table 'DeterminantesPlanta'
CREATE TABLE [dbo].[DeterminantesPlanta] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [idPlanta] bigint  NOT NULL,
    [idDeterminante] bigint  NOT NULL
);
GO

-- Creating table 'Formulario'
CREATE TABLE [dbo].[Formulario] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [nombre] varchar(45)  NOT NULL
);
GO

-- Creating table 'FormularioUsuario'
CREATE TABLE [dbo].[FormularioUsuario] (
    [idFormulario] bigint  NOT NULL,
    [idUsuario] int  NOT NULL,
    [id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Localidad'
CREATE TABLE [dbo].[Localidad] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [nombre] varchar(63)  NOT NULL,
    [inactiva] bit  NOT NULL,
    [codigoPostal] int  NULL
);
GO

-- Creating table 'Log'
CREATE TABLE [dbo].[Log] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [operacion] char(1)  NOT NULL,
    [detalle] varchar(max)  NULL,
    [nombreEntidad] varchar(63)  NULL,
    [idEntidad] bigint  NULL,
    [idUsuario] int  NOT NULL,
    [fechahora] datetime  NOT NULL
);
GO

-- Creating table 'Moneda'
CREATE TABLE [dbo].[Moneda] (
    [id] int  NOT NULL,
    [nombre] varchar(127)  NOT NULL,
    [simbologia] varchar(15)  NOT NULL,
    [cotizacion] decimal(18,5)  NOT NULL,
    [abrevAfip] varchar(5)  NULL
);
GO

-- Creating table 'Muestra'
CREATE TABLE [dbo].[Muestra] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Codigo] varchar(50)  NOT NULL,
    [Descripcion] varchar(255)  NOT NULL
);
GO

-- Creating table 'MuestraPlanta'
CREATE TABLE [dbo].[MuestraPlanta] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [idPlanta] bigint  NOT NULL,
    [idMuestra] bigint  NOT NULL
);
GO

-- Creating table 'Parametros'
CREATE TABLE [dbo].[Parametros] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [nombre] varchar(255)  NULL,
    [cuit] varchar(13)  NULL,
    [direccion] varchar(255)  NULL,
    [telefono] varchar(255)  NULL,
    [ingresosBrutos] varchar(45)  NULL,
    [inicioActividades] datetime  NULL,
    [email] varchar(255)  NULL,
    [sitioWeb] varchar(127)  NULL,
    [version] int  NULL,
    [idSituacionFrenteIva] int  NOT NULL
);
GO

-- Creating table 'ParametroSistema'
CREATE TABLE [dbo].[ParametroSistema] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(120)  NOT NULL,
    [descripcion] varchar(250)  NOT NULL,
    [valor] varchar(150)  NULL,
    [tipoDato] varchar(50)  NOT NULL
);
GO

-- Creating table 'Planta'
CREATE TABLE [dbo].[Planta] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [codigo] varchar(32)  NOT NULL,
    [nombre] varchar(255)  NOT NULL,
    [direccion] varchar(255)  NULL,
    [idCliente] bigint  NULL,
    [nombreContacto1] varchar(50)  NULL,
    [cargoContacto1] varchar(50)  NULL,
    [nombreContacto2] varchar(50)  NULL,
    [cargoContacto2] varchar(50)  NULL,
    [telefono1] varchar(25)  NULL,
    [telefono2] varchar(25)  NULL,
    [idLocalidad] bigint  NULL,
    [emailContac1] varchar(50)  NULL,
    [emailContac2] varchar(50)  NULL
);
GO

-- Creating table 'SituacionFrenteIva'
CREATE TABLE [dbo].[SituacionFrenteIva] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(40)  NOT NULL
);
GO

-- Creating table 'TipoUsuario'
CREATE TABLE [dbo].[TipoUsuario] (
    [id] smallint  NOT NULL,
    [tipo] varchar(63)  NOT NULL
);
GO

-- Creating table 'Unidad'
CREATE TABLE [dbo].[Unidad] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] varchar(255)  NOT NULL,
    [abreviatura] varchar(5)  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombreUsuario] varchar(15)  NOT NULL,
    [clave] varchar(64)  NOT NULL,
    [inactivo] bit  NOT NULL,
    [idTipoUsuario] smallint  NOT NULL
);
GO

-- Creating table 'ItemRecibo'
CREATE TABLE [dbo].[ItemRecibo] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [fechaIzq] datetime  NULL,
    [descripIzq] nvarchar(255)  NULL,
    [importeIzq] decimal(12,2)  NULL,
    [fechaDer] datetime  NULL,
    [descripDer] nvarchar(255)  NULL,
    [importeDer] decimal(12,2)  NULL,
    [idRecibo] bigint  NOT NULL
);
GO

-- Creating table 'ItemNota'
CREATE TABLE [dbo].[ItemNota] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [descripcion] nvarchar(255)  NOT NULL,
    [importe] decimal(12,2)  NOT NULL,
    [idRecargo] bigint  NULL,
    [idDevolucion] bigint  NULL,
    [cantidad] decimal(12,2)  NULL,
    [iva] decimal(4,2)  NULL
);
GO

-- Creating table 'ArticuloPlantaHistorico'
CREATE TABLE [dbo].[ArticuloPlantaHistorico] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [idArticulo] bigint  NOT NULL,
    [idPlanta] bigint  NOT NULL,
    [idMoneda] int  NOT NULL,
    [precio] decimal(18,2)  NOT NULL,
    [fechaCambio] datetime  NOT NULL
);
GO

-- Creating table 'VentaArticuloPlanta'
CREATE TABLE [dbo].[VentaArticuloPlanta] (
    [idComprobante] bigint  NOT NULL,
    [idArticulo] bigint  NOT NULL,
    [cantidad] decimal(10,2)  NOT NULL,
    [idMoneda] int  NOT NULL,
    [precio] decimal(18,2)  NOT NULL,
    [cotizacion] decimal(18,5)  NOT NULL,
    [iva] decimal(12,2)  NOT NULL,
    [lote] varchar(15)  NULL,
    [descripAdicional] varchar(50)  NULL
);
GO

-- Creating table 'Archivos'
CREATE TABLE [dbo].[Archivos] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [idRutina] bigint  NOT NULL,
    [extension] nchar(10)  NOT NULL,
    [archivo] varbinary(max)  NOT NULL
);
GO

-- Creating table 'CabeceraRutinaFirmantes'
CREATE TABLE [dbo].[CabeceraRutinaFirmantes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(100)  NOT NULL,
    [firma] varbinary(max)  NULL,
    [iniciales] nvarchar(10)  NULL
);
GO

-- Creating table 'Rel_Pv_Comprobante'
CREATE TABLE [dbo].[Rel_Pv_Comprobante] (
    [PuntoVenta] int  NOT NULL,
    [Comprobante] varchar(50)  NOT NULL,
    [FechaAlta] datetime  NOT NULL
);
GO

-- Creating table 'EstadoComprobante'
CREATE TABLE [dbo].[EstadoComprobante] (
    [Id] int  NOT NULL,
    [Descripcion] varchar(50)  NOT NULL
);
GO

-- Creating table 'Entrada'
CREATE TABLE [dbo].[Entrada] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [idPresentacion] int  NOT NULL,
    [nroLote] varchar(10)  NOT NULL,
    [cantidad] decimal(18,2)  NOT NULL,
    [concepto] varchar(100)  NULL,
    [fecha] datetime  NOT NULL
);
GO

-- Creating table 'Presentacion'
CREATE TABLE [dbo].[Presentacion] (
    [id] int IDENTITY(1,1) NOT NULL,
    [litrosEnvase] int  NOT NULL
);
GO

-- Creating table 'Salida'
CREATE TABLE [dbo].[Salida] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [idPresentacion] int  NOT NULL,
    [nroLote] varchar(10)  NOT NULL,
    [cantidad] decimal(18,2)  NOT NULL,
    [idCliente] bigint  NULL,
    [nombreVendedor] varchar(100)  NULL,
    [fecha] nchar(10)  NULL
);
GO

-- Creating table 'TipoArticulo'
CREATE TABLE [dbo].[TipoArticulo] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [nombre] varchar(255)  NOT NULL,
    [idUnidad] int  NULL,
    [idUnidadStock] int  NULL
);
GO

-- Creating table 'Lote'
CREATE TABLE [dbo].[Lote] (
    [numero] varchar(10)  NOT NULL,
    [fechaInicio] datetime  NOT NULL,
    [fechaCierre] datetime  NULL,
    [idTipoArticulo] bigint  NOT NULL,
    [fechaElaboracion] datetime  NULL,
    [fechaVencimiento] datetime  NULL
);
GO

-- Creating table 'Comprobante_Comprobante_Factura'
CREATE TABLE [dbo].[Comprobante_Comprobante_Factura] (
    [observacion] varchar(350)  NULL,
    [numero] bigint  NOT NULL,
    [vencimiento] datetime  NOT NULL,
    [condVta] nvarchar(255)  NOT NULL,
    [tipo] char(1)  NOT NULL,
    [ordenCompra] varchar(255)  NULL,
    [idMoneda] int  NULL,
    [cae] varchar(14)  NULL,
    [fecVtoCae] datetime  NULL,
    [pv] int  NOT NULL,
    [id] bigint  NOT NULL
);
GO

-- Creating table 'Comprobante_Comprobante_Remito'
CREATE TABLE [dbo].[Comprobante_Comprobante_Remito] (
    [observacion] varchar(350)  NULL,
    [cantidadBultos] int  NULL,
    [numero] bigint  NOT NULL,
    [pesoTotalKg] decimal(10,2)  NOT NULL,
    [ordenCompra] nvarchar(255)  NOT NULL,
    [idFactura] bigint  NULL,
    [idUnidad] int  NULL,
    [tipo] varchar(30)  NULL,
    [idMoneda] int  NOT NULL,
    [id] bigint  NOT NULL
);
GO

-- Creating table 'Comprobante_Comprobante_Recibo'
CREATE TABLE [dbo].[Comprobante_Comprobante_Recibo] (
    [formaPago] nvarchar(max)  NULL,
    [numero] bigint  NOT NULL,
    [id] bigint  NOT NULL
);
GO

-- Creating table 'Comprobante_Comprobante_Recargo'
CREATE TABLE [dbo].[Comprobante_Comprobante_Recargo] (
    [motivo] varchar(255)  NULL,
    [numero] bigint  NOT NULL,
    [condVta] nvarchar(255)  NOT NULL,
    [tipo] char(1)  NOT NULL,
    [pv] int  NOT NULL,
    [idComprobante] bigint  NULL,
    [cae] varchar(14)  NULL,
    [fecVtoCae] datetime  NULL,
    [idMoneda] int  NOT NULL,
    [id] bigint  NOT NULL
);
GO

-- Creating table 'Comprobante_Comprobante_Devolucion'
CREATE TABLE [dbo].[Comprobante_Comprobante_Devolucion] (
    [motivo] varchar(255)  NULL,
    [numero] bigint  NOT NULL,
    [condVta] nvarchar(255)  NOT NULL,
    [tipo] char(1)  NOT NULL,
    [pv] int  NOT NULL,
    [idComprobante] bigint  NULL,
    [cae] varchar(14)  NULL,
    [fecVtoCae] datetime  NULL,
    [idMoneda] int  NOT NULL,
    [id] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idArticulo], [idPlanta] in table 'ArticuloPlanta'
ALTER TABLE [dbo].[ArticuloPlanta]
ADD CONSTRAINT [PK_ArticuloPlanta]
    PRIMARY KEY CLUSTERED ([idArticulo], [idPlanta] ASC);
GO

-- Creating primary key on [id] in table 'CabeceraRutina'
ALTER TABLE [dbo].[CabeceraRutina]
ADD CONSTRAINT [PK_CabeceraRutina]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [PK_Cliente]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Comprobante'
ALTER TABLE [dbo].[Comprobante]
ADD CONSTRAINT [PK_Comprobante]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'DatosRutina'
ALTER TABLE [dbo].[DatosRutina]
ADD CONSTRAINT [PK_DatosRutina]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Determinante'
ALTER TABLE [dbo].[Determinante]
ADD CONSTRAINT [PK_Determinante]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'DeterminantesPlanta'
ALTER TABLE [dbo].[DeterminantesPlanta]
ADD CONSTRAINT [PK_DeterminantesPlanta]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Formulario'
ALTER TABLE [dbo].[Formulario]
ADD CONSTRAINT [PK_Formulario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'FormularioUsuario'
ALTER TABLE [dbo].[FormularioUsuario]
ADD CONSTRAINT [PK_FormularioUsuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Localidad'
ALTER TABLE [dbo].[Localidad]
ADD CONSTRAINT [PK_Localidad]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Log'
ALTER TABLE [dbo].[Log]
ADD CONSTRAINT [PK_Log]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Moneda'
ALTER TABLE [dbo].[Moneda]
ADD CONSTRAINT [PK_Moneda]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'Muestra'
ALTER TABLE [dbo].[Muestra]
ADD CONSTRAINT [PK_Muestra]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'MuestraPlanta'
ALTER TABLE [dbo].[MuestraPlanta]
ADD CONSTRAINT [PK_MuestraPlanta]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Parametros'
ALTER TABLE [dbo].[Parametros]
ADD CONSTRAINT [PK_Parametros]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'ParametroSistema'
ALTER TABLE [dbo].[ParametroSistema]
ADD CONSTRAINT [PK_ParametroSistema]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Planta'
ALTER TABLE [dbo].[Planta]
ADD CONSTRAINT [PK_Planta]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'SituacionFrenteIva'
ALTER TABLE [dbo].[SituacionFrenteIva]
ADD CONSTRAINT [PK_SituacionFrenteIva]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TipoUsuario'
ALTER TABLE [dbo].[TipoUsuario]
ADD CONSTRAINT [PK_TipoUsuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Unidad'
ALTER TABLE [dbo].[Unidad]
ADD CONSTRAINT [PK_Unidad]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemRecibo'
ALTER TABLE [dbo].[ItemRecibo]
ADD CONSTRAINT [PK_ItemRecibo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemNota'
ALTER TABLE [dbo].[ItemNota]
ADD CONSTRAINT [PK_ItemNota]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'ArticuloPlantaHistorico'
ALTER TABLE [dbo].[ArticuloPlantaHistorico]
ADD CONSTRAINT [PK_ArticuloPlantaHistorico]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [idComprobante], [idArticulo] in table 'VentaArticuloPlanta'
ALTER TABLE [dbo].[VentaArticuloPlanta]
ADD CONSTRAINT [PK_VentaArticuloPlanta]
    PRIMARY KEY CLUSTERED ([idComprobante], [idArticulo] ASC);
GO

-- Creating primary key on [id] in table 'Archivos'
ALTER TABLE [dbo].[Archivos]
ADD CONSTRAINT [PK_Archivos]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'CabeceraRutinaFirmantes'
ALTER TABLE [dbo].[CabeceraRutinaFirmantes]
ADD CONSTRAINT [PK_CabeceraRutinaFirmantes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [PuntoVenta], [Comprobante] in table 'Rel_Pv_Comprobante'
ALTER TABLE [dbo].[Rel_Pv_Comprobante]
ADD CONSTRAINT [PK_Rel_Pv_Comprobante]
    PRIMARY KEY CLUSTERED ([PuntoVenta], [Comprobante] ASC);
GO

-- Creating primary key on [Id] in table 'EstadoComprobante'
ALTER TABLE [dbo].[EstadoComprobante]
ADD CONSTRAINT [PK_EstadoComprobante]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'Entrada'
ALTER TABLE [dbo].[Entrada]
ADD CONSTRAINT [PK_Entrada]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Presentacion'
ALTER TABLE [dbo].[Presentacion]
ADD CONSTRAINT [PK_Presentacion]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Salida'
ALTER TABLE [dbo].[Salida]
ADD CONSTRAINT [PK_Salida]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TipoArticulo'
ALTER TABLE [dbo].[TipoArticulo]
ADD CONSTRAINT [PK_TipoArticulo]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [numero] in table 'Lote'
ALTER TABLE [dbo].[Lote]
ADD CONSTRAINT [PK_Lote]
    PRIMARY KEY CLUSTERED ([numero] ASC);
GO

-- Creating primary key on [id] in table 'Comprobante_Comprobante_Factura'
ALTER TABLE [dbo].[Comprobante_Comprobante_Factura]
ADD CONSTRAINT [PK_Comprobante_Comprobante_Factura]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Comprobante_Comprobante_Remito'
ALTER TABLE [dbo].[Comprobante_Comprobante_Remito]
ADD CONSTRAINT [PK_Comprobante_Comprobante_Remito]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Comprobante_Comprobante_Recibo'
ALTER TABLE [dbo].[Comprobante_Comprobante_Recibo]
ADD CONSTRAINT [PK_Comprobante_Comprobante_Recibo]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Comprobante_Comprobante_Recargo'
ALTER TABLE [dbo].[Comprobante_Comprobante_Recargo]
ADD CONSTRAINT [PK_Comprobante_Comprobante_Recargo]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Comprobante_Comprobante_Devolucion'
ALTER TABLE [dbo].[Comprobante_Comprobante_Devolucion]
ADD CONSTRAINT [PK_Comprobante_Comprobante_Devolucion]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idMoneda] in table 'ArticuloPlanta'
ALTER TABLE [dbo].[ArticuloPlanta]
ADD CONSTRAINT [FK_ArticuloPlanta_Moneda]
    FOREIGN KEY ([idMoneda])
    REFERENCES [dbo].[Moneda]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticuloPlanta_Moneda'
CREATE INDEX [IX_FK_ArticuloPlanta_Moneda]
ON [dbo].[ArticuloPlanta]
    ([idMoneda]);
GO

-- Creating foreign key on [idPlanta] in table 'ArticuloPlanta'
ALTER TABLE [dbo].[ArticuloPlanta]
ADD CONSTRAINT [FK_ArticuloPlanta_Planta]
    FOREIGN KEY ([idPlanta])
    REFERENCES [dbo].[Planta]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticuloPlanta_Planta'
CREATE INDEX [IX_FK_ArticuloPlanta_Planta]
ON [dbo].[ArticuloPlanta]
    ([idPlanta]);
GO

-- Creating foreign key on [idPlanta] in table 'CabeceraRutina'
ALTER TABLE [dbo].[CabeceraRutina]
ADD CONSTRAINT [FK_CabeceraRutina_Planta]
    FOREIGN KEY ([idPlanta])
    REFERENCES [dbo].[Planta]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CabeceraRutina_Planta'
CREATE INDEX [IX_FK_CabeceraRutina_Planta]
ON [dbo].[CabeceraRutina]
    ([idPlanta]);
GO

-- Creating foreign key on [idCabeceraRutina] in table 'DatosRutina'
ALTER TABLE [dbo].[DatosRutina]
ADD CONSTRAINT [FK_DatosRutina_CabeceraRutina]
    FOREIGN KEY ([idCabeceraRutina])
    REFERENCES [dbo].[CabeceraRutina]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DatosRutina_CabeceraRutina'
CREATE INDEX [IX_FK_DatosRutina_CabeceraRutina]
ON [dbo].[DatosRutina]
    ([idCabeceraRutina]);
GO

-- Creating foreign key on [idLocalidad] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [FK_cliente_fk_Cliente_Localidad1]
    FOREIGN KEY ([idLocalidad])
    REFERENCES [dbo].[Localidad]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_cliente_fk_Cliente_Localidad1'
CREATE INDEX [IX_FK_cliente_fk_Cliente_Localidad1]
ON [dbo].[Cliente]
    ([idLocalidad]);
GO

-- Creating foreign key on [idSituacionFrenteIva] in table 'Cliente'
ALTER TABLE [dbo].[Cliente]
ADD CONSTRAINT [FK_cliente_fk_Cliente_SituacionFrenteIva1]
    FOREIGN KEY ([idSituacionFrenteIva])
    REFERENCES [dbo].[SituacionFrenteIva]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_cliente_fk_Cliente_SituacionFrenteIva1'
CREATE INDEX [IX_FK_cliente_fk_Cliente_SituacionFrenteIva1]
ON [dbo].[Cliente]
    ([idSituacionFrenteIva]);
GO

-- Creating foreign key on [idCliente] in table 'Planta'
ALTER TABLE [dbo].[Planta]
ADD CONSTRAINT [FK_Planta_Cliente]
    FOREIGN KEY ([idCliente])
    REFERENCES [dbo].[Cliente]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Planta_Cliente'
CREATE INDEX [IX_FK_Planta_Cliente]
ON [dbo].[Planta]
    ([idCliente]);
GO

-- Creating foreign key on [idPlanta] in table 'Comprobante'
ALTER TABLE [dbo].[Comprobante]
ADD CONSTRAINT [FK_PlantaComprobante]
    FOREIGN KEY ([idPlanta])
    REFERENCES [dbo].[Planta]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlantaComprobante'
CREATE INDEX [IX_FK_PlantaComprobante]
ON [dbo].[Comprobante]
    ([idPlanta]);
GO

-- Creating foreign key on [idDeterminante] in table 'DatosRutina'
ALTER TABLE [dbo].[DatosRutina]
ADD CONSTRAINT [FK_DatosRutina_Determinante]
    FOREIGN KEY ([idDeterminante])
    REFERENCES [dbo].[Determinante]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DatosRutina_Determinante'
CREATE INDEX [IX_FK_DatosRutina_Determinante]
ON [dbo].[DatosRutina]
    ([idDeterminante]);
GO

-- Creating foreign key on [idMuestra] in table 'DatosRutina'
ALTER TABLE [dbo].[DatosRutina]
ADD CONSTRAINT [FK_DatosRutina_Muestra]
    FOREIGN KEY ([idMuestra])
    REFERENCES [dbo].[Muestra]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DatosRutina_Muestra'
CREATE INDEX [IX_FK_DatosRutina_Muestra]
ON [dbo].[DatosRutina]
    ([idMuestra]);
GO

-- Creating foreign key on [idDeterminante] in table 'DeterminantesPlanta'
ALTER TABLE [dbo].[DeterminantesPlanta]
ADD CONSTRAINT [FK_DeterminantesPlanta_Determinante]
    FOREIGN KEY ([idDeterminante])
    REFERENCES [dbo].[Determinante]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeterminantesPlanta_Determinante'
CREATE INDEX [IX_FK_DeterminantesPlanta_Determinante]
ON [dbo].[DeterminantesPlanta]
    ([idDeterminante]);
GO

-- Creating foreign key on [idPlanta] in table 'DeterminantesPlanta'
ALTER TABLE [dbo].[DeterminantesPlanta]
ADD CONSTRAINT [FK_DeterminantesPlanta_Planta]
    FOREIGN KEY ([idPlanta])
    REFERENCES [dbo].[Planta]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeterminantesPlanta_Planta'
CREATE INDEX [IX_FK_DeterminantesPlanta_Planta]
ON [dbo].[DeterminantesPlanta]
    ([idPlanta]);
GO

-- Creating foreign key on [idFormulario] in table 'FormularioUsuario'
ALTER TABLE [dbo].[FormularioUsuario]
ADD CONSTRAINT [FK_formulariousuario_fk_Formulario_has_Usuario_Formulario1]
    FOREIGN KEY ([idFormulario])
    REFERENCES [dbo].[Formulario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_formulariousuario_fk_Formulario_has_Usuario_Formulario1'
CREATE INDEX [IX_FK_formulariousuario_fk_Formulario_has_Usuario_Formulario1]
ON [dbo].[FormularioUsuario]
    ([idFormulario]);
GO

-- Creating foreign key on [idUsuario] in table 'FormularioUsuario'
ALTER TABLE [dbo].[FormularioUsuario]
ADD CONSTRAINT [FK_formulariousuario_fk_Formulario_has_Usuario_Usuario1]
    FOREIGN KEY ([idUsuario])
    REFERENCES [dbo].[Usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_formulariousuario_fk_Formulario_has_Usuario_Usuario1'
CREATE INDEX [IX_FK_formulariousuario_fk_Formulario_has_Usuario_Usuario1]
ON [dbo].[FormularioUsuario]
    ([idUsuario]);
GO

-- Creating foreign key on [idUsuario] in table 'Log'
ALTER TABLE [dbo].[Log]
ADD CONSTRAINT [FK_log_fk_Log_Usuario1]
    FOREIGN KEY ([idUsuario])
    REFERENCES [dbo].[Usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_log_fk_Log_Usuario1'
CREATE INDEX [IX_FK_log_fk_Log_Usuario1]
ON [dbo].[Log]
    ([idUsuario]);
GO

-- Creating foreign key on [idMuestra] in table 'MuestraPlanta'
ALTER TABLE [dbo].[MuestraPlanta]
ADD CONSTRAINT [FK_MuestraPlanta_Muestra]
    FOREIGN KEY ([idMuestra])
    REFERENCES [dbo].[Muestra]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MuestraPlanta_Muestra'
CREATE INDEX [IX_FK_MuestraPlanta_Muestra]
ON [dbo].[MuestraPlanta]
    ([idMuestra]);
GO

-- Creating foreign key on [idPlanta] in table 'MuestraPlanta'
ALTER TABLE [dbo].[MuestraPlanta]
ADD CONSTRAINT [FK_MuestraPlanta_Planta]
    FOREIGN KEY ([idPlanta])
    REFERENCES [dbo].[Planta]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MuestraPlanta_Planta'
CREATE INDEX [IX_FK_MuestraPlanta_Planta]
ON [dbo].[MuestraPlanta]
    ([idPlanta]);
GO

-- Creating foreign key on [idSituacionFrenteIva] in table 'Parametros'
ALTER TABLE [dbo].[Parametros]
ADD CONSTRAINT [FK_parametros_fk_Parametros_SituacionFrenteIva1]
    FOREIGN KEY ([idSituacionFrenteIva])
    REFERENCES [dbo].[SituacionFrenteIva]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_parametros_fk_Parametros_SituacionFrenteIva1'
CREATE INDEX [IX_FK_parametros_fk_Parametros_SituacionFrenteIva1]
ON [dbo].[Parametros]
    ([idSituacionFrenteIva]);
GO

-- Creating foreign key on [idTipoUsuario] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [FK_Usuario_TipoUsuario]
    FOREIGN KEY ([idTipoUsuario])
    REFERENCES [dbo].[TipoUsuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Usuario_TipoUsuario'
CREATE INDEX [IX_FK_Usuario_TipoUsuario]
ON [dbo].[Usuario]
    ([idTipoUsuario]);
GO

-- Creating foreign key on [idFactura] in table 'Comprobante_Comprobante_Remito'
ALTER TABLE [dbo].[Comprobante_Comprobante_Remito]
ADD CONSTRAINT [FK_Comprobante_FacturaComprobante_Remito]
    FOREIGN KEY ([idFactura])
    REFERENCES [dbo].[Comprobante_Comprobante_Factura]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_FacturaComprobante_Remito'
CREATE INDEX [IX_FK_Comprobante_FacturaComprobante_Remito]
ON [dbo].[Comprobante_Comprobante_Remito]
    ([idFactura]);
GO

-- Creating foreign key on [idRecibo] in table 'ItemRecibo'
ALTER TABLE [dbo].[ItemRecibo]
ADD CONSTRAINT [FK_Comprobante_ReciboItemRecibo]
    FOREIGN KEY ([idRecibo])
    REFERENCES [dbo].[Comprobante_Comprobante_Recibo]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_ReciboItemRecibo'
CREATE INDEX [IX_FK_Comprobante_ReciboItemRecibo]
ON [dbo].[ItemRecibo]
    ([idRecibo]);
GO

-- Creating foreign key on [idRecargo] in table 'ItemNota'
ALTER TABLE [dbo].[ItemNota]
ADD CONSTRAINT [FK_Comprobante_RecargoItemNota]
    FOREIGN KEY ([idRecargo])
    REFERENCES [dbo].[Comprobante_Comprobante_Recargo]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_RecargoItemNota'
CREATE INDEX [IX_FK_Comprobante_RecargoItemNota]
ON [dbo].[ItemNota]
    ([idRecargo]);
GO

-- Creating foreign key on [idDevolucion] in table 'ItemNota'
ALTER TABLE [dbo].[ItemNota]
ADD CONSTRAINT [FK_Comprobante_DevolucionItemNota]
    FOREIGN KEY ([idDevolucion])
    REFERENCES [dbo].[Comprobante_Comprobante_Devolucion]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_DevolucionItemNota'
CREATE INDEX [IX_FK_Comprobante_DevolucionItemNota]
ON [dbo].[ItemNota]
    ([idDevolucion]);
GO

-- Creating foreign key on [idUnidad] in table 'Comprobante_Comprobante_Remito'
ALTER TABLE [dbo].[Comprobante_Comprobante_Remito]
ADD CONSTRAINT [FK_Comprobante_Comprobante_Remito_Unidad1]
    FOREIGN KEY ([idUnidad])
    REFERENCES [dbo].[Unidad]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_Comprobante_Remito_Unidad1'
CREATE INDEX [IX_FK_Comprobante_Comprobante_Remito_Unidad1]
ON [dbo].[Comprobante_Comprobante_Remito]
    ([idUnidad]);
GO

-- Creating foreign key on [idArticulo], [idPlanta] in table 'ArticuloPlantaHistorico'
ALTER TABLE [dbo].[ArticuloPlantaHistorico]
ADD CONSTRAINT [FK_ArticuloPlantaHistorico_ArticuloPlanta]
    FOREIGN KEY ([idArticulo], [idPlanta])
    REFERENCES [dbo].[ArticuloPlanta]
        ([idArticulo], [idPlanta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticuloPlantaHistorico_ArticuloPlanta'
CREATE INDEX [IX_FK_ArticuloPlantaHistorico_ArticuloPlanta]
ON [dbo].[ArticuloPlantaHistorico]
    ([idArticulo], [idPlanta]);
GO

-- Creating foreign key on [idLocalidad] in table 'Planta'
ALTER TABLE [dbo].[Planta]
ADD CONSTRAINT [FK_Planta_Localidad1]
    FOREIGN KEY ([idLocalidad])
    REFERENCES [dbo].[Localidad]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Planta_Localidad1'
CREATE INDEX [IX_FK_Planta_Localidad1]
ON [dbo].[Planta]
    ([idLocalidad]);
GO

-- Creating foreign key on [idMoneda] in table 'Comprobante_Comprobante_Factura'
ALTER TABLE [dbo].[Comprobante_Comprobante_Factura]
ADD CONSTRAINT [FK_Comprobante_Comprobante_Factura_Moneda]
    FOREIGN KEY ([idMoneda])
    REFERENCES [dbo].[Moneda]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_Comprobante_Factura_Moneda'
CREATE INDEX [IX_FK_Comprobante_Comprobante_Factura_Moneda]
ON [dbo].[Comprobante_Comprobante_Factura]
    ([idMoneda]);
GO

-- Creating foreign key on [idComprobante] in table 'VentaArticuloPlanta'
ALTER TABLE [dbo].[VentaArticuloPlanta]
ADD CONSTRAINT [FK_VentaArticuloPlanta_Comprobante]
    FOREIGN KEY ([idComprobante])
    REFERENCES [dbo].[Comprobante]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idMoneda] in table 'VentaArticuloPlanta'
ALTER TABLE [dbo].[VentaArticuloPlanta]
ADD CONSTRAINT [FK_VentaArticuloPlanta_Moneda]
    FOREIGN KEY ([idMoneda])
    REFERENCES [dbo].[Moneda]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VentaArticuloPlanta_Moneda'
CREATE INDEX [IX_FK_VentaArticuloPlanta_Moneda]
ON [dbo].[VentaArticuloPlanta]
    ([idMoneda]);
GO

-- Creating foreign key on [idMoneda] in table 'Comprobante_Comprobante_Remito'
ALTER TABLE [dbo].[Comprobante_Comprobante_Remito]
ADD CONSTRAINT [FK_Comprobante_Comprobante_Remito_Moneda]
    FOREIGN KEY ([idMoneda])
    REFERENCES [dbo].[Moneda]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_Comprobante_Remito_Moneda'
CREATE INDEX [IX_FK_Comprobante_Comprobante_Remito_Moneda]
ON [dbo].[Comprobante_Comprobante_Remito]
    ([idMoneda]);
GO

-- Creating foreign key on [idCabeceraRutinaFirmante] in table 'CabeceraRutina'
ALTER TABLE [dbo].[CabeceraRutina]
ADD CONSTRAINT [FK_CabeceraRutina_CabeceraRutinaFirmantes]
    FOREIGN KEY ([idCabeceraRutinaFirmante])
    REFERENCES [dbo].[CabeceraRutinaFirmantes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CabeceraRutina_CabeceraRutinaFirmantes'
CREATE INDEX [IX_FK_CabeceraRutina_CabeceraRutinaFirmantes]
ON [dbo].[CabeceraRutina]
    ([idCabeceraRutinaFirmante]);
GO

-- Creating foreign key on [estadoCarga] in table 'Comprobante'
ALTER TABLE [dbo].[Comprobante]
ADD CONSTRAINT [FK_Comprobante_EstadoComprobante]
    FOREIGN KEY ([estadoCarga])
    REFERENCES [dbo].[EstadoComprobante]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_EstadoComprobante'
CREATE INDEX [IX_FK_Comprobante_EstadoComprobante]
ON [dbo].[Comprobante]
    ([estadoCarga]);
GO

-- Creating foreign key on [idComprobante] in table 'Comprobante_Comprobante_Devolucion'
ALTER TABLE [dbo].[Comprobante_Comprobante_Devolucion]
ADD CONSTRAINT [FK_Comprobante_Devolucion_Comprobante]
    FOREIGN KEY ([idComprobante])
    REFERENCES [dbo].[Comprobante]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_Devolucion_Comprobante'
CREATE INDEX [IX_FK_Comprobante_Devolucion_Comprobante]
ON [dbo].[Comprobante_Comprobante_Devolucion]
    ([idComprobante]);
GO

-- Creating foreign key on [idComprobante] in table 'Comprobante_Comprobante_Recargo'
ALTER TABLE [dbo].[Comprobante_Comprobante_Recargo]
ADD CONSTRAINT [FK_Comprobante_Recargo_Comprobante]
    FOREIGN KEY ([idComprobante])
    REFERENCES [dbo].[Comprobante]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_Recargo_Comprobante'
CREATE INDEX [IX_FK_Comprobante_Recargo_Comprobante]
ON [dbo].[Comprobante_Comprobante_Recargo]
    ([idComprobante]);
GO

-- Creating foreign key on [idMoneda] in table 'Comprobante_Comprobante_Devolucion'
ALTER TABLE [dbo].[Comprobante_Comprobante_Devolucion]
ADD CONSTRAINT [FK_Comprobante_Devolucion_Moneda]
    FOREIGN KEY ([idMoneda])
    REFERENCES [dbo].[Moneda]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_Devolucion_Moneda'
CREATE INDEX [IX_FK_Comprobante_Devolucion_Moneda]
ON [dbo].[Comprobante_Comprobante_Devolucion]
    ([idMoneda]);
GO

-- Creating foreign key on [idMoneda] in table 'Comprobante_Comprobante_Recargo'
ALTER TABLE [dbo].[Comprobante_Comprobante_Recargo]
ADD CONSTRAINT [FK_Comprobante_Recargo_Moneda]
    FOREIGN KEY ([idMoneda])
    REFERENCES [dbo].[Moneda]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comprobante_Recargo_Moneda'
CREATE INDEX [IX_FK_Comprobante_Recargo_Moneda]
ON [dbo].[Comprobante_Comprobante_Recargo]
    ([idMoneda]);
GO

-- Creating foreign key on [idPresentacion] in table 'Entrada'
ALTER TABLE [dbo].[Entrada]
ADD CONSTRAINT [FK_Entrada_Presentacion]
    FOREIGN KEY ([idPresentacion])
    REFERENCES [dbo].[Presentacion]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Entrada_Presentacion'
CREATE INDEX [IX_FK_Entrada_Presentacion]
ON [dbo].[Entrada]
    ([idPresentacion]);
GO

-- Creating foreign key on [idPresentacion] in table 'Salida'
ALTER TABLE [dbo].[Salida]
ADD CONSTRAINT [FK_Salida_Presentacion]
    FOREIGN KEY ([idPresentacion])
    REFERENCES [dbo].[Presentacion]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Salida_Presentacion'
CREATE INDEX [IX_FK_Salida_Presentacion]
ON [dbo].[Salida]
    ([idPresentacion]);
GO

-- Creating foreign key on [idArticulo] in table 'ArticuloPlanta'
ALTER TABLE [dbo].[ArticuloPlanta]
ADD CONSTRAINT [FK_ArticuloPlanta_TipoArticulo]
    FOREIGN KEY ([idArticulo])
    REFERENCES [dbo].[TipoArticulo]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [idUnidad] in table 'TipoArticulo'
ALTER TABLE [dbo].[TipoArticulo]
ADD CONSTRAINT [FK_TipoArticulo_Unidad]
    FOREIGN KEY ([idUnidad])
    REFERENCES [dbo].[Unidad]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoArticulo_Unidad'
CREATE INDEX [IX_FK_TipoArticulo_Unidad]
ON [dbo].[TipoArticulo]
    ([idUnidad]);
GO

-- Creating foreign key on [idArticulo] in table 'VentaArticuloPlanta'
ALTER TABLE [dbo].[VentaArticuloPlanta]
ADD CONSTRAINT [FK_VentaArticuloPlantaTipoArticulo]
    FOREIGN KEY ([idArticulo])
    REFERENCES [dbo].[TipoArticulo]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VentaArticuloPlantaTipoArticulo'
CREATE INDEX [IX_FK_VentaArticuloPlantaTipoArticulo]
ON [dbo].[VentaArticuloPlanta]
    ([idArticulo]);
GO

-- Creating foreign key on [idUnidadStock] in table 'TipoArticulo'
ALTER TABLE [dbo].[TipoArticulo]
ADD CONSTRAINT [FK_TipoArticulo_Unidad1]
    FOREIGN KEY ([idUnidadStock])
    REFERENCES [dbo].[Unidad]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoArticulo_Unidad1'
CREATE INDEX [IX_FK_TipoArticulo_Unidad1]
ON [dbo].[TipoArticulo]
    ([idUnidadStock]);
GO

-- Creating foreign key on [nroLote] in table 'Entrada'
ALTER TABLE [dbo].[Entrada]
ADD CONSTRAINT [FK_Entrada_Lote]
    FOREIGN KEY ([nroLote])
    REFERENCES [dbo].[Lote]
        ([numero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Entrada_Lote'
CREATE INDEX [IX_FK_Entrada_Lote]
ON [dbo].[Entrada]
    ([nroLote]);
GO

-- Creating foreign key on [idTipoArticulo] in table 'Lote'
ALTER TABLE [dbo].[Lote]
ADD CONSTRAINT [FK_Lote_TipoArticulo]
    FOREIGN KEY ([idTipoArticulo])
    REFERENCES [dbo].[TipoArticulo]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Lote_TipoArticulo'
CREATE INDEX [IX_FK_Lote_TipoArticulo]
ON [dbo].[Lote]
    ([idTipoArticulo]);
GO

-- Creating foreign key on [nroLote] in table 'Salida'
ALTER TABLE [dbo].[Salida]
ADD CONSTRAINT [FK_Salida_Lote]
    FOREIGN KEY ([nroLote])
    REFERENCES [dbo].[Lote]
        ([numero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Salida_Lote'
CREATE INDEX [IX_FK_Salida_Lote]
ON [dbo].[Salida]
    ([nroLote]);
GO

-- Creating foreign key on [id] in table 'Comprobante_Comprobante_Factura'
ALTER TABLE [dbo].[Comprobante_Comprobante_Factura]
ADD CONSTRAINT [FK_Comprobante_Factura_inherits_Comprobante]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[Comprobante]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id] in table 'Comprobante_Comprobante_Remito'
ALTER TABLE [dbo].[Comprobante_Comprobante_Remito]
ADD CONSTRAINT [FK_Comprobante_Remito_inherits_Comprobante]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[Comprobante]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id] in table 'Comprobante_Comprobante_Recibo'
ALTER TABLE [dbo].[Comprobante_Comprobante_Recibo]
ADD CONSTRAINT [FK_Comprobante_Recibo_inherits_Comprobante]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[Comprobante]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id] in table 'Comprobante_Comprobante_Recargo'
ALTER TABLE [dbo].[Comprobante_Comprobante_Recargo]
ADD CONSTRAINT [FK_Comprobante_Recargo_inherits_Comprobante]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[Comprobante]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id] in table 'Comprobante_Comprobante_Devolucion'
ALTER TABLE [dbo].[Comprobante_Comprobante_Devolucion]
ADD CONSTRAINT [FK_Comprobante_Devolucion_inherits_Comprobante]
    FOREIGN KEY ([id])
    REFERENCES [dbo].[Comprobante]
        ([id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------