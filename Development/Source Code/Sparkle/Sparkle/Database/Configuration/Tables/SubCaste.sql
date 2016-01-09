CREATE TABLE [Configuration].[SubCaste] (
    [Id]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_SubCaste_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_SubCaste] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_SubCaste] UNIQUE NONCLUSTERED ([Name] ASC)
);

