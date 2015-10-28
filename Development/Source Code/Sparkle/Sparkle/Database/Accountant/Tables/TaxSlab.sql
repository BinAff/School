CREATE TABLE [Accountant].[TaxSlab] (
    [TaxId]     NUMERIC (10)   NOT NULL,
    [Limit]     NUMERIC (10)   NOT NULL,
    [Amount]    NUMERIC (4, 2) NOT NULL,
    [StartDate] DATE           NOT NULL,
    [EndDate]   DATE           NOT NULL,
    CONSTRAINT [PK_TaxDetails] PRIMARY KEY CLUSTERED ([TaxId] ASC, [Limit] ASC),
    CONSTRAINT [FK_TaxDetails_Taxation] FOREIGN KEY ([TaxId]) REFERENCES [Accountant].[Tax] ([Id])
);

