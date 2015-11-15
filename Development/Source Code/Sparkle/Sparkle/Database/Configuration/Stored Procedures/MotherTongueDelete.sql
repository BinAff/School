CREATE PROCEDURE [Configuration].[MotherTongueDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.MotherTongue
	WHERE Id = @Id   
   
END