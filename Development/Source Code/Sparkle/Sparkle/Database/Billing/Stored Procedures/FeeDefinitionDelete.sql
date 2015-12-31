CREATE PROCEDURE Billing.FeeDefinitionDelete
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.FeeDefinition
	WHERE Id = @Id   
   
END