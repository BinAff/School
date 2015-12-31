CREATE TABLE [Billing].[FineType] (
    [Id]       BIGINT       NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [IsActive] BIT          CONSTRAINT [DF_FineType_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_FineType] PRIMARY KEY CLUSTERED ([Id] ASC)
);

