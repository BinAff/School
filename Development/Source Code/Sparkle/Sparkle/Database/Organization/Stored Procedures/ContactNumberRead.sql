CREATE PROCEDURE [Organization].[ContactNumberRead]
(
	@Id Numeric(10,0) = null
)
AS
BEGIN

	SELECT  Id, ContactNumber, OrganizationId
	FROM Organization.ContactNumber WITH (NOLOCK)
	WHERE Id = @Id
	
END