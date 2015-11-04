CREATE TABLE [Student].[Student] (
    [Id]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50)  NULL,
    [MiddleName] VARCHAR (50)  NULL,
    [LastName]   VARCHAR (50)  NULL,
    [Address]    VARCHAR (256) NULL,
    [StateId]    BIGINT        NULL,
    [City] VARCHAR(50) NULL, 
    [Pin] INT NULL, 
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_State] FOREIGN KEY ([StateId]) REFERENCES [Configuration].[State] ([Id])
);





