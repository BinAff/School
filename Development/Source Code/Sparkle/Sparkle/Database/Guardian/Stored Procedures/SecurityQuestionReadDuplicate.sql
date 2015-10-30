CREATE PROCEDURE Guardian.SecurityQuestionReadDuplicate
(
	@Name VARCHAR(250)		
)
AS
BEGIN

	SELECT Id, Question	
	FROM Guardian.SecurityQuestion WITH (NOLOCK)
	WHERE Question = @Name
			
END