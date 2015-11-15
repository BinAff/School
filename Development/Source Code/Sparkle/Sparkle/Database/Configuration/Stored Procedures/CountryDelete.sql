CREATE PROCEDURE [Configuration].[CountryDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.Country
	WHERE Id = @Id   
   
END