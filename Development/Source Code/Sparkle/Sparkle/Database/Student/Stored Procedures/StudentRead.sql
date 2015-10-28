CREATE PROCEDURE [Student].[StudentRead]
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id,
		FirstName, MiddleName, LastName
	FROM Student.Student WITH (NOLOCK)
	WHERE Id = @Id
	
END