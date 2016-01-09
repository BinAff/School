CREATE PROCEDURE [Configuration].[DistrictReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.District  WITH (NOLOCK)
	WHERE IsActive = 1
   
END