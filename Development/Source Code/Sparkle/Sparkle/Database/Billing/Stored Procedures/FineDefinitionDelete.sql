CREATE PROCEDURE [Billing].[FineDefinitionDelete]
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.FineDefinition
	WHERE Id = @Id   
   
END