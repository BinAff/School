CREATE PROCEDURE [Billing].[ConcessionReadAllActive]
AS
BEGIN
	
	SELECT Id, Amount, IsPercentage, FeeId, CasteId, IsActive
	FROM Billing.Concession  WITH (NOLOCK)
	WHERE IsActive = 1
   
END