CREATE TABLE [License].[Module] (
    [Id]          NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [Code]        CHAR (4)     NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Description] VARCHAR (50) NULL,
    [IsMandatory] BIT          NULL,
    CONSTRAINT [PK_Module_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

