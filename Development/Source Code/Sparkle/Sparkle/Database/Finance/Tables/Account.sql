CREATE TABLE [Finance].[Account] (
    [Id]             BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (50) NOT NULL,
    [OrganizationId] NUMERIC (10) NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Account_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [Organization].[Organization] ([Id])
);

