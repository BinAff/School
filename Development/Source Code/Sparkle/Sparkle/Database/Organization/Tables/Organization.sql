CREATE TABLE [Organization].[Organization] (
    [Id]               NUMERIC (10)    IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (50)    NOT NULL,
    [Logo]             VARBINARY (MAX) NULL,
    [LicenceNumber]    VARCHAR (50)    NULL,
    [ServiceTaxNumber] VARCHAR (50)    NULL,
    [LuxuaryTaxNumber] VARCHAR (50)    NULL,
    [Tan]              VARCHAR (50)    NULL,
    [Address]          VARCHAR (255)   NULL,
    [City]             VARCHAR (50)    NULL,
    [StateId]          NUMERIC (10)    NULL,
    [Pin]              INT             NULL,
    [ContactName]      VARCHAR (50)    NULL,
    CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED ([Id] ASC)
);

