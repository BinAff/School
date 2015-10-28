CREATE PROCEDURE [Guardian].[AccountInsert]
(  
   @LoginId Varchar(15),   
   @Password Varchar(127),
   --@RoleId Numeric(10,0),
   @Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
   INSERT INTO Guardian.Account(LoginId, [Password])
   VALUES (@LoginId, @Password)   
   SET @Id = @@IDENTITY   
   --INSERT INTO User_Role (UserId, RoleId)
   --VALUES(@Id, @RoleId)
END