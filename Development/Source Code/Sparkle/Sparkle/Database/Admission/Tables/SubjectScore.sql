CREATE TABLE [Admission].[SubjectScore] (
    [Id]            BIGINT IDENTITY (1, 1) NOT NULL,
    [TestId]        BIGINT NOT NULL,
    [TestSubjectId] BIGINT NOT NULL,
    [MarksScored]   BIGINT NULL,
    CONSTRAINT [PK_SubjectScore] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_SubjectScore_Subject] FOREIGN KEY ([TestSubjectId]) REFERENCES [Admission].[TestSubject] ([Id]),
    CONSTRAINT [FK_SubjectScore_Test] FOREIGN KEY ([TestId]) REFERENCES [Admission].[Test] ([Id])
);

