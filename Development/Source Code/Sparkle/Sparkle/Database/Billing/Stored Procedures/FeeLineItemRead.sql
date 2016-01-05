CREATE PROCEDURE [Billing].[FeeLineItemRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,BillId,FeesId,Installment,Amount
   FROM Billing.FeeLineItem WITH (NOLOCK)
   WHERE Id = @Id
   
END