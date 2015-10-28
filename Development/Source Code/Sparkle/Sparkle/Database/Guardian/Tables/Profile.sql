CREATE TABLE [Guardian].[Profile] (
    [UserId]     NUMERIC (10) NOT NULL,
    [Initial]    NUMERIC (10) NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [MiddleName] VARCHAR (50) NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [Dob]        DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Profile_Account] FOREIGN KEY ([UserId]) REFERENCES [Guardian].[Account] ([Id]),
    CONSTRAINT [FK_Profile_Initial] FOREIGN KEY ([Initial]) REFERENCES [Configuration].[Initial] ([Id])
);

