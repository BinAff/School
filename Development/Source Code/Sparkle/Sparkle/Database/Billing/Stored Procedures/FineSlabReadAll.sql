CREATE PROCEDURE [Billing].[FineSlabReadAll]
AS
BEGIN
	
	SELECT Id,FineId,LowerLimit,UpperLimit,Value,IsActive
	FROM Billing.FineSlab WITH (NOLOCK)
   
END