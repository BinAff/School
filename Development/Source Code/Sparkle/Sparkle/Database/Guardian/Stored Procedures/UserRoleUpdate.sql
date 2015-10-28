CREATE PROCEDURE [Guardian].[UserRoleUpdate]
(  
   @UserId Numeric(10,0),
   @RoleId Numeric(10,0)
)
AS
BEGIN
	UPDATE Guardian.UserRole
	SET RoleId = @RoleId  
	WHERE UserId = @UserId
END