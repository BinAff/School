CREATE PROCEDURE [Configuration].[ReligionReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.Religion WITH (NOLOCK)
   
END