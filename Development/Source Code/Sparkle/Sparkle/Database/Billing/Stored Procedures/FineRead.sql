CREATE PROCEDURE [Billing].[FineRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id,FineDefinitionId,StandardId,Amount,AccountingYearId,IsActive
   FROM Billing.Fine WITH (NOLOCK)
   WHERE Id = @Id
   
END