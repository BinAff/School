CREATE PROCEDURE [Student].[CategoryReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id	
	FROM Student.Category WITH (NOLOCK)
	WHERE Name = @Name
				
END