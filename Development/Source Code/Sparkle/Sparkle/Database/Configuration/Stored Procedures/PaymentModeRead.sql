CREATE PROCEDURE [Configuration].[PaymentModeRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id, Name,IsActive
   FROM Configuration.PaymentMode WITH (NOLOCK)
   WHERE Id = @Id
   
END