CREATE PROCEDURE [Student].[GuardianReadAll]
As
BEGIN

	SELECT  Id,PersonalInformationId,GuardianProfileId,RelationshipId
			FROM Student.Guardian WITH (NOLOCK)
	
END