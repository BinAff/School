CREATE PROCEDURE [Billing].[ConcessionDelete]
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM Billing.Concession
	WHERE Id = @Id   
   
END