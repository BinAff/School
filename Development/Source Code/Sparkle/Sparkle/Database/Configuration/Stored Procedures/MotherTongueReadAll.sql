CREATE PROCEDURE [Configuration].[MotherTongueReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.MotherTongue WITH (NOLOCK)
   
END
