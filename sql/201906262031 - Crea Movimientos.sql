use Ventas
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EMovimientos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EMovimientos];
GO

-- Creating table 'EMovimientos'
CREATE TABLE [dbo].[EMovimientos] (
    [Id] int  NOT NULL,
	[IdEmpresa] int NULL,
    [Fecha] datetime NULL,
	[idVenta] int NULL,
    [idCompra] int NULL,
	[idNotaCredito] int  NULL,
	[idNotaDebito] int  NULL,
	[idCheque] int  NULL,
	[idCuenta] int  NULL,
	[Detalle] varchar(255)  NULL,
	[Credito] numeric(17,2) NULL,
	[Debito] numeric(17,2) NULL,
	[Saldo] numeric(17,2) NULL,
	[Contrasiento] char(1) NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Proveedores'
ALTER TABLE [dbo].[EMovimientos]
ADD CONSTRAINT [PK_EMovimientos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

