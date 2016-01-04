CREATE TABLE [Billing].[Fee] (
    [Id]              BIGINT          NOT NULL,
    [FeeDefinitionId] BIGINT          NOT NULL,
    [StandardId]      BIGINT          NOT NULL,
    [CategoryId]      BIGINT          NULL,
    [Amount]          NUMERIC (10, 2) NOT NULL,
    [AccountYearId]   BIGINT          NOT NULL,
    [IsActive]        BIT             CONSTRAINT [DF_Fee_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Fee] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Fee_AccountingYear] FOREIGN KEY ([AccountYearId]) REFERENCES [Finance].[AccountingYear] ([Id]),
    CONSTRAINT [FK_Fee_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Student].[Category] ([Id]),
    CONSTRAINT [FK_Fee_FeeDefinition] FOREIGN KEY ([FeeDefinitionId]) REFERENCES [Billing].[FeeDefinition] ([Id]),
    CONSTRAINT [FK_Fee_Standard] FOREIGN KEY ([StandardId]) REFERENCES [School].[Standard] ([Id])
);



