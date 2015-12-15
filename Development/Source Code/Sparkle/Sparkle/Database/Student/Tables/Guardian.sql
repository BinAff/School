CREATE TABLE [Student].[Guardian] (
    [Id]                    BIGINT IDENTITY (1, 1) NOT NULL,
    [StudentId] BIGINT NOT NULL,
    [ProfileId]     BIGINT NOT NULL,
    [RelationshipId]        BIGINT NOT NULL,
    CONSTRAINT [PK_Guardian] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Guardian_Profile] FOREIGN KEY ([ProfileId]) REFERENCES [Configuration].[Profile] ([Id]),
    CONSTRAINT [FK_Guardian_Student] FOREIGN KEY ([StudentId]) REFERENCES [Student].[Student] ([Id])
);


