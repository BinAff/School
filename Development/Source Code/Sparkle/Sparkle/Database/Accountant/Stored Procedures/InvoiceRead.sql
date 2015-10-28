CREATE PROCEDURE Accountant.InvoiceRead
(
	@Id Numeric(10,0)
)
AS
BEGIN	
	
	SELECT 
		Id, [Date], SerialNumber, Advance, Discount,
		SellerName, SellerAddress, SellerContactNo, SellerEmail, SellerLicence,
		BuyerName, BuyerAddress, BuyerContactNo, BuyerEmail		
	FROM Accountant.Invoice WITH (NOLOCK)
	WHERE Id = @Id   
	
END