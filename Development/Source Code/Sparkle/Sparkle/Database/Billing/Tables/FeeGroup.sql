CREATE TABLE [Billing].[FeeGroup] (
    [Id]          BIGINT       NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [FrequencyId] BIGINT       NOT NULL,
    [IsActive]    BIT          CONSTRAINT [DF_FeeGroup_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_FeeGroup] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FeeGroup_Frequency] FOREIGN KEY ([FrequencyId]) REFERENCES [Configuration].[Frequency] ([Id])
);

