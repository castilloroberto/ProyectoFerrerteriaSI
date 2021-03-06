/****** Object:  Database [FerreteriaDB]    Script Date: 1/8/2021 02:33:31 ******/
CREATE DATABASE [FerreteriaDB]  (EDITION = 'Standard', SERVICE_OBJECTIVE = 'S0', MAXSIZE = 250 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS;
GO
ALTER DATABASE [FerreteriaDB] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [FerreteriaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FerreteriaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FerreteriaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FerreteriaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FerreteriaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FerreteriaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FerreteriaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FerreteriaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FerreteriaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FerreteriaDB] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [FerreteriaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FerreteriaDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [FerreteriaDB] SET  MULTI_USER 
GO
ALTER DATABASE [FerreteriaDB] SET ENCRYPTION ON
GO
ALTER DATABASE [FerreteriaDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [FerreteriaDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Cod_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Producto] [nvarchar](70) NOT NULL,
	[Precio] [decimal](7, 2) NOT NULL,
	[Stock] [int] NULL,
	[Cod_Categoria] [int] NOT NULL,
	[Cod_Marca] [int] NOT NULL,
	[Cod_Proveedor] [int] NOT NULL,
	[Estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Producto] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Cod_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Categoria] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Categoria] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Cod_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Proveedor] [nvarchar](30) NOT NULL,
	[Apell_Proveedor] [nvarchar](30) NOT NULL,
	[Nomb_Empresa] [nvarchar](30) NOT NULL,
	[Telefono] [nvarchar](8) NULL,
	[Correo] [nvarchar](70) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Proveedor] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[Cod_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Marca] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ProductosView]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[ProductosView]
as
    select Cod_Producto CodigoProducto,
            p.Producto,
            p.Precio,
            p.Stock,
            c.Nom_Categoria Categoria,
            m.Marca,
            pv.Nomb_Empresa Proveedor
     from Productos p
    INNER JOIN Categorias c on c.Cod_Categoria = p.Cod_Categoria
    INNER JOIN Proveedor pv on pv.Cod_Proveedor = p.Cod_Proveedor
    INNER JOIN Marcas m on m.Cod_Marca = p.Cod_Marca
    where estado = 1 
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Nom_Usuario] [nvarchar](20) NOT NULL,
	[Contra_Usuario] [nvarchar](20) NOT NULL,
	[Cod_Empleado] [nvarchar](13) NULL,
	[IDNivel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Nom_Usuario] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Cod_Venta] [uniqueidentifier] NOT NULL,
	[Codigofactura] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Cliente] [nvarchar](13) NULL,
	[Nom_Usuario] [nvarchar](20) NULL,
	[Cod_CAI] [nvarchar](50) NULL,
	[Fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Venta] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[Cod_Venta] [uniqueidentifier] NOT NULL,
	[Cod_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](7, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Cod_Cliente] [nvarchar](13) NOT NULL,
	[Nom_Cliente] [nvarchar](30) NOT NULL,
	[Apell_Cliente] [nvarchar](30) NOT NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[Telefono] [nvarchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Cliente] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Cod_Empleado] [nvarchar](13) NOT NULL,
	[NomEmpleado] [nvarchar](30) NOT NULL,
	[ApellEmpleado] [nvarchar](30) NOT NULL,
	[Direccion] [nvarchar](70) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Cargo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Empleado] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ventasView]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ventasView]
as
select v.Codigofactura as Factura,
        e.NomEmpleado as Empleado,
        v.Cod_Cliente as [DNI Cliente],
        c.Nom_Cliente + ' ' + c.Cod_Cliente as Cliente,
        c.Telefono as [Tel Cliente],
        p.Producto,
        dv.Cantidad,
        dv.Precio,
        dv.Cantidad*dv.Precio as Subtotal,
        v.Fecha 
    from ventas v
    INNER JOIN Clientes c on c.Cod_Cliente = v.Cod_Cliente  
    INNER JOIN Detalle_Venta dv on dv.Cod_Venta = v.Cod_Venta  
    INNER JOIN Productos p on p.Cod_Producto = dv.Cod_Producto  
    INNER JOIN Usuarios u on u.Nom_Usuario = v.Nom_Usuario  
    INNER JOIN Empleados e on e.Cod_Empleado = u.Cod_Empleado  
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[IDCargo] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCargo] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[empleadosView]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[empleadosView]
as
select  e.*,
        c.Cargo as NombreCargo
from Empleados e
inner JOIN Cargos c on c.IDCargo = e.Cargo
GO
/****** Object:  Table [dbo].[Acciones]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acciones](
	[Cod_Accion] [int] IDENTITY(1,1) NOT NULL,
	[Accion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Accion] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Cod_Bitacora] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](20) NOT NULL,
	[Cod_Accion] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Bitacora] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CAI]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAI](
	[Cod_CAI] [nvarchar](50) NOT NULL,
	[Fecha_Inicio] [datetime] NOT NULL,
	[Fecha_Final] [datetime] NOT NULL,
	[Rango_Inicio] [nvarchar](50) NOT NULL,
	[Rango_Final] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_CAI] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[Cod_Compra] [uniqueidentifier] NOT NULL,
	[Cod_Proveedor] [int] NOT NULL,
	[Cod_Categoria] [int] NOT NULL,
	[Fecha_Compra] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Compra] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Compra]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Compra](
	[Cod_Compra] [uniqueidentifier] NOT NULL,
	[Cod_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](7, 2) NOT NULL,
	[ISV] [decimal](7, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Niveles]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Niveles](
	[IDNivel] [int] IDENTITY(1,1) NOT NULL,
	[Nivel] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDNivel] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bitacora] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Compras] ADD  DEFAULT (getdate()) FOR [Fecha_Compra]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [df_estado]  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[Ventas] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD FOREIGN KEY([Cod_Accion])
REFERENCES [dbo].[Acciones] ([Cod_Accion])
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuarios] ([Nom_Usuario])
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD FOREIGN KEY([Cod_Categoria])
REFERENCES [dbo].[Categorias] ([Cod_Categoria])
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD FOREIGN KEY([Cod_Proveedor])
REFERENCES [dbo].[Proveedor] ([Cod_Proveedor])
GO
ALTER TABLE [dbo].[Detalle_Compra]  WITH CHECK ADD FOREIGN KEY([Cod_Compra])
REFERENCES [dbo].[Compras] ([Cod_Compra])
GO
ALTER TABLE [dbo].[Detalle_Compra]  WITH CHECK ADD FOREIGN KEY([Cod_Producto])
REFERENCES [dbo].[Productos] ([Cod_Producto])
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD FOREIGN KEY([Cod_Producto])
REFERENCES [dbo].[Productos] ([Cod_Producto])
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD FOREIGN KEY([Cod_Venta])
REFERENCES [dbo].[Ventas] ([Cod_Venta])
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([Cargo])
REFERENCES [dbo].[Cargos] ([IDCargo])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([Cod_Categoria])
REFERENCES [dbo].[Categorias] ([Cod_Categoria])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([Cod_Marca])
REFERENCES [dbo].[Marcas] ([Cod_Marca])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([Cod_Proveedor])
REFERENCES [dbo].[Proveedor] ([Cod_Proveedor])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([Cod_Empleado])
REFERENCES [dbo].[Empleados] ([Cod_Empleado])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([IDNivel])
REFERENCES [dbo].[Niveles] ([IDNivel])
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([Cod_Cliente])
REFERENCES [dbo].[Clientes] ([Cod_Cliente])
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD FOREIGN KEY([Nom_Usuario])
REFERENCES [dbo].[Usuarios] ([Nom_Usuario])
GO
/****** Object:  StoredProcedure [dbo].[sp_getCliente]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_getCliente]
@CodCliente NVARCHAR(13)
as
    select * from Clientes
    where Cod_Cliente = @CodCliente 
GO
/****** Object:  StoredProcedure [dbo].[sp_getMinMaxFechas]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_getMinMaxFechas]
as
select min(Fecha) as min,max(fecha) as max from Ventas
GO
/****** Object:  StoredProcedure [dbo].[sp_insertarDetalleVenta]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertarDetalleVenta]
@CodVenta UNIQUEIDENTIFIER,
@CodProd INT,
@Cant int,
@Precio float
as
insert into Detalle_Venta 
values(
    @CodVenta,
    @CodProd ,
    @Cant ,
    @Precio 
)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertCliente]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertCliente]
@CodCliente nvarchar(13),
@NomCliente nvarchar(30),
@ApeCliente nvarchar(30) = '',
@Direccion nvarchar(255) = '', 
@Telefono nvarchar(8)
as
insert into Clientes VALUES
(
@CodCliente,
@NomCliente,
@ApeCliente,
@Direccion ,
@Telefono
)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertProducto]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertProducto] 
@Producto nvarchar(70),
@Precio decimal,
@Stock int,
@CodCat int = 1,
@CodMarca int = 1,
@CodProv int = 1
as
    insert into Productos
    (
        Producto,
        Precio, 
        Stock ,
        Cod_Categoria, 
        Cod_Marca,
        Cod_Proveedor   
    ) 
    VALUES(
        @Producto,
        @Precio ,
        @Stock ,
        @CodCat ,
        @CodMarca ,
        @CodProv
    )
GO
/****** Object:  StoredProcedure [dbo].[sp_insertVenta]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_insertVenta]
@CodVenta UNIQUEIDENTIFIER,
@CodCliente NVARCHAR(13),
@NomUsuario nvarchar(20)
as
insert into Ventas(Cod_Venta,Cod_Cliente,Nom_Usuario) 
VALUES(
    @CodVenta ,
    @CodCliente ,
    @NomUsuario 
)
GO
/****** Object:  StoredProcedure [dbo].[sp_loggear]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_loggear]
@Nom_Usuario nvarchar(20),
@Contra_Usuario nvarchar(20)
as
select * from Usuarios
WHERE Nom_Usuario = @Nom_Usuario and Contra_Usuario = @Contra_Usuario
GO
/****** Object:  StoredProcedure [dbo].[sp_ventasPorFecha]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ventasPorFecha]
@fechaInicio date,
@fechaFin date
as
select * from ventasView
where Fecha BETWEEN @fechaInicio and DATEADD(DAY,1,@fechaFin)
ORDER BY Factura
GO
/****** Object:  StoredProcedure [dbo].[sp_verVentasPorFecha]    Script Date: 1/8/2021 02:33:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_verVentasPorFecha]
@fechaInicio date,
@fechaFin date
as
    select * 
    from ventas v
    INNER JOIN Clientes c on c.Cod_Cliente = v.Cod_Cliente  
    INNER JOIN Detalle_Venta dv on dv.Cod_Venta = v.Cod_Venta  
    INNER JOIN Productos p on p.Cod_Producto = dv.Cod_Producto  
    where Fecha BETWEEN @fechaInicio and DATEADD(DAY,1,@fechaFin)
    ORDER BY Codigofactura
GO
ALTER DATABASE [FerreteriaDB] SET  READ_WRITE 
GO
