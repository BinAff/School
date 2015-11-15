CREATE PROCEDURE [Student].[PersonalInformationInsert]
(
	@StudId Bigint,
	@DateOfBirth Date,
	@BirthPlace Varchar(100),
	@MothertongueId Bigint,
	@ReligionId Bigint,
	@CasteId Bigint,
	@SubCasteId Bigint,
	@GenderId Bigint,
	@PresentAddressId Bigint,
	@PermananentAddressId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.PersonalInformation
	(StudId,DateOfBirth,BirthPlace,MothertongueId,ReligionId,CasteId,SubCasteId,GenderId,PresentAddressId,PermananentAddressId)
	VALUES(@StudId,@DateOfBirth,@BirthPlace,@MothertongueId,@ReligionId,@CasteId,@SubCasteId,@GenderId,@PresentAddressId,@PermananentAddressId)
	SET @Id = @@IDENTITY
	
END