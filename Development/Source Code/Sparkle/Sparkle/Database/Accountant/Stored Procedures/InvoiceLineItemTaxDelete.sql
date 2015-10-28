CREATE PROCEDURE Accountant.InvoiceLineItemTaxDelete
( 
	@Id Numeric(10,0)
)
AS
BEGIN 

	DELETE FROM Accountant.InvoiceLineItemTax
	WHERE Id = @Id
	
END