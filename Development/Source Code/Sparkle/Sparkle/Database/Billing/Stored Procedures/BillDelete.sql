CREATE PROCEDURE [Billing].[BillDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.Bill
	WHERE Id = @Id   
   
END