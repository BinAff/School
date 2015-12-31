CREATE PROCEDURE Billing.FeeDefinitionReadAllActive
AS
BEGIN
	
	SELECT Id, Name, FeeGroupId, FineDefinitionId, AccountId, IsActive
	FROM Billing.FeeDefinition  WITH (NOLOCK)
	WHERE IsActive = 1
   
END