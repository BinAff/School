CREATE PROCEDURE [Configuration].[DistrictUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.District
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END