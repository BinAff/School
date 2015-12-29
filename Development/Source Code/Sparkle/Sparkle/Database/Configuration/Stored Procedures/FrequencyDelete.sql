CREATE PROCEDURE [Configuration].[FrequencyDelete]
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.Frequency
	WHERE Id = @Id   
   
END