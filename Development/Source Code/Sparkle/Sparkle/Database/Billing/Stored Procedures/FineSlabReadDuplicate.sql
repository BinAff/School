CREATE PROCEDURE [Billing].[FineSlabReadDuplicate]
(
	@FineId BIGINT,
	@LowerLimit BIGINT,
	@UpperLimit BIGINT
)
AS
BEGIN

	SELECT Id
	FROM Billing.FineSlab WITH (NOLOCK)
	WHERE FineId = @FineId
	and (LowerLimit = @LowerLimit
		 or UpperLimit = @UpperLimit)
				
END