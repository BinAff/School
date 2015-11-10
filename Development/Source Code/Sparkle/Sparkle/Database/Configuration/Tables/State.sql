CREATE TABLE [Configuration].[State] (
    [Id]        BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50) NOT NULL,
    [CountryId] BIGINT NOT NULL, 
    CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_State_State] FOREIGN KEY ([CountryId]) REFERENCES [Configuration].[Country] ([Id])
);



