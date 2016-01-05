CREATE PROCEDURE [Billing].[FineLineItemInsert]
(  
	@BillId BIGINT,
	@FineId BIGINT,
	@Amount BIGINT,
	@Id BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Billing.FineLineItem(BillId,FineId,Amount)
	VALUES(@BillId,@FineId,@Amount)
   
	SET @Id = @@IDENTITY

END