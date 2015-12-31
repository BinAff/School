CREATE PROCEDURE Billing.FineTypeReadAll
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Billing.FineType WITH (NOLOCK)
   
END