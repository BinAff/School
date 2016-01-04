CREATE PROCEDURE [School].[SectionReadDuplicate]
(
	@Name VARCHAR(50)
)
AS
BEGIN

	SELECT Id
	FROM School.Section WITH (NOLOCK)
	WHERE Name = @Name
				
END