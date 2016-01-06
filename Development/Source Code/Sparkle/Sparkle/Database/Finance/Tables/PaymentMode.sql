CREATE TABLE [Finance].[PaymentMode] (
    [Id]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_PaymentMode_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_PaymentMode] PRIMARY KEY CLUSTERED ([Id] ASC)
);



