CREATE PROCEDURE Student.GuardianReadAll
As
BEGIN

	SELECT Id, StudentId, ProfileId, RelationshipId
		FROM Student.Guardian WITH (NOLOCK)
	
END