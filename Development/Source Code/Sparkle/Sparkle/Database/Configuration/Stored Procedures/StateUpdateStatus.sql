CREATE PROCEDURE [Configuration].[StateUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.State
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END