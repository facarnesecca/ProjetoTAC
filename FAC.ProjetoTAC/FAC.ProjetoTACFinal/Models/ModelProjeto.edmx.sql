
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2015 17:19:55
-- Generated from EDMX file: C:\Projetos\ProjetoTAC\FAC.ProjetoTAC\FAC.ProjetoTACFinal\Models\ModelProjeto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO

IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EstadoCidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cidades] DROP CONSTRAINT [FK_EstadoCidade];
GO
IF OBJECT_ID(N'[dbo].[FK_CidadeEndereco]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Enderecos] DROP CONSTRAINT [FK_CidadeEndereco];
GO
IF OBJECT_ID(N'[dbo].[FK_EnderecoContato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contatos] DROP CONSTRAINT [FK_EnderecoContato];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cidades];
GO
IF OBJECT_ID(N'[dbo].[Enderecos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Enderecos];
GO
IF OBJECT_ID(N'[dbo].[Contatos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contatos];
GO
IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cidades'
CREATE TABLE [dbo].[Cidades] (
    [idCidade] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [iduf] int  NULL
);
GO

-- Creating table 'Enderecos'
CREATE TABLE [dbo].[Enderecos] (
    [IdEndereco] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [CEP] nvarchar(max)  NOT NULL,
    [idCidade] int  NULL
);
GO

-- Creating table 'Contatos'
CREATE TABLE [dbo].[Contatos] (
    [IdContato] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [DtNacimento] datetime  NULL,
    [CPF] nvarchar(max)  NULL,
    [RG] nvarchar(max)  NULL,
    [Detalhes] nvarchar(max)  NULL,
    [Numero] nvarchar(max)  NULL,
    [Compelmento] nvarchar(max)  NULL,
    [idEndereco] int  NULL
);
GO

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [Iduf] int IDENTITY(1,1) NOT NULL,
    [UF] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idCidade] in table 'Cidades'
ALTER TABLE [dbo].[Cidades]
ADD CONSTRAINT [PK_Cidades]
    PRIMARY KEY CLUSTERED ([idCidade] ASC);
GO

-- Creating primary key on [IdEndereco] in table 'Enderecos'
ALTER TABLE [dbo].[Enderecos]
ADD CONSTRAINT [PK_Enderecos]
    PRIMARY KEY CLUSTERED ([IdEndereco] ASC);
GO

-- Creating primary key on [IdContato] in table 'Contatos'
ALTER TABLE [dbo].[Contatos]
ADD CONSTRAINT [PK_Contatos]
    PRIMARY KEY CLUSTERED ([IdContato] ASC);
GO

-- Creating primary key on [Iduf] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([Iduf] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------