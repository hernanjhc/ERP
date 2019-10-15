use Ventas
go

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EComprasDetalles_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EComprasDetalles] DROP CONSTRAINT [FK_EComprasDetalles_Empresas];
GO
IF OBJECT_ID(N'[dbo].[FK_EComprasDetalles_Compras]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EComprasDetalles] DROP CONSTRAINT [FK_EComprasDetalles_Compras];
GO
IF OBJECT_ID(N'[dbo].[FK_EComprasDetalles_Articulos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EComprasDetalles] DROP CONSTRAINT [FK_EComprasDetalles_Articulos];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EComprasDetalles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EComprasDetalles];
GO
CREATE TABLE  EComprasDetalles  (
	Id  int NOT NULL,
	IdEmpresa  int NOT NULL,
	IdCompra  int NULL,
	IdArticulo  int NULL,
	Importe  numeric(17,2) NULL,
	Cantidad  int NULL,
	Precio  numeric(17,2) NULL
)

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EComprasDetalles'
ALTER TABLE [dbo].[EComprasDetalles]
ADD CONSTRAINT [PK_EComprasDetalles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'EComprasDetalles'
ALTER TABLE [dbo].[EComprasDetalles]
ADD CONSTRAINT [FK_EComprasDetalles_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdCompra] in table 'EComprasDetalles'
ALTER TABLE [dbo].[EComprasDetalles]
ADD CONSTRAINT [FK_EComprasDetalles_Compras]
    FOREIGN KEY ([IdCompra])
    REFERENCES [dbo].[ECompras]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdArticulo] in table 'EComprasDetalles'
ALTER TABLE [dbo].[EComprasDetalles]
ADD CONSTRAINT [FK_EComprasDetalles_Articulos]
    FOREIGN KEY ([IdArticulo])
    REFERENCES [dbo].[EArticulos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO