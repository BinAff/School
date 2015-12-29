CREATE TABLE [Finance].[PaymentMode] (
    [Id]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [IsActive] BIT          CONSTRAINT [DF__PaymentMo__IsAct__4C0144E4] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_PaymentMode] PRIMARY KEY CLUSTERED ([Id] ASC)
);



