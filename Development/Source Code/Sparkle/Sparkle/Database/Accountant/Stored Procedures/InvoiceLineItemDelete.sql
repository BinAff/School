CREATE PROCEDURE Accountant.InvoiceLineItemDelete
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Accountant.InvoiceLineItem
	WHERE Id = @Id   
   
END