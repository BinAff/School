CREATE TABLE [Configuration].[Country] (
    [Id]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (100) NOT NULL,
    [Code]    VARCHAR (50)  NULL,
    [IsdCode] VARCHAR (50)  NULL,
    [IsActive] BIT CONSTRAINT [DF_Country_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Country] UNIQUE NONCLUSTERED ([Name] ASC),
    CONSTRAINT [IX_Country_1] UNIQUE NONCLUSTERED ([Code] ASC)
);





