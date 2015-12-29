CREATE PROCEDURE [Configuration].[PaymentModeReadAll]
AS
BEGIN
	
	SELECT Id, Name,IsActive
	FROM Configuration.PaymentMode WITH (NOLOCK)
   
END