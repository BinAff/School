CREATE TABLE Configuration.Caste(
	Id   BIGINT       IDENTITY (1, 1) NOT NULL,
    Name VARCHAR (50) NOT NULL,

    [ReligionID] BIGINT NOT NULL, 
    CONSTRAINT PK_Caste PRIMARY KEY CLUSTERED (Id ASC),
	CONSTRAINT [FK_Caste_Religion] FOREIGN KEY ([ReligionId]) REFERENCES [Configuration].[Religion] ([Id])
);