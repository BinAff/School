CREATE PROCEDURE [Configuration].[CasteReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Configuration.Caste WITH (NOLOCK)
	WHERE Name = @Name
				
END