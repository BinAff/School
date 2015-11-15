CREATE PROCEDURE [Configuration].[OccupationDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.Occupation
	WHERE Id = @Id   
   
END