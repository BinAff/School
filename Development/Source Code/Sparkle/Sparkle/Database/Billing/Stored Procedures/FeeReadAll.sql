CREATE PROCEDURE Billing.FeeReadAll
AS
BEGIN
	
	SELECT Id, FeeDefinitionId, StandardId, CategoryId, Amount, AccountYearId, IsActive
	FROM Billing.Fee  WITH (NOLOCK)
   
END