CREATE TABLE [Configuration].[PaymentMode] (
    [Id]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [IsActive] BIT          DEFAULT ('1') NULL,
    CONSTRAINT [PK_PaymentMode] PRIMARY KEY CLUSTERED ([Id] ASC)
);

