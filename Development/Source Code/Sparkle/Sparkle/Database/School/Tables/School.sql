CREATE TABLE [School].[School] (
    [Id]                   BIGINT          IDENTITY (1, 1) NOT NULL,
    [Name]                 VARCHAR (50)    NOT NULL,
    [ContactInformationId] BIGINT          NOT NULL,
    [Logo]                 VARBINARY (MAX) NULL,
    [AccreditationNumber]  VARCHAR (50)    NULL,
    [Tan]                  VARCHAR (50)    NULL,
    CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED ([Id] ASC)
);

