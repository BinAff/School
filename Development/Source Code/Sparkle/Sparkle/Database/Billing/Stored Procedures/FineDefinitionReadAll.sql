CREATE PROCEDURE [Billing].[FineDefinitionReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsPercentage, FineTypeId, AccountId, IsActive
	FROM Billing.FineDefinition  WITH (NOLOCK)
   
END