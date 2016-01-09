CREATE PROCEDURE [Configuration].[MotherTongueReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.MotherTongue  WITH (NOLOCK)
	WHERE IsActive = 1
   
END