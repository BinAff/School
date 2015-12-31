CREATE PROCEDURE Billing.FeeDefinitionRead
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id, Name, FeeGroupId, FineDefinitionId, AccountId, IsActive
   FROM Billing.FeeDefinition  WITH (NOLOCK)
   WHERE Id = @Id
   
END