CREATE PROCEDURE [Configuration].[OccupationRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name, IsActive
   FROM Configuration.Occupation WITH (NOLOCK)
   WHERE Id = @Id
   
END