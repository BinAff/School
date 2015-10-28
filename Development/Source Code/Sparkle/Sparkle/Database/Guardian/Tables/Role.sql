CREATE TABLE [Guardian].[Role] (
    [Id]          NUMERIC (10)  IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (63)  NULL,
    [Description] VARCHAR (255) NULL,
    CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED ([Id] ASC)
);

