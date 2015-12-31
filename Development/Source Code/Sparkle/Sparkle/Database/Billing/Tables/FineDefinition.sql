CREATE TABLE [Billing].[FineDefinition] (
    [Id]           BIGINT       NOT NULL,
    [Name]         VARCHAR (50) NOT NULL,
    [IsPercentage] BIT          NOT NULL,
    [FineTypeId]   BIGINT       NOT NULL,
    [AccountId]    BIGINT       NOT NULL,
    [IsActive]     BIT          CONSTRAINT [DF_FineDefinition_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_FineDefinition] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FineDefinition_Account] FOREIGN KEY ([AccountId]) REFERENCES [Finance].[Account] ([Id]),
    CONSTRAINT [FK_FineDefinition_FineType] FOREIGN KEY ([FineTypeId]) REFERENCES [Billing].[FineType] ([Id])
);

