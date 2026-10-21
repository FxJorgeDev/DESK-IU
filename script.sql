USE [master]
GO
/****** Objeto: Database [SoporteTecnicoDB] Fecha de script: 04/07/2026 13:13:23 ******/
CREATE DATABASE [SoporteTecnicoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SoporteTecnicoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\SoporteTecnicoDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SoporteTecnicoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL17.MSSQLSERVER\MSSQL\DATA\SoporteTecnicoDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SoporteTecnicoDB] SET COMPATIBILITY_LEVEL = 170
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SoporteTecnicoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SoporteTecnicoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SoporteTecnicoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SoporteTecnicoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SoporteTecnicoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SoporteTecnicoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET RECOVERY FULL 
GO
ALTER DATABASE [SoporteTecnicoDB] SET  MULTI_USER 
GO
ALTER DATABASE [SoporteTecnicoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SoporteTecnicoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SoporteTecnicoDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SoporteTecnicoDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SoporteTecnicoDB] SET OPTIMIZED_LOCKING = OFF 
GO
ALTER DATABASE [SoporteTecnicoDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SoporteTecnicoDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [SoporteTecnicoDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SoporteTecnicoDB]
GO
/****** Objeto: Table [dbo].[CATEGORIA] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](200) NULL,
	[Activo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[CreadoPor] [varchar](100) NOT NULL,
	[ModificadoPor] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[REPORTE] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REPORTE](
	[IdReporte] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[TipoReporte] [varchar](50) NOT NULL,
	[Parametros] [text] NULL,
	[FechaGeneracion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[SEGUIMIENTO] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SEGUIMIENTO](
	[IdSeguimiento] [int] IDENTITY(1,1) NOT NULL,
	[IdSolicitud] [int] NOT NULL,
	[IdTecnico] [int] NOT NULL,
	[EstadoAnterior] [varchar](20) NOT NULL,
	[EstadoNuevo] [varchar](20) NOT NULL,
	[Comentario] [text] NULL,
	[FechaCambio] [datetime] NOT NULL,
	[CreadoPor] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSeguimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[SOLICITUD] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SOLICITUD](
	[IdSolicitud] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdTecnico] [int] NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[Titulo] [varchar](100) NOT NULL,
	[Descripcion] [text] NOT NULL,
	[Estado] [varchar](20) NOT NULL,
	[Prioridad] [varchar](10) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[FechaResolucion] [datetime] NULL,
	[Observacion] [text] NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[CreadoPor] [varchar](100) NOT NULL,
	[ModificadoPor] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSolicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[TECNICO] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TECNICO](
	[IdTecnico] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Especialidad] [varchar](30) NOT NULL,
	[Disponibilidad] [varchar](20) NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[CreadoPor] [varchar](100) NOT NULL,
	[ModificadoPor] [varchar](100) NULL,
	[FechaDisponibilidad] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTecnico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Objeto: Table [dbo].[USUARIO] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Celular] [varchar](9) NULL,
	[TipoUsuario] [varchar](20) NOT NULL,
	[Activo] [bit] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[FechaModificacion] [datetime] NULL,
	[CreadoPor] [varchar](100) NOT NULL,
	[ModificadoPor] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CATEGORIA] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[CATEGORIA] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[CATEGORIA] ADD  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[REPORTE] ADD  DEFAULT (getdate()) FOR [FechaGeneracion]
GO
ALTER TABLE [dbo].[SEGUIMIENTO] ADD  DEFAULT (getdate()) FOR [FechaCambio]
GO
ALTER TABLE [dbo].[SEGUIMIENTO] ADD  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[SOLICITUD] ADD  DEFAULT ('Pendiente') FOR [Estado]
GO
ALTER TABLE [dbo].[SOLICITUD] ADD  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[SOLICITUD] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[SOLICITUD] ADD  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[TECNICO] ADD  DEFAULT ('Disponible') FOR [Disponibilidad]
GO
ALTER TABLE [dbo].[TECNICO] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[TECNICO] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[TECNICO] ADD  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT (getdate()) FOR [FechaCreacion]
GO
ALTER TABLE [dbo].[USUARIO] ADD  DEFAULT (suser_sname()) FOR [CreadoPor]
GO
ALTER TABLE [dbo].[REPORTE]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario])
GO
ALTER TABLE [dbo].[SEGUIMIENTO]  WITH CHECK ADD FOREIGN KEY([IdSolicitud])
REFERENCES [dbo].[SOLICITUD] ([IdSolicitud])
GO
ALTER TABLE [dbo].[SEGUIMIENTO]  WITH CHECK ADD FOREIGN KEY([IdTecnico])
REFERENCES [dbo].[TECNICO] ([IdTecnico])
GO
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CATEGORIA] ([IdCategoria])
GO
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD FOREIGN KEY([IdTecnico])
REFERENCES [dbo].[TECNICO] ([IdTecnico])
GO
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario])
GO
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD CHECK  (([Prioridad]='Baja' OR [Prioridad]='Media' OR [Prioridad]='Alta'))
GO
ALTER TABLE [dbo].[SOLICITUD]  WITH CHECK ADD  CONSTRAINT [CK_SOLICITUD_Estado] CHECK  (([Estado]='Resuelto' OR [Estado]='Pendiente'))
GO
ALTER TABLE [dbo].[SOLICITUD] CHECK CONSTRAINT [CK_SOLICITUD_Estado]
GO
ALTER TABLE [dbo].[TECNICO]  WITH CHECK ADD CHECK  (([Disponibilidad]='No Disponible' OR [Disponibilidad]='Ocupado' OR [Disponibilidad]='Disponible'))
GO
ALTER TABLE [dbo].[TECNICO]  WITH CHECK ADD CHECK  (([Especialidad]='Accesos y Red' OR [Especialidad]='Software' OR [Especialidad]='Hardware'))
GO
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD CHECK  (([TipoUsuario]='Administrativo' OR [TipoUsuario]='Docente' OR [TipoUsuario]='Estudiante'))
GO
/****** Objeto: StoredProcedure [dbo].[sp_ActualizarSolicitud] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SP: ACTUALIZAR solicitud (lo que faltaba)
CREATE PROCEDURE [dbo].[sp_ActualizarSolicitud]
    @IdSolicitud INT, @IdTecnico INT, @IdCategoria INT,
    @Titulo VARCHAR(100), @Descripcion TEXT,
    @Estado VARCHAR(20), @Prioridad VARCHAR(10),
    @Observacion TEXT, @ModificadoPor VARCHAR(100)
AS BEGIN
    DECLARE @EstadoAnterior VARCHAR(20);
    SELECT @EstadoAnterior = Estado FROM SOLICITUD WHERE IdSolicitud = @IdSolicitud;

    UPDATE SOLICITUD SET
        IdTecnico         = @IdTecnico,
        IdCategoria       = @IdCategoria,
        Titulo            = @Titulo,
        Descripcion       = @Descripcion,
        Estado            = @Estado,
        Prioridad         = @Prioridad,
        Observacion       = @Observacion,
        FechaResolucion   = CASE WHEN @Estado IN ('Resuelto','Cancelado') THEN GETDATE() ELSE NULL END,
        FechaModificacion = GETDATE(),
        ModificadoPor     = @ModificadoPor
    WHERE IdSolicitud = @IdSolicitud;

    -- Guardar en historial si cambió el estado
    IF @EstadoAnterior <> @Estado
        INSERT INTO SEGUIMIENTO (IdSolicitud,IdTecnico,EstadoAnterior,EstadoNuevo,Comentario,CreadoPor)
        VALUES (@IdSolicitud,@IdTecnico,@EstadoAnterior,@Estado,@Observacion,@ModificadoPor);
END
GO
/****** Objeto: StoredProcedure [dbo].[sp_RegistrarSolicitud] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- SP: Registrar solicitud
CREATE PROCEDURE [dbo].[sp_RegistrarSolicitud]
    @IdUsuario INT, @IdTecnico INT, @IdCategoria INT,
    @Titulo VARCHAR(100), @Descripcion TEXT,
    @Estado VARCHAR(20), @Prioridad VARCHAR(10), @CreadoPor VARCHAR(100)
AS BEGIN
    INSERT INTO SOLICITUD (IdUsuario,IdTecnico,IdCategoria,Titulo,Descripcion,Estado,Prioridad,CreadoPor)
    VALUES (@IdUsuario,@IdTecnico,@IdCategoria,@Titulo,@Descripcion,@Estado,@Prioridad,@CreadoPor);
END
GO
/****** Objeto: StoredProcedure [dbo].[sp_ReportePorTipoUsuario] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SP: Reporte 4 - Solicitudes por tipo de usuario
CREATE PROCEDURE [dbo].[sp_ReportePorTipoUsuario]
    @TipoUsuario VARCHAR(20) = NULL
AS BEGIN
    SELECT u.TipoUsuario,
           COUNT(s.IdSolicitud)                                        AS Total,
           SUM(CASE WHEN s.Estado = 'Resuelto'   THEN 1 ELSE 0 END)   AS Resueltas,
           SUM(CASE WHEN s.Estado = 'Pendiente'  THEN 1 ELSE 0 END)   AS Pendientes,
           SUM(CASE WHEN s.Prioridad = 'Alta'    THEN 1 ELSE 0 END)   AS PrioridadAlta,
           c.Nombre AS CategoriaMasFrecuente
    FROM SOLICITUD s
    JOIN USUARIO   u ON s.IdUsuario   = u.IdUsuario
    JOIN CATEGORIA c ON s.IdCategoria = c.IdCategoria
    WHERE (@TipoUsuario IS NULL OR u.TipoUsuario = @TipoUsuario)
    GROUP BY u.TipoUsuario, c.Nombre
    ORDER BY Total DESC;
END
GO
/****** Objeto: StoredProcedure [dbo].[sp_ReporteRendimientoTecnico] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 3. Actualizar SP sp_ReporteRendimientoTecnico
CREATE PROCEDURE [dbo].[sp_ReporteRendimientoTecnico]
    @FechaInicio DATETIME = NULL,
    @FechaFin    DATETIME = NULL
AS BEGIN
    SELECT t.IdTecnico,
           t.Nombre + ' ' + t.Apellido AS Tecnico,
           t.Especialidad,
           COUNT(s.IdSolicitud)                                          AS TotalAsignadas,
           SUM(CASE WHEN s.Estado = 'Resuelto'    THEN 1 ELSE 0 END)    AS Resueltas,
           SUM(CASE WHEN s.Estado = 'Pendiente'   THEN 1 ELSE 0 END)    AS Pendientes,
           AVG(CASE WHEN s.Estado = 'Resuelto'
               THEN DATEDIFF(HOUR, s.FechaRegistro, s.FechaResolucion)
               ELSE NULL END)                                            AS PromedioHorasResolucion
    FROM TECNICO t
    LEFT JOIN SOLICITUD s ON t.IdTecnico = s.IdTecnico
        AND (@FechaInicio IS NULL OR s.FechaRegistro >= @FechaInicio)
        AND (@FechaFin    IS NULL OR s.FechaRegistro <= @FechaFin)
    GROUP BY t.IdTecnico, t.Nombre, t.Apellido, t.Especialidad
    ORDER BY Resueltas DESC;
END

GO
/****** Objeto: StoredProcedure [dbo].[sp_ReporteSolicitudesPorEstado] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SP: Reporte 1 - Solicitudes por estado y rango de fechas
CREATE PROCEDURE [dbo].[sp_ReporteSolicitudesPorEstado]
    @Estado VARCHAR(20) = NULL,
    @FechaInicio DATETIME = NULL,
    @FechaFin    DATETIME = NULL
AS BEGIN
    SELECT s.IdSolicitud, s.Titulo, s.Estado, s.Prioridad,
           c.Nombre AS Categoria,
           u.Nombre + ' ' + u.Apellido AS Usuario,
           t.Nombre + ' ' + t.Apellido AS Tecnico,
           s.FechaRegistro, s.FechaResolucion,
           DATEDIFF(HOUR, s.FechaRegistro, ISNULL(s.FechaResolucion, GETDATE())) AS HorasAtencion
    FROM SOLICITUD s
    JOIN USUARIO  u ON s.IdUsuario   = u.IdUsuario
    JOIN TECNICO  t ON s.IdTecnico   = t.IdTecnico
    JOIN CATEGORIA c ON s.IdCategoria = c.IdCategoria
    WHERE (@Estado     IS NULL OR s.Estado       = @Estado)
      AND (@FechaInicio IS NULL OR s.FechaRegistro >= @FechaInicio)
      AND (@FechaFin    IS NULL OR s.FechaRegistro <= @FechaFin)
    ORDER BY s.FechaRegistro DESC;
END
GO
/****** Objeto: StoredProcedure [dbo].[sp_ReporteSolicitudesUrgentes] Fecha de script: 04/07/2026 13:13:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 4. Actualizar SP sp_ReporteSolicitudesUrgentes
CREATE PROCEDURE [dbo].[sp_ReporteSolicitudesUrgentes]
AS BEGIN
    SELECT s.IdSolicitud, s.Titulo, s.Prioridad, s.Estado,
           c.Nombre AS Categoria,
           u.Nombre + ' ' + u.Apellido AS Usuario,
           t.Nombre + ' ' + t.Apellido AS Tecnico,
           s.FechaRegistro,
           DATEDIFF(HOUR, s.FechaRegistro, GETDATE()) AS HorasTranscurridas
    FROM SOLICITUD s
    JOIN USUARIO   u ON s.IdUsuario   = u.IdUsuario
    JOIN TECNICO   t ON s.IdTecnico   = t.IdTecnico
    JOIN CATEGORIA c ON s.IdCategoria = c.IdCategoria
    WHERE s.Prioridad = 'Alta'
      AND s.Estado = 'Pendiente'
    ORDER BY s.FechaRegistro ASC;
END

GO
USE [master]
GO
ALTER DATABASE [SoporteTecnicoDB] SET  READ_WRITE 
GO
