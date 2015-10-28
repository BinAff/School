CREATE TABLE [Configuration].[State] (
    [Id]        NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50) NOT NULL,
    [CountryId] NUMERIC (10) NOT NULL,
    CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_State_Country] FOREIGN KEY ([CountryId]) REFERENCES [Configuration].[Country] ([Id])
);

