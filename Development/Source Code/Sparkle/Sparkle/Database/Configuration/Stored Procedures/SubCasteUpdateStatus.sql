CREATE PROCEDURE [Configuration].[SubCasteUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.SubCaste
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END