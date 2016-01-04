CREATE PROCEDURE School.SchoolInsert
(
	@Name VARCHAR(50),
	@ContactInformationId BIGINT,
	@Logo VARBINARY(max) = null,
	@AccreditationNumber VARCHAR(50) = null,
	@Tan VARCHAR(50) = null,	
	@Id BIGINT OUTPUT
)
AS
BEGIN

	DECLARE @Cnt Int
	SELECT @Cnt = COUNT(*) FROM Organization.Organization

	IF(@Cnt > 0)
		BEGIN
		
			UPDATE School.School
			SET
				Name = @Name,
				ContactInformationId = @ContactInformationId,
				Logo = @Logo,
				AccreditationNumber = @AccreditationNumber,
				[Tan] = @Tan			
			
		END
	ELSE
		BEGIN
		
			INSERT INTO School.School(Name, ContactInformationId, Logo, AccreditationNumber,[Tan])
			VALUES(@Name, @ContactInformationId, @Logo,@AccreditationNumber, @Tan)
		
		END
	SET @Id = @@IDENTITY
	
END