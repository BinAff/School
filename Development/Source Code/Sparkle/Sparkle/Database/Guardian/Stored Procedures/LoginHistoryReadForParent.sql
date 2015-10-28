CREATE PROCEDURE [Guardian].[LoginHistoryReadForParent]
(
   @ParentId Numeric(10,0)
)
AS
BEGIN

   SELECT Id, LoginStamp, LogoutStamp
   FROM Guardian.LoginHistory WITH (NOLOCK)
   WHERE AccountId = @ParentId
   
END