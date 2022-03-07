
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/10/2022 17:36:39
-- Generated from EDMX file: C:\Users\203AKSAM_MUTLU\source\repos\2022\02.10.Persembe.EntityFrameworks\WindowsFormsApp1\WndAppModel\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Calısma];
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

-- Creating table 'EmlakSet'
CREATE TABLE [dbo].[EmlakSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Adres] nvarchar(max)  NOT NULL,
    [Metrekare] smallint  NOT NULL,
    [Fiyat] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EmlakSet'
ALTER TABLE [dbo].[EmlakSet]
ADD CONSTRAINT [PK_EmlakSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------