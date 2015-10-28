CREATE TABLE [Guardian].[SecurityAnswer] (
    [Id]         NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [UserId]     NUMERIC (10) NOT NULL,
    [QuestionId] NUMERIC (10) NOT NULL,
    [Answer]     VARCHAR (50) NOT NULL,
    CONSTRAINT [PK__Security__3214EC07529933DA] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SecurityAnswer_Account] FOREIGN KEY ([UserId]) REFERENCES [Guardian].[Account] ([Id]),
    CONSTRAINT [FK_SecurityAnswer_SecurityQuestion] FOREIGN KEY ([QuestionId]) REFERENCES [Guardian].[SecurityQuestion] ([Id])
);

