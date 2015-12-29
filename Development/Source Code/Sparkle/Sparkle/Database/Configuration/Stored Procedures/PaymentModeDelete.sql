CREATE PROCEDURE [Configuration].[PaymentModeDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.PaymentMode
	WHERE Id = @Id   
   
END