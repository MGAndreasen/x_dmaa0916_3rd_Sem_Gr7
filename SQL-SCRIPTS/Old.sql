/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2014 (12.0.2000)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [dmaa0916_128844]
GO
/****** Object:  Table [dbo].[Booking_Booking]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Booking_City]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_City](
	[ZipCode] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Booking_City] PRIMARY KEY CLUSTERED 
(
	[ZipCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking_Customer]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Booking_Destination]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_Destination](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Plane_Id] [int] NOT NULL,
	[NameDestination] [nvarchar](50) NULL,
 CONSTRAINT [PK_Booking_Destination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking_Passenger]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Booking_Payment]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_Payment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_Booking_Payment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking_Plane]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_Plane](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SeatSchema_Id] [int] NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Booking_Plane] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking_Row]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_Row](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SeatNumber] [int] NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_Booking_Row] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking_Seat]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Booking_SeatSchema]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_SeatSchema](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Layout] [int] NOT NULL,
	[Row] [int] NOT NULL,
 CONSTRAINT [PK_Booking_SeatSchema] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking_Ticket]    Script Date: 07-12-2017 11:05:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_Ticket](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Passenger_Id] [int] NOT NULL,
 CONSTRAINT [PK_Booking_Ticket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Customer] FOREIGN KEY([Customer_Id])
REFERENCES [dbo].[Booking_Customer] ([Id])
GO
ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Customer]
GO
ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Destination] FOREIGN KEY([StartDestinaton])
REFERENCES [dbo].[Booking_Destination] ([Id])
GO
ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Destination]
GO
ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Destination1] FOREIGN KEY([EndDestination])
REFERENCES [dbo].[Booking_Destination] ([Id])
GO
ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Destination1]
GO
ALTER TABLE [dbo].[Booking_Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Booking_Booking_Payment] FOREIGN KEY([Payment_Id])
REFERENCES [dbo].[Booking_Payment] ([Id])
GO
ALTER TABLE [dbo].[Booking_Booking] CHECK CONSTRAINT [FK_Booking_Booking_Booking_Payment]
GO
ALTER TABLE [dbo].[Booking_Customer]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Customer_Booking_City] FOREIGN KEY([City_Id])
REFERENCES [dbo].[Booking_City] ([ZipCode])
GO
ALTER TABLE [dbo].[Booking_Customer] CHECK CONSTRAINT [FK_Booking_Customer_Booking_City]
GO
ALTER TABLE [dbo].[Booking_Destination]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Destination_Booking_Plane] FOREIGN KEY([Plane_Id])
REFERENCES [dbo].[Booking_Plane] ([Id])
GO
ALTER TABLE [dbo].[Booking_Destination] CHECK CONSTRAINT [FK_Booking_Destination_Booking_Plane]
GO
ALTER TABLE [dbo].[Booking_Passenger]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Passenger_Booking_Booking] FOREIGN KEY([Booking_Id])
REFERENCES [dbo].[Booking_Booking] ([Id])
GO
ALTER TABLE [dbo].[Booking_Passenger] CHECK CONSTRAINT [FK_Booking_Passenger_Booking_Booking]
GO
ALTER TABLE [dbo].[Booking_Passenger]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Passenger_Booking_Seat] FOREIGN KEY([Seat_Id])
REFERENCES [dbo].[Booking_Seat] ([Id])
GO
ALTER TABLE [dbo].[Booking_Passenger] CHECK CONSTRAINT [FK_Booking_Passenger_Booking_Seat]
GO
ALTER TABLE [dbo].[Booking_Plane]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Plane_Booking_SeatSchema] FOREIGN KEY([SeatSchema_Id])
REFERENCES [dbo].[Booking_SeatSchema] ([Id])
GO
ALTER TABLE [dbo].[Booking_Plane] CHECK CONSTRAINT [FK_Booking_Plane_Booking_SeatSchema]
GO
ALTER TABLE [dbo].[Booking_Seat]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Seat_Booking_Row] FOREIGN KEY([Row_Id])
REFERENCES [dbo].[Booking_Row] ([Id])
GO
ALTER TABLE [dbo].[Booking_Seat] CHECK CONSTRAINT [FK_Booking_Seat_Booking_Row]
GO
ALTER TABLE [dbo].[Booking_Ticket]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Ticket_Booking_Passenger] FOREIGN KEY([Passenger_Id])
REFERENCES [dbo].[Booking_Passenger] ([Id])
GO
ALTER TABLE [dbo].[Booking_Ticket] CHECK CONSTRAINT [FK_Booking_Ticket_Booking_Passenger]
GO
