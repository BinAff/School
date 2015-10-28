CREATE PROCEDURE [Organization].[UnitClosureReasonReadAll]
AS
BEGIN
	
	SELECT Id, Reason, UnitId, ClosedDate
	FROM Organization.UnitClosureReason WITH (NOLOCK)
	
END