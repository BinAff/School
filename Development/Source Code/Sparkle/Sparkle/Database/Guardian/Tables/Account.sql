CREATE TABLE [Guardian].[Account] (
    [Id]       NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [LoginId]  VARCHAR (63) NOT NULL,
    [Password] VARCHAR (31) NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([Id] ASC)
);

