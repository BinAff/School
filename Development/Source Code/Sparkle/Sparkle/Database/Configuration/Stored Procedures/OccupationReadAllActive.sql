CREATE PROCEDURE [Configuration].[OccupationReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Occupation  WITH (NOLOCK)
	WHERE IsActive = 1
   
END