CREATE TABLE [Accountant].[InvoiceLineItemTax] (
    [Id]           NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [TaxName]      VARCHAR (50) NULL,
    [TaxAmount]    MONEY        NULL,
    [IsPercentage] BIT          NULL,
    [LineItemId]   NUMERIC (10) NOT NULL,
    CONSTRAINT [FK_LineItemTaxation_LineItem] FOREIGN KEY ([LineItemId]) REFERENCES [Accountant].[InvoiceLineItem] ([Id])
);

