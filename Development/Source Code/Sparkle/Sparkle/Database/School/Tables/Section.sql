CREATE TABLE [School].[Section] (
    [Id]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [IsActive] BIT          CONSTRAINT [DF_Section_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED ([Id] ASC)
);

