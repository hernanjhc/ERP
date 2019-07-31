use Ventas
go

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EPresupuestosDetalles_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EPresupuestosDetalles] DROP CONSTRAINT [FK_EPresupuestosDetalles_Empresas];
GO
IF OBJECT_ID(N'[dbo].[FK_EPresupuestosDetalles_Presupuestos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EPresupuestosDetalles] DROP CONSTRAINT [FK_EPresupuestosDetalles_Presupuestos];
GO
IF OBJECT_ID(N'[dbo].[FK_EPresupuestosDetalles_Articulos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EPresupuestosDetalles] DROP CONSTRAINT [FK_EPresupuestosDetalles_Articulos];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EPresupuestosDetalles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EPresupuestosDetalles];
GO
CREATE TABLE  EPresupuestosDetalles  (
	Id  int NOT NULL,
	IdEmpresa  int NOT NULL,
	IdPresupuesto  int NULL,
	IdArticulo  int NULL,
	Importe  numeric(17,2) NULL,
	Cantidad  int NULL,
	Precio  numeric(17,2) NULL
)

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EPresupuestosDetalles'
ALTER TABLE [dbo].[EPresupuestosDetalles]
ADD CONSTRAINT [PK_EPresupuestosDetalles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'EPresupuestosDetalles'
ALTER TABLE [dbo].[EPresupuestosDetalles]
ADD CONSTRAINT [FK_EPresupuestosDetalles_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPresupuesto] in table 'EPresupuestosDetalles'
ALTER TABLE [dbo].[EPresupuestosDetalles]
ADD CONSTRAINT [FK_EPresupuestosDetalles_Presupuestos]
    FOREIGN KEY ([IdPresupuesto])
    REFERENCES [dbo].[EPresupuestos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdArticulo] in table 'EPresupuestosDetalles'
ALTER TABLE [dbo].[EPresupuestosDetalles]
ADD CONSTRAINT [FK_EPresupuestosDetalles_Articulos]
    FOREIGN KEY ([IdArticulo])
    REFERENCES [dbo].[EArticulos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO