CREATE PROCEDURE [Billing].[FineLineItemRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,BillId,FineId,Amount
   FROM Billing.FineLineItem WITH (NOLOCK)
   WHERE Id = @Id
   
END