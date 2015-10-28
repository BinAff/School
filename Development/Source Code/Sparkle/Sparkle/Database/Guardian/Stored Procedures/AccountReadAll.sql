CREATE PROCEDURE [Guardian].[AccountReadAll]
AS
BEGIN

	SELECT 
		Id,
		LoginId,
		[Password]
	FROM Guardian.Account WITH (NOLOCK)
	WHERE LoginId != 'support'   
	SELECT 
		UserId, 
		RoleId
	FROM Guardian.UserRole WITH (NOLOCK)
	
END