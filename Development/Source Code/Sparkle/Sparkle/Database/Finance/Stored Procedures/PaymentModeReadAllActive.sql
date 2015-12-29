CREATE PROCEDURE [Finance].[PaymentModeReadAllActive]
AS
BEGIN	
	
	SELECT Id, Name, IsActive
	FROM Finance.PaymentMode WITH (NOLOCK)
	WHERE IsActive = 1
   
END