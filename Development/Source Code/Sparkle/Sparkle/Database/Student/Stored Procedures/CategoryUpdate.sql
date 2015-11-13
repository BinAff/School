CREATE PROCEDURE [Student].[CategoryUpdate]
(  
	@Id  Bigint,
	@Name Varchar(50)	
)
AS
BEGIN

	UPDATE Student.Category
	SET
		Name = @Name
	WHERE Id = @Id

END