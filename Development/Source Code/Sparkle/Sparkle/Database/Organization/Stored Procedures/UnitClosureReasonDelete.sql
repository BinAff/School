CREATE PROCEDURE  Organization.UnitClosureReasonDelete
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Organization.UnitClosureReason
	WHERE Id = @Id      
END