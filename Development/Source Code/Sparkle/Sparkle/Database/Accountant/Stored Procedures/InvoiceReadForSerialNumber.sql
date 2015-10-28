CREATE PROCEDURE Accountant.[InvoiceReadForSerialNumber]
(
	@SerialNumber Int,
	@Date Date
)
AS
BEGIN
	
	SELECT Id
	FROM Accountant.Invoice WITH (NOLOCK)
	WHERE SerialNumber = @SerialNumber
		AND Date = @Date
	
END