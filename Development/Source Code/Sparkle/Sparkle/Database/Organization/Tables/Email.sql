CREATE TABLE [Organization].[Email] (
    [Id]             NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [Email]          VARCHAR (50) NOT NULL,
    [OrganizationId] BIGINT       NULL,
    CONSTRAINT [PK_Email] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Organization_FK_Id] FOREIGN KEY ([OrganizationId]) REFERENCES [School].[School] ([Id])
);



