CREATE PROCEDURE [Organization].[StandardDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM [Organization].[Standard]
	WHERE Id = @Id   
   
END