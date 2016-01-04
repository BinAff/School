CREATE PROCEDURE [School].[StandardReadDuplicate]
(
	@Name VARCHAR(50)
)
AS
BEGIN

	SELECT Id
	FROM School.Standard WITH (NOLOCK)
	WHERE Name = @Name
				
END