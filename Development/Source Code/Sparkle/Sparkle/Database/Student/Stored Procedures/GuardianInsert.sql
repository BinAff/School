CREATE PROCEDURE Student.GuardianInsert
(
	@PersonalInformationId Bigint,
	@ProfileId Bigint,
	@RelationshipId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Guardian(PersonalInformationId, ProfileId, RelationshipId)
	VALUES(@PersonalInformationId, @ProfileId, @RelationshipId)   
	SET @Id = @@IDENTITY
	
END