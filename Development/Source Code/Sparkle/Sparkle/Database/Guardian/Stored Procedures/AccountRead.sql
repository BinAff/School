CREATE PROCEDURE [Guardian].[AccountRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	SELECT 
		Id,
		LoginId,
		[Password]
	FROM Guardian.Account WITH (NOLOCK)
	WHERE Id = @Id
	
	SELECT RoleId 
	FROM Guardian.UserRole WITH (NOLOCK)
	WHERE UserId = @Id
	
END
--Guardian.AccountRead 1