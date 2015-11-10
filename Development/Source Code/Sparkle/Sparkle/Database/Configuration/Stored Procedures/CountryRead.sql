CREATE PROCEDURE [Configuration].[CountryRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name,Code,IsdCode
   FROM Configuration.Country WITH (NOLOCK)
   WHERE Id = @Id
   
END