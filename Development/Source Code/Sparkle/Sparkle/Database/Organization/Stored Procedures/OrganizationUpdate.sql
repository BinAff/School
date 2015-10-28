CREATE PROCEDURE [Organization].[OrganizationUpdate]
(
@Id Numeric(10,0),
@Name Varchar(50),
@Logo Varbinary(max) = null,
@LicenceNumber Varchar(50) = null,
@Tan Varchar(50) = null,
@ServiceTaxNumber Varchar(50) = null,
@LuxuaryTaxNumber Varchar(50) = null,
@Address Varchar(255) = null,
@City Varchar(50) = null,
@StateId Numeric(10,0) = null,
@Pin Int = null,
@ContactName Varchar(50) = null
)
AS
BEGIN

UPDATE [Organization].Organization
SET
[Name] = @Name,
[Logo] = @Logo,
[LicenceNumber] = @LicenceNumber,
[Tan] = @Tan,
[ServiceTaxNumber] = @ServiceTaxNumber,
[LuxuaryTaxNumber] = @LuxuaryTaxNumber,
[Address] = @Address,
[City] = @City,
[StateId] = @StateId,
[Pin] = @Pin,
[ContactName] = @ContactName
WHERE Id = @Id

END