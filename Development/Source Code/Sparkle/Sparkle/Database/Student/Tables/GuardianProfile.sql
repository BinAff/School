CREATE TABLE [Student].[GuardianProfile] (
    [Id]                   BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName]            VARCHAR (100) NOT NULL,
    [MiddleName]           VARCHAR (100) NULL,
    [LastName]             VARCHAR (100) NULL,
    [OccupationId]         BIGINT        NULL,
    [ContactInformationId] BIGINT        NULL,
    CONSTRAINT [PK_GuardianProfile] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_GuardianP_ContactInfo] FOREIGN KEY ([ContactInformationId]) REFERENCES [Configuration].[ContactInformation] ([Id]),
    CONSTRAINT [FK_GuardianP_Occupation] FOREIGN KEY ([OccupationId]) REFERENCES [Configuration].[Occupation] ([Id])
);

