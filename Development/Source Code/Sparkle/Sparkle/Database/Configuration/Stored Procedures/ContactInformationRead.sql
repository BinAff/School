CREATE PROCEDURE [Configuration].[ContactInformationRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Address,Districtid,Pin,LandLine
   FROM Configuration.ContactInformation WITH (NOLOCK)
   WHERE Id = @Id
   
END