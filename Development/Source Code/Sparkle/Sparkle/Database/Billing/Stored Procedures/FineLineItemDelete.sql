CREATE PROCEDURE [Billing].[FineLineItemDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.FineLineItem
	WHERE Id = @Id   
   
END