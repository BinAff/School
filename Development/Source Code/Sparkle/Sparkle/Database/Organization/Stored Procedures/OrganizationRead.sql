CREATE PROCEDURE [Organization].[OrganizationRead]
(
	@Id Numeric(10,0) = null
)
AS
BEGIN

	SELECT Top 1
		Id,
		[Name],
		[Logo],
		[LicenceNumber],
		[Tan],
		[ServiceTaxNumber],
		[LuxuaryTaxNumber],
		[Address],
		[City],
		[StateId],
		[Pin],
		[ContactName]
	FROM [Organization].[Organization] WITH (NOLOCK)
	
END