CREATE PROCEDURE [Configuration].[MotherTongueReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.MotherTongue WITH (NOLOCK)
   
END
