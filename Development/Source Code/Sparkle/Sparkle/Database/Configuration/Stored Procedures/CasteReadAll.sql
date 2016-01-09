CREATE PROCEDURE [Configuration].[CasteReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Caste WITH (NOLOCK)
   
END
