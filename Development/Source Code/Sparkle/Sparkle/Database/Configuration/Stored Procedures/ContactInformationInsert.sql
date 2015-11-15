CREATE PROCEDURE [Configuration].[ContactinformationInsert]
(  
	@Address Varchar(500),
	@DistrictId Numeric(10,0),
	@Pin Numeric (10,0),
	@LandLine Numeric (20,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Contactinformation(Address,DistrictId,Pin,LandLine)
	VALUES(@Address,@DistrictId,@Pin,@LandLine)
   
	SET @Id = @@IDENTITY

END