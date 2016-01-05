
CREATE PROCEDURE [Billing].[FeeLineItemUpdate]
(
    @Id BIGINT,
	@BillId BIGINT,
	@FeesId BIGINT,
	@Installment BIGINT,
	@Amount BIGINT
	)
AS

BEGIN
	
	UPDATE Billing.FeeLineItem
	SET	
		BillId = @BillId,
		FeesId = @FeesId,
		Installment = @Installment,
		Amount = @Amount
		WHERE Id = @Id
   END