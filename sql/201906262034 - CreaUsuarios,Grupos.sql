/****** Object:  Table [dbo].[Usuarios]    Script Date: 02/01/2019 11:39:59 a.m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 02/01/2019 11:39:59 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Contraseña] [varchar](255) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[Estado] [tinyint] NOT NULL,
	[FechaBaja] [datetime] NULL,
	[NombreCompleto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Usuarios] TO  SCHEMA OWNER 
GO



IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Grupos]') AND type in (N'U'))
DROP TABLE [dbo].[Grupos]
GO
/****** Object:  Table [dbo].[Grupos]    Script Date: 07/01/2019 10:23:59 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Grupos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Grupos](
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
	[Estado] [tinyint] NOT NULL,
	CONSTRAINT [PK_Grupos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[Grupos] TO  SCHEMA OWNER 
GO





/****** Object:  Table [dbo].[GruposUsuarios]    Script Date: 07/01/2019 23:09:59 p.m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GruposUsuarios]') AND type in (N'U'))
DROP TABLE [dbo].[GruposUsuarios]
GO
/****** Object:  Table [dbo].[GruposUsuarios]    Script Date: 07/01/2019 23:09:59 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GruposUsuarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GruposUsuarios](
	[Id] [int] NOT NULL,
	[IdGrupo] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	CONSTRAINT [PK_GruposUsuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[GruposUsuarios] TO  SCHEMA OWNER 
GO



-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdGrupo] in table 'GruposUsuarios'
ALTER TABLE [dbo].[GruposUsuarios]
ADD CONSTRAINT [FK_GruposUsuarios_Grupos]
    FOREIGN KEY ([IdGrupo])
    REFERENCES [dbo].[Grupos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GruposUsuarios_Grupos'
CREATE INDEX [IX_FK_GruposUsuarios_Grupos]
ON [dbo].[GruposUsuarios]
    ([IdGrupo]);
GO

-- Creating foreign key on [IdUsuario] in table 'GruposUsuarios'
ALTER TABLE [dbo].[GruposUsuarios]
ADD CONSTRAINT [FK_GruposUsuarios_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GruposUsuarios_Grupos'
CREATE INDEX [IX_FK_GruposUsuarios_Usuarios]
ON [dbo].[GruposUsuarios]
    ([IdUsuario]);
GO



/****** Object:  Table [dbo].[ItemsMenu]    Script Date: 07/01/2019 10:23:59 p.m. ******/
--IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemsMenu]') AND type in (N'U'))
--DROP TABLE [dbo].[ItemsMenu]
--GO
/****** Object:  Table [dbo].[ItemsMenu]    Script Date: 07/01/2019 10:23:59 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ItemsMenu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ItemsMenu](
	[Id] [int] NOT NULL,
	[IdPadre] [int] NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	CONSTRAINT [PK_ItemsMenu] PRIMARY KEY CLUSTERED
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[ItemsMenu] TO  SCHEMA OWNER 
GO





/****** Object:  Table [dbo].[GruposItemsMenu]    Script Date: 07/01/2019 23:09:59 p.m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GruposItemsMenu]') AND type in (N'U'))
DROP TABLE [dbo].[GruposItemsMenu]
GO
/****** Object:  Table [dbo].[GruposItemsMenu]    Script Date: 07/01/2019 23:09:59 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GruposItemsMenu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GruposItemsMenu](
	[Id] [int] NOT NULL,
	[IdGrupo] [int] NOT NULL,
	[IdItemMenu] [int] NOT NULL,
	CONSTRAINT [PK_GruposItemsMenus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[GruposItemsMenu] TO  SCHEMA OWNER 
GO



-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdGrupo] in table 'GruposUsuarios'
ALTER TABLE [dbo].[GruposItemsMenu]
ADD CONSTRAINT [FK_GruposItemsMenu_Grupos]
    FOREIGN KEY ([IdGrupo])
    REFERENCES [dbo].[Grupos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GruposUsuarios_Grupos'
CREATE INDEX [IX_FK_GruposItemsMenu_Grupos]
ON [dbo].[GruposItemsMenu]
    ([IdGrupo]);
GO

-- Creating foreign key on [IdUsuario] in table 'GruposUsuarios'
ALTER TABLE [dbo].[GruposItemsMenu]
ADD CONSTRAINT [FK_GruposItemsMenus_ItemsMenu]
    FOREIGN KEY ([IdItemMenu])
    REFERENCES [dbo].[ItemsMenu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GruposUsuarios_Grupos'
CREATE INDEX [IX_FK_GruposItemsMenu_ItemsMenu]
ON [dbo].[GruposItemsMenu]
    ([IdItemMenu]);
GO
----------------


/****** Object:  Table [dbo].[UsuariosItemsMenu]    Script Date: 07/01/2019 23:09:59 p.m. ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsuariosItemsMenu]') AND type in (N'U'))
DROP TABLE [dbo].[UsuariosItemsMenu]
GO
/****** Object:  Table [dbo].[GruposItemsMenu]    Script Date: 07/01/2019 23:09:59 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UsuariosItemsMenu]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UsuariosItemsMenu](
	[Id] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdItemMenu] [int] NOT NULL,
	CONSTRAINT [PK_UsuariosItemsMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[UsuariosItemsMenu] TO  SCHEMA OWNER 
GO



-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdUsuario] in table 'GruposUsuarios'
ALTER TABLE [dbo].[UsuariosItemsMenu]
ADD CONSTRAINT [FK_UsuariosItemsMenu_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GruposUsuarios_Grupos'
CREATE INDEX [IX_FK_UsuariosItemsMenu_Usuarios]
ON [dbo].[UsuariosItemsMenu]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdUsuario] in table 'UsuariosItemsMenu'
ALTER TABLE [dbo].[UsuariosItemsMenu]
ADD CONSTRAINT [FK_UsuariosItemsMenu_ItemsMenu]
    FOREIGN KEY ([IdItemMenu])
    REFERENCES [dbo].[ItemsMenu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosItemsMenu_Grupos'
CREATE INDEX [IX_FK_UsuariosItemsMenu_ItemsMenu]
ON [dbo].[UsuariosItemsMenu]
    ([IdItemMenu]);
GO
