CREATE TABLE [dbo].[EMPLOYEE] (
    [Id]             INT      PRIMARY KEY      IDENTITY (1, 1) NOT NULL,
    [Name]           NVARCHAR (200)  NOT NULL,
    [Address]        NVARCHAR (2000) NOT NULL,
    [DOB]            DATETIME2 (7)  NOT NULL,
    [Mobile]         NVARCHAR (10) NOT NULL,
    [CreatedOn]      DATETIME2 (7)  NOT NULL,
    [LastModifiedOn] DATETIME2 (7)  NULL
);
