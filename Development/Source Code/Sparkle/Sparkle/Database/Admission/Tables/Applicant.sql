CREATE TABLE [Admission].[Applicant] (
    [Id]                    BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName]             VARCHAR (100) NOT NULL,
    [MiddleName]            VARCHAR (100) NULL,
    [LastName]              VARCHAR (100) NULL,
    [PersonalInformationId] BIGINT        NULL,
    [StandardId]            BIGINT        NULL,
    [FatherName]            VARCHAR (100) NULL,
    [FatherOccupation]      VARCHAR (100) NULL,
    [FatherMonthlyIncome]   BIGINT        NULL,
    [MotherName]            VARCHAR (100) NULL,
    [MotherOccupation]      VARCHAR (100) NULL,
    [MotherMonthlyIncome]   BIGINT        NULL,
    [EducationBackgroundId] BIGINT        NULL,
    [TestId]                BIGINT        NULL,
    CONSTRAINT [PK_Applicant] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Appl_EducationBg] FOREIGN KEY ([EducationBackgroundId]) REFERENCES [Admission].[EducationBackground] ([Id]),
    CONSTRAINT [FK_Appl_Personalinfo] FOREIGN KEY ([PersonalInformationId]) REFERENCES [Student].[PersonalInformation] ([Id]),
    CONSTRAINT [FK_Appl_Test] FOREIGN KEY ([TestId]) REFERENCES [Admission].[Test] ([Id]),
    CONSTRAINT [fk_Applicant_Standard] FOREIGN KEY ([StandardId]) REFERENCES [School].[Standard] ([Id])
);

