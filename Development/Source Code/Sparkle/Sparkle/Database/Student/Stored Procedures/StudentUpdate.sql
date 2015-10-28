CREATE PROCEDURE [Student].[StudentUpdate]
(  
	@Id  Bigint,
	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@StateId Bigint
)
AS
BEGIN

	UPDATE Student.Student
	SET
		FirstName = @FirstName,
		MiddleName = @MiddleName,
		LastName = @LastName,
		StateId = @StateId
	WHERE Id = @Id

END