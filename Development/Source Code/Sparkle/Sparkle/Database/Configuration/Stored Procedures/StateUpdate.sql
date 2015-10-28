CREATE PROCEDURE [Configuration].[StateUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50),
	@CountryId Numeric(10,0)
)
AS
BEGIN
	
	UPDATE Configuration.[State]
	SET	
		Name = @Name,
		CountryId = @CountryId
	WHERE Id = @Id
   
END