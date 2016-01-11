CREATE TABLE [Admission].[AdmissionForm] (
    [Id]              BIGINT        IDENTITY (1, 1) NOT NULL,
    [AdmissionNumber] VARCHAR (20)  NOT NULL,
    [DateOfIssue]     DATE          NOT NULL,
    [Remarks]         VARCHAR (100) NULL,
    [FeesId]          BIGINT        NULL,
    [ApplicantId]     BIGINT        NOT NULL,
    CONSTRAINT [PK_AdmissionForm] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Admform_Applicant] FOREIGN KEY ([ApplicantId]) REFERENCES [Admission].[Applicant] ([Id]),
    CONSTRAINT [FK_Admissionform_Fees] FOREIGN KEY ([FeesId]) REFERENCES [Billing].[Fee] ([Id])
);

