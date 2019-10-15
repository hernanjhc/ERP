use Ventas
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ECuentas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ECuentas];
GO

-- Creating table 'ECuentas'
CREATE TABLE [dbo].[ECuentas] (
    [Id] int  NOT NULL,
	[IdEmpresa] int NULL,
    [Tipo] int NULL,
	[Fecha] datetime NULL,
	[idReferencia] int NULL,
	[SaldoInicial] numeric(17,2) NULL,
	[Estado] int NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Proveedores'
ALTER TABLE [dbo].[ECuentas]
ADD CONSTRAINT [PK_ECuentas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

