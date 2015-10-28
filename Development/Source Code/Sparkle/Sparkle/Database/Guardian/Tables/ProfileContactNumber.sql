CREATE TABLE [Guardian].[ProfileContactNumber] (
    [Id]            NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [UserId]        NUMERIC (10) NOT NULL,
    [ContactNumber] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_ProfileContactNumber] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProfileContactNumber_Profile] FOREIGN KEY ([UserId]) REFERENCES [Guardian].[Profile] ([UserId])
);

