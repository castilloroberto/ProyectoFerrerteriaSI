SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([Cod_Categoria], [Nom_Categoria]) VALUES (1, N'Construccion')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([Cod_Proveedor], [Nom_Proveedor], [Apell_Proveedor], [Nomb_Empresa], [Telefono], [Correo]) VALUES (1, N'Angel', N'Castillo', N'Truper', N'88445544', N'angelv45@gmail.com')
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([Cod_Marca], [Marca]) VALUES (1, N'Truper')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Cod_Producto], [Producto], [Precio], [Stock], [Cod_Categoria], [Cod_Marca], [Cod_Proveedor], [Estado]) VALUES (2, N'Producto 1', CAST(4000.00 AS Decimal(7, 2)), 50, 1, 1, 1, 0)
INSERT [dbo].[Productos] ([Cod_Producto], [Producto], [Precio], [Stock], [Cod_Categoria], [Cod_Marca], [Cod_Proveedor], [Estado]) VALUES (3, N'Producto 2', CAST(1000.00 AS Decimal(7, 2)), 10, 1, 1, 1, 0)
INSERT [dbo].[Productos] ([Cod_Producto], [Producto], [Precio], [Stock], [Cod_Categoria], [Cod_Marca], [Cod_Proveedor], [Estado]) VALUES (5, N'producto 3', CAST(1500.00 AS Decimal(7, 2)), 15, 1, 1, 1, 0)
INSERT [dbo].[Productos] ([Cod_Producto], [Producto], [Precio], [Stock], [Cod_Categoria], [Cod_Marca], [Cod_Proveedor], [Estado]) VALUES (6, N'prodcuto 4', CAST(1500.00 AS Decimal(7, 2)), 20, 1, 1, 1, 1)
INSERT [dbo].[Productos] ([Cod_Producto], [Producto], [Precio], [Stock], [Cod_Categoria], [Cod_Marca], [Cod_Proveedor], [Estado]) VALUES (7, N'Martillo', CAST(50.00 AS Decimal(7, 2)), 15, 1, 1, 1, 1)
INSERT [dbo].[Productos] ([Cod_Producto], [Producto], [Precio], [Stock], [Cod_Categoria], [Cod_Marca], [Cod_Proveedor], [Estado]) VALUES (8, N'hola', CAST(123.00 AS Decimal(7, 2)), 4, 1, 1, 1, 0)
INSERT [dbo].[Productos] ([Cod_Producto], [Producto], [Precio], [Stock], [Cod_Categoria], [Cod_Marca], [Cod_Proveedor], [Estado]) VALUES (9, N'adios', CAST(444.00 AS Decimal(7, 2)), 2, 1, 1, 1, 0)
INSERT [dbo].[Productos] ([Cod_Producto], [Producto], [Precio], [Stock], [Cod_Categoria], [Cod_Marca], [Cod_Proveedor], [Estado]) VALUES (10, N'Carreta', CAST(400.00 AS Decimal(7, 2)), 20, 1, 1, 1, 1)
INSERT [dbo].[Productos] ([Cod_Producto], [Producto], [Precio], [Stock], [Cod_Categoria], [Cod_Marca], [Cod_Proveedor], [Estado]) VALUES (11, N'Pala', CAST(100.00 AS Decimal(7, 2)), 100, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Niveles] ON 

INSERT [dbo].[Niveles] ([IDNivel], [Nivel]) VALUES (1, N'admin')
INSERT [dbo].[Niveles] ([IDNivel], [Nivel]) VALUES (2, N'usuario')
SET IDENTITY_INSERT [dbo].[Niveles] OFF
GO
SET IDENTITY_INSERT [dbo].[Cargos] ON 

INSERT [dbo].[Cargos] ([IDCargo], [Cargo]) VALUES (1, N'Gerente')
INSERT [dbo].[Cargos] ([IDCargo], [Cargo]) VALUES (2, N'Programador')
INSERT [dbo].[Cargos] ([IDCargo], [Cargo]) VALUES (3, N'DBA')
SET IDENTITY_INSERT [dbo].[Cargos] OFF
GO
INSERT [dbo].[Empleados] ([Cod_Empleado], [NomEmpleado], [ApellEmpleado], [Direccion], [Telefono], [Cargo]) VALUES (N'0307200101235', N'Roberto', N'Castillo', N'Danli', 88137603, 2)
INSERT [dbo].[Empleados] ([Cod_Empleado], [NomEmpleado], [ApellEmpleado], [Direccion], [Telefono], [Cargo]) VALUES (N'0703200001235', N'Gabrieal', N'Gonzales', N'Danli', 78454545, 2)
GO
INSERT [dbo].[Usuarios] ([Nom_Usuario], [Contra_Usuario], [Cod_Empleado], [IDNivel]) VALUES (N'admin', N'admin', N'0703200001235', 1)
INSERT [dbo].[Usuarios] ([Nom_Usuario], [Contra_Usuario], [Cod_Empleado], [IDNivel]) VALUES (N'gabriela', N'1234', N'0703200001235', 1)
INSERT [dbo].[Usuarios] ([Nom_Usuario], [Contra_Usuario], [Cod_Empleado], [IDNivel]) VALUES (N'robertcast', N'1234', N'0307200101235', 2)
GO
INSERT [dbo].[Clientes] ([Cod_Cliente], [Nom_Cliente], [Apell_Cliente], [Direccion], [Telefono]) VALUES (N'0703200101235', N'Roberto Castillo', N'', N'', N'88137603')
INSERT [dbo].[Clientes] ([Cod_Cliente], [Nom_Cliente], [Apell_Cliente], [Direccion], [Telefono]) VALUES (N'1111', N'laura', N'', N'', N'929341')
INSERT [dbo].[Clientes] ([Cod_Cliente], [Nom_Cliente], [Apell_Cliente], [Direccion], [Telefono]) VALUES (N'1234', N'Laura', N'', N'', N'9302943')
INSERT [dbo].[Clientes] ([Cod_Cliente], [Nom_Cliente], [Apell_Cliente], [Direccion], [Telefono]) VALUES (N'22222', N'angelica', N'', N'', N'8589324')
INSERT [dbo].[Clientes] ([Cod_Cliente], [Nom_Cliente], [Apell_Cliente], [Direccion], [Telefono]) VALUES (N'2233', N'angelica', N'', N'', N'22333445')
INSERT [dbo].[Clientes] ([Cod_Cliente], [Nom_Cliente], [Apell_Cliente], [Direccion], [Telefono]) VALUES (N'3333', N'dania', N'', N'', N'9283923')
INSERT [dbo].[Clientes] ([Cod_Cliente], [Nom_Cliente], [Apell_Cliente], [Direccion], [Telefono]) VALUES (N'34243', N'roberto', N'', N'', N'3543644')
INSERT [dbo].[Clientes] ([Cod_Cliente], [Nom_Cliente], [Apell_Cliente], [Direccion], [Telefono]) VALUES (N'43221', N'laura', N'', N'', N'9232123')
INSERT [dbo].[Clientes] ([Cod_Cliente], [Nom_Cliente], [Apell_Cliente], [Direccion], [Telefono]) VALUES (N'54322', N'diana', N'', N'', N'8938234')
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'00000000-0000-0000-0000-000000000000', 1, N'54322', N'robertcast', NULL, CAST(N'2021-07-30T02:20:19.630' AS DateTime))
INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'fb1a3ff5-48f9-4af1-afdd-0d133f00b01f', 9, N'0703200101235', N'admin', NULL, CAST(N'2021-08-01T17:55:32.863' AS DateTime))
INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'd1522782-3cd0-4e34-a2e9-1d211e1d9c61', 3, N'3333', N'robertcast', NULL, CAST(N'2021-07-30T02:26:21.773' AS DateTime))
INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'eb677a1a-1a08-4ce7-a43a-3c4b50539274', 10, N'0703200101235', N'admin', NULL, CAST(N'2021-08-01T20:16:40.807' AS DateTime))
INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'a6391e4c-617c-4229-9e0a-4bec1acfba8e', 4, N'2233', N'robertcast', NULL, CAST(N'2021-07-30T02:46:21.340' AS DateTime))
INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'f5760e68-bd7d-4d6b-b868-6acd7b9a146b', 8, N'0703200101235', N'robertcast', NULL, CAST(N'2021-08-01T14:21:10.507' AS DateTime))
INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'692f3889-1d15-4a40-b712-72c1226442a4', 5, N'1111', N'robertcast', NULL, CAST(N'2021-07-30T02:58:41.910' AS DateTime))
INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'b4d7a438-305a-4e42-acf3-9f40b5046290', 2, N'22222', N'robertcast', NULL, CAST(N'2021-07-30T02:25:18.413' AS DateTime))
INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'8fcda743-a60a-4549-a99c-a8ea5e283fdb', 7, N'1111', N'robertcast', NULL, CAST(N'2021-07-30T03:04:40.973' AS DateTime))
INSERT [dbo].[Ventas] ([Cod_Venta], [Codigofactura], [Cod_Cliente], [Nom_Usuario], [Cod_CAI], [Fecha]) VALUES (N'9d32a5ef-5ce5-4ed9-8caa-c2b2502f678e', 6, N'1111', N'robertcast', NULL, CAST(N'2021-07-30T02:59:15.997' AS DateTime))
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'b4d7a438-305a-4e42-acf3-9f40b5046290', 2, 2, CAST(4000.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'd1522782-3cd0-4e34-a2e9-1d211e1d9c61', 2, 2, CAST(4000.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'a6391e4c-617c-4229-9e0a-4bec1acfba8e', 2, 2, CAST(4000.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'692f3889-1d15-4a40-b712-72c1226442a4', 2, 2, CAST(4000.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'9d32a5ef-5ce5-4ed9-8caa-c2b2502f678e', 2, 2, CAST(4000.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'8fcda743-a60a-4549-a99c-a8ea5e283fdb', 2, 2, CAST(4000.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'8fcda743-a60a-4549-a99c-a8ea5e283fdb', 3, 2, CAST(1000.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'fb1a3ff5-48f9-4af1-afdd-0d133f00b01f', 9, 2, CAST(400.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'fb1a3ff5-48f9-4af1-afdd-0d133f00b01f', 9, 1, CAST(444.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'eb677a1a-1a08-4ce7-a43a-3c4b50539274', 5, 2, CAST(1400.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'eb677a1a-1a08-4ce7-a43a-3c4b50539274', 10, 2, CAST(350.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'9d32a5ef-5ce5-4ed9-8caa-c2b2502f678e', 3, 2, CAST(1000.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'f5760e68-bd7d-4d6b-b868-6acd7b9a146b', 9, 1, CAST(444.00 AS Decimal(7, 2)))
INSERT [dbo].[Detalle_Venta] ([Cod_Venta], [Cod_Producto], [Cantidad], [Precio]) VALUES (N'f5760e68-bd7d-4d6b-b868-6acd7b9a146b', 6, 2, CAST(1500.00 AS Decimal(7, 2)))
GO
