CREATE TABLE [Billing].[Fine] (
    [Id]               BIGINT IDENTITY (1, 1) NOT NULL,
    [FineDefinitionId] BIGINT NOT NULL,
    [StandardId]       BIGINT NULL,
    [Amount]           BIGINT NULL,
    [AccountingYearId] BIGINT NOT NULL,
    [IsActive]         BIT    NULL,
    CONSTRAINT [PK_Fine] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Fine_AccYear] FOREIGN KEY ([AccountingYearId]) REFERENCES [Finance].[AccountingYear] ([Id]),
    CONSTRAINT [FK_Fine_FDefinition] FOREIGN KEY ([FineDefinitionId]) REFERENCES [Billing].[FineDefinition] ([Id]),
    CONSTRAINT [FK_Fine_Standard] FOREIGN KEY ([StandardId]) REFERENCES [School].[Standard] ([Id])
);

