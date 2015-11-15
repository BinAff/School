CREATE PROCEDURE [Configuration].[CasteReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.Caste WITH (NOLOCK)
   
END
