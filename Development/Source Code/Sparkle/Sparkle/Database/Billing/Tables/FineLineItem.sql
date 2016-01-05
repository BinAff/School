CREATE TABLE [Billing].[FineLineItem] (
    [Id]     BIGINT IDENTITY (1, 1) NOT NULL,
    [BillId] BIGINT NOT NULL,
    [FineId] BIGINT NOT NULL,
    [Amount] BIGINT NOT NULL,
    CONSTRAINT [PK_FineLineItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FineLine_Bill] FOREIGN KEY ([BillId]) REFERENCES [Billing].[Bill] ([Id]),
    CONSTRAINT [FK_FineLine_Fine] FOREIGN KEY ([FineId]) REFERENCES [Billing].[Fine] ([Id])
);

