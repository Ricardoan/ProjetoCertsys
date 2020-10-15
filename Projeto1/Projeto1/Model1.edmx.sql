
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/13/2020 16:01:06
-- Generated from EDMX file: C:\Users\ricar\Desktop\Projeto\Projeto1\Projeto1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Banco];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Fornecedoress'
CREATE TABLE [dbo].[Fornecedoress] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(255)  NULL,
    [CNPJ] nvarchar(255)  NULL,
    [Endereco] nvarchar(255)  NULL,
    [Ativo] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Fornecedoress'
ALTER TABLE [dbo].[Fornecedoress]
ADD CONSTRAINT [PK_Fornecedoress]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------