CREATE TABLE [Organization].[UnitClosureReason] (
    [Id]         NUMERIC (10) IDENTITY (1, 1) NOT NULL,
    [Reason]     VARCHAR (50) NOT NULL,
    [UnitId]     NUMERIC (10) NOT NULL,
    [ClosedDate] DATETIME     NOT NULL,
    CONSTRAINT [PK_BuildingClosureReason] PRIMARY KEY CLUSTERED ([Id] ASC)
);

