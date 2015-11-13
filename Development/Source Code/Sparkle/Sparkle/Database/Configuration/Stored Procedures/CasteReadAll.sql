CREATE PROCEDURE [Configuration].[CasteReadAll]
AS
BEGIN
	
	SELECT Id, Name,ReligionId
	FROM Configuration.Caste WITH (NOLOCK)
   
END
