CREATE PROCEDURE Student.StudentReadAll
As
BEGIN

	SELECT  Id, StudentId, FirstName, MiddleName, LastName, RollNumber, Photo,
		CategoryId, StandardId, SectionId
	FROM Student.Student WITH (NOLOCK)
	
END