CREATE PROCEDURE Billing.FeeGroupRead
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id, Name, FrequencyId, IsActive
   FROM Billing.FeeGroup  WITH (NOLOCK)
   WHERE Id = @Id
   
END