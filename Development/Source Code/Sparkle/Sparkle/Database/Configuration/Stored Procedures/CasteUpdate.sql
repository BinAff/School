CREATE PROCEDURE Configuration.CasteUpdate
(
	@Id Numeric(10,0),
	@Name Varchar(50),
	@ReligionId Numeric(10,0)
)
AS
BEGIN
	
	UPDATE Configuration.Caste
	SET	
		Name = @Name,
		ReligionId = @ReligionId
		WHERE Id = @Id
   END