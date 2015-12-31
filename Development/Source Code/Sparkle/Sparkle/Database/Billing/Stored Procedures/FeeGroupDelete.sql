CREATE PROCEDURE Billing.FeeGroupDelete
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.FeeGroup
	WHERE Id = @Id   
   
END