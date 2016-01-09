CREATE PROCEDURE [Configuration].[SubCasteReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.SubCaste  WITH (NOLOCK)
	WHERE IsActive = 1
   
END