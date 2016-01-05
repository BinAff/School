CREATE PROCEDURE [Billing].[FineLineItemUpdate]
(
    @Id BIGINT,
	@BillId BIGINT,
	@FineId BIGINT,
	@Amount BIGINT
	)
AS

BEGIN
	
	UPDATE Billing.FineLineItem
	SET	
	 BillId = @BillId,
	 FineId = @FineId,
	 Amount = @Amount
		
		WHERE Id = @Id
   END