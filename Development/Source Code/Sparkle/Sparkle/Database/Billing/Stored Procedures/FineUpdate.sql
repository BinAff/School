CREATE PROCEDURE [Billing].[FineUpdate]
(
    @Id BIGINT,
	@FineDefinitionId BIGINT,
	@StandardId BIGINT = NULL,
	@Amount BIGINT,
	@AccountingYearId BIGINT
	)
AS

BEGIN
	
	UPDATE Billing.Fine
	SET	
		FineDefinitionId = @FineDefinitionId,
		StandardId = @StandardId,
		Amount = @Amount,
		AccountingYearId = @AccountingYearId
		WHERE Id = @Id
   END