CREATE PROCEDURE [Configuration].[CountryReadDuplicate]
(
	@Name Varchar(50),
	@Code Varchar(50),
	@IsdCode Varchar(50)

)
AS
BEGIN

	SELECT Id	
	FROM Configuration.Country WITH (NOLOCK)
	WHERE Name = @Name
	or Code = @Code	
	or IsdCode = @IsdCode
				
END