CREATE PROCEDURE [Configuration].[ReligionRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name
   FROM Configuration.[Religion] WITH (NOLOCK)
   WHERE Id = @Id   
   
END