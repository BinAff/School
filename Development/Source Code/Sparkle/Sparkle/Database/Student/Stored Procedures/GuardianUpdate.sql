CREATE PROCEDURE Student.GuardianUpdate
(  
	@Id Bigint,
	@StudentId Bigint,
	@ProfileId Bigint,
	@RelationshipId Bigint
)
AS
BEGIN

	UPDATE Student.Guardian
	SET
		StudentId = @StudentId,
		ProfileId = @ProfileId,
		RelationshipId = @RelationshipId
	WHERE Id = @Id

END