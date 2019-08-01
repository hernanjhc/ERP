USE Ventas
GO	

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


IF OBJECT_ID(N'[dbo].[FK_Sucursales_Bancos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sucursales] DROP CONSTRAINT [FK_Sucursales_Bancos];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Sucursales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sucursales];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Sucursales'
CREATE TABLE [dbo].[Sucursales] (
    [Id] int  NOT NULL,
	[IdEmpresa] int not null,
    [IdBanco] int  NOT NULL,
    [Sucursal] varchar(100)  NOT NULL,
	[Numero] int  NULL,
	[IdDomicilio] int  NULL,
	[Direccion] varchar(255)  NULL,
    [EMail] varchar(255)  NULL,
    [Telefono] varchar(255)  NULL,
	[Web] varchar(255)  NULL,
    [Estado] tinyint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Sucursales'
ALTER TABLE [dbo].[Sucursales]
ADD CONSTRAINT [PK_Sucursales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdBanco] in table 'Sucursales'
ALTER TABLE [dbo].[Sucursales]
ADD CONSTRAINT [FK_Sucursales_Bancos]
    FOREIGN KEY ([IdBanco])
    REFERENCES [dbo].[Bancos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO