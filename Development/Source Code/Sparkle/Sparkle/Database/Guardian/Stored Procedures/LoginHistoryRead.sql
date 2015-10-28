CREATE PROCEDURE [Guardian].[LoginHistoryRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN

   SELECT Id, AccountId, LoginStamp, LogoutStamp
   FROM Guardian.LoginHistory WITH (NOLOCK)
   WHERE Id = @Id
   
END