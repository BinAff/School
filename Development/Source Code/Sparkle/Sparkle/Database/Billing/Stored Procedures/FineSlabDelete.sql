CREATE PROCEDURE [Billing].[FineSlabDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.FineSlab
	WHERE Id = @Id   
   
END