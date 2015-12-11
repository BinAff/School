CREATE TABLE [Student].[Student] (
    [Id]         BIGINT        IDENTITY (1, 1) NOT NULL,
	[StudentId] VARCHAR(50)    NOT NULL,
    [FirstName]  VARCHAR (100)  NULL,
    [MiddleName] VARCHAR (60)  NULL,
    [LastName]   VARCHAR (60)  NULL,
	[RollNumber] VARCHAR (50)  NULL,
	[Photo]		 VARBINARY(1024) Null,
    [CategoryId] BIGINT        NULL,
    [ClassId]    BIGINT        NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Student_Category] FOREIGN KEY ([CategoryId]) REFERENCES [Student].[Category] ([Id]),
	CONSTRAINT [FK_Student_Class] FOREIGN KEY ([ClassId]) REFERENCES [Organization].[Class] ([Id])
);





