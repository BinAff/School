CREATE PROCEDURE [Configuration].[ReligionUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.Religion
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END