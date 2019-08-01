use Ventas
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bancos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bancos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------
-- Creating table 'Bancos'
CREATE TABLE [dbo].[Bancos] (
    [Id] int  NOT NULL,
    [Nombre] varchar(50)  NOT NULL
);
GO


-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Bancos'
ALTER TABLE [dbo].[Bancos]
ADD CONSTRAINT [PK_Bancos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO