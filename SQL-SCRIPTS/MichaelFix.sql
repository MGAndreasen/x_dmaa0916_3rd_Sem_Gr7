	USE [dmaa0916_128844]
	GO

	/* Fjerner Constraints */

	GO
	IF (OBJECT_ID('FK_Booking_Ticket_Booking_Passenger') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Ticket DROP CONSTRAINT FK_Booking_Ticket_Booking_Passenger
	END
	GO
	IF (OBJECT_ID('FK_Booking_Seat_Booking_Row') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Seat DROP CONSTRAINT FK_Booking_Seat_Booking_Row
	END
	GO
	IF (OBJECT_ID('FK_Booking_Plane_Booking_SeatSchema') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Plane DROP CONSTRAINT FK_Booking_Plane_Booking_SeatSchema
	END
	GO
	IF (OBJECT_ID('FK_Booking_Passenger_Booking_Seat') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Passenger DROP CONSTRAINT FK_Booking_Passenger_Booking_Seat
	END
	GO
	IF (OBJECT_ID('FK_Booking_Passenger_Booking_Booking') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Passenger DROP CONSTRAINT FK_Booking_Passenger_Booking_Booking
	END
	GO
	IF (OBJECT_ID('FK_Booking_Destination_Booking_Plane') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Destination DROP CONSTRAINT FK_Booking_Destination_Booking_Plane
	END
	GO
	IF (OBJECT_ID('FK_Booking_Customer_Booking_City') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Customer DROP CONSTRAINT FK_Booking_Customer_Booking_City
	END
	GO
	IF (OBJECT_ID('FK_Booking_Booking_Booking_Payment') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Booking DROP CONSTRAINT FK_Booking_Booking_Booking_Payment
	END
	GO
	IF (OBJECT_ID('FK_Booking_Booking_Booking_Destination1') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Booking DROP CONSTRAINT FK_Booking_Booking_Booking_Destination1
	END
	GO
	IF (OBJECT_ID('FK_Booking_Booking_Booking_Destination') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Booking DROP CONSTRAINT FK_Booking_Booking_Booking_Destination
	END
	GO
	IF (OBJECT_ID('FK_Booking_Booking_Booking_Customer') IS NOT NULL)
	BEGIN
		ALTER TABLE dbo.Booking_Booking DROP CONSTRAINT FK_Booking_Booking_Booking_Customer
	END
	GO

	/* Fjerner Tabeller */

	GO
	IF (OBJECT_ID('Booking_Ticket') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Ticket]
	END
	GO
	IF (OBJECT_ID('Booking_SeatSchema') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_SeatSchema]
	END
	GO
	IF (OBJECT_ID('Booking_Seat') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Seat]
	END
	GO
	IF (OBJECT_ID('Booking_Row') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Row]
	END
	GO
	IF (OBJECT_ID('Booking_Plane') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Plane]
	END
	GO
	IF (OBJECT_ID('Booking_Payment') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Payment]
	END
	GO
	IF (OBJECT_ID('Booking_Passenger') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Passenger]
	END
	GO
	IF (OBJECT_ID('Booking_Destination') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Destination]
	END
	GO
	IF (OBJECT_ID('Booking_Customer') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Customer]
	END
	GO
	IF (OBJECT_ID('Booking_City') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_City]
	END
	GO
	IF (OBJECT_ID('Booking_Booking') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Booking]
	END
	GO

	SET ANSI_NULLS ON
	GO
	SET QUOTED_IDENTIFIER ON
	GO

	/* Opretter Tabeller */

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Booking]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Booking](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Payment_Id] [int] NOT NULL,
		[Customer_Id] [int] NOT NULL,
		[StartDestinaton] [int] NOT NULL,
		[EndDestination] [int] NOT NULL,
		[Date] [date] NOT NULL,
		[Price] [int] NOT NULL,
	 CONSTRAINT [PK_Booking_Booking] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_City]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_City](
		[ZipCode] [int] NOT NULL,
		[Name] [nvarchar](50) NOT NULL,
	 CONSTRAINT [PK_Booking_City] PRIMARY KEY CLUSTERED 
	(
		[ZipCode] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Customer]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Customer](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[City_Id] [int] NOT NULL,
		[Cpr] [bigint] NOT NULL,
		[PhoneNo] [bigint] NOT NULL,
		[FirstName] [nvarchar](50) NOT NULL,
		[LastName] [nvarchar](50) NOT NULL,
		[Email] [nvarchar](50) NOT NULL,
		[Address] [nvarchar](50) NOT NULL,
		[Password] [nvarchar](50) NOT NULL,
		[Cofirmed] [bit] NOT NULL,
		[Roles] [nvarchar](50) NULL,
		[LastActive] [datetime] NULL,
	 CONSTRAINT [PK_Booking_Customer] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Destination]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Destination](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Plane_Id] [int] NOT NULL,
		[NameDestination] [nvarchar](50) NULL,
	 CONSTRAINT [PK_Booking_Destination] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Passenger]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Passenger](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Booking_Id] [int] NOT NULL,
		[Seat_Id] [int] NOT NULL,
		[FirstName] [nvarchar](50) NOT NULL,
		[LastName] [nvarchar](50) NOT NULL,
		[Cpr] [bigint] NOT NULL,
		[PassportId] [bigint] NOT NULL,
		[Luggage] [bit] NOT NULL,
	 CONSTRAINT [PK_Booking_Passenger] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Payment]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Payment](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Date] [date] NOT NULL,
		[Amount] [int] NOT NULL,
	 CONSTRAINT [PK_Booking_Payment] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Plane]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Plane](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Type] [nvarchar](50) NOT NULL,
	 CONSTRAINT [PK_Booking_Plane] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Row]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Row](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[SeatNumber] [int] NOT NULL,
		[Price] [int] NOT NULL,
	 CONSTRAINT [PK_Booking_Row] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Seat]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Seat](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Row_Id] [int] NOT NULL,
		[Number] [int] NOT NULL,
		[Availability] [bit] NOT NULL,
	 CONSTRAINT [PK_Booking_Seat] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_SeatSchema]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_SeatSchema](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Plain_id] [int] NOT NULL,
		[Layout] [nvarchar](50) NOT NULL,
		[Row] [int] NOT NULL,
	 CONSTRAINT [PK_Booking_SeatSchema] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Ticket]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Ticket](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[Passenger_Id] [int] NOT NULL,
	 CONSTRAINT [PK_Booking_Ticket] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	END
	GO

	/* Indsætter Demo Data */

	GO
	SET IDENTITY_INSERT [dbo].[Booking_Booking] ON 
	GO
	INSERT [dbo].[Booking_Booking] ([Id], [Payment_Id], [Customer_Id], [StartDestinaton], [EndDestination], [Date], [Price]) VALUES (12, 1, 3, 5, 4, CAST(N'2017-11-28' AS Date), 10000)
	GO

	SET IDENTITY_INSERT [dbo].[Booking_Booking] OFF 
	GO
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9000, N'Aalborg')
	GO
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9440, N'Gjøl')
	GO
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9670, N'Løgstør')
	GO


	SET IDENTITY_INSERT [dbo].[Booking_Customer] ON 
	GO
	INSERT [dbo].[Booking_Customer] ([Id], [City_Id], [Cpr], [PhoneNo], [FirstName], [LastName], [Email], [Address], [Password], [Cofirmed], [Roles], [LastActive]) VALUES (1, 9000, 808881233, 42732521, N'Arne', N'Kongen', N'ArneKongen@gmail.com', N'Kongevej 5', N'KongeKode', 1, NULL, NULL)
	GO
	INSERT [dbo].[Booking_Customer] ([Id], [City_Id], [Cpr], [PhoneNo], [FirstName], [LastName], [Email], [Address], [Password], [Cofirmed], [Roles], [LastActive]) VALUES (2, 9440, 1234567, 42732522, N'Phil', N'ISISKriger', N'IsisKriger@gmail.com', N'AllahuAkbar 911', N'AllahDidNothingWrong', 1, NULL, NULL)
	GO
	INSERT [dbo].[Booking_Customer] ([Id], [City_Id], [Cpr], [PhoneNo], [FirstName], [LastName], [Email], [Address], [Password], [Cofirmed], [Roles], [LastActive]) VALUES (3, 9670, 31231231, 42732523, N'Michael', N'Viking', N'Viking4Leif@gmail.com', N'SmokeAllDay 420', N'VikingBest', 1, NULL, NULL)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Customer] OFF


	GO
	SET IDENTITY_INSERT [dbo].[Booking_Destination] ON 
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (2, 2, N'Mallorca')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (3, 2, N'Moscow')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (4, 3, N'Paris')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (5, 10, N'Aalborg')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (7, 9, N'Gjøl')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (8, 3, N'dffds')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (9, 10, N'dffds')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (10, 3, N'Hej')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (11, 3, N'Hej')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (12, 3, N'Bangkok')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (13, 10, N'fd')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (14, 3, N'sadadsadasdsdas')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (15, 3, N'Yo')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (16, 10, N'fdsfsdf')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (19, 9, N'hh')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (20, 3, N'Rom')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (21, 2, N'Banja LUka')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (22, 1, N'BalkanIsles')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (24, 1, N'ItalinMyMaan')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (25, 2, N'London')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (27, 1, N'PokemonISLAND')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (29, 1, N'POkemonIsland')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (30, 1, N'919199191')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (31, 1, N'TESTTEST')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [Plane_Id], [NameDestination]) VALUES (32, 1, N'')
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Destination] OFF

	GO
	SET IDENTITY_INSERT [dbo].[Booking_Passenger] ON
	GO
	INSERT [dbo].[Booking_Passenger] ([Id], [Booking_Id], [Seat_Id], [FirstName], [LastName], [Cpr], [PassportId], [Luggage]) VALUES (1, 12, 4, N'Bjarne', N'Jørgensen', 1408681731, 12358132134, 0)
	GO
	INSERT [dbo].[Booking_Passenger] ([Id], [Booking_Id], [Seat_Id], [FirstName], [LastName], [Cpr], [PassportId], [Luggage]) VALUES (2, 12, 5, N'Birgit', N'Jørgensen', 2004681732, 123581321, 1)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Passenger] OFF

	GO
	SET IDENTITY_INSERT [dbo].[Booking_Payment] ON
	GO
	INSERT [dbo].[Booking_Payment] ([Id], [Date], [Amount]) VALUES (1, CAST(N'2017-11-28' AS Date), 25000)
	GO
	INSERT [dbo].[Booking_Payment] ([Id], [Date], [Amount]) VALUES (2, CAST(N'2017-11-28' AS Date), 15000)
	GO
	INSERT [dbo].[Booking_Payment] ([Id], [Date], [Amount]) VALUES (3, CAST(N'2017-11-28' AS Date), 10000)
	GO
	INSERT [dbo].[Booking_Payment] ([Id], [Date], [Amount]) VALUES (4, CAST(N'2017-11-28' AS Date), 65000)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Payment] OFF

	GO
	SET IDENTITY_INSERT [dbo].[Booking_Plane] ON
	GO
	INSERT [dbo].[Booking_Plane] ([Id], [Type]) VALUES (1, N'747 beast mode')
	GO
	INSERT [dbo].[Booking_Plane] ([Id], [Type]) VALUES (2, N'Air Force One')
	GO
	INSERT [dbo].[Booking_Plane] ([Id], [Type]) VALUES (3, N'Boeing 777')
	GO
	INSERT [dbo].[Booking_Plane] ([Id], [Type]) VALUES (9, N'Boeing 787')
	GO
	INSERT [dbo].[Booking_Plane] ([Id], [Type]) VALUES (10, N'Boeing 767')
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Plane] OFF

	GO
	SET IDENTITY_INSERT [dbo].[Booking_Row] ON
	GO
	INSERT [dbo].[Booking_Row] ([Id], [SeatNumber], [Price]) VALUES (1, 3, 400)
	GO
	INSERT [dbo].[Booking_Row] ([Id], [SeatNumber], [Price]) VALUES (2, 10, 400)
	GO
	INSERT [dbo].[Booking_Row] ([Id], [SeatNumber], [Price]) VALUES (3, 5, 500)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Row] OFF

	GO
	SET IDENTITY_INSERT [dbo].[Booking_Seat] ON
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (4, 1, 1, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (5, 1, 2, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (6, 1, 3, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (7, 1, 4, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (8, 1, 5, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (9, 1, 6, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (10, 2, 1, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (11, 2, 2, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (12, 2, 3, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (13, 2, 4, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (14, 2, 5, 1)
	GO
	INSERT [dbo].[Booking_Seat] ([Id], [Row_Id], [Number], [Availability]) VALUES (15, 2, 6, 1)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Seat] OFF


	GO
	SET IDENTITY_INSERT [dbo].[Booking_SeatSchema] ON
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plain_Id], [Layout], [Row]) VALUES (1, 1, 'ABC|DEF', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plain_Id], [Layout], [Row]) VALUES (2, 1, 'ABC|DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plain_Id], [Layout], [Row]) VALUES (3, 1, 'AB|||CD', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plain_Id], [Layout], [Row]) VALUES (4, 1, 'A|||||B', 4)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_SeatSchema] OFF

	GO
	SET IDENTITY_INSERT [dbo].[Booking_Ticket] ON
	GO
	INSERT [dbo].[Booking_Ticket] ([Id], [Passenger_Id]) VALUES (1, 1)
	GO
	INSERT [dbo].[Booking_Ticket] ([Id], [Passenger_Id]) VALUES (2, 2)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Ticket] OFF
	GO

	/* Opretter foreign keys */
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Customer] FOREIGN KEY([Customer_Id])
	REFERENCES [dbo].[Booking_Customer] ([Id])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Customer]
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Destination]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Destination] FOREIGN KEY([StartDestinaton])
	REFERENCES [dbo].[Booking_Destination] ([Id])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Destination]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Destination]
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Destination1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Destination1] FOREIGN KEY([EndDestination])
	REFERENCES [dbo].[Booking_Destination] ([Id])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Destination1]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Destination1]
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Payment] FOREIGN KEY([Payment_Id])
	REFERENCES [dbo].[Booking_Payment] ([Id])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Payment]
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Customer_Booking_City]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Customer]'))
	ALTER TABLE [dbo].[Booking_Customer]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Customer_Booking_City] FOREIGN KEY([City_Id])
	REFERENCES [dbo].[Booking_City] ([ZipCode])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Customer_Booking_City]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Customer]'))
	ALTER TABLE [dbo].[Booking_Customer] CHECK CONSTRAINT [FK_Booking_Customer_Booking_City]
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Destination_Booking_Plane]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Destination]'))
	ALTER TABLE [dbo].[Booking_Destination]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Destination_Booking_Plane] FOREIGN KEY([Plane_Id])
	REFERENCES [dbo].[Booking_Plane] ([Id])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Destination_Booking_Plane]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Destination]'))
	ALTER TABLE [dbo].[Booking_Destination] CHECK CONSTRAINT [FK_Booking_Destination_Booking_Plane]
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Passenger_Booking_Booking]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Passenger]'))
	ALTER TABLE [dbo].[Booking_Passenger]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Passenger_Booking_Booking] FOREIGN KEY([Booking_Id])
	REFERENCES [dbo].[Booking_Booking] ([Id])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Passenger_Booking_Booking]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Passenger]'))
	ALTER TABLE [dbo].[Booking_Passenger] CHECK CONSTRAINT [FK_Booking_Passenger_Booking_Booking]
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Passenger_Booking_Seat]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Passenger]'))
	ALTER TABLE [dbo].[Booking_Passenger]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Passenger_Booking_Seat] FOREIGN KEY([Seat_Id])
	REFERENCES [dbo].[Booking_Seat] ([Id])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Passenger_Booking_Seat]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Passenger]'))
	ALTER TABLE [dbo].[Booking_Passenger] CHECK CONSTRAINT [FK_Booking_Passenger_Booking_Seat]
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Seat_Booking_Row]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Seat]'))
	ALTER TABLE [dbo].[Booking_Seat]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Seat_Booking_Row] FOREIGN KEY([Row_Id])
	REFERENCES [dbo].[Booking_Row] ([Id])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Seat_Booking_Row]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Seat]'))
	ALTER TABLE [dbo].[Booking_Seat] CHECK CONSTRAINT [FK_Booking_Seat_Booking_Row]
	GO
	IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Ticket_Booking_Passenger]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Ticket]'))
	ALTER TABLE [dbo].[Booking_Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Ticket_Booking_Passenger] FOREIGN KEY([Passenger_Id])
	REFERENCES [dbo].[Booking_Passenger] ([Id])
	GO
	IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Ticket_Booking_Passenger]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Ticket]'))
	ALTER TABLE [dbo].[Booking_Ticket] CHECK CONSTRAINT [FK_Booking_Ticket_Booking_Passenger]
	GO
