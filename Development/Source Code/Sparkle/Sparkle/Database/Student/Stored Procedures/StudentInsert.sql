CREATE PROCEDURE [Student].[StudentInsert]
(
	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@StateId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Student(FirstName, MiddleName, LastName, StateId)
	VALUES(@FirstName, @MiddleName, @LastName, @StateId)   
	SET @Id = @@IDENTITY
	
END