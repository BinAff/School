CREATE PROCEDURE [Configuration].[ReligionUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
)
AS
BEGIN
	
	UPDATE Configuration.Religion
	SET	
		Name = @Name
	WHERE Id = @Id
   
END