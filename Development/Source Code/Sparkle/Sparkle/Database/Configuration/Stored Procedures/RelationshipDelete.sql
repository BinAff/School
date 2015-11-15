CREATE PROCEDURE [Configuration].[RelationshipDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.Relationship
	WHERE Id = @Id   
   
END