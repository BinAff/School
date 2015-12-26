CREATE PROCEDURE [Finance].[AccountDetailsDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Finance.AccountDetails
	WHERE Id = @Id   
   
END