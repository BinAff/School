CREATE PROCEDURE [Billing].[BillReadAll]
AS
BEGIN
	
	SELECT Id,StudentId,BillDate,Installment,FeeAmount,FineAmount,TotalAmount,AmountPaid,PayModeId
	FROM Billing.Bill WITH (NOLOCK)
   
END