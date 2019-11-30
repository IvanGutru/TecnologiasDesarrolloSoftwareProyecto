
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/30/2019 12:09:06
-- Generated from EDMX file: C:\Users\irvin\Desktop\TecnologiasDesarrolloSoftwareProyecto\Servidor WCF\DAO\SEModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SerpientesEscaleras];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PartidaTablero]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PartidaSet] DROP CONSTRAINT [FK_PartidaTablero];
GO
IF OBJECT_ID(N'[dbo].[FK_TableroCasilla]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CasillaSet] DROP CONSTRAINT [FK_TableroCasilla];
GO
IF OBJECT_ID(N'[dbo].[FK_JugadorCuenta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[JugadorSet] DROP CONSTRAINT [FK_JugadorCuenta];
GO
IF OBJECT_ID(N'[dbo].[FK_PuntuacionJugador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PuntuacionSet] DROP CONSTRAINT [FK_PuntuacionJugador];
GO
IF OBJECT_ID(N'[dbo].[FK_PartidaPuntuacion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PuntuacionSet] DROP CONSTRAINT [FK_PartidaPuntuacion];
GO
IF OBJECT_ID(N'[dbo].[FK_TableroFicha]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FichaSet] DROP CONSTRAINT [FK_TableroFicha];
GO
IF OBJECT_ID(N'[dbo].[FK_CasillaPortal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PortalSet] DROP CONSTRAINT [FK_CasillaPortal];
GO
IF OBJECT_ID(N'[dbo].[FK_TableroFondoTablero]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FondoTableroSet] DROP CONSTRAINT [FK_TableroFondoTablero];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FichaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FichaSet];
GO
IF OBJECT_ID(N'[dbo].[PartidaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PartidaSet];
GO
IF OBJECT_ID(N'[dbo].[TableroSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TableroSet];
GO
IF OBJECT_ID(N'[dbo].[CasillaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CasillaSet];
GO
IF OBJECT_ID(N'[dbo].[PuntuacionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PuntuacionSet];
GO
IF OBJECT_ID(N'[dbo].[CuentaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CuentaSet];
GO
IF OBJECT_ID(N'[dbo].[JugadorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[JugadorSet];
GO
IF OBJECT_ID(N'[dbo].[PortalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PortalSet];
GO
IF OBJECT_ID(N'[dbo].[FondoTableroSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FondoTableroSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FichaSet'
CREATE TABLE [dbo].[FichaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [imagen] nvarchar(max)  NOT NULL,
    [Tablero_Id] int  NOT NULL
);
GO

-- Creating table 'PartidaSet'
CREATE TABLE [dbo].[PartidaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [num_jugadores] smallint  NOT NULL,
    [tiempo_inicio] datetime  NOT NULL,
    [tiempo_fin] datetime  NOT NULL,
    [Tablero_Id] int  NOT NULL
);
GO

-- Creating table 'TableroSet'
CREATE TABLE [dbo].[TableroSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [cuadricula] nvarchar(max)  NOT NULL,
    [no_casillas] smallint  NOT NULL
);
GO

-- Creating table 'CasillaSet'
CREATE TABLE [dbo].[CasillaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [numero] smallint  NOT NULL,
    [especial] bit  NOT NULL,
    [TableroId] int  NOT NULL
);
GO

-- Creating table 'PuntuacionSet'
CREATE TABLE [dbo].[PuntuacionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [puntos] smallint  NOT NULL,
    [turnos] smallint  NOT NULL,
    [Jugador_Id] int  NOT NULL,
    [Partida_Id] int  NOT NULL
);
GO

-- Creating table 'CuentaSet'
CREATE TABLE [dbo].[CuentaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [correo] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [salt] nvarchar(max)  NOT NULL,
    [validada] bit  NOT NULL
);
GO

-- Creating table 'JugadorSet'
CREATE TABLE [dbo].[JugadorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [apodo] nvarchar(max)  NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [apellidos] nvarchar(max)  NOT NULL,
    [Cuenta_Id] int  NOT NULL
);
GO

-- Creating table 'PortalSet'
CREATE TABLE [dbo].[PortalSet] (
    [Id] smallint  NOT NULL,
    [color] nvarchar(max)  NOT NULL,
    [imagen] nvarchar(max)  NOT NULL,
    [Casilla_Id] int  NOT NULL
);
GO

-- Creating table 'FondoTableroSet'
CREATE TABLE [dbo].[FondoTableroSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [imagen] nvarchar(max)  NOT NULL,
    [Tablero_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FichaSet'
ALTER TABLE [dbo].[FichaSet]
ADD CONSTRAINT [PK_FichaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PartidaSet'
ALTER TABLE [dbo].[PartidaSet]
ADD CONSTRAINT [PK_PartidaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TableroSet'
ALTER TABLE [dbo].[TableroSet]
ADD CONSTRAINT [PK_TableroSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CasillaSet'
ALTER TABLE [dbo].[CasillaSet]
ADD CONSTRAINT [PK_CasillaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PuntuacionSet'
ALTER TABLE [dbo].[PuntuacionSet]
ADD CONSTRAINT [PK_PuntuacionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CuentaSet'
ALTER TABLE [dbo].[CuentaSet]
ADD CONSTRAINT [PK_CuentaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'JugadorSet'
ALTER TABLE [dbo].[JugadorSet]
ADD CONSTRAINT [PK_JugadorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PortalSet'
ALTER TABLE [dbo].[PortalSet]
ADD CONSTRAINT [PK_PortalSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FondoTableroSet'
ALTER TABLE [dbo].[FondoTableroSet]
ADD CONSTRAINT [PK_FondoTableroSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Tablero_Id] in table 'PartidaSet'
ALTER TABLE [dbo].[PartidaSet]
ADD CONSTRAINT [FK_PartidaTablero]
    FOREIGN KEY ([Tablero_Id])
    REFERENCES [dbo].[TableroSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PartidaTablero'
CREATE INDEX [IX_FK_PartidaTablero]
ON [dbo].[PartidaSet]
    ([Tablero_Id]);
GO

-- Creating foreign key on [TableroId] in table 'CasillaSet'
ALTER TABLE [dbo].[CasillaSet]
ADD CONSTRAINT [FK_TableroCasilla]
    FOREIGN KEY ([TableroId])
    REFERENCES [dbo].[TableroSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TableroCasilla'
CREATE INDEX [IX_FK_TableroCasilla]
ON [dbo].[CasillaSet]
    ([TableroId]);
GO

-- Creating foreign key on [Cuenta_Id] in table 'JugadorSet'
ALTER TABLE [dbo].[JugadorSet]
ADD CONSTRAINT [FK_JugadorCuenta]
    FOREIGN KEY ([Cuenta_Id])
    REFERENCES [dbo].[CuentaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JugadorCuenta'
CREATE INDEX [IX_FK_JugadorCuenta]
ON [dbo].[JugadorSet]
    ([Cuenta_Id]);
GO

-- Creating foreign key on [Jugador_Id] in table 'PuntuacionSet'
ALTER TABLE [dbo].[PuntuacionSet]
ADD CONSTRAINT [FK_PuntuacionJugador]
    FOREIGN KEY ([Jugador_Id])
    REFERENCES [dbo].[JugadorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PuntuacionJugador'
CREATE INDEX [IX_FK_PuntuacionJugador]
ON [dbo].[PuntuacionSet]
    ([Jugador_Id]);
GO

-- Creating foreign key on [Partida_Id] in table 'PuntuacionSet'
ALTER TABLE [dbo].[PuntuacionSet]
ADD CONSTRAINT [FK_PartidaPuntuacion]
    FOREIGN KEY ([Partida_Id])
    REFERENCES [dbo].[PartidaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PartidaPuntuacion'
CREATE INDEX [IX_FK_PartidaPuntuacion]
ON [dbo].[PuntuacionSet]
    ([Partida_Id]);
GO

-- Creating foreign key on [Tablero_Id] in table 'FichaSet'
ALTER TABLE [dbo].[FichaSet]
ADD CONSTRAINT [FK_TableroFicha]
    FOREIGN KEY ([Tablero_Id])
    REFERENCES [dbo].[TableroSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TableroFicha'
CREATE INDEX [IX_FK_TableroFicha]
ON [dbo].[FichaSet]
    ([Tablero_Id]);
GO

-- Creating foreign key on [Casilla_Id] in table 'PortalSet'
ALTER TABLE [dbo].[PortalSet]
ADD CONSTRAINT [FK_CasillaPortal]
    FOREIGN KEY ([Casilla_Id])
    REFERENCES [dbo].[CasillaSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CasillaPortal'
CREATE INDEX [IX_FK_CasillaPortal]
ON [dbo].[PortalSet]
    ([Casilla_Id]);
GO

-- Creating foreign key on [Tablero_Id] in table 'FondoTableroSet'
ALTER TABLE [dbo].[FondoTableroSet]
ADD CONSTRAINT [FK_TableroFondoTablero]
    FOREIGN KEY ([Tablero_Id])
    REFERENCES [dbo].[TableroSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TableroFondoTablero'
CREATE INDEX [IX_FK_TableroFondoTablero]
ON [dbo].[FondoTableroSet]
    ([Tablero_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------