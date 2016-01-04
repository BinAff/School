CREATE PROCEDURE School.SchoolUpdate
(
	@Id Numeric(10,0),
	@Name VARCHAR(50),
	@ContactInformationId BIGINT,
	@Logo VARBINARY(MAX) = null,
	@AccreditationNumber VARCHAR(50) = null,
	@Tan VARCHAR(50) = null
)
AS
BEGIN

	UPDATE School.School
	SET
		Name = @Name,
		ContactInformationId = @ContactInformationId,
		Logo = @Logo,
		AccreditationNumber = @AccreditationNumber,
		[Tan] = @Tan
	WHERE Id = @Id

END