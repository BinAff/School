 
CREATE PROCEDURE [Billing].[FineSlabReadAllActive]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id,FineId,LowerLimit,UpperLimit,Value,IsActive
	FROM Billing.FineSlab WITH (NOLOCK) where Isactive = 1
					
END