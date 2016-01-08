CREATE TABLE [Admission].[TestSubject] (
    [Id]               BIGINT       IDENTITY (1, 1) NOT NULL,
    [SubjectName]      VARCHAR (80) NOT NULL,
    [TestDefinitionId] BIGINT       NOT NULL,
    [TotalMarks]       BIGINT       NULL,
    [PassingMarks]     BIGINT       NULL,
    [IsActive]         BIT          NULL,
    CONSTRAINT [PK_TestSubject] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TestSubject_TestDef] FOREIGN KEY ([TestDefinitionId]) REFERENCES [Admission].[TestDefinition] ([Id])
);

