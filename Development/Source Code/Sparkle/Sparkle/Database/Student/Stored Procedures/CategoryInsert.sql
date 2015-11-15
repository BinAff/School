CREATE PROCEDURE [Student].[CategoryInsert]
(
	@Name Varchar(50),
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Category(Name)
	VALUES(@Name)   
	SET @Id = @@IDENTITY
	
END