CREATE PROCEDURE Configuration.MobileRead
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT Id, MobileNumber, GuardianProfileId, CountryId
	FROM Configuration.Mobile WITH (NOLOCK)
	WHERE Id = @Id
	
END