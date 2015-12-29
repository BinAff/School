CREATE PROCEDURE [Configuration].[FrequencyDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.Frequency
	WHERE Id = @Id   
   
END