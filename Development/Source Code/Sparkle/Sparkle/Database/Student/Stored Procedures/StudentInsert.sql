CREATE PROCEDURE [Student].[StudentInsert]
(
	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@Address Varchar(256),
	@StateId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Student(FirstName, MiddleName, LastName, Address, StateId)
	VALUES(@FirstName, @MiddleName, @LastName, @Address, @StateId)   
	SET @Id = @@IDENTITY
	
END