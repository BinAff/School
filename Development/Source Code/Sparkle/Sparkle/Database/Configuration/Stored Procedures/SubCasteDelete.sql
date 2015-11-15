CREATE PROCEDURE [Configuration].[SubCasteDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.SubCaste
	WHERE Id = @Id   
   
END