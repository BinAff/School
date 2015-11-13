CREATE PROCEDURE [Student].[CategoryRead]
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id,
		Name FROM Student.Category WITH (NOLOCK)
	WHERE Id = @Id
	
END