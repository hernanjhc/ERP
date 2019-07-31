use Ventas
go

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EPresupuestos_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EPresupuestos] DROP CONSTRAINT [FK_EPresupuestos_Empresas];
GO
IF OBJECT_ID(N'[dbo].[FK_EPresupuestos_Clientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EPresupuestos] DROP CONSTRAINT [FK_EPresupuestos_Clientes];
GO
IF OBJECT_ID(N'[dbo].[FK_EPresupuestos_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EPresupuestos] DROP CONSTRAINT [FK_EPresupuestos_Usuarios];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EPresupuestos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EPresupuestos];
GO
CREATE TABLE  EPresupuestos  (
	Id  int NOT NULL,
	IdEmpresa  int NOT NULL,
	IdCliente  int NULL,
	Fecha datetime null,
	DiasValidez  int NULL,
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

-- Creating primary key on [Id] in table 'EArticulos'
ALTER TABLE [dbo].[EPresupuestos]
ADD CONSTRAINT [PK_EPresupuestos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'EPresupuestos'
ALTER TABLE [dbo].[EPresupuestos]
ADD CONSTRAINT [FK_EPresupuestos_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCliente] in table 'EPresupuestos'
ALTER TABLE [dbo].[EPresupuestos]
ADD CONSTRAINT [FK_EPresupuestos_Clientes]
    FOREIGN KEY ([IdCliente])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdUsuario] in table 'EPresupuestos'
ALTER TABLE [dbo].[EPresupuestos]
ADD CONSTRAINT [FK_EPresupuestos_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO