CREATE PROCEDURE [Configuration].[PaymentModeRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name,IsActive
   FROM Configuration.PaymentMode WITH (NOLOCK)
   WHERE Id = @Id
   
END