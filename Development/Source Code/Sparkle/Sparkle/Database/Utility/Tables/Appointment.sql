CREATE TABLE [Utility].[Appointment] (
    [Id]           NUMERIC (10)  IDENTITY (1, 1) NOT NULL,
    [ActorId]      NUMERIC (10)  NOT NULL,
    [Title]        VARCHAR (50)  NOT NULL,
    [TypeId]       NUMERIC (10)  NOT NULL,
    [Start]        DATETIME      NOT NULL,
    [End]          DATETIME      NOT NULL,
    [Location]     VARCHAR (50)  NOT NULL,
    [Description]  VARCHAR (250) NOT NULL,
    [ImportanceId] NUMERIC (10)  NULL,
    [Reminder]     DATETIME      NULL,
    CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Appointment_AppointmentType] FOREIGN KEY ([TypeId]) REFERENCES [Utility].[AppointmentType] ([Id]),
    CONSTRAINT [FK_Appointment_Importance] FOREIGN KEY ([ImportanceId]) REFERENCES [Utility].[Importance] ([Id])
);

