CREATE PROCEDURE [Configuration].[StateReadAll]
AS
BEGIN
	
	SELECT Id, Name, CountryId
	FROM Configuration.[State] WITH (NOLOCK)
   
END