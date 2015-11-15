CREATE PROCEDURE [Configuration].[RelationshipUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
)
AS

BEGIN
	
	UPDATE Configuration.Relationship
	SET	
		Name = @Name
		WHERE Id = @Id
   END