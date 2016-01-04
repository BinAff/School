CREATE PROCEDURE [School].[StandardUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE School.Standard
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END