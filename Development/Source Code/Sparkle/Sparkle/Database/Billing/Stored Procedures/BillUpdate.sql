

CREATE PROCEDURE [Billing].[BillUpdate]
(
    @Id BIGINT,
	@StudentId BIGINT,
	@BillDate Date,
	@Installment BIGINT,
	@FeeAmount BIGINT,
	@FineAmount BIGINT,
	@TotalAmount BIGINT,
	@AmountPaid BIGINT,
	@PayModeid BIGINT
	)
AS

BEGIN
	
	UPDATE Billing.Bill
	SET	
		StudentId = @StudentId,
		BillDate = @BillDate,
		Installment = @Installment,
		FeeAmount = @FeeAmount,
		FineAmount = @FineAmount,
		TotalAmount =@TotalAmount,
		AmountPaid =@AmountPaid,
		PayModeid = @PayModeid
		WHERE Id = @Id
   END