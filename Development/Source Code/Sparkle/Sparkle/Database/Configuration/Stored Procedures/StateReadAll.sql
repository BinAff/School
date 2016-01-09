CREATE PROCEDURE [Configuration].[StateReadAll]
AS
BEGIN
	
	SELECT Id, Name, CountryId, IsActive
	FROM Configuration.[State] WITH (NOLOCK)
   
END