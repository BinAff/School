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
	@PermanentAddressId Bigint
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
		PermanentAddressId = @PermanentAddressId
	WHERE Id = @Id

END