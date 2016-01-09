CREATE PROCEDURE [Configuration].[CountryUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.Country
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END