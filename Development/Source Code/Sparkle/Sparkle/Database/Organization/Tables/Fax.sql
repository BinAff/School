CREATE TABLE [Organization].[Fax] (
    [Id]             NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [Fax]            VARCHAR (50) NOT NULL,
    [OrganizationId] BIGINT       NULL,
    CONSTRAINT [PK_Fax] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Organization_FK_FaxId] FOREIGN KEY ([OrganizationId]) REFERENCES [School].[School] ([Id])
);



