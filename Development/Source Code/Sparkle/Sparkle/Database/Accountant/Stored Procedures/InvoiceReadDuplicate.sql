CREATE PROCEDURE Accountant.InvoiceReadDuplicate
(
	@SerialNumber int		
)
AS
BEGIN

	SELECT Id
	FROM Accountant.Invoice WITH (NOLOCK)
	WHERE SerialNumber = @SerialNumber
	
END