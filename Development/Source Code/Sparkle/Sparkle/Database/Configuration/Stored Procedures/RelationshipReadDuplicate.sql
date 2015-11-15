CREATE PROCEDURE [Configuration].[RelationshipReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Configuration.Relationship WITH (NOLOCK)
	WHERE Name = @Name
				
END