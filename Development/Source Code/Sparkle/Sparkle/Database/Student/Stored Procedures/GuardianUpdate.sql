CREATE PROCEDURE Student.GuardianUpdate
(  
	@Id Bigint,
	@PersonalInformationId Bigint,
	@ProfileId Bigint,
	@RelationshipId Bigint
)
AS
BEGIN

	UPDATE Student.Guardian
	SET
		PersonalInformationId = @PersonalInformationId,
		ProfileId = @ProfileId,
		RelationshipId = @RelationshipId
	WHERE Id = @Id

END