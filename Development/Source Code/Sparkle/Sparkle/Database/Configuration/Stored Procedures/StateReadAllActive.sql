CREATE PROCEDURE [Configuration].[StateReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.State  WITH (NOLOCK)
	WHERE IsActive = 1
   
END