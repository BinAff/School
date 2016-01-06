CREATE TABLE [Configuration].[Gender] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_Gender_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Gender] UNIQUE NONCLUSTERED ([Name] ASC)
);

