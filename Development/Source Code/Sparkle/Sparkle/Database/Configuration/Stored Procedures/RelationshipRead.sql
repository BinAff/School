CREATE PROCEDURE [Configuration].[RelationshipRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name, IsActive
   FROM Configuration.Relationship WITH (NOLOCK)
   WHERE Id = @Id
   
END