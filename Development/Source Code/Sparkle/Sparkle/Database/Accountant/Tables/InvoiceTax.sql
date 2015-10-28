CREATE TABLE [Accountant].[InvoiceTax] (
    [Id]           NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [TaxName]      VARCHAR (50) NULL,
    [TaxAmount]    MONEY        NULL,
    [IsPercentage] BIT          NULL,
    [InvoiceId]    NUMERIC (10) NULL,
    CONSTRAINT [FK_InvoiceTaxation_Invoice] FOREIGN KEY ([InvoiceId]) REFERENCES [Accountant].[Invoice] ([Id])
);

