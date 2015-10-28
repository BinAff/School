CREATE PROCEDURE [Guardian].[LoginHistoryInsert]
(  
   @AccountId Numeric(10,0),
   @Id Numeric(10,0) OUT
)
AS
BEGIN
   INSERT INTO Guardian.LoginHistory (AccountId, LoginStamp, LogoutStamp)
   VALUES(@AccountId, GETDATE(), null)
   SET @Id = @@IDENTITY
END