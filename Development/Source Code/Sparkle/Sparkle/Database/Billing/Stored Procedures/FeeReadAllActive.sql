CREATE PROCEDURE Billing.FeeReadAllActive
AS
BEGIN
	
	SELECT Id, FeeDefinitionId, StandardId, CategoryId, Amount, AccountYearId, IsActive
	FROM Billing.Fee  WITH (NOLOCK)
	WHERE IsActive = 1
   
END