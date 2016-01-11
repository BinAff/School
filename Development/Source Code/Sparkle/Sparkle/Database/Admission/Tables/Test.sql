CREATE TABLE [Admission].[Test] (
    [Id]               BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (80) NOT NULL,
    [TestDefinitionId] BIGINT       NOT NULL,
    [TotalScore]       BIGINT       NULL,
    [IsPassed]         BIT          NULL,
    [TestRank]         BIGINT       NULL,
    CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Test_TestDef] FOREIGN KEY ([TestDefinitionId]) REFERENCES [Admission].[TestDefinition] ([Id])
);

