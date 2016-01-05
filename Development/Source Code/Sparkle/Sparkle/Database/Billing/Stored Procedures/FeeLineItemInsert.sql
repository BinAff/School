CREATE PROCEDURE [Billing].[FeeLineItemInsert]
(  
	@BillId BIGINT,
	@FeesId BIGINT,
	@Installment BIGINT,
	@Amount BIGINT,
	@Id  BIGINT OUTPUT
	)
AS
BEGIN	
	
	INSERT INTO Billing.FeeLineItem(BillId,FeesId,Installment,Amount)
	VALUES(@BillId,@FeesId,@Installment,@Amount)
   
	SET @Id = @@IDENTITY

END