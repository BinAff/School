CREATE PROCEDURE [Configuration].[CasteUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.Caste
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END