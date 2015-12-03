CREATE PROCEDURE [Student].[GuardianRead]
(
	@Id Bigint
)
As
BEGIN

	SELECT  Id, PersonalInformationId, ProfileId, RelationshipId
	FROM Student.Guardian WITH (NOLOCK)
	WHERE Id = @Id
	
END