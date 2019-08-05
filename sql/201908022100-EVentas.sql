use Ventas
go

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EVentas_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EVentas] DROP CONSTRAINT [FK_EVentas_Empresas];
GO
IF OBJECT_ID(N'[dbo].[FK_EVentas_Clientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EVentas] DROP CONSTRAINT [FK_EVentas_Clientes];
GO
IF OBJECT_ID(N'[dbo].[FK_EVentas_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EVentas] DROP CONSTRAINT [FK_EVentas_Usuarios];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EVentas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EVentas];
GO
CREATE TABLE  EVentas  (
	Id  int NOT NULL,
	IdEmpresa  int NOT NULL,
	IdCliente  int NULL,
	Fecha datetime null,	
	Importe  numeric(17,2) NULL,
	Descuento  numeric(17,2) NULL,
	DescuentoPorc  numeric(5,2) NULL,
	ImporteTotal  numeric(17,2) NULL,
	PrecioLista  int NULL,
	IdUsuario  int NULL,
	Estado  int DEFAULT NULL
)

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EVentas'
ALTER TABLE [dbo].EVentas
ADD CONSTRAINT [PK_EVentas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'EVentas'
ALTER TABLE [dbo].[EVentas]
ADD CONSTRAINT [FK_EVentas_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCliente] in table 'EVentas'
ALTER TABLE [dbo].[EVentas]
ADD CONSTRAINT [FK_EVentas_Clientes]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUsuario] in table 'EVentas'
ALTER TABLE [dbo].[EVentas]
ADD CONSTRAINT [FK_EVentas_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO