CREATE PROCEDURE [Student].ProfileRead
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id,
		FirstName, MiddleName, LastName
	FROM Student.Profile WITH (NOLOCK)
	WHERE Id = @Id
	
END