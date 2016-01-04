CREATE TABLE [Configuration].[MotherTongue] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_MotherTongue] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_MotherTongue] UNIQUE NONCLUSTERED ([Name] ASC)
);

