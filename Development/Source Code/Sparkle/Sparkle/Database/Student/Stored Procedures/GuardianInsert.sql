CREATE PROCEDURE [Student].[GuardianInsert]
(
	@PersonalInformationId Numeric (10,0),
	@GuardianProfileId Numeric (10,0),
	@RelationshipId Numeric (10,0),
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Guardian(PersonalInformationId,GuardianProfileId,RelationshipId)
	VALUES(@PersonalInformationId,@GuardianProfileId,@RelationshipId)   
	SET @Id = @@IDENTITY
	
END