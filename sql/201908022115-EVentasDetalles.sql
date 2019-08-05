use Ventas
go

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EVentasDetalles_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EVentasDetalles] DROP CONSTRAINT [FK_EVentasDetalles_Empresas];
GO
IF OBJECT_ID(N'[dbo].[FK_EVentasDetalles_Ventas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EVentasDetalles] DROP CONSTRAINT [FK_EVentasDetalles_Ventas];
GO
IF OBJECT_ID(N'[dbo].[FK_EVentasDetalles_Articulos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EVentasDetalles] DROP CONSTRAINT [FK_EVentasDetalles_Articulos];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EVentasDetalles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EVentasDetalles];
GO
CREATE TABLE  EVentasDetalles  (
	Id  int NOT NULL,
	IdEmpresa  int NOT NULL,
	IdVenta  int NULL,
	IdArticulo  int NULL,
	Importe  numeric(17,2) NULL,
	Cantidad  int NULL,
	Precio  numeric(17,2) NULL
)

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EVentasDetalles'
ALTER TABLE [dbo].[EVentasDetalles]
ADD CONSTRAINT [PK_EVentasDetalles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'EVentasDetalles'
ALTER TABLE [dbo].[EVentasDetalles]
ADD CONSTRAINT [FK_EVentasDetalles_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdVenta] in table 'EVentasDetalles'
ALTER TABLE [dbo].[EVentasDetalles]
ADD CONSTRAINT [FK_EVentasDetalles_Ventas]
    FOREIGN KEY ([IdVenta])
    REFERENCES [dbo].[EVentas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdArticulo] in table 'EVentasDetalles'
ALTER TABLE [dbo].[EVentasDetalles]
ADD CONSTRAINT [FK_EVentasDetalles_Articulos]
    FOREIGN KEY ([IdArticulo])
    REFERENCES [dbo].[EArticulos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO