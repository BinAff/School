CREATE PROCEDURE [Configuration].[CountryReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Country  WITH (NOLOCK)
	WHERE IsActive = 1
   
END