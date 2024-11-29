USE [master]
GO
/****** Object:  Database [TPDataBase]    Script Date: 26/11/2024 18:08:12 ******/
CREATE DATABASE [TPDataBase]
GO
USE [TPDataBase] 
GO
ALTER DATABASE [TPDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TPDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TPDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TPDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TPDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [TPDataBase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TPDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TPDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TPDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TPDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TPDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TPDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TPDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TPDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TPDataBase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TPDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TPDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TPDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TPDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TPDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TPDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TPDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TPDataBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TPDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [TPDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TPDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TPDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TPDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TPDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TPDataBase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TPDataBase] SET QUERY_STORE = ON
GO
ALTER DATABASE [TPDataBase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TPDataBase]
GO
/****** Object:  Table [dbo].[CLASE]    Script Date: 26/11/2024 18:08:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLASE](
	[ID_CLASE] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION] [varchar](50) NOT NULL,
	[DIA_CLASE] [varchar](50) NOT NULL,
	[HORARIO] [varchar](50) NOT NULL,
	[ENTRENADOR] [varchar](50) NOT NULL,
	[CAPACIDAD_MAXIMA] [int] NOT NULL,
 CONSTRAINT [PK_CLASE] PRIMARY KEY CLUSTERED 
(
	[ID_CLASE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLASE_MIEMBRO]    Script Date: 26/11/2024 18:08:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLASE_MIEMBRO](
	[ID_CLASE] [int] NOT NULL,
	[ID_MIEMBRO] [int] NOT NULL,
	[FECHA_INSCRIPCION] [date] NOT NULL,
	[FECHA_VENCIMIENTO] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEMBRESIA]    Script Date: 26/11/2024 18:08:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEMBRESIA](
	[ID_MEMBRESIA] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION] [varchar](50) NOT NULL,
	[PRECIO] [decimal](12, 2) NOT NULL,
	[DURACION_DIAS] [int] NOT NULL,
 CONSTRAINT [PK_MEMBRESIA] PRIMARY KEY CLUSTERED 
(
	[ID_MEMBRESIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MIEMBRO]    Script Date: 26/11/2024 18:08:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MIEMBRO](
	[ID_MIEMBRO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE_APELLIDO] [varchar](50) NOT NULL,
	[FECHA_NACIMIENTO] [date] NOT NULL,
	[CORREO_ELEC] [varchar](50) NOT NULL,
	[ID_MEMBRESIA] [int] NOT NULL,
 CONSTRAINT [PK_MIEMBRO] PRIMARY KEY CLUSTERED 
(
	[ID_MIEMBRO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MEMBRESIA] ON 

INSERT [dbo].[MEMBRESIA] ([ID_MEMBRESIA], [DESCRIPCION], [PRECIO], [DURACION_DIAS]) VALUES (1, N'Mensual', CAST(1500.00 AS Decimal(12, 2)), 30)
INSERT [dbo].[MEMBRESIA] ([ID_MEMBRESIA], [DESCRIPCION], [PRECIO], [DURACION_DIAS]) VALUES (2, N'Trimestral', CAST(4500.00 AS Decimal(12, 2)), 90)
INSERT [dbo].[MEMBRESIA] ([ID_MEMBRESIA], [DESCRIPCION], [PRECIO], [DURACION_DIAS]) VALUES (3, N'Anual', CAST(18000.00 AS Decimal(12, 2)), 360)
SET IDENTITY_INSERT [dbo].[MEMBRESIA] OFF
GO
ALTER TABLE [dbo].[CLASE_MIEMBRO]  WITH CHECK ADD  CONSTRAINT [FK_CLASE_MIEMBRO_CLASE] FOREIGN KEY([ID_CLASE])
REFERENCES [dbo].[CLASE] ([ID_CLASE])
GO
ALTER TABLE [dbo].[CLASE_MIEMBRO] CHECK CONSTRAINT [FK_CLASE_MIEMBRO_CLASE]
GO
ALTER TABLE [dbo].[CLASE_MIEMBRO]  WITH CHECK ADD  CONSTRAINT [FK_CLASE_MIEMBRO_MIEMBRO] FOREIGN KEY([ID_MIEMBRO])
REFERENCES [dbo].[MIEMBRO] ([ID_MIEMBRO])
GO
ALTER TABLE [dbo].[CLASE_MIEMBRO] CHECK CONSTRAINT [FK_CLASE_MIEMBRO_MIEMBRO]
GO
ALTER TABLE [dbo].[MIEMBRO]  WITH CHECK ADD  CONSTRAINT [FK_MIEMBRO_MEMBRESIA] FOREIGN KEY([ID_MEMBRESIA])
REFERENCES [dbo].[MEMBRESIA] ([ID_MEMBRESIA])
GO
ALTER TABLE [dbo].[MIEMBRO] CHECK CONSTRAINT [FK_MIEMBRO_MEMBRESIA]
GO
USE [master]
GO
ALTER DATABASE [TPDataBase] SET  READ_WRITE 
GO
