CREATE PROCEDURE School.SectionUpdateStatus
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE School.Section
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END