CREATE TABLE [Accountant].[Invoice] (
    [Id]              NUMERIC (10)  IDENTITY (1, 1) NOT NULL,
    [SerialNumber]    INT           NOT NULL,
    [Date]            DATETIME      NOT NULL,
    [Advance]         MONEY         NULL,
    [Discount]        MONEY         NULL,
    [SellerName]      VARCHAR (50)  NOT NULL,
    [SellerAddress]   VARCHAR (250) NULL,
    [SellerContactNo] VARCHAR (50)  NULL,
    [SellerEmail]     VARCHAR (50)  NULL,
    [SellerLicence]   VARCHAR (50)  NULL,
    [BuyerName]       VARCHAR (50)  NOT NULL,
    [BuyerAddress]    VARCHAR (250) NULL,
    [BuyerContactNo]  VARCHAR (50)  NULL,
    [BuyerEmail]      VARCHAR (50)  NULL,
    CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED ([Id] ASC)
);

