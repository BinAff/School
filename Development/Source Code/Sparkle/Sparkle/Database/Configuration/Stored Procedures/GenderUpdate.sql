CREATE PROCEDURE [Configuration].[GenderUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
)
AS
BEGIN
	
	UPDATE Configuration.Gender
	SET	
		Name = @Name
	WHERE Id = @Id
   
END