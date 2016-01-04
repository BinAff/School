CREATE PROCEDURE [Billing].[FineDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.Fine
	WHERE Id = @Id   
   
END