CREATE PROCEDURE [Configuration].[CasteUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
)
AS

BEGIN
	
	UPDATE Configuration.Caste
	SET	
		Name = @Name
		WHERE Id = @Id
   END