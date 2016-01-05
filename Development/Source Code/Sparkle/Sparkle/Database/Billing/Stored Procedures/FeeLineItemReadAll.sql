CREATE PROCEDURE [Billing].[FeeLineItemReadAll]
AS
BEGIN
	
	SELECT Id,BillId,FeesId,Installment,Amount
	FROM Billing.FeeLineItem WITH (NOLOCK)
   
END