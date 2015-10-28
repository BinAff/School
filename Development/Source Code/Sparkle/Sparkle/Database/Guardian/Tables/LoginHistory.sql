CREATE TABLE [Guardian].[LoginHistory] (
    [Id]          NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [AccountId]   NUMERIC (10) NOT NULL,
    [LoginStamp]  DATETIME     NULL,
    [LogoutStamp] DATETIME     NULL,
    CONSTRAINT [PK_LoginLogoutHistory] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_LoginLogoutHistory_Account] FOREIGN KEY ([AccountId]) REFERENCES [Guardian].[Account] ([Id])
);

