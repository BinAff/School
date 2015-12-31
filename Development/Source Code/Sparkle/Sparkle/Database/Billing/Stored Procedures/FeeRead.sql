CREATE PROCEDURE Billing.FeeRead
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id, FeeDefinitionId, StandardId, CategoryId, Amount, AccountYearId, IsActive
   FROM Billing.Fee  WITH (NOLOCK)
   WHERE Id = @Id
   
END