CREATE PROCEDURE [Student].[GuardianUpdate]
(  
	@Id  Bigint,
	@PersonalInformationId Numeric(10,0),
	@GuardianProfileId Numeric(10,0),
	@RelationshipId Numeric(10,0)	
)
AS
BEGIN

	UPDATE Student.Guardian
	SET
	PersonalInformationId = @PersonalInformationId,
	GuardianProfileId = @GuardianProfileId,
	RelationshipId = @RelationshipId
	WHERE Id = @Id

END