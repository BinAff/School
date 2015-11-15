CREATE PROCEDURE [Student].[MobileInsert]
(
	@MobileNumber Bigint,
	@GuardianProfileId Bigint,
	@CountryId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Mobile(MobileNumber,GuardianProfileId,CountryId)
	VALUES(@MobileNumber,@GuardianProfileId,@CountryId)
	SET @Id = @@IDENTITY
	
END