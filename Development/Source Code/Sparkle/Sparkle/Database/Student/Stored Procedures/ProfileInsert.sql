CREATE PROCEDURE [Student].ProfileInsert
(
	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Profile(FirstName, MiddleName, LastName)
	VALUES(@FirstName, @MiddleName,@LastName)   
	SET @Id = @@IDENTITY
	
END