CREATE PROCEDURE [Configuration].[InitialUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
)
AS
BEGIN
	
	UPDATE [Configuration].Initial
	SET	
		[Name] = @Name	
	WHERE Id = @Id
   
END