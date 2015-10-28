CREATE PROCEDURE [Configuration].[CountryReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.Country WITH (NOLOCK)
   
END