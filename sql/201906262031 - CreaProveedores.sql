IF OBJECT_ID(N'[dbo].[FK_Proveedores_Domicilios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Proveedores_Domicilios];
GO
IF OBJECT_ID(N'[dbo].[FK_Proveedores_TiposDocumento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Proveedores_TiposDocumento];
GO
-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Proveedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proveedores];
GO

-- Creating table 'Proveedores'
CREATE TABLE [dbo].[Proveedores] (
    [Id] int  NOT NULL,
	[IdEmpresa] int  NOT NULL,
    [RazonSocial] varchar(255)  NOT NULL,
    [IdTipoDocumento] int  NOT NULL,
    [NroDocumento] decimal(18,0)  NOT NULL,
    [FechaNacimiento] datetime  NULL,
    [EMail] varchar(255)  NULL,
    [Direccion] varchar(255)  NULL,
	[Telefono] varchar(255)  NULL,
    [Sexo] char(1) NULL,
	[IdDomicilio] int  NULL,
    [Estado] tinyint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [PK_Proveedores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdDomicilio] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [FK_Proveedores_Domicilios]
    FOREIGN KEY ([IdDomicilio])
    REFERENCES [dbo].[Domicilios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proveedores_Domicilios'
CREATE INDEX [IX_FK_Proveedores_Domicilios]
ON [dbo].[Proveedores]
    ([IdDomicilio]);
GO

-- Creating foreign key on [IdTipoDocumento] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [FK_Proveedores_TiposDocumento]
    FOREIGN KEY ([IdTipoDocumento])
    REFERENCES [dbo].[TiposDocumento]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proveedores_TiposDocumento'
CREATE INDEX [IX_FK_Proveedores_TiposDocumento]
ON [dbo].[Proveedores]
    ([IdTipoDocumento]);
GO
