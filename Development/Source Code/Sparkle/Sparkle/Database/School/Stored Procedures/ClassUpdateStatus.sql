create PROCEDURE [School].[ClassUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE School.Class
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END