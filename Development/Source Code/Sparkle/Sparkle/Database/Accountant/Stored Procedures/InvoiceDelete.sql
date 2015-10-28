CREATE PROCEDURE Accountant.InvoiceDelete
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Accountant.Invoice
	WHERE Id = @Id   
   
END