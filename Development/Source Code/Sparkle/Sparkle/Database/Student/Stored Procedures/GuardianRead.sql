CREATE PROCEDURE [Student].[GuardianRead]
(
	@Id Bigint
)
As
BEGIN

	SELECT  Id, StudentId, ProfileId, RelationshipId
	FROM Student.Guardian WITH (NOLOCK)
	WHERE Id = @Id
	
END