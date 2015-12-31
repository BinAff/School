CREATE PROCEDURE Billing.FeeGroupReadAllActive
AS
BEGIN
	
	SELECT Id, Name, FrequencyId, IsActive
	FROM Billing.FeeGroup  WITH (NOLOCK)
	WHERE IsActive = 1
   
END