CREATE PROCEDURE [Student].[StudentRead]
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id,StudentId,FirstName,MiddleName,LastName,RollNumber,Photo,CategoryId,ClassId
	FROM Student.Student WITH (NOLOCK)
	WHERE Id = @Id
	
END