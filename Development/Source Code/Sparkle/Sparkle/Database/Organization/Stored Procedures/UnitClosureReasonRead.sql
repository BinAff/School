CREATE PROCEDURE Organization.UnitClosureReasonRead
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Reason, UnitId, ClosedDate
	FROM Organization.UnitClosureReason WITH (NOLOCK)
	WHERE Id = @Id   
	
END