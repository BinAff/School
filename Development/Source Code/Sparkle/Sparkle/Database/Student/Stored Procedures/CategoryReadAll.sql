CREATE PROCEDURE [Student].[CategoryReadAll]
As
BEGIN

	SELECT Id, Name
			FROM Student.Category WITH (NOLOCK)
	
END