CREATE PROCEDURE [Student].[MobileReadAll]
As
BEGIN

	SELECT Id, MobileNumber,GuardianProfileId,CountryId
			FROM Student.Mobile WITH (NOLOCK)
	
END