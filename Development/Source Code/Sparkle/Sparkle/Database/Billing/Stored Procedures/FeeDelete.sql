CREATE PROCEDURE Billing.FeeDelete
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.Fee
	WHERE Id = @Id   
   
END