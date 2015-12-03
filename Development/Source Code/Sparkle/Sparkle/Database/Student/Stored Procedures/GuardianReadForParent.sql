CREATE PROCEDURE Student.GuardianReadForParent
(
	@ParentId Bigint
)
AS
BEGIN

	SELECT Id, PersonalInformationId, ProfileId, RelationshipId
	FROM Student.Guardian WITH (NOLOCK)
	WHERE PersonalInformationId = @ParentId
	
END