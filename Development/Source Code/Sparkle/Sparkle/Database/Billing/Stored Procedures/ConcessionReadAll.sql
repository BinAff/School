CREATE PROCEDURE [Billing].[ConcessionReadAll]
AS
BEGIN
	
	SELECT Id, Amount, IsPercentage, FeeId, CasteId, IsActive
	FROM Billing.Concession  WITH (NOLOCK)
   
END