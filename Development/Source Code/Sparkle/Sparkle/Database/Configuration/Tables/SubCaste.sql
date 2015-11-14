CREATE TABLE [Configuration].[SubCaste] (
    [Id]        BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (100) NOT NULL,
        CONSTRAINT [PK_SubCaste] PRIMARY KEY CLUSTERED ([Id] ASC)    
);