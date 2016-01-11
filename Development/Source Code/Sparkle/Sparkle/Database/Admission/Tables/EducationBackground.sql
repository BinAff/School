CREATE TABLE [Admission].[EducationBackground] (
    [Id]               BIGINT       IDENTITY (1, 1) NOT NULL,
    [PreviousStandard] VARCHAR (80) NOT NULL,
    [PreviousSchool]   VARCHAR (80) NOT NULL,
    [PreviousPercent]  BIGINT       NULL,
    CONSTRAINT [PK_EducationBackground] PRIMARY KEY CLUSTERED ([Id] ASC)
);

