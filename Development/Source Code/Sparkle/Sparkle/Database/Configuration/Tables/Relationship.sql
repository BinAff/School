CREATE TABLE [Configuration].[Relationship] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_Relationship_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Relationship] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Relationship] UNIQUE NONCLUSTERED ([Name] ASC)
);


