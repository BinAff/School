CREATE PROCEDURE Accountant.InvoiceReadAll
AS
BEGIN
	
	SELECT 
		Id, [Date], SerialNumber, Advance, Discount,
		SellerName, SellerAddress, SellerContactNo, SellerEmail, SellerLicence,
		BuyerName, BuyerAddress, BuyerContactNo, BuyerEmail
	FROM Accountant.Invoice WITH (NOLOCK)
   
END