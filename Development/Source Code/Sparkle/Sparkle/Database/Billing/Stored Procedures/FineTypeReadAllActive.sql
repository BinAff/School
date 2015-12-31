CREATE PROCEDURE [Billing].[FineTypeReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Billing.FineType  WITH (NOLOCK)
	WHERE IsActive = 1
   
END