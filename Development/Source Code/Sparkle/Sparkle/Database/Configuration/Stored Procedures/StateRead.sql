CREATE PROCEDURE [Configuration].[StateRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name, CountryId, IsActive
   FROM Configuration.[State] WITH (NOLOCK)
   WHERE Id = @Id   
   
END