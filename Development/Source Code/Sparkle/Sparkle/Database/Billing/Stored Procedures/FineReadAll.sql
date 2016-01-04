CREATE PROCEDURE [Billing].[FineReadAll]
AS
BEGIN
	
	SELECT Id,FineDefinitionId,StandardId,Amount,AccountingYearId,IsActive
	FROM Billing.Fine WITH (NOLOCK)
   
END