CREATE PROCEDURE [Finance].[PaymentModeDelete]
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM Finance.PaymentMode
	WHERE Id = @Id   
   
END