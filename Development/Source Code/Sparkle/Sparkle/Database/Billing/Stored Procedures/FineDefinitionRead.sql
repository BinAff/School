CREATE PROCEDURE [Billing].[FineDefinitionRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id, Name, IsPercentage, FineTypeId, AccountId, IsActive
   FROM Billing.FineDefinition  WITH (NOLOCK)
   WHERE Id = @Id
   
END