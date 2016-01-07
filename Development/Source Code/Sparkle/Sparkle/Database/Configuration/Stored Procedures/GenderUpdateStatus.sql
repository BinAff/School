CREATE PROCEDURE [Configuration].[GenderUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.Gender
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END