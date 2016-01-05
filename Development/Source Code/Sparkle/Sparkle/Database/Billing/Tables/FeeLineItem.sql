CREATE TABLE [Billing].[FeeLineItem] (
    [Id]          BIGINT IDENTITY (1, 1) NOT NULL,
    [BillId]      BIGINT NOT NULL,
    [FeesId]      BIGINT NOT NULL,
    [Installment] BIGINT NOT NULL,
    [Amount]      BIGINT NOT NULL,
    CONSTRAINT [PK_FeeLineItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FeeLine_Bill] FOREIGN KEY ([BillId]) REFERENCES [Billing].[Bill] ([Id]),
    CONSTRAINT [FK_FeeLine_Fees] FOREIGN KEY ([FeesId]) REFERENCES [Billing].[Fee] ([Id])
);

