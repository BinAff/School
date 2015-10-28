CREATE PROCEDURE [Organization].[EmailRead]
(
	@Id Numeric(10,0) = null
)
AS
BEGIN

	SELECT Id, Email, OrganizationId
	FROM Organization.Email WITH (NOLOCK)
	WHERE Id = @Id
	
END