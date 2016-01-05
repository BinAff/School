CREATE PROCEDURE [Billing].[BillRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,StudentId,BillDate,Installment,FeeAmount,FineAmount,TotalAmount,AmountPaid,PayModeid
   FROM Billing.Bill WITH (NOLOCK)
   WHERE Id = @Id
   
END