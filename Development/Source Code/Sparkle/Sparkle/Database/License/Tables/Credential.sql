CREATE TABLE [License].[Credential] (
    [LicenseNo]        VARCHAR (MAX)  NOT NULL,
    [LicenseDate]      DATE           NOT NULL,
    [AuthToken]        VARBINARY (50) NOT NULL,
    [FingurePrint]     VARCHAR (MAX)  NOT NULL,
    [InstallationDate] DATE           NOT NULL
);

