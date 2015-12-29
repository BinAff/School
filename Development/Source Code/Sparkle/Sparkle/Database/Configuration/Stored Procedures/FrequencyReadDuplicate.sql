CREATE PROCEDURE [Configuration].[FrequencyReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Configuration.Frequency WITH (NOLOCK)
	WHERE Name = @Name
				
END