CREATE PROCEDURE [Billing].[ConcessionReadDuplicate]
(
	@FeeId BIGINT,
	@CasteId BIGINT
)
AS
BEGIN

	SELECT Id
	FROM Billing.Concession WITH (NOLOCK)
	WHERE FeeId = @FeeId
		AND CasteId = @CasteId
				
END