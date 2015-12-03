CREATE PROCEDURE Student.PersonalInformationUpdate
(  
	@Id  Bigint,
	@StudentId Bigint,
	@DateOfBirth Date,
	@BirthPlace Varchar(100),
	@MothertongueId Bigint,
	@ReligionId Bigint,
	@CasteId Bigint,
	@SubCasteId Bigint,
	@GenderId Bigint,
	@PresentAddressId Bigint,
	@PermananentAddressId Bigint
)
AS
BEGIN

	UPDATE Student.PersonalInformation
	SET
		StudentId = @StudentId,
		DateOfBirth = @DateOfBirth,
		BirthPlace = @BirthPlace,
		MothertongueId = @MothertongueId,
		ReligionId = @ReligionId,
		CasteId = @CasteId,
		SubCasteId = @SubCasteId,
		GenderId = @GenderId,
		PresentAddressId = @PresentAddressId,
		PermananentAddressId = @PermananentAddressId
	WHERE Id = @Id

END