CREATE TABLE [Finance].[Account] (
    [Id]             BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]           VARCHAR (50) NOT NULL,
    [OrganizationId] BIGINT       NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Account_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [School].[School] ([Id])
);



