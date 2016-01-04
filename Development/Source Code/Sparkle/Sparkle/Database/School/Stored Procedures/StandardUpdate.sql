CREATE PROCEDURE [School].[StandardUpdate]
(
	@Id BIGINT,
	@Name VARCHAR(50)	
)
AS
BEGIN
	
	UPDATE School.Standard
	SET	
		Name = @Name
	WHERE Id = @Id
		
END