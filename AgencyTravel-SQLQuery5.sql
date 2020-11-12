USE [AgenciaTravel]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 12/11/2020 16:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[primernombreCliente] [nvarchar](20) NOT NULL,
	[segundonombreCliente] [nvarchar](20) NOT NULL,
	[primerapellidoCliente] [nvarchar](20) NOT NULL,
	[segundoapellidoCliente] [nvarchar](20) NOT NULL,
	[telefonoCliente] [varchar](20) NOT NULL,
	[dpiCliente] [nvarchar](20) NOT NULL,
	[iddestinoCliente] [int] NOT NULL,
	[emailCliente] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Destinos]    Script Date: 12/11/2020 16:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destinos](
	[idDestino] [int] IDENTITY(1,1) NOT NULL,
	[primernombreDestino] [nvarchar](30) NOT NULL,
	[segundonombreDestino] [nvarchar](50) NOT NULL,
	[descripcionDestino] [nvarchar](100) NOT NULL,
	[precioDestino] [int] NOT NULL,
 CONSTRAINT [PK_Destinos] PRIMARY KEY CLUSTERED 
(
	[idDestino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Viajes]    Script Date: 12/11/2020 16:21:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viajes](
	[idViaje] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[idDestino] [int] NOT NULL,
	[descripcionDestino] [nvarchar](100) NOT NULL,
	[precioDestino] [int] NOT NULL,
	[emailCliente] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Viajes] PRIMARY KEY CLUSTERED 
(
	[idViaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([idCliente], [primernombreCliente], [segundonombreCliente], [primerapellidoCliente], [segundoapellidoCliente], [telefonoCliente], [dpiCliente], [iddestinoCliente], [emailCliente]) VALUES (1, N'Sergio', N'Vinicio', N'De Paz', N'Giron', N'57181532', N'2150703052121', 1, N'sergio.depaz.201221022@gmail.com')
GO
INSERT [dbo].[Clientes] ([idCliente], [primernombreCliente], [segundonombreCliente], [primerapellidoCliente], [segundoapellidoCliente], [telefonoCliente], [dpiCliente], [iddestinoCliente], [emailCliente]) VALUES (3, N'Javier', N'Mauricio', N'De Paz', N'Giron', N'5556669988', N'2150717121321', 2, N'javier@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Destinos] ON 
GO
INSERT [dbo].[Destinos] ([idDestino], [primernombreDestino], [segundonombreDestino], [descripcionDestino], [precioDestino]) VALUES (1, N'Siete Altares', N'Livignston', N'Un hermoso destino lleno de cascadas naturales en la playa de Livingston', 800)
GO
INSERT [dbo].[Destinos] ([idDestino], [primernombreDestino], [segundonombreDestino], [descripcionDestino], [precioDestino]) VALUES (2, N'Playa Blanca', N'Izabal', N'Playas de arena blanca con hermosas palmeras para disfrutar del sol', 1000)
GO
SET IDENTITY_INSERT [dbo].[Destinos] OFF
GO
/****** Object:  Index [IX_Clientes]    Script Date: 12/11/2020 16:21:25 ******/
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [IX_Clientes] UNIQUE NONCLUSTERED 
(
	[iddestinoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Viajes]    Script Date: 12/11/2020 16:21:25 ******/
ALTER TABLE [dbo].[Viajes] ADD  CONSTRAINT [IX_Viajes] UNIQUE NONCLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Viajes_1]    Script Date: 12/11/2020 16:21:25 ******/
ALTER TABLE [dbo].[Viajes] ADD  CONSTRAINT [IX_Viajes_1] UNIQUE NONCLUSTERED 
(
	[idDestino] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Destinos]  WITH CHECK ADD  CONSTRAINT [FK_Destinos_Clientes] FOREIGN KEY([idDestino])
REFERENCES [dbo].[Clientes] ([iddestinoCliente])
GO
ALTER TABLE [dbo].[Destinos] CHECK CONSTRAINT [FK_Destinos_Clientes]
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD  CONSTRAINT [FK_Viajes_Clientes] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Clientes] ([idCliente])
GO
ALTER TABLE [dbo].[Viajes] CHECK CONSTRAINT [FK_Viajes_Clientes]
GO
ALTER TABLE [dbo].[Viajes]  WITH CHECK ADD  CONSTRAINT [FK_Viajes_Destinos] FOREIGN KEY([idDestino])
REFERENCES [dbo].[Destinos] ([idDestino])
GO
ALTER TABLE [dbo].[Viajes] CHECK CONSTRAINT [FK_Viajes_Destinos]
GO
