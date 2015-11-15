CREATE PROCEDURE [Student].[PersonalInformationReadAll]
As
BEGIN

	SELECT  Id,StudId,DateOfBirth,BirthPlace,MothertongueId,
	ReligionId,CasteId,SubCasteId,GenderId,PresentAddressId,PermananentAddressId
	FROM Student.PersonalInformation WITH (NOLOCK)
	
END