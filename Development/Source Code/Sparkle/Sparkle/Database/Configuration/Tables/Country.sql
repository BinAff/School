CREATE TABLE [Configuration].[Country] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    [Code] VARCHAR(50) NULL, 
    [IsdCode] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([Id] ASC)
);



