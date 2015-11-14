CREATE TABLE [Organization].[Section] (
    [Id]        BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50) NOT NULL,
        CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED ([Id] ASC)    
);