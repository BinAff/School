CREATE TABLE [School].[Class] (
    [Id]         BIGINT IDENTITY (1, 1) NOT NULL,
    [StandardId] BIGINT NOT NULL,
    [SectionId]  BIGINT NOT NULL,
    [IsActive]   BIT    NOT NULL,
    CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Class_Section] FOREIGN KEY ([SectionId]) REFERENCES [School].[Section] ([Id]),
    CONSTRAINT [FK_Class_Standard] FOREIGN KEY ([StandardId]) REFERENCES [School].[Standard] ([Id])
);

