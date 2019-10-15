use ventas
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EMovimStock]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EMovimStock];
GO

-- Creating table 'EMovimStock'
CREATE TABLE [dbo].[EMovimStock] (
    [Id] int  NOT NULL,
	[IdEmpresa] int NULL,
    [Fecha] datetime NULL,
	[idArticulo] int NULL,
    [idProveedorOrigen] int NULL,
	[idClienteOrigen] int  NULL,
	[idDepositoOrigen] int  NULL,
	[idProveedorDestino] int NULL,
	[idClienteDestino] int  NULL,
	[idDepositoDestino] int  NULL,
	[Ingreo] numeric(17,2) NULL,
	[Egreso] numeric(17,2) NULL,
	[Stock] numeric(17,2) NULL,
	[Usuario] int NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Proveedores'
ALTER TABLE [dbo].[EMovimStock]
ADD CONSTRAINT [PK_EMovimStock]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

