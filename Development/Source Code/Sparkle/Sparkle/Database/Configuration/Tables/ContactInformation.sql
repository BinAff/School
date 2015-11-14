 CREATE TABLE [Configuration].[ContactInformation] (
    [Id]        BIGINT       IDENTITY (1, 1) NOT NULL,
    [Address]      VARCHAR (500) NOT NULL,
    [DistrictId] BIGINT NOT NULL, 
	[Pin] BIGINT NULL, 
	[LandLine] BIGINT NULL, 
    CONSTRAINT [PK_ContactInformation] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ContactInformation_District] FOREIGN KEY ([DistrictId]) REFERENCES [Configuration].[District] ([Id])
);
