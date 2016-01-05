CREATE PROCEDURE [Billing].[FineReadDuplicate]
(
	@FineDefinitionId BIGINT,
	@StandardId BIGINT,
	@AccountingYearId BIGINT
	
)
AS
BEGIN

	SELECT Id
	FROM Billing.Fine WITH (NOLOCK)
	WHERE FineDefinitionId = @FineDefinitionId
	and StandardId = @StandardId
	and AccountingYearId = @AccountingYearId
	
END