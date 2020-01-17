
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/09/2020 11:26:10
-- Generated from EDMX file: E:\AquamanRoyalTea\AquamanRoyalTeaPlusPlus\AquamanRoyalTea\Model\EntityFrameworkDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Aquaman];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CargoInfoGoodsInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GoodsInfoSet] DROP CONSTRAINT [FK_CargoInfoGoodsInfo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserInfo];
GO
IF OBJECT_ID(N'[dbo].[OrderInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrderInfoSet];
GO
IF OBJECT_ID(N'[dbo].[CargoInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CargoInfoSet];
GO
IF OBJECT_ID(N'[dbo].[GoodsInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GoodsInfoSet];
GO
IF OBJECT_ID(N'[dbo].[UserPrivilegesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserPrivilegesSet];
GO
IF OBJECT_ID(N'[dbo].[CargoLogInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CargoLogInfoSet];
GO
IF OBJECT_ID(N'[dbo].[ProjectInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjectInfoSet];
GO
IF OBJECT_ID(N'[dbo].[ApplyInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplyInfo];
GO
IF OBJECT_ID(N'[dbo].[ApplyCargoInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplyCargoInfo];
GO
IF OBJECT_ID(N'[dbo].[SupplyInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SupplyInfoSet];
GO
IF OBJECT_ID(N'[dbo].[CategoryInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoryInfoSet];
GO
IF OBJECT_ID(N'[dbo].[SupplyCategoryInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SupplyCategoryInfoSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserInfo'
CREATE TABLE [dbo].[UserInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [DelFlag] bit  NOT NULL,
    [UserPrivilegesId] int  NULL,
    [RealName] nvarchar(max)  NULL
);
GO

-- Creating table 'OrderInfoSet'
CREATE TABLE [dbo].[OrderInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Time] datetime  NOT NULL,
    [UserInfoId] int  NOT NULL,
    [Department] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CargoInfoSet'
CREATE TABLE [dbo].[CargoInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CargoName] nvarchar(max)  NOT NULL,
    [Unit] nvarchar(max)  NULL,
    [CargoCount] decimal(18,0)  NOT NULL,
    [Amount] decimal(18,0)  NULL,
    [DelFlag] bit  NOT NULL,
    [Specifications] nvarchar(max)  NULL,
    [Type] nvarchar(max)  NULL,
    [LastCargoName] nvarchar(max)  NOT NULL,
    [Area] nvarchar(max)  NULL,
    [CanDel] bit  NOT NULL
);
GO

-- Creating table 'GoodsInfoSet'
CREATE TABLE [dbo].[GoodsInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OrderInfoId] int  NOT NULL,
    [Count] int  NOT NULL,
    [CargoInfoId] int  NOT NULL
);
GO

-- Creating table 'UserPrivilegesSet'
CREATE TABLE [dbo].[UserPrivilegesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PrivilegeName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CargoLogInfoSet'
CREATE TABLE [dbo].[CargoLogInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IsIncome] bit  NULL,
    [ChangeCount] decimal(18,0)  NOT NULL,
    [CargoInfoId] int  NOT NULL,
    [Time] datetime  NOT NULL,
    [ProjectInfoId] int  NULL,
    [UserId] int  NOT NULL,
    [Desc] nvarchar(max)  NULL,
    [TakenName] nvarchar(max)  NULL
);
GO

-- Creating table 'ProjectInfoSet'
CREATE TABLE [dbo].[ProjectInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL,
    [ProjectId] nvarchar(max)  NULL,
    [DelFlag] bit  NOT NULL,
    [UserId] int  NULL,
    [DutyName] nvarchar(max)  NULL
);
GO

-- Creating table 'ApplyInfo'
CREATE TABLE [dbo].[ApplyInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProjectId] nvarchar(max)  NOT NULL,
    [UserApply] nvarchar(max)  NOT NULL,
    [Time] datetime  NOT NULL,
    [UserConfirm] nvarchar(max)  NOT NULL,
    [TimeConfirm] nvarchar(max)  NOT NULL,
    [Batch] int  NOT NULL,
    [ConfirmFlag] bit  NOT NULL
);
GO

-- Creating table 'ApplyCargoInfo'
CREATE TABLE [dbo].[ApplyCargoInfo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ChangeCount] int  NOT NULL,
    [ProjectId] nvarchar(max)  NOT NULL,
    [Batch] int  NOT NULL,
    [IncomingFlag] int  NOT NULL,
    [ShippingFlag] int  NOT NULL,
    [UserIncoming] nvarchar(max)  NOT NULL,
    [TimeIncoming] datetime  NOT NULL,
    [UserShipping] nvarchar(max)  NOT NULL,
    [TimeShipping] nvarchar(max)  NOT NULL,
    [CargoName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SupplyInfoSet'
CREATE TABLE [dbo].[SupplyInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Company] nvarchar(max)  NOT NULL,
    [SupplyName] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [Phone] nvarchar(max)  NULL,
    [DelFlag] bit  NOT NULL,
    [CanDel] bit  NOT NULL,
    [CategoryId] int  NULL
);
GO

-- Creating table 'CategoryInfoSet'
CREATE TABLE [dbo].[CategoryInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(max)  NULL,
    [DelFlag] bit  NULL,
    [CanDel] bit  NULL
);
GO

-- Creating table 'SupplyCategoryInfoSet'
CREATE TABLE [dbo].[SupplyCategoryInfoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SupplyInfoId] int  NOT NULL,
    [CategoryInfoId] int  NOT NULL,
    [Time] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserInfo'
ALTER TABLE [dbo].[UserInfo]
ADD CONSTRAINT [PK_UserInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderInfoSet'
ALTER TABLE [dbo].[OrderInfoSet]
ADD CONSTRAINT [PK_OrderInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CargoInfoSet'
ALTER TABLE [dbo].[CargoInfoSet]
ADD CONSTRAINT [PK_CargoInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GoodsInfoSet'
ALTER TABLE [dbo].[GoodsInfoSet]
ADD CONSTRAINT [PK_GoodsInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserPrivilegesSet'
ALTER TABLE [dbo].[UserPrivilegesSet]
ADD CONSTRAINT [PK_UserPrivilegesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CargoLogInfoSet'
ALTER TABLE [dbo].[CargoLogInfoSet]
ADD CONSTRAINT [PK_CargoLogInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProjectInfoSet'
ALTER TABLE [dbo].[ProjectInfoSet]
ADD CONSTRAINT [PK_ProjectInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApplyInfo'
ALTER TABLE [dbo].[ApplyInfo]
ADD CONSTRAINT [PK_ApplyInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApplyCargoInfo'
ALTER TABLE [dbo].[ApplyCargoInfo]
ADD CONSTRAINT [PK_ApplyCargoInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SupplyInfoSet'
ALTER TABLE [dbo].[SupplyInfoSet]
ADD CONSTRAINT [PK_SupplyInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CategoryInfoSet'
ALTER TABLE [dbo].[CategoryInfoSet]
ADD CONSTRAINT [PK_CategoryInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SupplyCategoryInfoSet'
ALTER TABLE [dbo].[SupplyCategoryInfoSet]
ADD CONSTRAINT [PK_SupplyCategoryInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CargoInfoId] in table 'GoodsInfoSet'
ALTER TABLE [dbo].[GoodsInfoSet]
ADD CONSTRAINT [FK_CargoInfoGoodsInfo]
    FOREIGN KEY ([CargoInfoId])
    REFERENCES [dbo].[CargoInfoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CargoInfoGoodsInfo'
CREATE INDEX [IX_FK_CargoInfoGoodsInfo]
ON [dbo].[GoodsInfoSet]
    ([CargoInfoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------