CREATE PROCEDURE Billing.FineTypeDelete
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.FineType
	WHERE Id = @Id   
   
END