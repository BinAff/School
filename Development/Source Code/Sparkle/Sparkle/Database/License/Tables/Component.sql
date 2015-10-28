CREATE TABLE [License].[Component] (
    [Id]          NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [Code]        CHAR (4)     NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Description] VARCHAR (50) NULL,
    [IsForm]      BIT          NULL,
    [IsCatalogue] BIT          NULL,
    [IsReport]    BIT          NULL,
    CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED ([Id] ASC)
);

