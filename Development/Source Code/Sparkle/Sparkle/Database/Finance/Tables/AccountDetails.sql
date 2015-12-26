CREATE TABLE [Finance].[AccountDetails] (
    [Id]               BIGINT IDENTITY (1, 1) NOT NULL,
    [AccountingYearId] BIGINT NOT NULL,
    [AccountId]        BIGINT NOT NULL,
    [BillNumber]       BIGINT NULL,
    CONSTRAINT [PK_AccountDetails] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AccDet_Account] FOREIGN KEY ([AccountId]) REFERENCES [Finance].[Account] ([Id]),
    CONSTRAINT [FK_AccDet_AccYear] FOREIGN KEY ([AccountingYearId]) REFERENCES [Finance].[AccountingYear] ([Id])
);

