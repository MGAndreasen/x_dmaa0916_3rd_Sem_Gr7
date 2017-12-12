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
	IF (OBJECT_ID('Booking_Departure') IS NOT NULL)
	BEGIN
		DROP TABLE [dbo].[Booking_Departure]
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
		[Departure_Id] [int] NOT NULL,
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
		[Plane_id] [int] NOT NULL,
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
	
	IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Booking_Departure]') AND type in (N'U'))
	BEGIN
	CREATE TABLE [dbo].[Booking_Departure](
		[Id] [int] IDENTITY(1,1) NOT NULL,
		[StartDestination] [int] NULL,
		[EndDestination] [int] NULL,
		[DepartureTime] [datetime] NULL,
		[Plane_Id] [int] NULL,
	CONSTRAINT [PK_Booking_Departure] PRIMARY KEY CLUSTERED 
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
	INSERT [dbo].[Booking_Booking] ([Id], [Payment_Id], [Customer_Id], [Departure_Id], [Date], [Price]) VALUES (12, 1, 3, 1, CAST(N'2017-11-28' AS Date), 10000)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Booking] OFF 
	GO

	GO
	SET IDENTITY_INSERT [dbo].[Booking_Departure] ON 
	GO
	INSERT [dbo].[Booking_Departure] ([Id], [StartDestination], [EndDestination], [DepartureTime], [Plane_Id]) VALUES (1, 1, 2, CAST(N'2017-12-28' AS DateTime), 1)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Departure] OFF 
	GO

	
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9000, N'Aalborg')
	GO
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9440, N'Gjøl')
	GO
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9670, N'Løgstør')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9260, N'Gistrup')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (7700, N'Thisted')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9240, N'Nibe')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9293, N'Kongerslev')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9400, N'Nørresundby')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9990, N'Skagen')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9700, N'Brønderslev')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9500, N'Hobro')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9800, N'Hjørring')
	GO 
	INSERT [dbo].[Booking_City] ([ZipCode], [Name]) VALUES (9940, N'Læsø')
	GO 

	SET IDENTITY_INSERT [dbo].[Booking_Customer] ON 
	GO
	INSERT [dbo].[Booking_Customer] ([Id], [City_Id], [Cpr], [PhoneNo], [FirstName], [LastName], [Email], [Address], [Password], [Cofirmed], [Roles], [LastActive]) VALUES (1, 9000, 808881233, 42732521, N'Admin', N'istrator', N'admin@test.dk', N'Kongevej 5', N'1234', 1, 'Admin', NULL)
	GO
	INSERT [dbo].[Booking_Customer] ([Id], [City_Id], [Cpr], [PhoneNo], [FirstName], [LastName], [Email], [Address], [Password], [Cofirmed], [Roles], [LastActive]) VALUES (2, 9440, 1234567, 42732522, N'User', N'Customer', N'user@test.dk', N'AllahuAkbar 911', N'1234', 1, 'User', NULL)
	GO
	INSERT [dbo].[Booking_Customer] ([Id], [City_Id], [Cpr], [PhoneNo], [FirstName], [LastName], [Email], [Address], [Password], [Cofirmed], [Roles], [LastActive]) VALUES (3, 9670, 31231231, 42732523, N'guest', N'account', N'guest', N'SmokeAllDay 420', N'Guest', 1, 'Guest', NULL)
	GO
	SET IDENTITY_INSERT [dbo].[Booking_Customer] OFF


	GO
	SET IDENTITY_INSERT [dbo].[Booking_Destination] ON 
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (2, N'Mallorca')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (3, N'Moscow')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (4, N'Paris')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (5, N'Aalborg')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (7, N'Gjøl')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (8, N'Tel-Aviv')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (9, N'Barcelona')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (10, N'Stockholm')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (11, N'Oslo')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (12, N'Berlin')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (13, N'Amsterdam')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (14, N'Melbourne')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (15, N'Cape Town')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (16, N'Libanon')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (17, N'Bangkok')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (18, N'Tokyo')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (19, N'Shanghai')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (20, N'Beijing')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (21, N'Madrid')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (22, N'Rom')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (23, N'Firenze')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (24, N'København')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (25, N'Helsinki')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (26, N'Nuuk')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (27, N'Seoul')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (28, N'Kampala')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (29, N'Detroit')
	GO
	INSERT [dbo].[Booking_Destination] ([Id], [NameDestination]) VALUES (30, N'Dubai')
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
	INSERT [dbo].[Booking_Plane] ([Id], [Type]) VALUES (1, N'Boeing 737-800')
	GO
	INSERT [dbo].[Booking_Plane] ([Id], [Type]) VALUES (9, N'Boeing 787')
	GO
	INSERT [dbo].[Booking_Plane] ([Id], [Type]) VALUES (10, N'Boeing 737-8')
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
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (1, 1, 'AB||CD||EF', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (2, 1, 'AB||CD||EF', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (3, 1, 'AB||CD||EF', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (4, 1, 'AB||CD||EF', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (5, 1, 'AB||CD||EF', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (6, 1, 'AB||CD||EF', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (7, 1, 'AB||CD||EF', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (8, 1, 'AB||CD||EF', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (9, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (10, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (11, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (12, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (13, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (14, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (15, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (16, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (17, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (18, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (19, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (20, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (21, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (22, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (23, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (24, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (25, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (26, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (27, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (28, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (29, 1, 'ABC|DEF|GHI', 1)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (30, 9, 'AB|||CD', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (31, 9, 'AB|||CD', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (32, 9, 'AB|||CD', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (33, 9, 'AB|||CD', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (34, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (35, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (36, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (37, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (38, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (39, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (40, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (41, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (42, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (43, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (44, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (45, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (46, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (47, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (48, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (49, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (50, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (51, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (52, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (53, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (54, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (55, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (56, 9, 'ABC||DEF', 2)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (57, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (58, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (59, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (60, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (61, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (62, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (63, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (64, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (65, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (66, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (67, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (68, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (69, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (70, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (71, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (72, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (73, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (74, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (75, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (76, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (77, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (78, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (79, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (80, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (81, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (82, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (83, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (84, 10, 'ABC||DEF', 3)
	GO
	INSERT [dbo].[Booking_SeatSchema] ([Id], [Plane_Id], [Layout], [Row]) VALUES (85, 1, 'A|||||B', 4)
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
	-- GO
	-- IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	-- ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Customer] FOREIGN KEY([Customer_Id])
	-- REFERENCES [dbo].[Booking_Customer] ([Id])
	-- GO
	-- IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Customer]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	-- ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Customer]
	-- GO
	-- IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	-- ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Payment] FOREIGN KEY([Payment_Id])
	-- REFERENCES [dbo].[Booking_Payment] ([Id])
	-- GO
	-- IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Booking_Booking_Payment]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Booking]'))
	-- ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Payment]
	-- GO
	-- IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Customer_Booking_City]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Customer]'))
	-- ALTER TABLE [dbo].[Booking_Customer]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Customer_Booking_City] FOREIGN KEY([City_Id])
	-- REFERENCES [dbo].[Booking_City] ([ZipCode])
	-- GO
	-- IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Customer_Booking_City]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Customer]'))
	-- ALTER TABLE [dbo].[Booking_Customer] CHECK CONSTRAINT [FK_Booking_Customer_Booking_City]
	-- GO
	-- IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Passenger_Booking_Booking]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Passenger]'))
	-- ALTER TABLE [dbo].[Booking_Passenger]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Passenger_Booking_Booking] FOREIGN KEY([Booking_Id])
	-- REFERENCES [dbo].[Booking_Booking] ([Id])
	-- GO
	-- IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Passenger_Booking_Booking]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Passenger]'))
	-- ALTER TABLE [dbo].[Booking_Passenger] CHECK CONSTRAINT [FK_Booking_Passenger_Booking_Booking]
	-- GO
	-- IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Passenger_Booking_Seat]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Passenger]'))
	-- ALTER TABLE [dbo].[Booking_Passenger]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Passenger_Booking_Seat] FOREIGN KEY([Seat_Id])
	-- REFERENCES [dbo].[Booking_Seat] ([Id])
	-- GO
	-- IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Passenger_Booking_Seat]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Passenger]'))
	-- ALTER TABLE [dbo].[Booking_Passenger] CHECK CONSTRAINT [FK_Booking_Passenger_Booking_Seat]
	-- GO
	-- IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Seat_Booking_Row]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Seat]'))
	-- ALTER TABLE [dbo].[Booking_Seat]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Seat_Booking_Row] FOREIGN KEY([Row_Id])
	-- REFERENCES [dbo].[Booking_Row] ([Id])
	-- GO
	-- IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Seat_Booking_Row]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Seat]'))
	-- ALTER TABLE [dbo].[Booking_Seat] CHECK CONSTRAINT [FK_Booking_Seat_Booking_Row]
	-- GO
	-- IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Ticket_Booking_Passenger]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Ticket]'))
	-- ALTER TABLE [dbo].[Booking_Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Ticket_Booking_Passenger] FOREIGN KEY([Passenger_Id])
	-- REFERENCES [dbo].[Booking_Passenger] ([Id])
	-- GO
	-- IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Booking_Ticket_Booking_Passenger]') AND parent_object_id = OBJECT_ID(N'[dbo].[Booking_Ticket]'))
	-- ALTER TABLE [dbo].[Booking_Ticket] CHECK CONSTRAINT [FK_Booking_Ticket_Booking_Passenger]
	-- GO
