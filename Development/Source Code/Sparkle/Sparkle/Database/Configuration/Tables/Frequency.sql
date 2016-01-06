CREATE TABLE [Configuration].[Frequency] (
    [Id]       BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_Frequency_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_Frequency] PRIMARY KEY CLUSTERED ([Id] ASC)
);



