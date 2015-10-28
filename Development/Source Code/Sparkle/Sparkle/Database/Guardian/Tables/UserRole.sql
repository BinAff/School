CREATE TABLE [Guardian].[UserRole] (
    [UserId] NUMERIC (10) NOT NULL,
    [RoleId] NUMERIC (10) NOT NULL,
    CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC),
    CONSTRAINT [FK_UserRole_Account] FOREIGN KEY ([UserId]) REFERENCES [Guardian].[Account] ([Id]),
    CONSTRAINT [FK_UserRole_Role] FOREIGN KEY ([RoleId]) REFERENCES [Guardian].[Role] ([Id])
);

