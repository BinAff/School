CREATE TABLE [Finance].[AccountingYear] (
    [Id]          BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [CurrentFlag] BIT          NOT NULL,
    [IsActive] BIT NOT NULL, 
    CONSTRAINT [PK_AccYear] PRIMARY KEY CLUSTERED ([Id] ASC)
);

