CREATE PROCEDURE [Accountant].[InvoiceLineItemRead]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Start, [End],
		[Description], UnitRate, [Count], ExtraRate, ExtraCount,
		InvoiceId
	FROM Accountant.InvoiceLineItem WITH (NOLOCK)
	WHERE Id = @Id   
	
END