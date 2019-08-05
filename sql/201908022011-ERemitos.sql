use Ventas
go

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ERemitos_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ERemitos] DROP CONSTRAINT [FK_ERemitos_Empresas];
GO
IF OBJECT_ID(N'[dbo].[FK_ERemitos_Clientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ERemitos] DROP CONSTRAINT [FK_ERemitos_Clientes];
GO
IF OBJECT_ID(N'[dbo].[FK_ERemitos_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ERemitos] DROP CONSTRAINT [FK_ERemitos_Usuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_ERemitos_Ventas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EVentas] DROP CONSTRAINT [FK_ERemitos_EVentas];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ERemitos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ERemitos];
GO
CREATE TABLE  ERemitos  (
	Id  int NOT NULL,
	IdEmpresa  int NOT NULL,
	IdCliente  int NULL,
	Fecha datetime null,
	IdVenta  int NOT NULL,
	EntregaNombre  varchar(200) NULL,
	RecibeNombre  varchar(200) NULL,
	RecibeTipoDocumento  int NULL,
	RecibeNroDocumento  decimal(18,2) NULL,
	IdUsuario  int NULL,
	Estado  int DEFAULT NULL
)

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EArticulos'
ALTER TABLE [dbo].[ERemitos]
ADD CONSTRAINT [PK_ERemitos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'ERemitos'
ALTER TABLE [dbo].[ERemitos]
ADD CONSTRAINT [FK_ERemitos_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCliente] in table 'ERemitos'
ALTER TABLE [dbo].[ERemitos]
ADD CONSTRAINT [FK_ERemitos_Clientes]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUsuario] in table 'ERemitos'
ALTER TABLE [dbo].[ERemitos]
ADD CONSTRAINT [FK_ERemitos_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdVenta] in table 'ERemitos'
ALTER TABLE [dbo].[ERemitos]
ADD CONSTRAINT [FK_ERemitos_EVentas]
    FOREIGN KEY ([IdVenta])
    REFERENCES [dbo].[EVentas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO