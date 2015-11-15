CREATE PROCEDURE [Configuration].[ContactInformationUpdate]
(
	@Id Numeric(10,0),
	@Address Varchar(500),
	@DistrictId Numeric(10,0),
	@Pin Numeric (10,0),
	@LandLine Numeric (10,0)

)
AS
BEGIN
	
	UPDATE Configuration.ContactInformation
	SET	
		Address = @Address,
		DistrictId = @DistrictId,
		Pin = @Pin,
		LandLine = @LandLine
		WHERE Id = @Id
   END