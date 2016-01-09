CREATE PROCEDURE [Configuration].[CasteReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Caste  WITH (NOLOCK)
	WHERE IsActive = 1
   
END