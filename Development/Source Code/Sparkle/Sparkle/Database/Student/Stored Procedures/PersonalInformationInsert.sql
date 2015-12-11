CREATE PROCEDURE Student.PersonalInformationInsert
(
	@StudentId Bigint,
	@DateOfBirth Date,
	@BirthPlace Varchar(100),
	@MothertongueId Bigint,
	@ReligionId Bigint,
	@CasteId Bigint,
	@SubCasteId Bigint,
	@GenderId Bigint,
	@PresentAddressId Bigint,
	@PermanentAddressId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.PersonalInformation
		(StudentId, DateOfBirth, BirthPlace, MothertongueId, ReligionId, CasteId,
		SubCasteId, GenderId, PresentAddressId, PermanentAddressId)
	VALUES(@StudentId, @DateOfBirth, @BirthPlace, @MothertongueId, @ReligionId, @CasteId,
		@SubCasteId, @GenderId, @PresentAddressId, @PermanentAddressId)
	SET @Id = @@IDENTITY
	
END