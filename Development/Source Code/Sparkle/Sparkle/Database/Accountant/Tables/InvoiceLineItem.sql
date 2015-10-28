CREATE TABLE [Accountant].[InvoiceLineItem] (
    [Id]          NUMERIC (10)  IDENTITY (1, 1) NOT NULL,
    [InvoiceId]   NUMERIC (10)  NOT NULL,
    [Start]       DATETIME      NULL,
    [End]         DATETIME      NULL,
    [Description] VARCHAR (250) NOT NULL,
    [UnitRate]    MONEY         NOT NULL,
    [Count]       INT           NOT NULL,
    [ExtraRate]   MONEY         CONSTRAINT [DF_InvoiceLineItem_ExtraRate] DEFAULT ((0)) NOT NULL,
    [ExtraCount]  INT           CONSTRAINT [DF_InvoiceLineItem_ExtraCount] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_LineItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LineItem_Invoice] FOREIGN KEY ([InvoiceId]) REFERENCES [Accountant].[Invoice] ([Id])
);

