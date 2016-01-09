CREATE PROCEDURE [Configuration].[ReligionReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Religion WITH (NOLOCK)
   
END