CREATE PROCEDURE [Configuration].[RelationshipReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.Relationship WITH (NOLOCK)
   
END
