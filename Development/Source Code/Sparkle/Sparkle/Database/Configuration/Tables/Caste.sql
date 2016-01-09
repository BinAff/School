CREATE TABLE [Configuration].[Caste] (
    [Id]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_Caste_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Caste] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Caste] UNIQUE NONCLUSTERED ([Name] ASC)
);

