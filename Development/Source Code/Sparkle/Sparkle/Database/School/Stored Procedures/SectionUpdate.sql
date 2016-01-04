CREATE PROCEDURE [School].[SectionUpdate]
(
	@Id BIGINT,
	@Name VARCHAR(50)
)
AS
BEGIN
	
	UPDATE School.Section
	SET	
		Name = @Name
	WHERE Id = @Id
	
END