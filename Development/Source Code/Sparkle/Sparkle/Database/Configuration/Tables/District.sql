CREATE TABLE [Configuration].[District] (
    [Id]        BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (100) NOT NULL,
    [StateId] BIGINT NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_District_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_District_State] FOREIGN KEY ([StateId]) REFERENCES [Configuration].[State] ([Id])
);
