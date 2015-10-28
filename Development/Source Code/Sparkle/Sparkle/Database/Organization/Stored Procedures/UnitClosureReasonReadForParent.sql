CREATE PROCEDURE Organization.UnitClosureReasonReadForParent
(
	@ParentId Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, UnitId, Reason, ClosedDate
	FROM Organization.UnitClosureReason WITH (NOLOCK)
	WHERE UnitId = @ParentId
	
END