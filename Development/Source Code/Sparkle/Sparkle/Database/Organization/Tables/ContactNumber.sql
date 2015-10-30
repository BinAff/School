CREATE TABLE [Organization].[ContactNumber] (
    [Id]             NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [ContactNumber]  VARCHAR (50) NOT NULL,
    [OrganizationId] NUMERIC (10) NULL,
    CONSTRAINT [PK_ContactNumber] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Organization_FK_ContactNumberId] FOREIGN KEY ([OrganizationId]) REFERENCES [Organization].[Organization] ([Id])
);

