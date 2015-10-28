CREATE TABLE [Student].[Profile] (
    [Id]         BIGINT       NOT NULL,
    [FirstName]  VARCHAR (50) NULL,
    [MiddleName] VARCHAR (50) NULL,
    [LastName]   VARCHAR (50) NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC)
);

