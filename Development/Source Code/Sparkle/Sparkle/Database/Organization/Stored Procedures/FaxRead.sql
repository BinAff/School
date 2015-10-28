CREATE PROCEDURE [Organization].[FaxRead]
(
	@Id Numeric(10,0) = null
)
AS
BEGIN

	SELECT Id, Fax,	OrganizationId
	FROM Organization.Fax WITH (NOLOCK)
	WHERE Id = @Id
	
END