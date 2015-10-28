CREATE TABLE [Guardian].[SecurityQuestion] (
    [Id]       NUMERIC (10)  IDENTITY (1, 1) NOT NULL,
    [Question] VARCHAR (155) NULL,
    CONSTRAINT [PK_SecurityQuestion] PRIMARY KEY CLUSTERED ([Id] ASC)
);

