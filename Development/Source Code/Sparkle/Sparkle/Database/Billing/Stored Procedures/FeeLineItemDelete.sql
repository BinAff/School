CREATE PROCEDURE [Billing].[FeeLineItemDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.FeeLineItem
	WHERE Id = @Id   
   
END