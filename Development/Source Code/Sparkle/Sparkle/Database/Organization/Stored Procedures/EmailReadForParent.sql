CREATE PROCEDURE [Organization].[EmailReadForParent]
(
	@ParentId Numeric(10,0)
)
AS
BEGIN
	
	SELECT 
		Id, OrganizationId, Email
	FROM Organization.Email
	WHERE OrganizationId = @ParentId
	
END