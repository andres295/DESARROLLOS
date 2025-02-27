USE [master]
GO
/****** Object:  Database [INVENTARIOSFARCOSA]    Script Date: 11/11/2023 15:22:39 ******/
CREATE DATABASE [INVENTARIOSFARCOSA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'INVENTARIOSFARCOSA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\INVENTARIOSFARCOSA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'INVENTARIOSFARCOSA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\INVENTARIOSFARCOSA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [INVENTARIOSFARCOSA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET ARITHABORT OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET  MULTI_USER 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET QUERY_STORE = OFF
GO
USE [INVENTARIOSFARCOSA]
GO
/****** Object:  User [IIS APPPOOL\DefaultAppPool]    Script Date: 11/11/2023 15:22:40 ******/
CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool] WITH DEFAULT_SCHEMA=[IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_owner] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_datareader] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [IIS APPPOOL\DefaultAppPool]
GO
/****** Object:  Table [dbo].[inventa]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lote] [varchar](20) NULL,
	[fecha] [date] NULL,
	[codigo] [varchar](20) NOT NULL,
	[descripcion] [varchar](60) NOT NULL,
	[bodega] [varchar](10) NOT NULL,
	[cantidad] [numeric](14, 4) NOT NULL,
	[nCont1] [numeric](14, 4) NOT NULL,
	[nCont2] [numeric](14, 4) NOT NULL,
	[nCont3] [numeric](14, 4) NOT NULL,
	[precio] [money] NULL,
	[costo] [numeric](15, 4) NULL,
	[validado] [tinyint] NOT NULL,
	[sistema] [numeric](14, 4) NULL,
	[referencia] [varchar](100) NULL,
	[g1] [varchar](100) NOT NULL,
	[g2] [varchar](100) NOT NULL,
	[g3] [varchar](100) NOT NULL,
	[nv] [numeric](14, 4) NOT NULL,
	[vpc] [varchar](100) NOT NULL,
	[lv] [bit] NOT NULL,
	[Proveedor] [varchar](100) NULL,
	[Tipo] [varchar](50) NULL,
	[Ubicacion] [varchar](20) NULL,
	[UM] [varchar](10) NULL,
	[Rack] [varchar](8) NULL,
	[nCont4] [numeric](14, 4) NULL,
	[nCont5] [numeric](14, 4) NULL,
	[nCont6] [numeric](14, 4) NULL,
	[nCont7] [numeric](14, 4) NULL,
	[nCont8] [numeric](14, 4) NULL,
	[nCont9] [numeric](14, 4) NULL,
	[g4] [varchar](100) NULL,
	[g5] [varchar](100) NULL,
	[g6] [varchar](100) NULL,
	[g7] [varchar](100) NULL,
	[g8] [varchar](100) NULL,
	[g9] [varchar](100) NULL,
	[User1] [varchar](100) NULL,
	[User2] [varchar](100) NULL,
	[User3] [varchar](100) NULL,
	[User4] [varchar](100) NULL,
	[User5] [varchar](100) NULL,
	[User6] [varchar](100) NULL,
	[User7] [varchar](100) NULL,
	[User8] [varchar](100) NULL,
	[User9] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Conteos]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Conteos]
AS
SELECT codigo AS Articulo, descripcion, bodega, lote, fecha AS [Fecha de vencimiento], Rack, Ubicacion, cantidad, nCont1 AS Conteo1, nCont2 AS Conteo2, nCont3 AS Verificacion, Proveedor, Tipo, UM, nCont4, nCont5, nCont6, nCont7, nCont8, 
                  nCont9
FROM     dbo.inventa
GO
/****** Object:  View [dbo].[ConteosConsumo]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ConteosConsumo]
AS
SELECT codigo, descripcion AS Descripción, bodega, lote, fecha AS FechaVence, cantidad, nCont1 AS Conteo1, nCont2 AS Conteo2, nCont3 AS Conteo3, nCont4 AS Conteo4, nCont5 AS Conteo5, nCont6 AS Conteo6, nCont7 AS Conteo7, 
                  nCont8 AS Conteo8, nCont9 AS Conteo9, User1 AS Usuario1, User2 AS Usuario2, User3 AS Usuario3, User4 AS Usuario4, User5 AS Usuario5, User6 AS Usuario6, User7 AS Usuario7, User8 AS Usuario8, User9 AS Usuario9, Proveedor, Tipo, 
                  Rack, Ubicacion, UM
FROM     dbo.inventa
GO
/****** Object:  Table [dbo].[ARTICULO]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ARTICULO](
	[ARTICULO] [varchar](20) NOT NULL,
	[DESCRIPCION] [varchar](254) NOT NULL,
	[PROVEEDOR] [varchar](100) NULL,
	[TIPO] [varchar](50) NULL,
	[UM] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ARTICULO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UBICACIONES]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UBICACIONES](
	[ARTICULO] [varchar](50) NULL,
	[UBICACION] [varchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__cantida__34E8D562]  DEFAULT ((0.00)) FOR [cantidad]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__nCont1__35DCF99B]  DEFAULT ((0)) FOR [nCont1]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__nCont2__36D11DD4]  DEFAULT ((0)) FOR [nCont2]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__nCont3__37C5420D]  DEFAULT ((0)) FOR [nCont3]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__precio__38B96646]  DEFAULT ((0.00)) FOR [precio]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__costo__39AD8A7F]  DEFAULT ((0.0)) FOR [costo]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__validad__3AA1AEB8]  DEFAULT ((0)) FOR [validado]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__sistema__3B95D2F1]  DEFAULT ((0)) FOR [sistema]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__referen__3C89F72A]  DEFAULT ('') FOR [referencia]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF_inventa_g1]  DEFAULT ('') FOR [g1]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF_inventa_g2]  DEFAULT ('') FOR [g2]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF_inventa_g3]  DEFAULT ('') FOR [g3]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF_inventa_nv]  DEFAULT ((0)) FOR [nv]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF_inventa_vpc]  DEFAULT ('') FOR [vpc]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF_inventa_lv]  DEFAULT ((0)) FOR [lv]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__nCont4__36D11DD4]  DEFAULT ((0)) FOR [nCont4]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__nCont5__36D11DD4]  DEFAULT ((0)) FOR [nCont5]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__nCont6__36D11DD4]  DEFAULT ((0)) FOR [nCont6]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__nCont7__36D11DD4]  DEFAULT ((0)) FOR [nCont7]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__nCont8__36D11DD4]  DEFAULT ((0)) FOR [nCont8]
GO
ALTER TABLE [dbo].[inventa] ADD  CONSTRAINT [DF__inventa__nCont9__36D11DD4]  DEFAULT ((0)) FOR [nCont9]
GO
/****** Object:  StoredProcedure [dbo].[agregarinventa_conteo]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarinventa_conteo]
       @pConteo integer=0,
       @plote varchar(20),
       @pfecha DATE,
       @pbodega varchar(10),
       @pcodigo varchar(20),
       @pdescripcion varchar(60),
       @pcantidad NUMERIC(14,4),
	   @pproveedor varchar(100),
	   @ptipo varchar(50),
	   @pubicacion varchar(20),
	   @prack varchar(8),
	   @pum varchar(10),
	   @user varchar(100)

AS
BEGIN
	if @pConteo<=0 or @pConteo>9
    begin
    	RAISERROR('No ha especificado Conteo a Grabar',16,1)
        return -1
    end
    
	if @pBodega=''
	begin
    	RAISERROR('No ha especificado Bodega....',16,1)
        return -1
	end
	
	IF @pdescripcion=''
	BEGIN
		RAISERROR('Error de grabación, intente de nuevo....',16,1)
        return -1
	END
	
	
	Declare @vpc as varchar(50)
	Declare @vpchora as varchar(100)

	
	Set @vpc = HOST_NAME()
	
	IF @vpc='.NET CF SqlClient'
	BEGIN
		Exec @vpc = GetInfoCliente 0
	END
	
	Set @vpchora = @vpc + ' / ' + Convert(varchar(40),GetDate(),121)
	
	
	/**/


    /*
    Preguntar si el registro existe, para ese lote
    Si existe, actualizarlo, sino 
    ingresarlo
    */
    
    Select codigo FROM inventa WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=FORMAT(@pFecha,'MM/yy') and Ubicacion=@pubicacion and Rack=@prack
    
    IF @@ROWCOUNT <= 0
    BEGIN
     -- Ingresar.  Registro no existe.
    	INSERT INTO INVENTA (LOTE,FECHA,BODEGA,CODIGO,DESCRIPCION, Proveedor,Tipo,Ubicacion,Rack,UM,User1)
        	 VALUES (@plote,@pfecha,@pbodega,@pcodigo,@pdescripcion,@pproveedor,@ptipo,@pubicacion,@prack,@pum,@user)    	
    END
    
    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Registro Solicitado',16,1)
        return -1
    END

    -- 1º Conteo    
    IF @pConteo=1
    BEGIN
    	UPDATE Inventa SET nCont1 = nCont1 + @pcantidad
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=FORMAT(@pFecha,'MM/yy') and Ubicacion=@pubicacion and Rack=@prack

    	UPDATE Inventa SET Cantidad = nCont1
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=FORMAT(@pFecha,'MM/yy') and Ubicacion=@pubicacion and Rack=@prack

	
    	UPDATE Inventa SET g1=@vpchora
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=FORMAT(@pFecha,'MM/yy') and Ubicacion = @pubicacion and Rack=@prack

				UPDATE Inventa SET User1=@user
        	WHERE  codigo=@pcodigo and Bodega=@pBodega and  Ubicacion = @pubicacion and Rack=@prack

		
    END

    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Conteo',16,1)
        return -1
    END

    -- 2º Conteo
    IF @pConteo=2
    BEGIN
    	UPDATE Inventa SET nCont2 = nCont2 + @pcantidad
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

    	UPDATE Inventa SET Cantidad = nCont2
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

		
    	UPDATE Inventa SET g2=@vpchora
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

				UPDATE Inventa SET User2=@user
        	WHERE  codigo=@pcodigo and Bodega=@pBodega and  Ubicacion = @pubicacion and Rack=@prack

		
    END

    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Conteo',16,1)
        return -1
    END

    -- 3º Conteo
    IF @pConteo=3
    BEGIN
    	UPDATE Inventa SET nCont3 = nCont3 + @pcantidad
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

    	UPDATE Inventa SET Cantidad = nCont3
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

		
    	UPDATE Inventa SET g3=@vpchora
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

				UPDATE Inventa SET User3=@user
        	WHERE  codigo=@pcodigo and Bodega=@pBodega and  Ubicacion = @pubicacion and Rack=@prack
		
    END

    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Conteo',16,1)
        return -1
    END


	-- 4º Conteo
    IF @pConteo=4
    BEGIN
    	UPDATE Inventa SET nCont4 = nCont4 + @pcantidad
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

    	UPDATE Inventa SET Cantidad = nCont4
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

		
    	UPDATE Inventa SET g4=@vpchora
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

				UPDATE Inventa SET User4=@user
        	WHERE  codigo=@pcodigo and Bodega=@pBodega and  Ubicacion = @pubicacion and Rack=@prack
		
    END

    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Conteo',16,1)
        return -1
    END

		-- 5º Conteo
    IF @pConteo=5
    BEGIN
    	UPDATE Inventa SET nCont5 = nCont5 + @pcantidad
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

    	UPDATE Inventa SET Cantidad = nCont5
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

	
    	UPDATE Inventa SET g5=@vpchora
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

				UPDATE Inventa SET User5=@user
        	WHERE  codigo=@pcodigo and Bodega=@pBodega and  Ubicacion = @pubicacion and Rack=@prack
		
    END

    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Conteo',16,1)
        return -1
    END

		-- 6º Conteo
    IF @pConteo=6
    BEGIN
    	UPDATE Inventa SET nCont6 = nCont6 + @pcantidad
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

    	UPDATE Inventa SET Cantidad = nCont6
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

		
    	UPDATE Inventa SET g6=@vpchora
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

				UPDATE Inventa SET User6=@user
        	WHERE  codigo=@pcodigo and Bodega=@pBodega and  Ubicacion = @pubicacion and Rack=@prack
		
    END

    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Conteo',16,1)
        return -1
    END

			-- 7º Conteo
    IF @pConteo=7
    BEGIN
    	UPDATE Inventa SET nCont7 = nCont7 + @pcantidad
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

    	UPDATE Inventa SET Cantidad = nCont7
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

		
    	UPDATE Inventa SET g7=@vpchora
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

				UPDATE Inventa SET User7=@user
        	WHERE  codigo=@pcodigo and Bodega=@pBodega and  Ubicacion = @pubicacion and Rack=@prack
		
    END

    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Conteo',16,1)
        return -1
    END

	
		-- 8º Conteo
    IF @pConteo=8
    BEGIN
    	UPDATE Inventa SET nCont8 = nCont8 + @pcantidad
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

    	UPDATE Inventa SET Cantidad = nCont8
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

		
    	UPDATE Inventa SET g8=@vpchora
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

				UPDATE Inventa SET User8=@user
        	WHERE  codigo=@pcodigo and Bodega=@pBodega and  Ubicacion = @pubicacion and Rack=@prack
		
    END

    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Conteo',16,1)
        return -1
    END

			-- 9º Conteo
    IF @pConteo=9
    BEGIN
    	UPDATE Inventa SET nCont9 = nCont9 + @pcantidad
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

    	UPDATE Inventa SET Cantidad = nCont9
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

		
    	UPDATE Inventa SET g9=@vpchora
        	WHERE lote=@plote and codigo=@pcodigo and Bodega=@pBodega and Fecha=CONVERT(date,@pFecha,103) and Ubicacion=@pubicacion and Rack=@prack

				UPDATE Inventa SET User9=@user
        	WHERE  codigo=@pcodigo and Bodega=@pBodega and  Ubicacion = @pubicacion and Rack=@prack
		
    END

    IF @@ERROR>0
    BEGIN
    	RAISERROR('Imposible Agregar Conteo',16,1)
        return -1
    END



END
GO
/****** Object:  StoredProcedure [dbo].[BuscarArticulos]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarArticulos]
@busqueda varchar(20)
AS
SELECT ARTICULO AS Articulo, DESCRIPCION AS Descripcion, PROVEEDOR AS Proveedor, TIPO AS Tipo, UM AS Um
FROM ARTICULO 
--where ARTICULO like '%' + @busqueda + '%' --Or DESCRIPCION like '%' + @busqueda + '%'
WHERE ARTICULO = @busqueda
order by DESCRIPCION asc
GO
/****** Object:  StoredProcedure [dbo].[BuscarUbicacion]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BuscarUbicacion]
@Codigo varchar(50)
AS
BEGIN
	SELECT UBICACION as Ubicacion FROM UBICACIONES WHERE ARTICULO=@Codigo GROUP BY UBICACION
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTAR_UBICACION]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LISTAR_UBICACION]
AS
SELECT UBICACION AS Ubicacion
FROM UBICACIONES 
GO
/****** Object:  StoredProcedure [dbo].[usp_listar_art]    Script Date: 11/11/2023 15:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_listar_art]
as
begin
SELECT ARTICULO AS Articulo, DESCRIPCION AS Descripcion, PROVEEDOR,TIPO,UM  FROM ARTICULO
end
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[29] 4[3] 2[21] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "inventa"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 335
               Right = 326
            End
            DisplayFlags = 280
            TopColumn = 21
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 16
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1152
         Width = 1200
         Width = 2496
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Conteos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Conteos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[55] 4[3] 2[23] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "inventa"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 30
         Width = 284
         Width = 1200
         Width = 2136
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 4440
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ConteosConsumo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ConteosConsumo'
GO
USE [master]
GO
ALTER DATABASE [INVENTARIOSFARCOSA] SET  READ_WRITE 
GO
