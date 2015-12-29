CREATE PROCEDURE [Configuration].[FrequencyReadAll]
AS
BEGIN
	
	SELECT Id, Name,IsActive
	FROM Configuration.Frequency WITH (NOLOCK)
   
END