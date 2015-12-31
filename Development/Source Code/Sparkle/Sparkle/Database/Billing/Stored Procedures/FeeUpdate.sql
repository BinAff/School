CREATE PROCEDURE Billing.FeeUpdate
(
	@Id BIGINT,
	@FeeDefinitionId BIGINT,
	@StandardId BIGINT,
	@CategoryId BIGINT,
	@Amount NUMERIC(10,2),
	@AccountYearId BIGINT
)
AS
BEGIN
	
	UPDATE Billing.Fee
	SET	
		FeeDefinitionId = @FeeDefinitionId,
		StandardId = @StandardId,
		CategoryId = @CategoryId,
		Amount = @Amount,
		AccountYearId = @AccountYearId
	WHERE Id = @Id
	
END