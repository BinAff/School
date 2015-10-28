CREATE PROCEDURE [Student].[StudentReadAll]
As
BEGIN

	SELECT Id,
		FirstName, MiddleName, LastName,
		StateId
	FROM Student.Student WITH (NOLOCK)
	
END