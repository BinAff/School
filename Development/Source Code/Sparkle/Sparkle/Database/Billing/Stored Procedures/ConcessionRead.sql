CREATE PROCEDURE [Billing].[ConcessionRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id, Amount, IsPercentage, FeeId, CasteId, IsActive
   FROM Billing.Concession  WITH (NOLOCK)
   WHERE Id = @Id
   
END