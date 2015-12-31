CREATE TABLE [Billing].[FeeDefinition] (
    [Id]               BIGINT       NOT NULL,
    [Name]             VARCHAR (50) NOT NULL,
    [FeeGroupId]       BIGINT       NOT NULL,
    [FineDefinitionId] BIGINT       NULL,
    [AccountId]        BIGINT       NOT NULL,
    [IsActive]         BIT          CONSTRAINT [DF_FeeDefinition_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_FeeDefinition] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FeeDefinition_Account] FOREIGN KEY ([AccountId]) REFERENCES [Finance].[Account] ([Id]),
    CONSTRAINT [FK_FeeDefinition_FeeGroup] FOREIGN KEY ([FeeGroupId]) REFERENCES [Billing].[FeeGroup] ([Id]),
    CONSTRAINT [FK_FeeDefinition_FineDefinition] FOREIGN KEY ([FineDefinitionId]) REFERENCES [Billing].[FineDefinition] ([Id])
);

