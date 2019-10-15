use ventas
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EDepositos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EDepositos];
GO

-- Creating table 'EDepositos'
CREATE TABLE [dbo].[EDepositos] (
    [Id] int  NOT NULL,
	[IdEmpresa] int NULL,
	[Deposito] varchar(100) null,
	[idProvincia] int NULL,
    [idLocalidad] int NULL,
	[idBarrio] int  NULL,
	[Direccion] varchar(100)  NULL,
	[idEncargado] int NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Proveedores'
ALTER TABLE [dbo].[EDepositos]
ADD CONSTRAINT [PK_EDepositos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

