CREATE PROCEDURE Student.GuardianReadForParent
(
	@ParentId Bigint
)
AS
BEGIN

	SELECT Id, StudentId, ProfileId, RelationshipId
	FROM Student.Guardian WITH (NOLOCK)
	WHERE StudentId = @ParentId
	
END