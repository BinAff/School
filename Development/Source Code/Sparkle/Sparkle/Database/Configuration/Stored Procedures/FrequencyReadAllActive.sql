CREATE PROCEDURE [Configuration].[FrequencyReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Frequency  WITH (NOLOCK)
	WHERE IsActive = 1
   
END