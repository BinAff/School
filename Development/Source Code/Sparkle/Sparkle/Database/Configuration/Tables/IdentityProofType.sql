CREATE TABLE [Configuration].[IdentityProofType] (
    [Id]   NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_IdentityProofType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

