CREATE PROCEDURE [Configuration].[FrequencyUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.Frequency
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END