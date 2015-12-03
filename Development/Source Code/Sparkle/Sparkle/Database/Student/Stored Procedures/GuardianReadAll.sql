CREATE PROCEDURE Student.GuardianReadAll
As
BEGIN

	SELECT Id, PersonalInformationId, ProfileId, RelationshipId
		FROM Student.Guardian WITH (NOLOCK)
	
END