CREATE TABLE [Configuration].[Gender] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Gender] UNIQUE NONCLUSTERED ([Name] ASC)
);

