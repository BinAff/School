CREATE PROCEDURE [Student].ProfileReadAll
As
BEGIN

	SELECT Id,
		FirstName,MiddleName,LastName
	FROM Student.Profile WITH (NOLOCK)
	
END