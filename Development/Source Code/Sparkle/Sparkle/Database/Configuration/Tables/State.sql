﻿CREATE TABLE [Configuration].[State] (
    [Id]        BIGINT        IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (100) NOT NULL,
    [CountryId] BIGINT        NOT NULL,
    [IsActive] BIT CONSTRAINT [DF_State_IsActive] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_State_State] FOREIGN KEY ([CountryId]) REFERENCES [Configuration].[Country] ([Id]),
    CONSTRAINT [IX_State] UNIQUE NONCLUSTERED ([Name] ASC, [CountryId] ASC)
);


