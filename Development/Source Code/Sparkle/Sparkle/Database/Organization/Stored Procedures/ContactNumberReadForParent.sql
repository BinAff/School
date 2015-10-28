CREATE PROCEDURE [Organization].[ContactNumberReadForParent]
(
	@ParentId Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, OrganizationId, ContactNumber
	FROM Organization.ContactNumber WITH (NOLOCK)
	WHERE OrganizationId = @ParentId
	
END