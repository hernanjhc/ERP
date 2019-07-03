-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Empresas_Domicilios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empresas] DROP CONSTRAINT [FK_Empresas_Domicilios];
GO
IF OBJECT_ID(N'[dbo].[FK_Empresas_TiposDocumento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empresas] DROP CONSTRAINT [FK_Empresas_TiposDocumento];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Empresas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empresas];
GO

CREATE TABLE  Empresas  (
   Id  int NOT NULL,
   RazonSocial  varchar(100) NOT NULL,
   IdTipoDoc  int NOT NULL,
   NroDoc  decimal(17,0) NOT NULL,
   IdDomicilio		int DEFAULT NULL,
   Direccion  varchar(100) DEFAULT NULL,
   Email  varchar(100) DEFAULT NULL,
   Telefono  varchar(100) DEFAULT NULL,
   Presupuesto  int NOT NULL DEFAULT '0',
   Venta		int NOT NULL DEFAULT '0',
   Remito		int NOT NULL DEFAULT '0',
   NotaDebito	int NOT NULL DEFAULT '0',
   NotaCredito  int NOT NULL DEFAULT '0',
   Compra		int NOT NULL DEFAULT '0'
) 

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [PK_Empresas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdDomicilio] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [FK_Empresas_Domicilios]
    FOREIGN KEY ([IdDomicilio])
    REFERENCES [dbo].[Domicilios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdTipoDoc] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [FK_Empresas_TiposDocumento]
    FOREIGN KEY ([IdTipoDoc])
    REFERENCES [dbo].[TiposDocumento]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EMarcas_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EMarcas] DROP CONSTRAINT [FK_EMarcas_Empresas];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EMarcas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EMarcas];
GO
CREATE TABLE  EMarcas  (
   Id				int NOT NULL,
   IdEmpresa		int NOT NULL,
   Marca			varchar(45)   NULL,
   Observaciones	varchar(100)  NULL
)

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EMarcas'
ALTER TABLE [dbo].[EMarcas]
ADD CONSTRAINT [PK_EMarcas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO


-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'EMarcas'
ALTER TABLE [dbo].[EMarcas]
ADD CONSTRAINT [FK_EMarcas_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO





-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ERubros_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ERubros] DROP CONSTRAINT [FK_ERubros_Empresas];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ERubros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ERubros];
GO
CREATE TABLE  ERubros  (
   Id				int NOT NULL,
   IdEmpresa		int  NULL,
   Rubro			varchar(50)  NULL,
   Observaciones	varchar(100)  NULL,
   Estado			int  NULL
)


-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ERubros'
ALTER TABLE [dbo].[ERubros]
ADD CONSTRAINT [PK_ERubros]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO


-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'ERubros'
ALTER TABLE [dbo].[ERubros]
ADD CONSTRAINT [FK_ERubros_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

--asd


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Unidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Unidades];
GO
CREATE TABLE  Unidades  (
   Id				int NOT NULL,
   Unidad			varchar(30) NULL,
   Observaciones	varchar(100) NULL,
   Estado			int NULL
)

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Unidades'
ALTER TABLE [dbo].[Unidades]
ADD CONSTRAINT [PK_Unidades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EArticulos_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EArticulos] DROP CONSTRAINT [FK_EArticulos_Empresas];
GO
IF OBJECT_ID(N'[dbo].[FK_EArticulos_Marcas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EArticulos] DROP CONSTRAINT [FK_EArticulos_Marcas];
GO
IF OBJECT_ID(N'[dbo].[FK_EArticulos_Rubros]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EArticulos] DROP CONSTRAINT [FK_EArticulos_Rubros];
GO
IF OBJECT_ID(N'[dbo].[FK_EArticulos_Proveedores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EArticulos] DROP CONSTRAINT [FK_EArticulos_Proveedores];
GO
IF OBJECT_ID(N'[dbo].[FK_EArticulos_Unidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EArticulos] DROP CONSTRAINT [FK_EArticulos_Unidades];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EArticulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EArticulos];
GO

CREATE TABLE  EArticulos  (
	Id  int NOT NULL,
	IdEmpresa  int NOT NULL,
	CodBarra  varchar(50) NOT NULL,
	Descripcion  varchar(50) NOT NULL,
	IdMarca  int NULL,
	IdRubro  int NULL,
	IdProveedor  int  NULL,
	IdUnidad  int  NULL,
	CostoInicial  decimal(17,2) NOT NULL,
	CostoAdicional1  decimal(17,2) NOT NULL,
	CostoAdicional2  decimal(17,2) NOT NULL,
	Costo  decimal(17,2) NOT NULL,
	Stock  int DEFAULT NULL,
	StockMinimo  int NOT NULL,
	PrecioL1  decimal(17,2) DEFAULT NULL,
	PrecioL2  decimal(17,2) DEFAULT NULL,
	PrecioL3  decimal(17,2) DEFAULT NULL,
	Observaciones  varchar(100) DEFAULT NULL,
	Estado  int DEFAULT NULL
) 

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EArticulos'
ALTER TABLE [dbo].[EArticulos]
ADD CONSTRAINT [PK_EArticulos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'EArticulos'
ALTER TABLE [dbo].[EArticulos]
ADD CONSTRAINT [FK_EArticulos_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdMarca] in table 'EArticulos'
ALTER TABLE [dbo].[EArticulos]
ADD CONSTRAINT [FK_EArticulos_Marcas]
    FOREIGN KEY ([IdMarca])
    REFERENCES [dbo].[EMarcas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdRubro] in table 'EArticulos'
ALTER TABLE [dbo].[EArticulos]
ADD CONSTRAINT [FK_EArticulos_Rubros]
    FOREIGN KEY ([IdRubro])
    REFERENCES [dbo].[ERubros]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdProveedor] in table 'EArticulos'
ALTER TABLE [dbo].[EArticulos]
ADD CONSTRAINT [FK_EArticulos_Proveedores]
    FOREIGN KEY ([IdProveedor])
    REFERENCES [dbo].[Proveedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUnidad] in table 'EArticulos'
ALTER TABLE [dbo].[EArticulos]
ADD CONSTRAINT [FK_EArticulos_Unidades]
    FOREIGN KEY ([IdUnidad])
    REFERENCES [dbo].[Unidades]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO
