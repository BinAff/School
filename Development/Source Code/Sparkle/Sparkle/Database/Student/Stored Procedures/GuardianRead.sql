CREATE PROCEDURE [Student].[GuardianRead]
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id,PersonalInformationId,GuardianProfileId,RelationshipId
		Name FROM Student.Guardian WITH (NOLOCK)
	WHERE Id = @Id
	
END