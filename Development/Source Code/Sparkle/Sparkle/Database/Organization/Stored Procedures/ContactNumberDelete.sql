CREATE PROCEDURE [Organization].[ContactNumberDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM [Organization].[ContactNumber]
	WHERE Id = @Id   
   
END