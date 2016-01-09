CREATE TABLE [Configuration].[Occupation] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_Occupation_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Occupation] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Occupation] UNIQUE NONCLUSTERED ([Name] ASC)
);

