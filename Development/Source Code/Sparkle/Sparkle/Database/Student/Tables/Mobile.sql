CREATE TABLE [Configuration].[Mobile] (
    [Id]        BIGINT       IDENTITY (1, 1) NOT NULL,
    [MobileNumber]      BIGINT NOT NULL,
	[GuardianProfileId] BIGINT NOT NULL,
        CONSTRAINT [PK_Mobile] PRIMARY KEY CLUSTERED ([Id] ASC),
		CONSTRAINT [FK_Mobile_GuardianP] FOREIGN KEY ([GuardianProfileId]) REFERENCES [Student].[GuardianProfile] ([Id])    
);
