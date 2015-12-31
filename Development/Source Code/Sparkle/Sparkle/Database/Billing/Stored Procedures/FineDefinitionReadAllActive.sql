CREATE PROCEDURE [Billing].[FineDefinitionReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsPercentage, FineTypeId, AccountId, IsActive
	FROM Billing.FineDefinition  WITH (NOLOCK)
	WHERE IsActive = 1
   
END