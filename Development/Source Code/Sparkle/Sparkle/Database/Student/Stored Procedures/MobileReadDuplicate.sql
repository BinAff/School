CREATE PROCEDURE [Student].[MobileReadDuplicate]
(
	@MobileNumber Bigint,
	@GuardianProfileId Bigint,
	@CountryId Bigint
)
AS
BEGIN

	SELECT Id	
	FROM Student.Mobile WITH (NOLOCK)
	WHERE MobileNumber = @MobileNumber 
	and GuardianProfileId = @GuardianProfileId
	and CountryId = @CountryId
				
END