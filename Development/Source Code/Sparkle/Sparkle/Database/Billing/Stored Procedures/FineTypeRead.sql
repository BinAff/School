CREATE PROCEDURE Billing.FineTypeRead
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id, Name, IsActive
   FROM Billing.FineType WITH (NOLOCK)
   WHERE Id = @Id
   
END