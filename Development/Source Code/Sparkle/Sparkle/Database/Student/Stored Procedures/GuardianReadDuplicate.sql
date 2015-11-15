CREATE PROCEDURE Student.GuardianReadDuplicate
(
	@PersonalInformationId Numeric(10,0),
	@GuardianProfileId Numeric(10,0),
	@RelationshipId Numeric(10,0)
)
AS
BEGIN

	SELECT Id	
	FROM Student.Guardian WITH (NOLOCK)
	WHERE PersonalInformationId = @PersonalInformationId
	and GuardianProfileId = @GuardianProfileId
	and RelationshipId = @RelationshipId
				
END