CREATE PROCEDURE Configuration.MobileReadDuplicate
(
	@MobileNumber Bigint,
	@GuardianProfileId Bigint,
	@CountryId Bigint
)
AS
BEGIN

	SELECT Id	
	FROM Configuration.Mobile WITH (NOLOCK)
	WHERE MobileNumber = @MobileNumber 
	AND GuardianProfileId = @GuardianProfileId
	AND CountryId = @CountryId
				
END