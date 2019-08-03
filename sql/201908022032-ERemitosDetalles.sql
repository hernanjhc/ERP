use Ventas
go

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ERemitosDetalles_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ERemitosDetalles] DROP CONSTRAINT [FK_ERemitosDetalles_Empresas];
GO
IF OBJECT_ID(N'[dbo].[FK_ERemitosDetalles_Remitos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ERemitosDetalles] DROP CONSTRAINT [FK_ERemitosDetalles_Remitos];
GO
IF OBJECT_ID(N'[dbo].[FK_ERemitosDetalles_Articulos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ERemitosDetalles] DROP CONSTRAINT [FK_ERemitosDetalles_Articulos];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ERemitosDetalles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ERemitosDetalles];
GO
CREATE TABLE  ERemitosDetalles  (
	Id  int NOT NULL,
	IdEmpresa  int NOT NULL,
	IdRemito  int NULL,
	IdArticulo  int NULL,
	Cantidad  int NULL	
)

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ERemitosDetalles'
ALTER TABLE [dbo].[ERemitosDetalles]
ADD CONSTRAINT [PK_ERemitosDetalles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'ERemitosDetalles'
ALTER TABLE [dbo].[ERemitosDetalles]
ADD CONSTRAINT [FK_ERemitosDetalles_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdRemito] in table 'ERemitosDetalles'
ALTER TABLE [dbo].[ERemitosDetalles]
ADD CONSTRAINT [FK_ERemitosDetalles_Remitos]
    FOREIGN KEY ([IdRemito])
    REFERENCES [dbo].[ERemitos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdArticulo] in table 'ERemitosDetalles'
ALTER TABLE [dbo].[ERemitosDetalles]
ADD CONSTRAINT [FK_ERemitosDetalles_Articulos]
    FOREIGN KEY ([IdArticulo])
    REFERENCES [dbo].[EArticulos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO