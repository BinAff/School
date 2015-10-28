CREATE PROCEDURE [Organization].[OrganizationInsert]
(
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
@ContactName Varchar(50) = null,
@Id Numeric(10,0) OUTPUT
)
AS
BEGIN

Declare @Cnt Int
Select @Cnt = COUNT(*) From [Organization].Organization

if(@Cnt > 0)
Begin
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
End
Else
Begin
INSERT INTO [Organization].Organization([Name],[Logo],[LicenceNumber],[Tan],[ServiceTaxNumber],[LuxuaryTaxNumber],[Address],[City],[StateId],[Pin],[ContactName])
VALUES(@Name,@Logo,@LicenceNumber,@Tan,@ServiceTaxNumber,@LuxuaryTaxNumber,@Address,@City,@StateId,@Pin,@ContactName)

End

SET @Id = @@IDENTITY
END