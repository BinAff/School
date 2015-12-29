CREATE PROCEDURE [Finance].[PaymentModeReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Finance.PaymentMode WITH (NOLOCK)
   
END