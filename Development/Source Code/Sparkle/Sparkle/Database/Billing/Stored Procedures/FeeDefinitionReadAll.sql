CREATE PROCEDURE Billing.FeeDefinitionReadAll
AS
BEGIN
	
	SELECT Id, Name, FeeGroupId, FineDefinitionId, AccountId, IsActive
	FROM Billing.FeeDefinition  WITH (NOLOCK)
   
END