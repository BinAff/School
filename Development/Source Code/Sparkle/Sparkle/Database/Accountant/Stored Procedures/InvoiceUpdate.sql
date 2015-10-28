CREATE PROCEDURE Accountant.InvoiceUpdate
(
	@Id Numeric(10,0),
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
	@BuyerEmail Varchar(50)
)
AS
BEGIN
	
	UPDATE Accountant.Invoice
	SET	
		[Date] = @Date,
		Advance = @Advance,
		Discount = @Discount,
		SellerName = @SellerName,
		SellerAddress = @SellerAddress,
		SellerContactNo = @SellerContactNo,
		SellerEmail = @SellerEmail,
		SellerLicence = @SellerLicence,
		BuyerName = @BuyerName,
		BuyerAddress = @BuyerAddress,
		BuyerContactNo = @BuyerContactNo,
		BuyerEmail = @BuyerEmail
	WHERE Id = @Id
   
END