CREATE PROCEDURE Configuration.StateReadDuplicate
(
	@Name Varchar(50),
	@CountryId Bigint
)
AS
BEGIN

	SELECT Id	
	FROM Configuration.State WITH (NOLOCK)
	WHERE Name = @Name AND CountryId = @CountryId
				
END