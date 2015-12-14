CREATE PROCEDURE Student.StudentDelete
(
	@Id Numeric(10,0)
)
As
BEGIN

	DELETE FROM Student.Student
	WHERE Id = @Id
	
End