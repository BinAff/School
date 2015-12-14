CREATE PROCEDURE Student.PersonalInformationReadForParent
(
	@ParentId Bigint
)
AS
BEGIN

	SELECT  Id, StudentId, DateOfBirth, BirthPlace, MothertongueId,
		ReligionId, CasteId, SubCasteId, GenderId, PresentAddressId, PermanentAddressId
	FROM Student.PersonalInformation WITH (NOLOCK)
	WHERE StudentId = @ParentId
	
END