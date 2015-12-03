CREATE PROCEDURE Student.GuardianReadDuplicate
(
	@PersonalInformationId Bigint,
	@ProfileId Bigint,
	@RelationshipId Bigint
)
AS
BEGIN

	SELECT Id
	FROM Student.Guardian WITH (NOLOCK)
	WHERE PersonalInformationId = @PersonalInformationId
	AND ProfileId = @ProfileId
	AND RelationshipId = @RelationshipId
				
END