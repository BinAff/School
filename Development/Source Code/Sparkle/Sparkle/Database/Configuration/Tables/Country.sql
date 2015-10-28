CREATE TABLE [Configuration].[Country] (
    [Id]   NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([Id] ASC)
);

