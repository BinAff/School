
CREATE PROCEDURE [Configuration].[PaymentModeReadAllActive]
AS
BEGIN
	
	
	SELECT Id, Name,IsActive
	FROM Configuration.PaymentMode WITH (NOLOCK) where IsActive = 1
   
END