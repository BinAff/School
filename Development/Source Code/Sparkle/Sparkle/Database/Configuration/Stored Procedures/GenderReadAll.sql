CREATE PROCEDURE [Configuration].[GenderReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Gender WITH (NOLOCK)
   
END