CREATE PROCEDURE [Student].[StudentReadAll]
As
BEGIN

	SELECT Id, Name
			FROM Student.Category WITH (NOLOCK)
	
END