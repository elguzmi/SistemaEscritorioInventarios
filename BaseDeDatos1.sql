USE [master]
GO
/****** Object:  Database [Kardex]    Script Date: 7/6/2021 8:58:25 AM ******/
CREATE DATABASE [Kardex]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kardex', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERVERSANTI\MSSQL\DATA\Kardex.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kardex_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERVERSANTI\MSSQL\DATA\Kardex_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Kardex] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kardex].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kardex] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kardex] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kardex] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kardex] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kardex] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kardex] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Kardex] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kardex] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kardex] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kardex] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kardex] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kardex] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kardex] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kardex] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kardex] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Kardex] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kardex] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kardex] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kardex] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kardex] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kardex] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kardex] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kardex] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Kardex] SET  MULTI_USER 
GO
ALTER DATABASE [Kardex] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kardex] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kardex] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kardex] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kardex] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kardex] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Kardex] SET QUERY_STORE = OFF
GO
USE [Kardex]
GO
/****** Object:  Table [dbo].[Administracion]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administracion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Descripcion] [nvarchar](100) NULL,
	[ValorTotal] [decimal](10, 3) NULL,
	[Tipo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[Id_Articulo] [int] IDENTITY(1,1) NOT NULL,
	[CodigoArticulo] [nvarchar](100) NOT NULL,
	[Nombre_Articulo] [nvarchar](200) NULL,
	[DescripcionArticulo] [text] NULL,
	[Cantidad_Stock] [int] NULL,
	[Precio_Costo] [decimal](19, 3) NULL,
	[Precio_Venta] [decimal](19, 3) NULL,
	[Stock_Ideal] [int] NULL,
	[Estado] [bit] NULL,
	[IdCategoria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Articulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NULL,
	[Descripcion] [text] NULL,
	[FechaCreado] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[Fk_Articulos] [int] NOT NULL,
	[fk_Salidas] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[Valor_total] [decimal](10, 3) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles_Entrada]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles_Entrada](
	[Fk_Entrada] [int] NOT NULL,
	[Fk_Articulo] [int] NOT NULL,
	[Cantidad] [int] NULL,
	[PrecioXunidad] [decimal](10, 3) NULL,
	[Valor_total_XArticulo] [decimal](10, 3) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entradas]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entradas](
	[Id_Entrada] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Valortotal] [decimal](10, 3) NULL,
	[Nit_proveedor] [int] NULL,
	[Estado] [bit] NULL,
	[Nombre_E] [nvarchar](200) NULL,
	[Procesado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nit] [int] NULL,
	[RazonSocial] [nvarchar](100) NULL,
	[Telefono] [int] NULL,
	[Direccion] [nvarchar](200) NULL,
	[Correo] [nvarchar](100) NULL,
	[Observacion] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salidas]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salidas](
	[Id_Salida] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Hora] [time](4) NULL,
	[Precio_total_Salida] [decimal](10, 3) NULL,
	[NombreSalida] [nvarchar](200) NULL,
	[Estado] [bit] NULL,
	[Procesado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Salida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Registro]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Registro](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Clave] [nvarchar](100) NOT NULL,
	[Nombre] [nvarchar](200) NULL,
	[Correo] [nvarchar](200) NULL,
	[Cargo] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Entradas] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Salidas] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
/****** Object:  StoredProcedure [dbo].[AdminArticulos]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AdminArticulos]
@Dato int,
@Id int,
@Codigo nvarchar(100),
@Nombre nvarchar(200),
@Descripcion text,
@Cantidad int,
@StockIdeal int,
@PrecioV decimal(19,3),
@PrecioC decimal(19,3),
@Estado bit,
@IdCategoria int,
@Mensaje nvarchar(100)out
AS
IF @Dato = 1 BEGIN
	INSERT INTO Articulos(CodigoArticulo,Nombre_Articulo,DescripcionArticulo,Cantidad_Stock,Precio_Costo,Precio_Venta,Stock_Ideal,Estado,IdCategoria) 
	VALUES (@Codigo,@Nombre,@Descripcion,@Cantidad,@PrecioC,@PrecioV,@StockIdeal,@Estado,@IdCategoria);
	if exists (select* from Articulos WHERE CodigoArticulo = @Codigo) begin
	Set @Mensaje = 'Has insertado El Articulo';
	end
	ELSE begin
	Set @Mensaje = 'Ocurrio un error';
	end
	end
IF @Dato = 2 BEGIN
	UPDATE Articulos SET CodigoArticulo= @Codigo, Nombre_Articulo= @Nombre,DescripcionArticulo=@Descripcion,Cantidad_Stock=@Cantidad,Precio_Costo=@PrecioC,
	Precio_Venta=@PrecioV,Stock_Ideal=@StockIdeal,Estado=@Estado,IdCategoria=@IdCategoria WHERE Id_Articulo= @Id
	Set @Mensaje = 'Has Actualizado el Articulo'
	end
If @Dato = 3 BEGIN
	DELETE FROM Articulos WHERE Id_Articulo = @Id
	Set @Mensaje = 'Has eliminado el Articulo'
END
GO
/****** Object:  StoredProcedure [dbo].[AdminCategorias]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[AdminCategorias]
@Dato int,
@Id int,
@Nombre nvarchar(200),
@Descripcion text,
@Mensaje nvarchar(100)out
AS
IF @Dato = 1 BEGIN
	INSERT INTO Categorias (Nombre,Descripcion,FechaCreado) VALUES (@Nombre,@Descripcion,GETDATE());
	Set @Mensaje = 'Has insertado la categoria'
	end
IF @Dato = 2 BEGIN
	UPDATE Categorias SET Nombre = @Nombre , Descripcion= @Descripcion WHERE Id_Categoria= @Id
	Set @Mensaje = 'Has Actualizado la categoria'
	end
If @Dato = 3 BEGIN
	DELETE FROM Categorias WHERE Id_Categoria = @Id
	Set @Mensaje = 'Has eliminado la categoria'
END


GO
/****** Object:  StoredProcedure [dbo].[AdminProveedores]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[AdminProveedores]
@Dato int,
@Id int,
@Nit int,
@RazonSocial nvarchar(100),
@Telefono int,
@Direccion nvarchar(200),
@Correo nvarchar(100),
@Observacion TEXT,
@Mensaje nvarchar(100)out
AS
IF @Dato = 1 BEGIN
	INSERT INTO Proveedores (Nit,RazonSocial,Telefono,Direccion,Correo,Observacion) VALUES (@Nit,@RazonSocial,@Telefono,@Direccion,@Correo,@Observacion);
	Set @Mensaje = 'Has insertado el proveedor'
	end
IF @Dato = 2 BEGIN
	UPDATE Proveedores SET Nit = @Nit , RazonSocial= @RazonSocial,Telefono=@Telefono, Direccion=@Direccion,Correo=@Correo,Observacion=@Observacion WHERE Id= @Id
	Set @Mensaje = 'Has Actualizado el proveedor'
	end
If @Dato = 3 BEGIN
	DELETE FROM Proveedores WHERE Id= @Id
	Set @Mensaje = 'Has eliminado el proveedor'
END


GO
/****** Object:  StoredProcedure [dbo].[ChangeState]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ChangeState]
@Dato int,
@Id int,
@Estado int,
@Mensaje nvarchar(20) out
AS
IF @Dato = 1 BEGIN
	IF @Estado =1 BEGIN
		UPDATE Entradas SET Estado =0 WHERE Id_Entrada =@Id
		SET @Mensaje =(SELECT Estado FROM Entradas WHERE Id_Entrada =@Id)
	END
	If @Estado =0 begin
		UPDATE Entradas SET Estado =1 WHERE Id_Entrada =@Id
		SET @Mensaje =(SELECT Estado FROM Entradas WHERE Id_Entrada =@Id)
	END
END

IF @Dato = 2 BEGIN
	IF @Estado =1 BEGIN
		UPDATE Salidas SET Estado =0 WHERE Id_Salida =@Id
		SET @Mensaje =(SELECT Estado FROM Salidas WHERE Id_Salida =@Id)
	END
	If @Estado =0 begin
		UPDATE Salidas SET Estado =1 WHERE Id_Salida =@Id
		SET @Mensaje =(SELECT Estado FROM Salidas WHERE Id_Salida =@Id)
	END
END

GO
/****** Object:  StoredProcedure [dbo].[ConsultaEgresos]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ConsultaEgresos]
@FechaInicio date,
@FechaFinal date
AS
SELECT Id_Entrada,Fecha,Nombre_E,Valortotal FROM Entradas WHERE Fecha between @FechaInicio and @fechaFinal and Estado= 1 and Procesado = 0
GO
/****** Object:  StoredProcedure [dbo].[ConsultaIngresos]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ConsultaIngresos]
@FechaInicio date,
@FechaFinal date
AS
SELECT Id_Salida,Fecha,NombreSalida,Precio_total_Salida as Valortotal FROM Salidas WHERE Fecha between @FechaInicio and @fechaFinal and Estado= 1 AND Procesado =0
GO
/****** Object:  StoredProcedure [dbo].[FiltrarArticulos]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCedure [dbo].[FiltrarArticulos]
@Dato int,
@Codigo nvarchar(50),
@Nombre nvarchar(50),
@Cantidad int
AS
IF @Dato = 1 BEGIN
SELECT CodigoArticulo,Nombre_Articulo,DescripcionArticulo,Cantidad_Stock,Precio_Costo,Precio_Venta,Stock_Ideal,Estado,Categorias.Nombre
FROM Articulos
INNER JOIN Categorias on IdCategoria = Categorias.Id_Categoria
 WHERE CodigoArticulo like + '%'+RTRIM(@Codigo)+'%';
END
IF @Dato = 2 BEGIN
SELECT CodigoArticulo,Nombre_Articulo,DescripcionArticulo,Cantidad_Stock,Precio_Costo,Precio_Venta,Stock_Ideal,Estado,Categorias.Nombre
FROM Articulos
INNER JOIN Categorias on IdCategoria = Categorias.Id_Categoria
 WHERE Nombre_Articulo like + '%'+RTRIM(@Nombre)+'%';
END
IF @Dato = 3 BEGIN
SELECT CodigoArticulo,Nombre_Articulo,DescripcionArticulo,Cantidad_Stock,Precio_Costo,Precio_Venta,Stock_Ideal,Estado,Categorias.Nombre
FROM Articulos
INNER JOIN Categorias on IdCategoria = Categorias.Id_Categoria
 WHERE Cantidad_Stock like + '%'+RTRIM(@Cantidad)+'%';
END
GO
/****** Object:  StoredProcedure [dbo].[FiltroProductos]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FiltroProductos]
@Dato int,
@Codigo nvarchar(100),
@Nombre nvarchar(200)
AS
IF @Dato = 1 begin
	SELECT Id_Articulo as Id,CodigoArticulo as Codigo,Nombre_Articulo as Nombre,DescripcionArticulo as Descripcion,
	Cantidad_Stock as Cantidad,Precio_Costo as precio_Costo,Precio_Venta as Precio_Venta,Stock_Ideal,Estado,Categorias.Nombre
	FROM Articulos 
	INNER JOIN Categorias on Articulos.IdCategoria = Categorias.Id_Categoria
	where CodigoArticulo like + '%'+RTRIM(@Codigo)+'%';
end
if @Dato = 2 begin
	SELECT Id_Articulo as Id,CodigoArticulo as Codigo,Nombre_Articulo as Nombre,DescripcionArticulo as Descripcion,
	Cantidad_Stock as Cantidad,Precio_Costo as precio_Costo,Precio_Venta as Precio_Venta,Stock_Ideal,Estado,Categorias.Nombre as Categoria
	FROM Articulos 
	INNER JOIN Categorias on Articulos.IdCategoria = Categorias.Id_Categoria
	where Nombre_Articulo like + '%'+RTRIM(@Nombre)+'%';
end
if @Dato = 3 begin
	SELECT Id_Articulo as Id,CodigoArticulo as Codigo,Nombre_Articulo as Nombre,DescripcionArticulo as Descripcion,
	Cantidad_Stock as Cantidad,Precio_Costo as precio_Costo,Precio_Venta as Precio_Venta,Stock_Ideal,Estado,Categorias.Nombre as Categoria
	FROM Articulos 
	INNER JOIN Categorias on Articulos.IdCategoria = Categorias.Id_Categoria
end
GO
/****** Object:  StoredProcedure [dbo].[FiltroProveedores]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FiltroProveedores]
@Dato int,
@Codigo int,
@Nombre nvarchar(200)
AS
IF @Dato = 1 begin
	SELECT Id,Nit,RazonSocial,Telefono,Direccion,Correo,Observacion
	FROM Proveedores 
	where Nit like + '%'+RTRIM(@Codigo)+'%';
end
if @Dato = 2 begin
	SELECT Id,Nit,RazonSocial,Telefono,Direccion,Correo,Observacion
	FROM Proveedores 
	where RazonSocial like + '%'+RTRIM(@Nombre)+'%';
end
GO
/****** Object:  StoredProcedure [dbo].[FiltroUtilidad]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FiltroUtilidad]
@FechaI date,
@FechaF date
AS
SELECT ISNULL (Articulos.CodigoArticulo,'') [Codigo],
    ISNULL (Articulos.Nombre_Articulo,'') [Nombre],
	ISNULL(Cantidad,0)[Cantidad],
	ISNULL (Articulos.Precio_Costo,0)[PrecioCompra],
	ISNULL (Articulos.Precio_Venta,0)[PrecioVenta],
	ISNULL (Salidas.Fecha,'')[Fecha],
	ISNULL(Valor_total,0)[TotalVenta]

FROM Detalle_Venta
INNER JOIN Articulos on Fk_Articulos = Articulos.Id_Articulo
INNER JOIN Salidas on fk_Salidas = Salidas.Id_Salida
WHERE Salidas.Fecha BETWEEN @FechaI AND @FechaF
GO
/****** Object:  StoredProcedure [dbo].[InsertarEntrada]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarEntrada]
@Dato int,
@Id_Entrada int,
@Nombre nvarchar(100),
@ValorTotal decimal(10,3),
@Nit int,
@Id_Articulo int,
@Cantidad int,
@Precio decimal(10,3),
@Total decimal(10,3),
@Mensaje varchar(100) out
AS
if @Dato =1 begin
 
INSERT INTO Entradas VALUES (GETDATE(),@ValorTotal,@Nit,1,@Nombre,0);
SET @mensaje = 'Insertado';
end
if @Dato =2 begin
DECLARE @Cant int
SET @Cant = (select Sum(Cantidad_Stock) as cantidadA FROM Articulos WHERE Id_Articulo = @Id_Articulo);
INSERT INTO Detalles_Entrada VALUES (@Id_Entrada,@Id_Articulo,@Cantidad,@Precio,@Total);
Update Articulos SET Cantidad_Stock = (@Cant+@Cantidad) WHERE Id_Articulo = @Id_Articulo
SET @mensaje = 'Correcto';
end
GO
/****** Object:  StoredProcedure [dbo].[InsertarSalida]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarSalida]
@dato int,
@Id_Articulo int,
@Id_Salidas int,
@Cantidad int,
@ValorT decimal(10,3),
@NombreSalida nvarchar(100),
@PrecioTotal decimal(10,3),
@mensaje nvarchar(100) out
AS
declare @Can int;

if @dato = 1 begin
INSERT INTO Salidas VALUES(CONVERT (date, SYSDATETIME()),CONVERT(time, SYSDATETIME()),@PrecioTotal,@NombreSalida,1,0);
set @mensaje = 'Se ha insertado'
end
if @dato = 2 begin
set @Can = (SELECT Cantidad_Stock FROM Articulos WHERE Id_Articulo = @Id_Articulo)
declare @Total int
set @Total = @Can - @Cantidad
	if @Total>=0 begin
		DECLARE @Cant int
		SET @Cant = (select Sum(Cantidad_Stock) as cantidadA FROM Articulos WHERE Id_Articulo = @Id_Articulo);

		INSERT INTO Detalle_Venta VALUES(@Id_Articulo,@Id_Salidas,@Cantidad,@ValorT);
		Update Articulos SET Cantidad_Stock = @Cant-@Cantidad WHERE Id_Articulo = @Id_Articulo
		Set @mensaje = 'Si';
	end
	if @Total=0 or @Total <0 begin
		UPDATE Salidas SET Estado =0,Precio_total_Salida = 0 where Id_Salida = @Id_Salidas
		set @mensaje = 'No';
	end

end
GO
/****** Object:  StoredProcedure [dbo].[ListarArti]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarArti]
AS
SELECT Id_Articulo [Id],
    CodigoArticulo [Codigo],
    ISNULL(Nombre_Articulo,'')[Nombre],
	ISNULL (DescripcionArticulo,'')[Descripcion],
	ISNULL(Precio_Costo,0.0)[PrecioC],
	ISNULL(Precio_Venta,0.0)[PrecioV]
FROM Articulos
GO
/****** Object:  StoredProcedure [dbo].[ListarArticulos]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarArticulos] 
AS
SELECT Id_Articulo [Id],
    CodigoArticulo [Codigo],
    ISNULL(Nombre_Articulo,'')[Nombre],
	ISNULL (DescripcionArticulo,'')[Descripcion],
	ISNULL(Precio_Costo,'')[PrecioC]
FROM Articulos
GO
/****** Object:  StoredProcedure [dbo].[ListarCategorias]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarCategorias]

AS
SELECT Id_Categoria,Nombre,Descripcion FROM Categorias

GO
/****** Object:  StoredProcedure [dbo].[ListarEntradas]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarEntradas]
AS
SELECT Id_Entrada [Id],
    ISNULL (Fecha,'') [fecha],
	ISNULL(Nombre_E,'')[Nombre],
    ISNULL(Valortotal,0)[VTotal],
	ISNULL (Proveedores.RazonSocial,'')[Razon],
	ISNULL(Estado,0)[Estado]
FROM Entradas
INNER JOIN Proveedores on Nit_proveedor = Proveedores.Id
GO
/****** Object:  StoredProcedure [dbo].[ListarProveedores]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarProveedores]
AS
SELECT Id,Nit,RazonSocial,Telefono,Direccion,Correo,Observacion FROM Proveedores

GO
/****** Object:  StoredProcedure [dbo].[ListarSalidas]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ListarSalidas]
AS
SELECT Id_Salida [Id],
    ISNULL (Fecha,'') [fecha],
	ISNULL(NombreSalida,'')[Nombre],
    ISNULL(Precio_total_Salida,0)[VTotal],
	ISNULL(Estado,0)[Estado]
FROM Salidas
GO
/****** Object:  StoredProcedure [dbo].[ListarUsuarios]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarUsuarios]
AS
SELECT Id_Usuario [Id],
    ISNULL(Username,'') [User],
    ISNULL(Clave,'')[Clave],
	ISNULL (Nombre,'')[Nombre],
	ISNULL(Correo,'')[Correo],
	ISNULL(Cargo,'')[Cargo]
FROM Usuarios
GO
/****** Object:  StoredProcedure [dbo].[Logeo]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Logeo] 
@Usuario nvarchar(100),
@Clave nvarchar(100)
AS
SELECT * FROM Usuarios WHERE Username = @Usuario AND Clave =@Clave
GO
/****** Object:  StoredProcedure [dbo].[MenuPrincipal]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MenuPrincipal]
@Dato int
AS
if @Dato =1 begin
SELECT COUNT(1) as Articulos FROM Articulos 
end
if @Dato =2 begin
SELECT COUNT(1) as Salidas FROM Salidas
end
if @Dato =3 begin
SELECT COUNT(1) as entradas FROM Entradas
end
if @Dato =4 begin
SELECT  CodigoArticulo,Nombre_Articulo,DescripcionArticulo,Cantidad_Stock FROM Articulos WHERE Cantidad_Stock <= 5
end
if @Dato =5 begin
SELECT  top 20 Id_Entrada,Nombre_E,Fecha,Valortotal FROM Entradas ORDER BY Fecha ASC
end
if @Dato =6 begin
SELECT  top 20 Id_Salida,NombreSalida,Fecha,Precio_total_Salida FROM Salidas ORDER BY Fecha ASC
end
GO
/****** Object:  StoredProcedure [dbo].[PerfilesA]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[PerfilesA]
    @Dato INT,
	@Id int,
	@User VARCHAR(50),
	@Nombre VARCHAR(100),
	@Clave VARCHAR(100),
	@Correo VARCHAR(100),
	@Cargo VARCHAR(100)
AS
IF @Dato = 1 BEGIN
	INSERT INTO Usuarios(Username,Clave,Nombre,Correo,Cargo) VALUES (@User,@Clave,@Nombre,@Correo,@Cargo);
	end
IF @Dato = 2 BEGIN
	UPDATE Usuarios SET Username=@User, Clave=@Clave,Nombre=@Nombre,Correo=@Correo,Cargo=@Cargo WHERE Id_Usuario= @Id
	end
If @Dato = 3 BEGIN
	DELETE FROM Usuarios WHERE Id_Usuario= @Id
END
GO
/****** Object:  StoredProcedure [dbo].[RepEgresos]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RepEgresos]
@dato int,
@descripcion nvarchar(100),
@ValorTotal decimal(10,3),
@Id_Entrada int,
@Mensaje nvarchar(30) out
AS
IF @dato= 1 begin
	INSERT INTO Administracion VALUES (GETDATE(),@descripcion,@ValorTotal,2);
	SET @Mensaje ='Se ha insertado';
end
if @dato=2 begin
	UPDATE Entradas SET Procesado =1 WHERE Id_Entrada= @Id_Entrada
	SET @Mensaje ='Se ha Modificado';
end
GO
/****** Object:  StoredProcedure [dbo].[RepIngresos]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RepIngresos]
@dato int,
@descripcion nvarchar(100),
@ValorTotal decimal(10,3),
@Id_Salida int,
@Mensaje nvarchar(30) out
AS
IF @dato= 1 begin
	INSERT INTO Administracion VALUES (GETDATE(),@descripcion,@ValorTotal,1);
	SET @Mensaje ='Se ha insertado';
end
if @dato=2 begin
	UPDATE Salidas SET Procesado =1 WHERE Id_Salida= @Id_Salida
	SET @Mensaje ='Se ha insertado';
end
GO
/****** Object:  StoredProcedure [dbo].[ReporteGlobal]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteGlobal]
@Dato int,
@FechaInicio date,
@FechaFinal date
AS
if @Dato =1 begin
SELECT * FROM Administracion WHERE Fecha BETWEEN @FechaInicio and @FechaFinal AND Tipo =1
end
if @Dato =2 begin
SELECT * FROM Administracion WHERE Fecha BETWEEN @FechaInicio and @FechaFinal AND Tipo=2
end

GO
/****** Object:  StoredProcedure [dbo].[ReporteUtilidad]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ReporteUtilidad]
@FechaI Date,
@FechaF Date
AS
SELECT Salidas.Fecha,Articulos.CodigoArticulo,Articulos.Nombre_Articulo,Detalle_Venta.Cantidad,
Articulos.Precio_Costo,Articulos.Precio_Venta,Detalle_Venta.Valor_total,Detalle_Venta.Cantidad*Articulos.Precio_Costo as TotalCosto FROM Detalle_Venta
INNER JOIN Articulos on Fk_Articulos = Articulos.Id_Articulo
INNER JOIN Salidas on fk_Salidas = Salidas.Id_Salida
WHERE Salidas.Fecha BETWEEN @FechaI AND @FechaF
GO
/****** Object:  StoredProcedure [dbo].[TraerDetalles]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TraerDetalles]
@Dato int,
@Id int
AS
if(@Dato =1)begin
SELECT CodigoArticulo,Nombre_Articulo,Cantidad,PrecioXunidad,Valor_total_XArticulo FROM Entradas
left JOIN Detalles_Entrada on Id_Entrada = Detalles_Entrada.Fk_Entrada
left join Articulos on Detalles_Entrada.Fk_Articulo = Articulos.Id_Articulo
where Entradas.Id_Entrada =@Id
end
if(@Dato=2)begin
SELECT CodigoArticulo,Nombre_Articulo,Cantidad,Valor_total FROM Salidas
left JOIN Detalle_Venta on Id_Salida= Detalle_Venta.fk_Salidas
left join Articulos on Detalle_Venta.Fk_Articulos= Articulos.Id_Articulo
where Salidas.Id_Salida =@Id
end
if(@Dato=3)begin
SELECT Cantidad_Stock FROM Articulos
where Id_Articulo =@Id
end
GO
/****** Object:  StoredProcedure [dbo].[TraerUser]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[TraerUser]
@ID int
AS
SELECT Id_Usuario [Id],
    ISNULL(Username,'') [User],
    ISNULL(Clave,'')[Clave],
	ISNULL (Nombre,'')[Nombre],
	ISNULL(Correo,'')[Correo],
	ISNULL(Cargo,'')[Cargo]
FROM Usuarios
WHERE Id_Usuario = @ID
GO
/****** Object:  StoredProcedure [dbo].[TraerXId]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TraerXId]
@Id int
AS
SELECT Id_Articulo as Id,CodigoArticulo as Codigo,Nombre_Articulo ,DescripcionArticulo as Descripcion,
	Cantidad_Stock as Cantidad,Precio_Costo,Precio_Venta,Stock_Ideal,Estado,Id_Categoria,Categorias.Nombre
	FROM Articulos 
	INNER JOIN Categorias on Articulos.IdCategoria = Categorias.Id_Categoria
	where Id_Articulo =@Id
GO
/****** Object:  StoredProcedure [dbo].[UltimoIdArticulo]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UltimoIdArticulo]
AS
SELECT TOP 1 Id_Articulo FROM Articulos ORDER BY Id_Articulo DESC 
GO
/****** Object:  StoredProcedure [dbo].[UltimoIdEntrada]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UltimoIdEntrada]
AS
SELECT TOP 1 Id_Entrada FROM Entradas ORDER BY Id_Entrada DESC 
GO
/****** Object:  StoredProcedure [dbo].[UltimoIdSalida]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UltimoIdSalida]
AS
SELECT TOP 1 Id_Salida FROM Salidas ORDER BY Id_Salida DESC 
GO
/****** Object:  StoredProcedure [dbo].[UpdateArticles]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateArticles]
@Dato int,
@Codigo nvarchar(100),
@Cantidad int,
@Estado int,
@Mensaje nvarchar(2) out
AS
declare @cant int
declare @final int
If @Dato =1 BEGIN
	If @Estado =1 begin
	
	SET @cant= (select Cantidad_Stock FROM Articulos WHERE CodigoArticulo=@Codigo)
	SET @final = @cant + @Cantidad
	UPDATE Articulos set Cantidad_Stock=@final WHERE CodigoArticulo =@Codigo
	SET @Mensaje = '1'
	end
	If @Estado =0 begin
	SET @cant= (select Cantidad_Stock FROM Articulos WHERE CodigoArticulo=@Codigo)
	SET @final = @cant - @Cantidad
	UPDATE Articulos set Cantidad_Stock=@final WHERE CodigoArticulo =@Codigo
	SET @Mensaje = '1'
	end
END

If @Dato =2 BEGIN
	If @Estado =1 begin
	
	SET @cant= (select Cantidad_Stock FROM Articulos WHERE CodigoArticulo=@Codigo)
	SET @final = @cant - @Cantidad
	UPDATE Articulos set Cantidad_Stock=@final WHERE CodigoArticulo =@Codigo
	SET @Mensaje = '1'
	end
	If @Estado =0 begin
	SET @cant= (select Cantidad_Stock FROM Articulos WHERE CodigoArticulo=@Codigo)
	SET @final = @cant + @Cantidad
	UPDATE Articulos set Cantidad_Stock=@final WHERE CodigoArticulo =@Codigo
	SET @Mensaje = '1'
	end
END

GO
/****** Object:  StoredProcedure [dbo].[Utilidad]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Utilidad]
AS
SELECT ISNULL (Articulos.CodigoArticulo,'') [Codigo],
    ISNULL (Articulos.Nombre_Articulo,'') [Nombre],
	ISNULL(Cantidad,0)[Cantidad],
	ISNULL (Articulos.Precio_Costo,0)[PrecioCompra],
	ISNULL (Articulos.Precio_Venta,0)[PrecioVenta],
	ISNULL (Salidas.Fecha,'')[Fecha],
	ISNULL(Valor_total,0)[TotalVenta]

FROM Detalle_Venta
INNER JOIN Articulos on Fk_Articulos = Articulos.Id_Articulo
INNER JOIN Salidas on fk_Salidas = Salidas.Id_Salida
WHERE Salidas.Estado =1

GO
/****** Object:  StoredProcedure [dbo].[UtilidadFecha]    Script Date: 7/6/2021 8:58:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UtilidadFecha]
@FechaI date,
@FechaF date
AS
SELECT ISNULL (Articulos.CodigoArticulo,'') [Codigo],
    ISNULL (Articulos.Nombre_Articulo,'') [Nombre],
	ISNULL(Cantidad,0)[Cantidad],
	ISNULL (Articulos.Precio_Costo,0)[PrecioCompra],
	ISNULL (Articulos.Precio_Venta,0)[PrecioVenta],
	ISNULL (Salidas.Fecha,'')[Fecha],
	ISNULL(Valor_total,0)[TotalVenta]

FROM Detalle_Venta
INNER JOIN Articulos on Fk_Articulos = Articulos.Id_Articulo
INNER JOIN Salidas on fk_Salidas = Salidas.Id_Salida
WHERE Salidas.Fecha between @FechaI AND @FechaF AND Salidas.Estado=1
GO
USE [master]
GO
ALTER DATABASE [Kardex] SET  READ_WRITE 
GO
