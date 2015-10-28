CREATE PROCEDURE [Guardian].[UserRoleRead]
(
	@UserId Numeric(10,0)
)
AS
BEGIN

	SELECT UserId, RoleId		
	FROM Guardian.UserRole WITH (NOLOCK)
	WHERE UserId = @UserId
	
END