CREATE PROCEDURE [Accountant].[InvoiceInsert]
(  
	@Date DateTime,
	@Advance Money,
	@Discount Money,
	
	@SellerName Varchar(50),
	@SellerAddress Varchar(250),
	@SellerContactNo Varchar(50),
	@SellerEmail Varchar(50),
	@SellerLicence Varchar(50),
	
	@BuyerName Varchar(50),
	@BuyerAddress Varchar(250),
	@BuyerContactNo Varchar(50),
	@BuyerEmail Varchar(50),	
	
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	BEGIN TRANSACTION
	
	DECLARE @Max Int
	SELECT @Max = MAX(SerialNumber) + 1 FROM Accountant.Invoice
		WHERE CONVERT(VARCHAR(8), Date, 112) = CONVERT(VARCHAR(8), @Date, 112)
	IF @Max IS Null SET @Max = 1
	INSERT INTO Accountant.Invoice([Date], SerialNumber, Advance, Discount,
		SellerName,  SellerAddress, SellerContactNo, SellerEmail, SellerLicence,
		BuyerName, BuyerAddress, BuyerContactNo, BuyerEmail)
	VALUES(@Date, @Max, @Advance, @Discount,
		@SellerName, @SellerAddress, @SellerContactNo, @SellerEmail, @SellerLicence,
		@BuyerName, @BuyerAddress, @BuyerContactNo, @BuyerEmail)
    
    COMMIT TRANSACTION
    
	SET @Id = @@IDENTITY
	
END