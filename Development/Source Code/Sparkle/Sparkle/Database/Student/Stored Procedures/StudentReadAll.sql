CREATE PROCEDURE [Student].[StudentReadAll]
As
BEGIN

	SELECT Id,
		FirstName, MiddleName, LastName,
		Address,
		StateId
	FROM Student.Student WITH (NOLOCK)
	
END