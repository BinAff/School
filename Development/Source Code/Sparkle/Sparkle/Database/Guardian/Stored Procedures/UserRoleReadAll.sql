CREATE PROCEDURE [Guardian].[UserRoleReadAll]
AS
BEGIN

	SELECT UserId, RoleId		
	FROM Guardian.UserRole WITH (NOLOCK)
	
END