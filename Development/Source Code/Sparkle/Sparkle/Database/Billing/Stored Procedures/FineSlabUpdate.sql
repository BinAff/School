CREATE PROCEDURE [Billing].[FineSlabUpdate]
(
    @Id BIGINT,
	@FineId BIGINT,
	@LowerLimit BIGINT = NULL,
	@UpperLimit BIGINT = NULL,
	@Value BIGINT
	)
AS

BEGIN
	
	UPDATE Billing.FineSlab
	SET	
		FineId = @FineId,
		LowerLimit = @LowerLimit,
		UpperLimit = @UpperLimit,
		Value = @Value
		WHERE Id = @Id
   END