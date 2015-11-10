CREATE PROCEDURE [Configuration].[CountryReadAll]
AS
BEGIN
	
	SELECT Id, Name,Code,IsdCode
	FROM Configuration.Country WITH (NOLOCK)
   
END