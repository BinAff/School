CREATE PROCEDURE [Organization].[ClassDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM [Organization].[Class]
	WHERE Id = @Id   
   
END