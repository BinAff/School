CREATE PROCEDURE [Student].[StudentUpdate]
(  
	@Id  Bigint,
	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@Address Varchar(256),
	@StateId Bigint
)
AS
BEGIN

	UPDATE Student.Student
	SET
		FirstName = @FirstName,
		MiddleName = @MiddleName,
		LastName = @LastName,
		Address = @Address,
		StateId = @StateId
	WHERE Id = @Id

END