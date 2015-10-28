CREATE PROCEDURE [Guardian].[AccountDelete]
(
   @Id Numeric(10,0)
)
AS
BEGIN
   DELETE FROM Guardian.Account
   WHERE Id = @Id
END