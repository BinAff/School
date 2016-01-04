CREATE PROCEDURE [Billing].[FineSlabRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id,FineId,LowerLimit,UpperLimit,Value,IsActive
   FROM Billing.FineSlab WITH (NOLOCK)
   WHERE Id = @Id
   
END