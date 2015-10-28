CREATE PROCEDURE Accountant.InvoiceLineItemTaxRead
( 
	@LineItemId Numeric(10,0)
)
AS
BEGIN 

	SELECT Id, TaxName, TaxAmount, IsPercentage, LineItemId
	FROM Accountant.InvoiceLineItemTax WITH (NOLOCK)
	WHERE LineItemId = @LineItemId

END