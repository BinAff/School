CREATE PROCEDURE [Configuration].[SubCasteReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.SubCaste WITH (NOLOCK)
   
END
