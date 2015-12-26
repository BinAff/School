CREATE PROCEDURE [Finance].[AccountDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Finance.Account
	WHERE Id = @Id   
   
END