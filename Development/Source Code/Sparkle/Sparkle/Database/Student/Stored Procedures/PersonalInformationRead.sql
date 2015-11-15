CREATE PROCEDURE [Student].[PersonalInformationRead]
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id,StudId,DateOfBirth,BirthPlace,MothertongueId,
	ReligionId,CasteId,SubCasteId,GenderId,PresentAddressId,PermananentAddressId
	FROM Student.PersonalInformation WITH (NOLOCK)
	WHERE Id = @Id
	
END