CREATE PROCEDURE [Student].[StudentInsert]
(
	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Student(FirstName, MiddleName, LastName)
	VALUES(@FirstName, @MiddleName,@LastName)   
	SET @Id = @@IDENTITY
	
END