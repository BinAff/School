CREATE PROCEDURE [Student].[StudentReadAll]
As
BEGIN

	SELECT Id,
		FirstName, MiddleName, LastName,
		Address, StateId, City, Pin
	FROM Student.Student WITH (NOLOCK)
	
END