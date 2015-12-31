CREATE PROCEDURE Billing.FeeReadDuplicate
(
	@FeeDefinitionId BIGINT,
	@StandardId BIGINT,
	@CategoryId BIGINT,
	@AccountYearId BIGINT
)
AS
BEGIN

	SELECT Id
	FROM Billing.Fee WITH (NOLOCK)
	WHERE FeeDefinitionId = @FeeDefinitionId
	AND StandardId = @StandardId
	AND CategoryId = @CategoryId
	AND AccountYearId = @AccountYearId
				
END