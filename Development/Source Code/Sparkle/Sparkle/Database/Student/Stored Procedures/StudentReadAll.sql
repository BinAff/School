CREATE PROCEDURE [Student].[StudentReadAll]
As
BEGIN

	SELECT Id,
		FirstName,MiddleName,LastName
	FROM Student.Student WITH (NOLOCK)
	
END