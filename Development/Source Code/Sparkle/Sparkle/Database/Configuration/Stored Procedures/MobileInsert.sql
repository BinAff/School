CREATE PROCEDURE Configuration.MobileInsert
(
	@MobileNumber Bigint,
	@GuardianProfileId Bigint,
	@CountryId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Configuration.Mobile(MobileNumber, GuardianProfileId, CountryId)
	VALUES(@MobileNumber, @GuardianProfileId, @CountryId)
	SET @Id = @@IDENTITY
	
END