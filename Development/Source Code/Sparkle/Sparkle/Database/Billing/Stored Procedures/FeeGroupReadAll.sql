CREATE PROCEDURE Billing.FeeGroupReadAll
AS
BEGIN
	
	SELECT Id, Name, FrequencyId, IsActive
	FROM Billing.FeeGroup  WITH (NOLOCK)
   
END