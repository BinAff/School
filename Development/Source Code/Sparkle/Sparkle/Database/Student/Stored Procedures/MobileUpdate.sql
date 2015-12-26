CREATE PROCEDURE [Student].[MobileUpdate]
(  
	@Id  Bigint,
	@MobileNumber Bigint,
	@GuardianProfileId Bigint,
	@CountryId Bigint
)
AS
BEGIN

	UPDATE Student.Mobile
	SET
		MobileNumber = @MobileNumber,
		GuardianProfileId = @GuardianProfileId,
		CountryId = @CountryId
		WHERE Id = @Id

END