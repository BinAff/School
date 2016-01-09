CREATE PROCEDURE [Configuration].[RelationshipUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.Relationship
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END