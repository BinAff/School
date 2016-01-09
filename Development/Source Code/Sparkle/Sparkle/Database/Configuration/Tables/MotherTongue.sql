CREATE TABLE [Configuration].[MotherTongue] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_MotherTongue_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_MotherTongue] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_MotherTongue] UNIQUE NONCLUSTERED ([Name] ASC)
);

