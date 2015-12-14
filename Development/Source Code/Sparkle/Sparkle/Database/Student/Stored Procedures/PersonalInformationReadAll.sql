CREATE PROCEDURE Student.PersonalInformationReadAll
AS
BEGIN

	SELECT  Id, StudentId, DateOfBirth, BirthPlace, MothertongueId,
		ReligionId, CasteId, SubCasteId, GenderId, PresentAddressId, PermanentAddressId
	FROM Student.PersonalInformation WITH (NOLOCK)
	
END