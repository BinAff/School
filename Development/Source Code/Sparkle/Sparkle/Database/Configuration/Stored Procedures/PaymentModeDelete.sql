CREATE PROCEDURE [Configuration].[PaymentModeDelete]
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.PaymentMode
	WHERE Id = @Id   
   
END