CREATE PROCEDURE [Configuration].[OccupationUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Configuration.Occupation
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END