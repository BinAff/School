CREATE PROCEDURE [Configuration].[RelationshipReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Relationship  WITH (NOLOCK)
	WHERE IsActive = 1
   
END