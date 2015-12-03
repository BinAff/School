CREATE PROCEDURE Configuration.MobileUpdate
(  
	@Id  Bigint,
	@MobileNumber Bigint,
	@GuardianProfileId Bigint,
	@CountryId Bigint
)
AS
BEGIN

	UPDATE Configuration.Mobile
	SET
		MobileNumber = @MobileNumber,
		GuardianProfileId = @GuardianProfileId,
		CountryId = @CountryId
		WHERE Id = @Id

END