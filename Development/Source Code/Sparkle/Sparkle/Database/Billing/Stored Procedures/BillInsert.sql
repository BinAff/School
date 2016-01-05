CREATE PROCEDURE [Billing].[BillInsert]
(  
	@StudentId BIGINT,
	@BillDate Date,
	@Installment BIGINT,
	@FeeAmount BIGINT,
	@FineAmount BIGINT,
	@TotalAmount BIGINT,
	@AmountPaid BIGINT,
	@PayModeid BIGINT,
	@Id BIGINT OUTPUT
	
	)
AS
BEGIN	
	
	INSERT INTO Billing.Bill(StudentId,BillDate,Installment,FeeAmount,FineAmount,TotalAmount,AmountPaid,PayModeid)
	VALUES(@StudentId,@BillDate,@Installment,@FeeAmount,@FineAmount,@TotalAmount,@AmountPaid,@PayModeid)
   
	SET @Id = @@IDENTITY

END