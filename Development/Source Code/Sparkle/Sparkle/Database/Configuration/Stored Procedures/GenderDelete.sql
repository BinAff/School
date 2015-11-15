CREATE PROCEDURE [Configuration].[GenderDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.Gender
	WHERE Id = @Id   
   
END