CREATE TABLE [Billing].[Concesion] (
    [Id]           BIGINT          NOT NULL,
    [Amount]       NUMERIC (10, 2) NOT NULL,
    [IsPercentage] BIT             NOT NULL,
    [FeeId]        BIGINT          NOT NULL,
    [CasteId]      BIGINT          NOT NULL,
    [IsActive]     BIT             CONSTRAINT [DF_Concesion_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Concesion] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Concesion_Caste] FOREIGN KEY ([CasteId]) REFERENCES [Configuration].[Caste] ([Id]),
    CONSTRAINT [FK_Concesion_Fee] FOREIGN KEY ([FeeId]) REFERENCES [Billing].[Fee] ([Id])
);

