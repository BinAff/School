CREATE PROCEDURE [Configuration].[MotherTongueUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.MotherTongue
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END