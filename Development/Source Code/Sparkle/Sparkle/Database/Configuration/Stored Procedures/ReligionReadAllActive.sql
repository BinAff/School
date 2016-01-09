CREATE PROCEDURE [Configuration].[ReligionReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Religion  WITH (NOLOCK)
	WHERE IsActive = 1
   
END