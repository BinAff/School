CREATE PROCEDURE Student.StudentRead
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id, StudentId, FirstName, MiddleName, LastName, RollNumber, Photo,
		CategoryId, StandardId, SectionId
	FROM Student.Student WITH (NOLOCK)
	WHERE Id = @Id
	
END