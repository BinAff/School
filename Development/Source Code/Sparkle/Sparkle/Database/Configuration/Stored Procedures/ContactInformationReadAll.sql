CREATE PROCEDURE [Configuration].[ContactInformationReadAll]
AS
BEGIN
	
	SELECT Id, Address,DistrictId,Pin,LandLine
	FROM Configuration.ContactInformation WITH (NOLOCK)
   
END
