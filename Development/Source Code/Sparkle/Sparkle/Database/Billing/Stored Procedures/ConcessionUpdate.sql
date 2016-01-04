CREATE PROCEDURE [Billing].[ConcessionUpdate]
(
	@Id BIGINT,
	@Amount NUMERIC(10,2),
	@IsPercentage BIT,
	@FeeId BIGINT,
	@CasteId BIGINT
)
AS
BEGIN
	
	UPDATE Billing.Concession
	SET	
		Amount = @Amount,
		IsPercentage = @IsPercentage,
		FeeId = @FeeId,
		CasteId = @CasteId
	WHERE Id = @Id
	
END