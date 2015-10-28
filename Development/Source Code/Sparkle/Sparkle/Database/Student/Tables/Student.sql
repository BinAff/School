CREATE TABLE [Student].[Student] (
    [Id]         BIGINT       NOT NULL,
    [FirstName]  VARCHAR (50) NULL,
    [MiddleName] VARCHAR (50) NULL,
    [LastName]   VARCHAR (50) NULL,
    [StateId]    BIGINT       NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_State] FOREIGN KEY ([StateId]) REFERENCES [Configuration].[State] ([Id])
);



