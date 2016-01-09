CREATE PROCEDURE [Configuration].[CountryReadAll]
AS
BEGIN
	
	SELECT Id, Name, Code, IsdCode, IsActive
	FROM Configuration.Country WITH (NOLOCK)
   
END