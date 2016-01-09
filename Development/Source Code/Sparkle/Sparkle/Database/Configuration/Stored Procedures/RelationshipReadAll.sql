CREATE PROCEDURE [Configuration].[RelationshipReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Relationship WITH (NOLOCK)
   
END
