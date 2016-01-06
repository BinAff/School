CREATE PROCEDURE [Configuration].[GenderReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Gender  WITH (NOLOCK)
	WHERE IsActive = 1
   
END