use Ventas
go

drop table EArticulos
go

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
	Codigo  varchar(50) NOT NULL,
	CodBarra  varchar(50) NOT NULL,
	Descripcion  varchar(50) NOT NULL,
	IdMarca  int NULL,
	IdRubro  int NULL,
	IdProveedor  int  NULL,
	IdUnidad  int  NULL,

	CostoInicial  numeric(17,2) NULL,
	Descuento1  numeric(17,2) NULL,
	DescuentoPorc1 numeric(3,2) null,
	Descuento2  numeric(17,2) NULL,
	DescuentoPorc2 numeric(3,2) null,
	Descuento3  numeric(17,2) NULL,
	DescuentoPorc3 numeric(3,2) null,
	Costo  numeric(17,2) NOT NULL,

	Stock  numeric(17,2) DEFAULT NULL,
	StockMinimo  numeric(17,2) NOT NULL,

	PrecioL1  numeric(17,2) DEFAULT NULL,
	PrecioPorcL1 numeric(3,2) null,
	PrecioL2  numeric(17,2) DEFAULT NULL,
	PrecioPorcL2 numeric(3,2) null,
	PrecioL3  numeric(17,2) DEFAULT NULL,
	PrecioPorcL3 numeric(3,2) null,
	IVA numeric(3,2) null,

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
