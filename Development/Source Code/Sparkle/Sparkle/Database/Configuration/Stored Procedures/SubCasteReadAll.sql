CREATE PROCEDURE [Configuration].[SubCasteReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.SubCaste WITH (NOLOCK)
   
END
