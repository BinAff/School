CREATE TABLE [Billing].[FineSlab] (
    [Id]         BIGINT IDENTITY (1, 1) NOT NULL,
    [FineId]     BIGINT NOT NULL,
    [LowerLimit] BIGINT NULL,
    [UpperLimit] BIGINT NULL,
    [Value]      BIGINT NULL,
    [IsActive]   BIT    NULL,
    CONSTRAINT [PK_Fineslab] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Fineslab_Fine] FOREIGN KEY ([FineId]) REFERENCES [Billing].[Fine] ([Id])
);

