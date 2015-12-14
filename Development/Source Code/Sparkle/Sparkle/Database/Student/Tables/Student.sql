CREATE TABLE [Student].[Student] (
    [Id]         BIGINT        IDENTITY (1, 1) NOT NULL,
	[StudentId] VARCHAR(50)    NOT NULL,
    [FirstName]  VARCHAR (100)  NOT NULL,
    [MiddleName] VARCHAR (60)  NULL,
    [LastName]   VARCHAR (60)  NULL,
	[RollNumber] VARCHAR (50)  NULL,
	[Photo]		 VARBINARY(1024) Null,
    [CategoryId] BIGINT        NULL,
    [StandardId]    BIGINT        NOT NULL,
    [SectionId] BIGINT NOT NULL, 
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Student].[Category] ([Id]),
	CONSTRAINT [FK_Student_Standard] FOREIGN KEY ([StandardId]) REFERENCES [Organization].[Standard] ([Id]),
	CONSTRAINT [FK_Student_Section] FOREIGN KEY ([SectionId]) REFERENCES [Organization].[Section] ([Id])
);





