CREATE PROCEDURE [Billing].[FineLineItemReadAll]
AS
BEGIN
	
	SELECT Id,BillId,FineId,Amount
	FROM Billing.FineLineItem WITH (NOLOCK)
   
END