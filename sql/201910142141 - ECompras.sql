use Ventas
go

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ECompras_Empresas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ECompras] DROP CONSTRAINT [FK_ECompras_Empresas];
GO
IF OBJECT_ID(N'[dbo].[FK_ECompras_Proveedores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ECompras] DROP CONSTRAINT [FK_ECompras_Proveedores];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ECompras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ECompras];
GO
CREATE TABLE  ECompras  (
	Id  int NOT NULL,
	IdEmpresa  int NOT NULL,
	IdProveedor  int NULL,
	Fecha datetime null,	
	Importe  numeric(17,2) NULL,
	Retirado  int NULL,
	Pagado  int NULL
)

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ECompras'
ALTER TABLE [dbo].ECompras
ADD CONSTRAINT [PK_ECompras]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEmpresa] in table 'ECompras'
ALTER TABLE [dbo].[ECompras]
ADD CONSTRAINT [FK_ECompras_Empresas]
    FOREIGN KEY ([IdEmpresa])
    REFERENCES [dbo].[Empresas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdProveedor] in table 'ECompras'
ALTER TABLE [dbo].[ECompras]
ADD CONSTRAINT [FK_ECompras_Proveedores]
    FOREIGN KEY ([IdProveedor])
    REFERENCES [dbo].[Proveedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO