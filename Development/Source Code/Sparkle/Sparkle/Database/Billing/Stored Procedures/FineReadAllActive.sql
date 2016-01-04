 
   CREATE PROCEDURE [Billing].[FineReadAllActive]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id,FineDefinitionId,StandardId,Amount,AccountingYearId,IsActive
	FROM Billing.Fine WITH (NOLOCK) where Isactive = 1
				
END