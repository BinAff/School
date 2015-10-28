CREATE TABLE [Accountant].[Tax] (
    [Id]           NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [Name]         VARCHAR (50) NOT NULL,
    [Amount]       MONEY        NOT NULL,
    [IsPercentage] BIT          NOT NULL,
    CONSTRAINT [PK_Taxation] PRIMARY KEY CLUSTERED ([Id] ASC)
);

