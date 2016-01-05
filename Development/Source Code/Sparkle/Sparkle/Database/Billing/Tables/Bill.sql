CREATE TABLE [Billing].[Bill] (
    [Id]          BIGINT IDENTITY (1, 1) NOT NULL,
    [StudentId]   BIGINT NOT NULL,
    [BillDate]    DATE   NOT NULL,
    [Installment] BIGINT NOT NULL,
    [FeeAmount]   BIGINT NOT NULL,
    [FineAmount]  BIGINT NULL,
    [TotalAmount] BIGINT NOT NULL,
    [AmountPaid]  BIGINT NOT NULL,
    [PayModeId]   BIGINT NOT NULL,
    CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Bill_PayMoe] FOREIGN KEY ([PayModeId]) REFERENCES [Finance].[PaymentMode] ([Id]),
    CONSTRAINT [FK_Bill_Student] FOREIGN KEY ([StudentId]) REFERENCES [Student].[Student] ([Id])
);

