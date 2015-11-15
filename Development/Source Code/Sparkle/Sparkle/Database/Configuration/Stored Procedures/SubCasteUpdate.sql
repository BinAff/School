CREATE PROCEDURE [Configuration].[SubCasteUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
	)
AS
BEGIN
	
	UPDATE Configuration.SubCaste
	SET	
		Name = @Name
		WHERE Id = @Id
   END