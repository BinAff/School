CREATE PROCEDURE [Guardian].[SearchUserByLoginId]
(
	@LoginId Varchar(15)
)
AS
BEGIN
	
	SELECT 
		Id, LoginId, [Password]
	FROM Guardian.Account
	WHERE LoginId = @LoginId
	
	SELECT UserId, RoleId
	FROM Guardian.UserRole
	WHERE UserId = (SELECT Id
		FROM Guardian.Account
		WHERE LoginId = @LoginId)
   
END