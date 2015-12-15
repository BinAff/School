CREATE PROCEDURE Student.GuardianReadDuplicate
(
	@StudentId Bigint,
	@ProfileId Bigint,
	@RelationshipId Bigint
)
AS
BEGIN

	SELECT Id
	FROM Student.Guardian WITH (NOLOCK)
	WHERE StudentId = @StudentId
	AND ProfileId = @ProfileId
	AND RelationshipId = @RelationshipId
				
END