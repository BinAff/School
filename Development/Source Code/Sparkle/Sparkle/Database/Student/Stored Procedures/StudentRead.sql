CREATE PROCEDURE [Student].[StudentRead]
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id,
		FirstName, MiddleName, LastName,
		Address, StateId, City, Pin
	FROM Student.Student WITH (NOLOCK)
	WHERE Id = @Id
	
END