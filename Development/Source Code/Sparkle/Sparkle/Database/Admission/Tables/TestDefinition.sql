CREATE TABLE [Admission].[TestDefinition] (
    [Id]           BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (50) NOT NULL,
    [PassingMarks] BIGINT       NULL,
    [IsActive]     BIT          NULL,
    CONSTRAINT [PK_TestDefinition] PRIMARY KEY CLUSTERED ([Id] ASC)
);

